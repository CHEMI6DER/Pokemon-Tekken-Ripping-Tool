namespace Pokemon_Tekken_Ripping_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.DRP_Extract_Start = new System.Windows.Forms.Button();
            this.DRP_Extract_LeaveTempFiles = new System.Windows.Forms.CheckBox();
            this.DRP_Extract_DeleteOriginal = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_Textures_Start = new System.Windows.Forms.Button();
            this.DRP_Extract_DragDrop = new System.Windows.Forms.Label();
            this.NUD_Textures_DeleteOriginal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_Textures_DragDrop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxScript_SaveAsFile = new System.Windows.Forms.Button();
            this.Console_Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extraction and Conversion";
            // 
            // DRP_Extract_Start
            // 
            this.DRP_Extract_Start.AllowDrop = true;
            this.DRP_Extract_Start.Location = new System.Drawing.Point(18, 45);
            this.DRP_Extract_Start.Name = "DRP_Extract_Start";
            this.DRP_Extract_Start.Size = new System.Drawing.Size(147, 63);
            this.DRP_Extract_Start.TabIndex = 1;
            this.DRP_Extract_Start.Text = "Extract files from .drp archive";
            this.DRP_Extract_Start.UseVisualStyleBackColor = true;
            this.DRP_Extract_Start.Click += new System.EventHandler(this.DRP_Extract_Start_Click);
            // 
            // DRP_Extract_LeaveTempFiles
            // 
            this.DRP_Extract_LeaveTempFiles.AutoSize = true;
            this.DRP_Extract_LeaveTempFiles.Location = new System.Drawing.Point(18, 116);
            this.DRP_Extract_LeaveTempFiles.Name = "DRP_Extract_LeaveTempFiles";
            this.DRP_Extract_LeaveTempFiles.Size = new System.Drawing.Size(126, 17);
            this.DRP_Extract_LeaveTempFiles.TabIndex = 3;
            this.DRP_Extract_LeaveTempFiles.Text = "Leave temporary files";
            this.DRP_Extract_LeaveTempFiles.UseVisualStyleBackColor = true;
            // 
            // DRP_Extract_DeleteOriginal
            // 
            this.DRP_Extract_DeleteOriginal.AutoSize = true;
            this.DRP_Extract_DeleteOriginal.Location = new System.Drawing.Point(18, 137);
            this.DRP_Extract_DeleteOriginal.Name = "DRP_Extract_DeleteOriginal";
            this.DRP_Extract_DeleteOriginal.Size = new System.Drawing.Size(114, 17);
            this.DRP_Extract_DeleteOriginal.TabIndex = 5;
            this.DRP_Extract_DeleteOriginal.Text = "Delete original files";
            this.DRP_Extract_DeleteOriginal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 208);
            this.label2.TabIndex = 6;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // NUD_Textures_Start
            // 
            this.NUD_Textures_Start.Location = new System.Drawing.Point(188, 45);
            this.NUD_Textures_Start.Name = "NUD_Textures_Start";
            this.NUD_Textures_Start.Size = new System.Drawing.Size(147, 63);
            this.NUD_Textures_Start.TabIndex = 7;
            this.NUD_Textures_Start.Text = "Extract textures from .nud archive";
            this.NUD_Textures_Start.UseVisualStyleBackColor = true;
            this.NUD_Textures_Start.Click += new System.EventHandler(this.NUD_Textures_Start_Click);
            // 
            // DRP_Extract_DragDrop
            // 
            this.DRP_Extract_DragDrop.AllowDrop = true;
            this.DRP_Extract_DragDrop.AutoSize = true;
            this.DRP_Extract_DragDrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DRP_Extract_DragDrop.Location = new System.Drawing.Point(18, 157);
            this.DRP_Extract_DragDrop.Name = "DRP_Extract_DragDrop";
            this.DRP_Extract_DragDrop.Size = new System.Drawing.Size(147, 93);
            this.DRP_Extract_DragDrop.TabIndex = 8;
            this.DRP_Extract_DragDrop.Text = "\r\n\r\n\r\nDrag and Drop your files here\r\n\r\n\r\n\r\n";
            this.DRP_Extract_DragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.DRP_Extract_DragDrop_DragDrop);
            this.DRP_Extract_DragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.DRP_Extract_DragDrop_DragEnter);
            // 
            // NUD_Textures_DeleteOriginal
            // 
            this.NUD_Textures_DeleteOriginal.AutoSize = true;
            this.NUD_Textures_DeleteOriginal.Location = new System.Drawing.Point(188, 116);
            this.NUD_Textures_DeleteOriginal.Name = "NUD_Textures_DeleteOriginal";
            this.NUD_Textures_DeleteOriginal.Size = new System.Drawing.Size(114, 17);
            this.NUD_Textures_DeleteOriginal.TabIndex = 5;
            this.NUD_Textures_DeleteOriginal.Text = "Delete original files";
            this.NUD_Textures_DeleteOriginal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 247);
            this.label3.TabIndex = 10;
            this.label3.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(348, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Download Links";
            // 
            // NUD_Textures_DragDrop
            // 
            this.NUD_Textures_DragDrop.AllowDrop = true;
            this.NUD_Textures_DragDrop.AutoSize = true;
            this.NUD_Textures_DragDrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NUD_Textures_DragDrop.Location = new System.Drawing.Point(188, 157);
            this.NUD_Textures_DragDrop.Name = "NUD_Textures_DragDrop";
            this.NUD_Textures_DragDrop.Size = new System.Drawing.Size(147, 93);
            this.NUD_Textures_DragDrop.TabIndex = 8;
            this.NUD_Textures_DragDrop.Text = "\r\n\r\n\r\nDrag and Drop your files here\r\n\r\n\r\n\r\n";
            this.NUD_Textures_DragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.NUD_Textures_DragDrop_DragDrop);
            this.NUD_Textures_DragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.NUD_Textures_DragDrop_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(354, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "MaxScript NUD Importer and NUD2DDS script by RTB";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(354, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(239, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.vg-resource.com/thread-29836.html";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(354, 98);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(195, 13);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://aluigi.altervista.org/quickbms.htm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(354, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "quickbms by Luigi Auriemma";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(354, 135);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(235, 13);
            this.linkLabel3.TabIndex = 16;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://github.com/Sammi-Husky/Pokken-Tools";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(354, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pokken-Tools by Sammi Husky";
            // 
            // MaxScript_SaveAsFile
            // 
            this.MaxScript_SaveAsFile.Location = new System.Drawing.Point(357, 178);
            this.MaxScript_SaveAsFile.Name = "MaxScript_SaveAsFile";
            this.MaxScript_SaveAsFile.Size = new System.Drawing.Size(326, 72);
            this.MaxScript_SaveAsFile.TabIndex = 17;
            this.MaxScript_SaveAsFile.Text = "Save NUD Importer MaxScript to file";
            this.MaxScript_SaveAsFile.UseVisualStyleBackColor = true;
            this.MaxScript_SaveAsFile.Click += new System.EventHandler(this.MaxScript_SaveAsFile_Click);
            // 
            // Console_Output
            // 
            this.Console_Output.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Console_Output.ForeColor = System.Drawing.Color.Lime;
            this.Console_Output.FormattingEnabled = true;
            this.Console_Output.Items.AddRange(new object[] {
            ">>Pokemon Tekken Ripping Tools Ver 1.0 by CHEMI6DER",
            ">>Credits:",
            ">>quickbms by Luigi Auriemma",
            ">>MaxScript NUD Importer and NUD2DDS script by Random Talking Bush",
            ">>Pokken-Tools by Sammi Husky"});
            this.Console_Output.Location = new System.Drawing.Point(18, 259);
            this.Console_Output.Name = "Console_Output";
            this.Console_Output.Size = new System.Drawing.Size(665, 212);
            this.Console_Output.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 482);
            this.Controls.Add(this.Console_Output);
            this.Controls.Add(this.MaxScript_SaveAsFile);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUD_Textures_DragDrop);
            this.Controls.Add(this.DRP_Extract_DragDrop);
            this.Controls.Add(this.NUD_Textures_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUD_Textures_DeleteOriginal);
            this.Controls.Add(this.DRP_Extract_DeleteOriginal);
            this.Controls.Add(this.DRP_Extract_LeaveTempFiles);
            this.Controls.Add(this.DRP_Extract_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pokemon Tekken Ripping Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DRP_Extract_Start;
        private System.Windows.Forms.CheckBox DRP_Extract_LeaveTempFiles;
        private System.Windows.Forms.CheckBox DRP_Extract_DeleteOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NUD_Textures_Start;
        private System.Windows.Forms.Label DRP_Extract_DragDrop;
        private System.Windows.Forms.CheckBox NUD_Textures_DeleteOriginal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NUD_Textures_DragDrop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MaxScript_SaveAsFile;
        private System.Windows.Forms.ListBox Console_Output;
    }
}

