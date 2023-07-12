namespace ProteinMoleculesForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.CompareBtn = new System.Windows.Forms.Button();
            this.comboBoxChainFile1 = new System.Windows.Forms.ComboBox();
            this.File1 = new System.Windows.Forms.Button();
            this.File2 = new System.Windows.Forms.Button();
            this.comboBoxFile1 = new System.Windows.Forms.ComboBox();
            this.comboBoxFile2 = new System.Windows.Forms.ComboBox();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxChainFile2 = new System.Windows.Forms.ComboBox();
            this.richTextBoxProtein1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxProtein2 = new System.Windows.Forms.RichTextBox();
            this.textBoxCompareRes = new System.Windows.Forms.TextBox();
            this.textBoxBestFound = new System.Windows.Forms.TextBox();
            this.panelGraf1 = new System.Windows.Forms.Panel();
            this.panelGraf2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_3DModel = new System.Windows.Forms.Button();
            this.button2_3DModel = new System.Windows.Forms.Button();
            this.pictureBoxProtein1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxProtein2 = new System.Windows.Forms.PictureBox();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProtein1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProtein2)).BeginInit();
            this.SuspendLayout();
            // 
            // CompareBtn
            // 
            this.CompareBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.CompareBtn.Location = new System.Drawing.Point(40, 412);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(140, 50);
            this.CompareBtn.TabIndex = 1;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = false;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // comboBoxChainFile1
            // 
            this.comboBoxChainFile1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxChainFile1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChainFile1.FormattingEnabled = true;
            this.comboBoxChainFile1.Location = new System.Drawing.Point(679, 61);
            this.comboBoxChainFile1.Name = "comboBoxChainFile1";
            this.comboBoxChainFile1.Size = new System.Drawing.Size(103, 24);
            this.comboBoxChainFile1.TabIndex = 3;
            // 
            // File1
            // 
            this.File1.BackColor = System.Drawing.Color.GhostWhite;
            this.File1.Location = new System.Drawing.Point(40, 47);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(167, 51);
            this.File1.TabIndex = 4;
            this.File1.Text = "Choose file 1";
            this.File1.UseVisualStyleBackColor = false;
            this.File1.Click += new System.EventHandler(this.File1_Click);
            // 
            // File2
            // 
            this.File2.BackColor = System.Drawing.Color.GhostWhite;
            this.File2.Location = new System.Drawing.Point(40, 137);
            this.File2.Name = "File2";
            this.File2.Size = new System.Drawing.Size(167, 51);
            this.File2.TabIndex = 6;
            this.File2.Text = "Choose file 2";
            this.File2.UseVisualStyleBackColor = false;
            this.File2.Click += new System.EventHandler(this.File2_Click);
            // 
            // comboBoxFile1
            // 
            this.comboBoxFile1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxFile1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFile1.FormattingEnabled = true;
            this.comboBoxFile1.Location = new System.Drawing.Point(262, 61);
            this.comboBoxFile1.Name = "comboBoxFile1";
            this.comboBoxFile1.Size = new System.Drawing.Size(357, 24);
            this.comboBoxFile1.TabIndex = 8;
            this.comboBoxFile1.SelectedIndexChanged += new System.EventHandler(this.comboBoxFile1_SelectedIndexChanged);
            // 
            // comboBoxFile2
            // 
            this.comboBoxFile2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxFile2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFile2.FormattingEnabled = true;
            this.comboBoxFile2.Location = new System.Drawing.Point(262, 151);
            this.comboBoxFile2.Name = "comboBoxFile2";
            this.comboBoxFile2.Size = new System.Drawing.Size(357, 24);
            this.comboBoxFile2.TabIndex = 9;
            this.comboBoxFile2.SelectedIndexChanged += new System.EventHandler(this.comboBoxFile2_SelectedIndexChanged);
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.AutoSize = true;
            this.radioButtonMin.Location = new System.Drawing.Point(28, 41);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(49, 20);
            this.radioButtonMin.TabIndex = 0;
            this.radioButtonMin.TabStop = true;
            this.radioButtonMin.Text = "Min";
            this.radioButtonMin.UseVisualStyleBackColor = true;
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Location = new System.Drawing.Point(28, 86);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(53, 20);
            this.radioButtonMax.TabIndex = 1;
            this.radioButtonMax.TabStop = true;
            this.radioButtonMax.Text = "Max";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonMax);
            this.groupBoxMode.Controls.Add(this.radioButtonMin);
            this.groupBoxMode.Location = new System.Drawing.Point(335, 217);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(176, 137);
            this.groupBoxMode.TabIndex = 12;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(1067, 680);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 50);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxChainFile2
            // 
            this.comboBoxChainFile2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxChainFile2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChainFile2.FormattingEnabled = true;
            this.comboBoxChainFile2.Location = new System.Drawing.Point(679, 151);
            this.comboBoxChainFile2.Name = "comboBoxChainFile2";
            this.comboBoxChainFile2.Size = new System.Drawing.Size(103, 24);
            this.comboBoxChainFile2.TabIndex = 14;
            // 
            // richTextBoxProtein1
            // 
            this.richTextBoxProtein1.Enabled = false;
            this.richTextBoxProtein1.Location = new System.Drawing.Point(22, 217);
            this.richTextBoxProtein1.Name = "richTextBoxProtein1";
            this.richTextBoxProtein1.Size = new System.Drawing.Size(279, 181);
            this.richTextBoxProtein1.TabIndex = 15;
            this.richTextBoxProtein1.Text = "";
            // 
            // richTextBoxProtein2
            // 
            this.richTextBoxProtein2.Enabled = false;
            this.richTextBoxProtein2.Location = new System.Drawing.Point(541, 217);
            this.richTextBoxProtein2.Name = "richTextBoxProtein2";
            this.richTextBoxProtein2.Size = new System.Drawing.Size(285, 181);
            this.richTextBoxProtein2.TabIndex = 16;
            this.richTextBoxProtein2.Text = "";
            // 
            // textBoxCompareRes
            // 
            this.textBoxCompareRes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCompareRes.Enabled = false;
            this.textBoxCompareRes.Location = new System.Drawing.Point(311, 376);
            this.textBoxCompareRes.Name = "textBoxCompareRes";
            this.textBoxCompareRes.Size = new System.Drawing.Size(218, 22);
            this.textBoxCompareRes.TabIndex = 17;
            // 
            // textBoxBestFound
            // 
            this.textBoxBestFound.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxBestFound.Enabled = false;
            this.textBoxBestFound.Location = new System.Drawing.Point(311, 426);
            this.textBoxBestFound.Name = "textBoxBestFound";
            this.textBoxBestFound.Size = new System.Drawing.Size(218, 22);
            this.textBoxBestFound.TabIndex = 18;
            // 
            // panelGraf1
            // 
            this.panelGraf1.Location = new System.Drawing.Point(846, 47);
            this.panelGraf1.Name = "panelGraf1";
            this.panelGraf1.Size = new System.Drawing.Size(361, 196);
            this.panelGraf1.TabIndex = 19;
            // 
            // panelGraf2
            // 
            this.panelGraf2.Location = new System.Drawing.Point(846, 283);
            this.panelGraf2.Name = "panelGraf2";
            this.panelGraf2.Size = new System.Drawing.Size(361, 196);
            this.panelGraf2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1126, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Graf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1104, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Second Graf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(962, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Blue - alpha\r\nGreen - beta";
            // 
            // button1_3DModel
            // 
            this.button1_3DModel.Location = new System.Drawing.Point(22, 578);
            this.button1_3DModel.Name = "button1_3DModel";
            this.button1_3DModel.Size = new System.Drawing.Size(158, 51);
            this.button1_3DModel.TabIndex = 26;
            this.button1_3DModel.Text = "3D model Protein 1";
            this.button1_3DModel.UseVisualStyleBackColor = true;
            this.button1_3DModel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_3DModel
            // 
            this.button2_3DModel.Location = new System.Drawing.Point(561, 578);
            this.button2_3DModel.Name = "button2_3DModel";
            this.button2_3DModel.Size = new System.Drawing.Size(140, 51);
            this.button2_3DModel.TabIndex = 27;
            this.button2_3DModel.Text = "3D model Protein 2";
            this.button2_3DModel.UseVisualStyleBackColor = true;
            this.button2_3DModel.Click += new System.EventHandler(this.button2_3DModel_Click);
            // 
            // pictureBoxProtein1
            // 
            this.pictureBoxProtein1.Location = new System.Drawing.Point(231, 490);
            this.pictureBoxProtein1.Name = "pictureBoxProtein1";
            this.pictureBoxProtein1.Size = new System.Drawing.Size(280, 240);
            this.pictureBoxProtein1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProtein1.TabIndex = 28;
            this.pictureBoxProtein1.TabStop = false;
            // 
            // pictureBoxProtein2
            // 
            this.pictureBoxProtein2.Location = new System.Drawing.Point(742, 490);
            this.pictureBoxProtein2.Name = "pictureBoxProtein2";
            this.pictureBoxProtein2.Size = new System.Drawing.Size(280, 240);
            this.pictureBoxProtein2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProtein2.TabIndex = 29;
            this.pictureBoxProtein2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1228, 751);
            this.Controls.Add(this.pictureBoxProtein2);
            this.Controls.Add(this.pictureBoxProtein1);
            this.Controls.Add(this.button2_3DModel);
            this.Controls.Add(this.button1_3DModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGraf2);
            this.Controls.Add(this.panelGraf1);
            this.Controls.Add(this.textBoxBestFound);
            this.Controls.Add(this.textBoxCompareRes);
            this.Controls.Add(this.richTextBoxProtein2);
            this.Controls.Add(this.richTextBoxProtein1);
            this.Controls.Add(this.comboBoxChainFile2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.comboBoxFile2);
            this.Controls.Add(this.comboBoxFile1);
            this.Controls.Add(this.File2);
            this.Controls.Add(this.File1);
            this.Controls.Add(this.comboBoxChainFile1);
            this.Controls.Add(this.CompareBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Compare proteins";
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProtein1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProtein2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.ComboBox comboBoxChainFile1;
        private System.Windows.Forms.Button File1;
        private System.Windows.Forms.Button File2;
        private System.Windows.Forms.ComboBox comboBoxFile1;
        private System.Windows.Forms.ComboBox comboBoxFile2;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxChainFile2;
        private System.Windows.Forms.RichTextBox richTextBoxProtein1;
        private System.Windows.Forms.RichTextBox richTextBoxProtein2;
        private System.Windows.Forms.TextBox textBoxCompareRes;
        private System.Windows.Forms.TextBox textBoxBestFound;
        private System.Windows.Forms.Panel panelGraf1;
        private System.Windows.Forms.Panel panelGraf2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_3DModel;
        private System.Windows.Forms.Button button2_3DModel;
        private System.Windows.Forms.PictureBox pictureBoxProtein1;
        private System.Windows.Forms.PictureBox pictureBoxProtein2;
    }
}

