using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace Pokemon_Tekken_Ripping_Tool
{
    public partial class Form1 : Form
    {
        private static RandomXS _rand;

        public Form1()
        {
            InitializeComponent();
        }

        void UI(bool arg)
        {
            DRP_Extract_Start.Enabled = arg;
            DRP_Extract_LeaveTempFiles.Enabled = arg;
            DRP_Extract_DeleteOriginal.Enabled = arg;
            DRP_Extract_DragDrop.Enabled = arg;
            NUD_Textures_Start.Enabled = arg;
            NUD_Textures_DeleteOriginal.Enabled = arg;
            NUD_Textures_DragDrop.Enabled = arg;
        }

        void ConsoleWrite(int source, string text)
        {
            if (source == 0)
            {
                Console_Output.Items.Add(">>" + text);
            }
            if (source == 1)
            {
                Console_Output.Items.Add("Decompress DRP>>" + text);
            }
            if (source == 2)
            {
                Console_Output.Items.Add("Extract DRP>>" + text);
            }
            if (source == 3)
            {
                Console_Output.Items.Add("quickbms>>" + text);
            }
            if (source == 5)
            {
                Console_Output.Items.Add("");
            }
        }

        void HandleDRP()
        {
            DecompressDRP("volodya.exe");
        }

        public class RandomXS
        {
            public RandomXS(int seed)
            {
                int init = 0x41C64E6D;
                _data = new int[4];
                _data[0] = (seed * init) + 0x3039;
                _data[1] = (_data[0] * init) + 0x3039;
                _data[2] = (_data[1] * init) + 0x3039;
                _data[3] = (_data[2] * init) + 0x3039;
            }
            private int[] _data;
            public int GetInt()
            {
                var last = _data[3];
                var first = _data[0];
                var third = _data[2];
                var second = _data[1];

                var XOR1 = last ^ (last << 11);
                var XOR2 = first ^ (first >> 0x13);
                var XOR3 = XOR1 ^ (XOR1 >> 8);
                var FINAL_XOR = XOR2 ^ XOR3;

                _data[1] = first;
                _data[3] = third;
                _data[2] = second;
                _data[0] = FINAL_XOR;
                return FINAL_XOR & 0x7FFFFFFF;
            }
        }

        public static byte[] Decrypt(string path)
        {
            int[] filedata = null;
            using (var stream = File.Open(path, FileMode.Open))
            {
                filedata = new int[stream.Length / 4];
                using (var reader = new BinaryReader(stream))
                {
                    int size = (int)stream.Length;
                    int words = size >> 2;
                    int xorval = 0;
                    stream.Seek(0x1C, SeekOrigin.Begin);
                    int SEED = reader.ReadInt32().Reverse();
                    _rand = new RandomXS(SEED);
                    stream.Seek(0, SeekOrigin.Begin);
                    if (size % 8 == 0) goto Dword_loop;
                    else if (size == 0) return null;
                    else if (size / 8 <= 0) goto BYTE_loop;
#pragma warning disable CS0642 // Возможно, ошибочный пустой оператор
                    else;//goto default_loop
#pragma warning restore CS0642 // Возможно, ошибочный пустой оператор

                    #region DWORD Loop
                    Dword_loop:
                    if (words == 0)
                        goto loops_end;
                    else if (words / 8 <= 0)
                        goto Word_Loop;
                    else
                        for (int i = 0; i < words >> 3; i++)
                        {
                            for (int x = 0; x < 8; x++)
                            {
                                var randInt = _rand.GetInt();
                                var XOR = reader.ReadInt32().Reverse() ^ randInt;
                                var val = XOR ^ xorval;
                                xorval = (randInt << 13) & unchecked((int)0x80000000);
                                filedata[x + (i * 8)] = val.Reverse();
                            }
                        }
                    #endregion
                    #region Word Loop
                    Word_Loop:
                    if ((words & 7) <= 0)
                        goto loops_end;
                    int offset = (size >> 2 >> 3 << 3 << 2);
                    stream.Seek(offset, SeekOrigin.Begin);

                    for (int i = 0; i < (words & 7); i++)
                    {
                        var randInt = _rand.GetInt();
                        var XOR = reader.ReadInt32().Reverse() ^ randInt;
                        var val = XOR ^ xorval;
                        xorval = (randInt << 13) & unchecked((int)0x80000000);
                        filedata[offset / 4 + i] = val.Reverse();
                    }
                    goto loops_end;
                    #endregion
                    #region BYTE Loop
                    BYTE_loop:
                    if ((size & 7) == 0)
                        goto func_end;
                    stream.Seek(4, SeekOrigin.Begin);
                    for (int i = 4; i < (size & 7); i++)
                    {
                        byte[] data = BitConverter.GetBytes(filedata[i.RoundDown(4)]);
                        var b = reader.ReadByte();
                        var shifted = (b >> 3) | (b << 32 - 3);
                        var val = b ^ shifted;
                        data[i] = (byte)val;
                    }
                    #endregion
                    loops_end:
                    filedata[7] = SEED.Reverse();
                }
            }
            func_end:
            byte[] result = new byte[filedata.Length * sizeof(int)];
            Buffer.BlockCopy(filedata, 0, result, 0, result.Length);
            return result;
        }

        void DecompressDRP(string filepath)
        {
            ConsoleWrite(0, "Loading DRPDecryptor v0.8 by Sammi Husky...");
            ConsoleWrite(1, "Decrypting input file...");
            File.WriteAllBytes(filepath + ".dec", Decrypt(filepath));
            if (DRP_Extract_DeleteOriginal.Checked)
            {
                File.Delete(filepath);
            }
            ConsoleWrite(1, "Decrypted successfully!!! Passing file to ExtractDRP");
            ExtractDRP(filepath + ".dec");
        }

        void ExtractDRP(string filepath)
        {
            ConsoleWrite(0, "Loading DRPExtractor v0.8 by Sammi Husky...");
            ConsoleWrite(2, "Extracting decrypted input file...");
            using (var stream = File.Open(filepath, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream))
                {
                    stream.Seek(0x60, SeekOrigin.Begin);
                    Directory.CreateDirectory(filepath.Remove(filepath.IndexOf('.')));
                    while (stream.Position != stream.Length)
                    {
                        var BaseAddr = stream.Position;
                        var name = reader.ReadTerminatedString();
                        stream.Position = BaseAddr + 0x44;
                        var next = reader.ReadInt32().Reverse();
                        stream.Position = BaseAddr + 0x4A;
                        var count = reader.ReadInt16().Reverse();
                        stream.Position = BaseAddr + 0x50;
                        var sizes = new int[count];
                        for (int i = 0; i < count; i++)
                            sizes[i] = reader.ReadInt32().Reverse();

                        stream.Position = BaseAddr + 0x60;
                        for (int i = 0; i < count; i++)
                        {
                            var newname = name;
                            if (count > 1)
                                newname += $"[{i}]";

                            stream.Seek(0x06, SeekOrigin.Current);
                            using (var originStream = new MemoryStream(reader.ReadBytes(sizes[i] - 6)))
                            {
                                using (var destStream = File.Create(Path.Combine(filepath.Remove(filepath.IndexOf('.')), newname)))
                                {
                                    using (var decompStream = new DeflateStream(originStream, CompressionMode.Decompress))
                                    {
                                        decompStream.CopyTo(destStream);
                                    }
                                }
                            }
                        }
                        stream.Position = BaseAddr + next;
                    }
                }
            }
            if (!DRP_Extract_LeaveTempFiles.Checked)
            {
                File.Delete(filepath);
            }
            ConsoleWrite(2, "Extracted successfully to " + filepath.Remove(filepath.IndexOf('.')) + " !!!");
        }

        private void DRP_Extract_Start_Click(object sender, EventArgs e)
        {
            UI(false);
            var dlg = new OpenFileDialog();
            dlg.Filter = "DRP Archives (*.drp)|*.drp|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlg.FileNames.Length; i++)
                {
                    ConsoleWrite(5, "");
                    ConsoleWrite(0, "Extracting " + dlg.FileNames[i]);
                    DecompressDRP(dlg.FileNames[i]);
                }
            }
            UI(true);
        }

        private void DRP_Extract_DragDrop_DragDrop(object sender, DragEventArgs e)
        {
            UI(false);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; i++)
            {
                ConsoleWrite(5, "");
                ConsoleWrite(0, "Extracting " + files[i]);
                DecompressDRP(files[i]);
            }
            UI(true);
        }

        private void DRP_Extract_DragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void NUD_Textures_Start_Click(object sender, EventArgs e)
        {
            UI(false);
            var dlg = new OpenFileDialog();
            dlg.Filter = "NUD Archives (*.nud)|*.nud|NUT Archives (*.nut)|*.nut|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(Environment.CurrentDirectory + "\\bms.exe");
                sw.BaseStream.Write(Properties.Resources.quickbms, 0, Properties.Resources.quickbms.Length);
                sw.Close();
                sw.Dispose();
                System.IO.StreamWriter sw2 = new System.IO.StreamWriter(Environment.CurrentDirectory + "\\script");
                sw2.BaseStream.Write(Properties.Resources.Pokken_NUT, 0, Properties.Resources.Pokken_NUT.Length);
                sw2.Close();
                sw2.Dispose();
                for (int i = 0; i < dlg.FileNames.Length; i++)
                {
                    ConsoleWrite(5, "");
                    ConsoleWrite(0, "Extracting " + dlg.FileNames[i]);
                    System.Diagnostics.Process quickbms = new System.Diagnostics.Process();
                    quickbms.StartInfo.FileName = Environment.CurrentDirectory + "\\bms.exe";
                    quickbms.StartInfo.Arguments = "-o -Y -Q \"" + Environment.CurrentDirectory + "\\script\" \"" + dlg.FileNames[i] + "\" \"" + dlg.FileNames[i].Remove(dlg.FileNames[i].IndexOf('.')) + "\"";
                    quickbms.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                    quickbms.Start();
                    quickbms.WaitForExit();
                    quickbms.Dispose();
                    ConsoleWrite(3, "Extraction finished!!!");
                    if (NUD_Textures_DeleteOriginal.Checked)
                    {
                        File.Delete(dlg.FileNames[i]);
                    }
                }
                File.Delete(Environment.CurrentDirectory + "\\bms");
                File.Delete(Environment.CurrentDirectory + "\\script");
            }
            UI(true);
        }

        private void NUD_Textures_DragDrop_DragDrop(object sender, DragEventArgs e)
        {
            UI(false);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Environment.CurrentDirectory + "\\bms.exe");
            sw.BaseStream.Write(Properties.Resources.quickbms, 0, Properties.Resources.quickbms.Length);
            sw.Close();
            sw.Dispose();
            System.IO.StreamWriter sw2 = new System.IO.StreamWriter(Environment.CurrentDirectory + "\\script");
            sw2.BaseStream.Write(Properties.Resources.Pokken_NUT, 0, Properties.Resources.Pokken_NUT.Length);
            sw2.Close();
            sw2.Dispose();
            for (int i = 0; i < files.Length; i++)
            {
                    ConsoleWrite(5, "");
                    ConsoleWrite(0, "Extracting " + files[i]);
                    System.Diagnostics.Process quickbms = new System.Diagnostics.Process();
                    quickbms.StartInfo.FileName = Environment.CurrentDirectory + "\\bms.exe";
                    quickbms.StartInfo.Arguments = "-o -Y -Q \"" + Environment.CurrentDirectory + "\\script\" \"" + files[i] + "\" \"" + files[i].Remove(files[i].IndexOf('.')) + "\"";
                    quickbms.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                    quickbms.Start();
                    quickbms.WaitForExit();
                 quickbms.Dispose();
                if (NUD_Textures_DeleteOriginal.Checked)
                {
                    File.Delete(files[i]);
                }
                }
                File.Delete(Environment.CurrentDirectory + "\\bms");
                File.Delete(Environment.CurrentDirectory + "\\script");
            UI(true);
        }

        private void NUD_Textures_DragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MaxScript_SaveAsFile_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "MaxScript File (*.ms)|*.ms";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ConsoleWrite(5, "");
                ConsoleWrite(0, "Writing MaxScript script to " + dlg.FileName);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlg.FileName);
                sw.BaseStream.Write(Properties.Resources.PokkenTournament_NDWD, 0, Properties.Resources.PokkenTournament_NDWD.Length);
                sw.Close();
                sw.Dispose();
                ConsoleWrite(0, "Written successfully!!!");
            }
        }
    }
}
