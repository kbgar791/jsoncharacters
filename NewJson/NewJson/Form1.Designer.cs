namespace NewJson
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.DescText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.HeadshotBox = new System.Windows.Forms.PictureBox();
            this.InfText = new System.Windows.Forms.TextBox();
            this.HPText = new System.Windows.Forms.TextBox();
            this.TypeText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.InfLabel = new System.Windows.Forms.Label();
            this.HPLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeadshotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(224, 444);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 59);
            this.button6.TabIndex = 35;
            this.button6.Text = "Next";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 59);
            this.button3.TabIndex = 32;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(288, 180);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(125, 43);
            this.addbutton.TabIndex = 28;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // DescText
            // 
            this.DescText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescText.ForeColor = System.Drawing.SystemColors.Window;
            this.DescText.Location = new System.Drawing.Point(12, 180);
            this.DescText.Multiline = true;
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(270, 194);
            this.DescText.TabIndex = 26;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(288, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 43);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HeadshotBox
            // 
            this.HeadshotBox.Image = global::NewJson.Properties.Resources.CLARKE_THOMAS;
            this.HeadshotBox.Location = new System.Drawing.Point(250, 5);
            this.HeadshotBox.Name = "HeadshotBox";
            this.HeadshotBox.Size = new System.Drawing.Size(165, 172);
            this.HeadshotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeadshotBox.TabIndex = 29;
            this.HeadshotBox.TabStop = false;
            this.HeadshotBox.Click += new System.EventHandler(this.HeadshotBox_Click);
            // 
            // InfText
            // 
            this.InfText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InfText.ForeColor = System.Drawing.SystemColors.Window;
            this.InfText.Location = new System.Drawing.Point(101, 117);
            this.InfText.Name = "InfText";
            this.InfText.Size = new System.Drawing.Size(100, 20);
            this.InfText.TabIndex = 24;
            // 
            // HPText
            // 
            this.HPText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HPText.ForeColor = System.Drawing.SystemColors.Window;
            this.HPText.Location = new System.Drawing.Point(101, 83);
            this.HPText.Name = "HPText";
            this.HPText.Size = new System.Drawing.Size(100, 20);
            this.HPText.TabIndex = 22;
            // 
            // TypeText
            // 
            this.TypeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypeText.ForeColor = System.Drawing.SystemColors.Window;
            this.TypeText.Location = new System.Drawing.Point(101, 45);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(100, 20);
            this.TypeText.TabIndex = 19;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameText.ForeColor = System.Drawing.SystemColors.Window;
            this.NameText.Location = new System.Drawing.Point(101, 11);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 18;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DescLabel.Location = new System.Drawing.Point(6, 143);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(113, 34);
            this.DescLabel.TabIndex = 25;
            this.DescLabel.Text = "Description";
            // 
            // InfLabel
            // 
            this.InfLabel.AutoSize = true;
            this.InfLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfLabel.ForeColor = System.Drawing.Color.Maroon;
            this.InfLabel.Location = new System.Drawing.Point(6, 111);
            this.InfLabel.Name = "InfLabel";
            this.InfLabel.Size = new System.Drawing.Size(89, 34);
            this.InfLabel.TabIndex = 23;
            this.InfLabel.Text = "Infection";
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPLabel.ForeColor = System.Drawing.Color.Maroon;
            this.HPLabel.Location = new System.Drawing.Point(6, 77);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(35, 34);
            this.HPLabel.TabIndex = 21;
            this.HPLabel.Text = "HP";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TypeLabel.Location = new System.Drawing.Point(6, 39);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(57, 34);
            this.TypeLabel.TabIndex = 20;
            this.TypeLabel.Text = "Type";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.NameLabel.Location = new System.Drawing.Point(6, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 34);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(288, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(423, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.DescText);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HeadshotBox);
            this.Controls.Add(this.InfText);
            this.Controls.Add(this.HPText);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.InfLabel);
            this.Controls.Add(this.HPLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Characs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadshotBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox DescText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox HeadshotBox;
        private System.Windows.Forms.TextBox InfText;
        private System.Windows.Forms.TextBox HPText;
        private System.Windows.Forms.TextBox TypeText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label InfLabel;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

