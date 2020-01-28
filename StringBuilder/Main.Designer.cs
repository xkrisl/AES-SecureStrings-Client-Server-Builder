namespace StringBuilder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EncryptTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DecryptTextbox = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.AESPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EncryptTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt";
            // 
            // EncryptTextbox
            // 
            this.EncryptTextbox.Location = new System.Drawing.Point(6, 19);
            this.EncryptTextbox.Multiline = true;
            this.EncryptTextbox.Name = "EncryptTextbox";
            this.EncryptTextbox.Size = new System.Drawing.Size(460, 75);
            this.EncryptTextbox.TabIndex = 8;
            this.EncryptTextbox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DecryptTextbox);
            this.groupBox2.Location = new System.Drawing.Point(15, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt";
            // 
            // DecryptTextbox
            // 
            this.DecryptTextbox.Location = new System.Drawing.Point(6, 19);
            this.DecryptTextbox.Multiline = true;
            this.DecryptTextbox.Name = "DecryptTextbox";
            this.DecryptTextbox.Size = new System.Drawing.Size(460, 75);
            this.DecryptTextbox.TabIndex = 9;
            this.DecryptTextbox.TabStop = false;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(409, 270);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 14;
            this.DecryptButton.TabStop = false;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(409, 135);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 13;
            this.EncryptButton.TabStop = false;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // AESPasswordTextbox
            // 
            this.AESPasswordTextbox.Location = new System.Drawing.Point(74, 3);
            this.AESPasswordTextbox.Name = "AESPasswordTextbox";
            this.AESPasswordTextbox.Size = new System.Drawing.Size(410, 20);
            this.AESPasswordTextbox.TabIndex = 12;
            this.AESPasswordTextbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.AESPasswordTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES String Builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EncryptTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DecryptTextbox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox AESPasswordTextbox;
        private System.Windows.Forms.Label label1;
    }
}

