namespace СonvolutionalСode
{
    partial class FM_Main
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
            this.RTB_Source = new System.Windows.Forms.RichTextBox();
            this.LB_SourceStr = new System.Windows.Forms.Label();
            this.BT_Code = new System.Windows.Forms.Button();
            this.PN_WWOS = new System.Windows.Forms.Panel();
            this.LB_ConvCode = new System.Windows.Forms.Label();
            this.LB_AdEl = new System.Windows.Forms.Label();
            this.LB_Binary = new System.Windows.Forms.Label();
            this.RTB_ConvolCode = new System.Windows.Forms.RichTextBox();
            this.RTB_AditElems = new System.Windows.Forms.RichTextBox();
            this.RTB_BinStr = new System.Windows.Forms.RichTextBox();
            this.LB_PNOName = new System.Windows.Forms.Label();
            this.PN_WWIS = new System.Windows.Forms.Panel();
            this.LB_RecStr = new System.Windows.Forms.Label();
            this.LB_RecCode = new System.Windows.Forms.Label();
            this.LB_ConvolCodeWithInter = new System.Windows.Forms.Label();
            this.RTB_RecoveredStr = new System.Windows.Forms.RichTextBox();
            this.RTB_RecoveredCode = new System.Windows.Forms.RichTextBox();
            this.RTB_ConvolCodeWithInter = new System.Windows.Forms.RichTextBox();
            this.LB_PNIName = new System.Windows.Forms.Label();
            this.PN_InterOpt = new System.Windows.Forms.Panel();
            this.LB_InterOpt = new System.Windows.Forms.Label();
            this.NUD_InterfIntensive = new System.Windows.Forms.NumericUpDown();
            this.BT_InsertInterf = new System.Windows.Forms.Button();
            this.PN_Source = new System.Windows.Forms.Panel();
            this.PN_WWOS.SuspendLayout();
            this.PN_WWIS.SuspendLayout();
            this.PN_InterOpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_InterfIntensive)).BeginInit();
            this.PN_Source.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTB_Source
            // 
            this.RTB_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Source.Location = new System.Drawing.Point(4, 24);
            this.RTB_Source.Name = "RTB_Source";
            this.RTB_Source.Size = new System.Drawing.Size(539, 40);
            this.RTB_Source.TabIndex = 0;
            this.RTB_Source.Text = "";
            // 
            // LB_SourceStr
            // 
            this.LB_SourceStr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_SourceStr.AutoSize = true;
            this.LB_SourceStr.Location = new System.Drawing.Point(234, 8);
            this.LB_SourceStr.Name = "LB_SourceStr";
            this.LB_SourceStr.Size = new System.Drawing.Size(94, 13);
            this.LB_SourceStr.TabIndex = 1;
            this.LB_SourceStr.Text = "Исходная строка";
            // 
            // BT_Code
            // 
            this.BT_Code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_Code.Location = new System.Drawing.Point(70, 68);
            this.BT_Code.Name = "BT_Code";
            this.BT_Code.Size = new System.Drawing.Size(125, 30);
            this.BT_Code.TabIndex = 2;
            this.BT_Code.Text = "Закодировать";
            this.BT_Code.UseVisualStyleBackColor = true;
            this.BT_Code.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BT_Code_MouseUp);
            // 
            // PN_WWOS
            // 
            this.PN_WWOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_WWOS.Controls.Add(this.LB_ConvCode);
            this.PN_WWOS.Controls.Add(this.LB_AdEl);
            this.PN_WWOS.Controls.Add(this.LB_Binary);
            this.PN_WWOS.Controls.Add(this.RTB_ConvolCode);
            this.PN_WWOS.Controls.Add(this.RTB_AditElems);
            this.PN_WWOS.Controls.Add(this.RTB_BinStr);
            this.PN_WWOS.Controls.Add(this.LB_PNOName);
            this.PN_WWOS.Dock = System.Windows.Forms.DockStyle.Left;
            this.PN_WWOS.Location = new System.Drawing.Point(0, 109);
            this.PN_WWOS.Name = "PN_WWOS";
            this.PN_WWOS.Size = new System.Drawing.Size(272, 291);
            this.PN_WWOS.TabIndex = 3;
            // 
            // LB_ConvCode
            // 
            this.LB_ConvCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_ConvCode.AutoSize = true;
            this.LB_ConvCode.Location = new System.Drawing.Point(91, 204);
            this.LB_ConvCode.Name = "LB_ConvCode";
            this.LB_ConvCode.Size = new System.Drawing.Size(89, 13);
            this.LB_ConvCode.TabIndex = 11;
            this.LB_ConvCode.Text = "Свёрточный код";
            // 
            // LB_AdEl
            // 
            this.LB_AdEl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_AdEl.AutoSize = true;
            this.LB_AdEl.Location = new System.Drawing.Point(26, 124);
            this.LB_AdEl.Name = "LB_AdEl";
            this.LB_AdEl.Size = new System.Drawing.Size(218, 13);
            this.LB_AdEl.TabIndex = 10;
            this.LB_AdEl.Text = "Дополнительные элементы кодирования";
            // 
            // LB_Binary
            // 
            this.LB_Binary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Binary.AutoSize = true;
            this.LB_Binary.Location = new System.Drawing.Point(76, 44);
            this.LB_Binary.Name = "LB_Binary";
            this.LB_Binary.Size = new System.Drawing.Size(118, 13);
            this.LB_Binary.TabIndex = 9;
            this.LB_Binary.Text = "Двоичный код строки";
            // 
            // RTB_ConvolCode
            // 
            this.RTB_ConvolCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTB_ConvolCode.Location = new System.Drawing.Point(3, 220);
            this.RTB_ConvolCode.Name = "RTB_ConvolCode";
            this.RTB_ConvolCode.ReadOnly = true;
            this.RTB_ConvolCode.Size = new System.Drawing.Size(264, 55);
            this.RTB_ConvolCode.TabIndex = 8;
            this.RTB_ConvolCode.Text = "";
            // 
            // RTB_AditElems
            // 
            this.RTB_AditElems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTB_AditElems.ForeColor = System.Drawing.Color.Green;
            this.RTB_AditElems.Location = new System.Drawing.Point(3, 140);
            this.RTB_AditElems.Name = "RTB_AditElems";
            this.RTB_AditElems.ReadOnly = true;
            this.RTB_AditElems.Size = new System.Drawing.Size(264, 55);
            this.RTB_AditElems.TabIndex = 7;
            this.RTB_AditElems.Text = "";
            // 
            // RTB_BinStr
            // 
            this.RTB_BinStr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTB_BinStr.Location = new System.Drawing.Point(3, 60);
            this.RTB_BinStr.Name = "RTB_BinStr";
            this.RTB_BinStr.ReadOnly = true;
            this.RTB_BinStr.Size = new System.Drawing.Size(264, 55);
            this.RTB_BinStr.TabIndex = 6;
            this.RTB_BinStr.Text = "";
            // 
            // LB_PNOName
            // 
            this.LB_PNOName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_PNOName.AutoSize = true;
            this.LB_PNOName.Location = new System.Drawing.Point(39, 10);
            this.LB_PNOName.Name = "LB_PNOName";
            this.LB_PNOName.Size = new System.Drawing.Size(198, 13);
            this.LB_PNOName.TabIndex = 5;
            this.LB_PNOName.Text = "Представление оригинальной строки";
            // 
            // PN_WWIS
            // 
            this.PN_WWIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_WWIS.Controls.Add(this.LB_RecStr);
            this.PN_WWIS.Controls.Add(this.LB_RecCode);
            this.PN_WWIS.Controls.Add(this.LB_ConvolCodeWithInter);
            this.PN_WWIS.Controls.Add(this.RTB_RecoveredStr);
            this.PN_WWIS.Controls.Add(this.RTB_RecoveredCode);
            this.PN_WWIS.Controls.Add(this.RTB_ConvolCodeWithInter);
            this.PN_WWIS.Controls.Add(this.LB_PNIName);
            this.PN_WWIS.Dock = System.Windows.Forms.DockStyle.Right;
            this.PN_WWIS.Location = new System.Drawing.Point(272, 109);
            this.PN_WWIS.Name = "PN_WWIS";
            this.PN_WWIS.Size = new System.Drawing.Size(277, 291);
            this.PN_WWIS.TabIndex = 4;
            // 
            // LB_RecStr
            // 
            this.LB_RecStr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_RecStr.AutoSize = true;
            this.LB_RecStr.Location = new System.Drawing.Point(70, 124);
            this.LB_RecStr.Name = "LB_RecStr";
            this.LB_RecStr.Size = new System.Drawing.Size(135, 13);
            this.LB_RecStr.TabIndex = 14;
            this.LB_RecStr.Text = "Восстановленная строка";
            // 
            // LB_RecCode
            // 
            this.LB_RecCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_RecCode.AutoSize = true;
            this.LB_RecCode.Location = new System.Drawing.Point(47, 44);
            this.LB_RecCode.Name = "LB_RecCode";
            this.LB_RecCode.Size = new System.Drawing.Size(183, 13);
            this.LB_RecCode.TabIndex = 13;
            this.LB_RecCode.Text = "Восстановленный свёрточный код";
            // 
            // LB_ConvolCodeWithInter
            // 
            this.LB_ConvolCodeWithInter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_ConvolCodeWithInter.AutoSize = true;
            this.LB_ConvolCodeWithInter.Location = new System.Drawing.Point(70, 204);
            this.LB_ConvolCodeWithInter.Name = "LB_ConvolCodeWithInter";
            this.LB_ConvolCodeWithInter.Size = new System.Drawing.Size(152, 13);
            this.LB_ConvolCodeWithInter.TabIndex = 12;
            this.LB_ConvolCodeWithInter.Text = "Свёрточный код с помехами";
            // 
            // RTB_RecoveredStr
            // 
            this.RTB_RecoveredStr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTB_RecoveredStr.Location = new System.Drawing.Point(4, 140);
            this.RTB_RecoveredStr.Name = "RTB_RecoveredStr";
            this.RTB_RecoveredStr.ReadOnly = true;
            this.RTB_RecoveredStr.Size = new System.Drawing.Size(264, 55);
            this.RTB_RecoveredStr.TabIndex = 9;
            this.RTB_RecoveredStr.Text = "";
            // 
            // RTB_RecoveredCode
            // 
            this.RTB_RecoveredCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTB_RecoveredCode.Location = new System.Drawing.Point(4, 60);
            this.RTB_RecoveredCode.Name = "RTB_RecoveredCode";
            this.RTB_RecoveredCode.ReadOnly = true;
            this.RTB_RecoveredCode.Size = new System.Drawing.Size(264, 55);
            this.RTB_RecoveredCode.TabIndex = 8;
            this.RTB_RecoveredCode.Text = "";
            // 
            // RTB_ConvolCodeWithInter
            // 
            this.RTB_ConvolCodeWithInter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTB_ConvolCodeWithInter.Location = new System.Drawing.Point(4, 220);
            this.RTB_ConvolCodeWithInter.Name = "RTB_ConvolCodeWithInter";
            this.RTB_ConvolCodeWithInter.ReadOnly = true;
            this.RTB_ConvolCodeWithInter.Size = new System.Drawing.Size(264, 55);
            this.RTB_ConvolCodeWithInter.TabIndex = 7;
            this.RTB_ConvolCodeWithInter.Text = "";
            // 
            // LB_PNIName
            // 
            this.LB_PNIName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_PNIName.AutoSize = true;
            this.LB_PNIName.Location = new System.Drawing.Point(61, 10);
            this.LB_PNIName.Name = "LB_PNIName";
            this.LB_PNIName.Size = new System.Drawing.Size(173, 13);
            this.LB_PNIName.TabIndex = 6;
            this.LB_PNIName.Text = "Строка с внесёнными помехами";
            // 
            // PN_InterOpt
            // 
            this.PN_InterOpt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PN_InterOpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_InterOpt.Controls.Add(this.LB_InterOpt);
            this.PN_InterOpt.Controls.Add(this.NUD_InterfIntensive);
            this.PN_InterOpt.Controls.Add(this.BT_InsertInterf);
            this.PN_InterOpt.Location = new System.Drawing.Point(232, 67);
            this.PN_InterOpt.Name = "PN_InterOpt";
            this.PN_InterOpt.Size = new System.Drawing.Size(311, 39);
            this.PN_InterOpt.TabIndex = 5;
            // 
            // LB_InterOpt
            // 
            this.LB_InterOpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_InterOpt.AutoSize = true;
            this.LB_InterOpt.Location = new System.Drawing.Point(1, 12);
            this.LB_InterOpt.Name = "LB_InterOpt";
            this.LB_InterOpt.Size = new System.Drawing.Size(158, 13);
            this.LB_InterOpt.TabIndex = 2;
            this.LB_InterOpt.Text = "Кол-во проходов цикла помех";
            // 
            // NUD_InterfIntensive
            // 
            this.NUD_InterfIntensive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_InterfIntensive.Location = new System.Drawing.Point(161, 10);
            this.NUD_InterfIntensive.Name = "NUD_InterfIntensive";
            this.NUD_InterfIntensive.Size = new System.Drawing.Size(43, 20);
            this.NUD_InterfIntensive.TabIndex = 1;
            // 
            // BT_InsertInterf
            // 
            this.BT_InsertInterf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_InsertInterf.Location = new System.Drawing.Point(210, 3);
            this.BT_InsertInterf.Name = "BT_InsertInterf";
            this.BT_InsertInterf.Size = new System.Drawing.Size(96, 30);
            this.BT_InsertInterf.TabIndex = 0;
            this.BT_InsertInterf.Text = "Внести помехи";
            this.BT_InsertInterf.UseVisualStyleBackColor = true;
            this.BT_InsertInterf.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BT_InsertInterf_MouseUp);
            // 
            // PN_Source
            // 
            this.PN_Source.Controls.Add(this.PN_InterOpt);
            this.PN_Source.Controls.Add(this.BT_Code);
            this.PN_Source.Controls.Add(this.RTB_Source);
            this.PN_Source.Controls.Add(this.LB_SourceStr);
            this.PN_Source.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Source.Location = new System.Drawing.Point(0, 0);
            this.PN_Source.Name = "PN_Source";
            this.PN_Source.Size = new System.Drawing.Size(549, 109);
            this.PN_Source.TabIndex = 6;
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(549, 400);
            this.Controls.Add(this.PN_WWIS);
            this.Controls.Add(this.PN_WWOS);
            this.Controls.Add(this.PN_Source);
            this.Name = "FM_Main";
            this.Text = "Свёрточный код";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM_Main_FormClosing);
            this.Load += new System.EventHandler(this.FM_Main_Load);
            this.PN_WWOS.ResumeLayout(false);
            this.PN_WWOS.PerformLayout();
            this.PN_WWIS.ResumeLayout(false);
            this.PN_WWIS.PerformLayout();
            this.PN_InterOpt.ResumeLayout(false);
            this.PN_InterOpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_InterfIntensive)).EndInit();
            this.PN_Source.ResumeLayout(false);
            this.PN_Source.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Source;
        private System.Windows.Forms.Label LB_SourceStr;
        private System.Windows.Forms.Button BT_Code;
        private System.Windows.Forms.Panel PN_WWOS;
        private System.Windows.Forms.Panel PN_WWIS;
        private System.Windows.Forms.Label LB_PNOName;
        private System.Windows.Forms.Label LB_PNIName;
        private System.Windows.Forms.RichTextBox RTB_ConvolCode;
        private System.Windows.Forms.RichTextBox RTB_AditElems;
        private System.Windows.Forms.RichTextBox RTB_BinStr;
        private System.Windows.Forms.Label LB_ConvCode;
        private System.Windows.Forms.Label LB_AdEl;
        private System.Windows.Forms.Label LB_Binary;
        private System.Windows.Forms.RichTextBox RTB_ConvolCodeWithInter;
        private System.Windows.Forms.RichTextBox RTB_RecoveredStr;
        private System.Windows.Forms.RichTextBox RTB_RecoveredCode;
        private System.Windows.Forms.Label LB_RecStr;
        private System.Windows.Forms.Label LB_RecCode;
        private System.Windows.Forms.Label LB_ConvolCodeWithInter;
        private System.Windows.Forms.Panel PN_InterOpt;
        private System.Windows.Forms.Button BT_InsertInterf;
        private System.Windows.Forms.NumericUpDown NUD_InterfIntensive;
        private System.Windows.Forms.Label LB_InterOpt;
        private System.Windows.Forms.Panel PN_Source;
    }
}

