namespace FileLocker
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.tabControlEncrptDecrypt = new System.Windows.Forms.TabControl();
            this.tabPageEncrypt = new System.Windows.Forms.TabPage();
            this.tabPageDecrypt = new System.Windows.Forms.TabPage();
            this.btnChangeEncrypt = new System.Windows.Forms.Button();
            this.txtDestinationEncrypt = new System.Windows.Forms.TextBox();
            this.lblFileDestEncrypt = new System.Windows.Forms.Label();
            this.lblFileToEncrypt = new System.Windows.Forms.Label();
            this.btnBrowseEncrypt = new System.Windows.Forms.Button();
            this.txtFileToEncrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtConPassEncrypt = new System.Windows.Forms.TextBox();
            this.txtPassEncrypt = new System.Windows.Forms.TextBox();
            this.lblConPassEncrypt = new System.Windows.Forms.Label();
            this.lblPassEncrypt = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtConPassDecrypt = new System.Windows.Forms.TextBox();
            this.txtPassDecrypt = new System.Windows.Forms.TextBox();
            this.lblConPassDecrypt = new System.Windows.Forms.Label();
            this.lblPassDecrypt = new System.Windows.Forms.Label();
            this.btnChangeDecrypt = new System.Windows.Forms.Button();
            this.txtDestinationDecrypt = new System.Windows.Forms.TextBox();
            this.lblFileDestDecrypt = new System.Windows.Forms.Label();
            this.lblFileToDecrypt = new System.Windows.Forms.Label();
            this.btnBrowseDecrypt = new System.Windows.Forms.Button();
            this.txtFileToDecrypt = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.lblRequired1 = new System.Windows.Forms.Label();
            this.lblRequired2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlEncrptDecrypt.SuspendLayout();
            this.tabPageEncrypt.SuspendLayout();
            this.tabPageDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEncrptDecrypt
            // 
            this.tabControlEncrptDecrypt.Controls.Add(this.tabPageEncrypt);
            this.tabControlEncrptDecrypt.Controls.Add(this.tabPageDecrypt);
            this.tabControlEncrptDecrypt.Location = new System.Drawing.Point(5, 25);
            this.tabControlEncrptDecrypt.Name = "tabControlEncrptDecrypt";
            this.tabControlEncrptDecrypt.SelectedIndex = 0;
            this.tabControlEncrptDecrypt.Size = new System.Drawing.Size(396, 158);
            this.tabControlEncrptDecrypt.TabIndex = 0;
            // 
            // tabPageEncrypt
            // 
            this.tabPageEncrypt.Controls.Add(this.lblRequired2);
            this.tabPageEncrypt.Controls.Add(this.lblRequired1);
            this.tabPageEncrypt.Controls.Add(this.btnEncrypt);
            this.tabPageEncrypt.Controls.Add(this.txtConPassEncrypt);
            this.tabPageEncrypt.Controls.Add(this.txtPassEncrypt);
            this.tabPageEncrypt.Controls.Add(this.lblConPassEncrypt);
            this.tabPageEncrypt.Controls.Add(this.lblPassEncrypt);
            this.tabPageEncrypt.Controls.Add(this.btnChangeEncrypt);
            this.tabPageEncrypt.Controls.Add(this.txtDestinationEncrypt);
            this.tabPageEncrypt.Controls.Add(this.lblFileDestEncrypt);
            this.tabPageEncrypt.Controls.Add(this.lblFileToEncrypt);
            this.tabPageEncrypt.Controls.Add(this.btnBrowseEncrypt);
            this.tabPageEncrypt.Controls.Add(this.txtFileToEncrypt);
            this.tabPageEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEncrypt.Name = "tabPageEncrypt";
            this.tabPageEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncrypt.Size = new System.Drawing.Size(388, 132);
            this.tabPageEncrypt.TabIndex = 0;
            this.tabPageEncrypt.Text = "Encrypt";
            this.tabPageEncrypt.UseVisualStyleBackColor = true;
            // 
            // tabPageDecrypt
            // 
            this.tabPageDecrypt.Controls.Add(this.label1);
            this.tabPageDecrypt.Controls.Add(this.label2);
            this.tabPageDecrypt.Controls.Add(this.btnDecrypt);
            this.tabPageDecrypt.Controls.Add(this.txtConPassDecrypt);
            this.tabPageDecrypt.Controls.Add(this.txtPassDecrypt);
            this.tabPageDecrypt.Controls.Add(this.lblConPassDecrypt);
            this.tabPageDecrypt.Controls.Add(this.lblPassDecrypt);
            this.tabPageDecrypt.Controls.Add(this.btnChangeDecrypt);
            this.tabPageDecrypt.Controls.Add(this.txtDestinationDecrypt);
            this.tabPageDecrypt.Controls.Add(this.lblFileDestDecrypt);
            this.tabPageDecrypt.Controls.Add(this.lblFileToDecrypt);
            this.tabPageDecrypt.Controls.Add(this.btnBrowseDecrypt);
            this.tabPageDecrypt.Controls.Add(this.txtFileToDecrypt);
            this.tabPageDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecrypt.Name = "tabPageDecrypt";
            this.tabPageDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecrypt.Size = new System.Drawing.Size(388, 132);
            this.tabPageDecrypt.TabIndex = 1;
            this.tabPageDecrypt.Text = "Decrypt";
            this.tabPageDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnChangeEncrypt
            // 
            this.btnChangeEncrypt.Enabled = false;
            this.btnChangeEncrypt.Location = new System.Drawing.Point(301, 35);
            this.btnChangeEncrypt.Name = "btnChangeEncrypt";
            this.btnChangeEncrypt.Size = new System.Drawing.Size(72, 21);
            this.btnChangeEncrypt.TabIndex = 17;
            this.btnChangeEncrypt.Text = "Change";
            this.btnChangeEncrypt.Click += new System.EventHandler(this.btnChangeEncrypt_Click);
            // 
            // txtDestinationEncrypt
            // 
            this.txtDestinationEncrypt.Location = new System.Drawing.Point(109, 36);
            this.txtDestinationEncrypt.Name = "txtDestinationEncrypt";
            this.txtDestinationEncrypt.ReadOnly = true;
            this.txtDestinationEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtDestinationEncrypt.TabIndex = 16;
            // 
            // lblFileDestEncrypt
            // 
            this.lblFileDestEncrypt.Location = new System.Drawing.Point(-3, 36);
            this.lblFileDestEncrypt.Name = "lblFileDestEncrypt";
            this.lblFileDestEncrypt.Size = new System.Drawing.Size(88, 16);
            this.lblFileDestEncrypt.TabIndex = 15;
            this.lblFileDestEncrypt.Text = "File destination:";
            this.lblFileDestEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileToEncrypt
            // 
            this.lblFileToEncrypt.Location = new System.Drawing.Point(3, 13);
            this.lblFileToEncrypt.Name = "lblFileToEncrypt";
            this.lblFileToEncrypt.Size = new System.Drawing.Size(80, 16);
            this.lblFileToEncrypt.TabIndex = 14;
            this.lblFileToEncrypt.Text = "File to encrypt:";
            this.lblFileToEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowseEncrypt
            // 
            this.btnBrowseEncrypt.Location = new System.Drawing.Point(301, 11);
            this.btnBrowseEncrypt.Name = "btnBrowseEncrypt";
            this.btnBrowseEncrypt.Size = new System.Drawing.Size(72, 21);
            this.btnBrowseEncrypt.TabIndex = 13;
            this.btnBrowseEncrypt.Text = "Browse";
            this.btnBrowseEncrypt.Click += new System.EventHandler(this.btnBrowseEncrypt_Click);
            // 
            // txtFileToEncrypt
            // 
            this.txtFileToEncrypt.Location = new System.Drawing.Point(109, 12);
            this.txtFileToEncrypt.Name = "txtFileToEncrypt";
            this.txtFileToEncrypt.ReadOnly = true;
            this.txtFileToEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtFileToEncrypt.TabIndex = 12;
            this.txtFileToEncrypt.Text = "Click Browse to load file.";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(301, 69);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(72, 45);
            this.btnEncrypt.TabIndex = 22;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtConPassEncrypt
            // 
            this.txtConPassEncrypt.Enabled = false;
            this.txtConPassEncrypt.Location = new System.Drawing.Point(109, 94);
            this.txtConPassEncrypt.Name = "txtConPassEncrypt";
            this.txtConPassEncrypt.PasswordChar = '*';
            this.txtConPassEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtConPassEncrypt.TabIndex = 21;
            // 
            // txtPassEncrypt
            // 
            this.txtPassEncrypt.Enabled = false;
            this.txtPassEncrypt.Location = new System.Drawing.Point(109, 69);
            this.txtPassEncrypt.Name = "txtPassEncrypt";
            this.txtPassEncrypt.PasswordChar = '*';
            this.txtPassEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtPassEncrypt.TabIndex = 20;
            // 
            // lblConPassEncrypt
            // 
            this.lblConPassEncrypt.Location = new System.Drawing.Point(-3, 94);
            this.lblConPassEncrypt.Name = "lblConPassEncrypt";
            this.lblConPassEncrypt.Size = new System.Drawing.Size(100, 16);
            this.lblConPassEncrypt.TabIndex = 19;
            this.lblConPassEncrypt.Text = "Confirm password:";
            this.lblConPassEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassEncrypt
            // 
            this.lblPassEncrypt.Location = new System.Drawing.Point(-3, 70);
            this.lblPassEncrypt.Name = "lblPassEncrypt";
            this.lblPassEncrypt.Size = new System.Drawing.Size(88, 16);
            this.lblPassEncrypt.TabIndex = 18;
            this.lblPassEncrypt.Text = "Type password:";
            this.lblPassEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(303, 70);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(72, 44);
            this.btnDecrypt.TabIndex = 33;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtConPassDecrypt
            // 
            this.txtConPassDecrypt.Enabled = false;
            this.txtConPassDecrypt.Location = new System.Drawing.Point(113, 93);
            this.txtConPassDecrypt.Name = "txtConPassDecrypt";
            this.txtConPassDecrypt.PasswordChar = '*';
            this.txtConPassDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtConPassDecrypt.TabIndex = 32;
            // 
            // txtPassDecrypt
            // 
            this.txtPassDecrypt.Enabled = false;
            this.txtPassDecrypt.Location = new System.Drawing.Point(113, 68);
            this.txtPassDecrypt.Name = "txtPassDecrypt";
            this.txtPassDecrypt.PasswordChar = '*';
            this.txtPassDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtPassDecrypt.TabIndex = 31;
            // 
            // lblConPassDecrypt
            // 
            this.lblConPassDecrypt.Location = new System.Drawing.Point(1, 93);
            this.lblConPassDecrypt.Name = "lblConPassDecrypt";
            this.lblConPassDecrypt.Size = new System.Drawing.Size(100, 16);
            this.lblConPassDecrypt.TabIndex = 30;
            this.lblConPassDecrypt.Text = "Confirm password:";
            this.lblConPassDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassDecrypt
            // 
            this.lblPassDecrypt.Location = new System.Drawing.Point(1, 69);
            this.lblPassDecrypt.Name = "lblPassDecrypt";
            this.lblPassDecrypt.Size = new System.Drawing.Size(88, 16);
            this.lblPassDecrypt.TabIndex = 29;
            this.lblPassDecrypt.Text = "Type password:";
            this.lblPassDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChangeDecrypt
            // 
            this.btnChangeDecrypt.Enabled = false;
            this.btnChangeDecrypt.Location = new System.Drawing.Point(303, 36);
            this.btnChangeDecrypt.Name = "btnChangeDecrypt";
            this.btnChangeDecrypt.Size = new System.Drawing.Size(72, 21);
            this.btnChangeDecrypt.TabIndex = 28;
            this.btnChangeDecrypt.Text = "Change";
            this.btnChangeDecrypt.Click += new System.EventHandler(this.btnChangeDecrypt_Click);
            // 
            // txtDestinationDecrypt
            // 
            this.txtDestinationDecrypt.Location = new System.Drawing.Point(113, 35);
            this.txtDestinationDecrypt.Name = "txtDestinationDecrypt";
            this.txtDestinationDecrypt.ReadOnly = true;
            this.txtDestinationDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtDestinationDecrypt.TabIndex = 27;
            // 
            // lblFileDestDecrypt
            // 
            this.lblFileDestDecrypt.Location = new System.Drawing.Point(1, 35);
            this.lblFileDestDecrypt.Name = "lblFileDestDecrypt";
            this.lblFileDestDecrypt.Size = new System.Drawing.Size(88, 16);
            this.lblFileDestDecrypt.TabIndex = 26;
            this.lblFileDestDecrypt.Text = "File destination:";
            this.lblFileDestDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileToDecrypt
            // 
            this.lblFileToDecrypt.Location = new System.Drawing.Point(7, 12);
            this.lblFileToDecrypt.Name = "lblFileToDecrypt";
            this.lblFileToDecrypt.Size = new System.Drawing.Size(80, 16);
            this.lblFileToDecrypt.TabIndex = 25;
            this.lblFileToDecrypt.Text = "File to decrypt:";
            this.lblFileToDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowseDecrypt
            // 
            this.btnBrowseDecrypt.Location = new System.Drawing.Point(303, 12);
            this.btnBrowseDecrypt.Name = "btnBrowseDecrypt";
            this.btnBrowseDecrypt.Size = new System.Drawing.Size(72, 21);
            this.btnBrowseDecrypt.TabIndex = 24;
            this.btnBrowseDecrypt.Text = "Browse";
            this.btnBrowseDecrypt.Click += new System.EventHandler(this.btnBrowseDecrypt_Click);
            // 
            // txtFileToDecrypt
            // 
            this.txtFileToDecrypt.Location = new System.Drawing.Point(113, 11);
            this.txtFileToDecrypt.Name = "txtFileToDecrypt";
            this.txtFileToDecrypt.ReadOnly = true;
            this.txtFileToDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtFileToDecrypt.TabIndex = 23;
            this.txtFileToDecrypt.Text = "Click Browse to load file.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(5, 185);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(396, 25);
            this.pbStatus.TabIndex = 2;
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Location = new System.Drawing.Point(349, 9);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(35, 13);
            this.aboutLinkLabel.TabIndex = 3;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "About";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.ForeColor = System.Drawing.Color.Red;
            this.lblRequired1.Location = new System.Drawing.Point(96, 76);
            this.lblRequired1.Name = "lblRequired1";
            this.lblRequired1.Size = new System.Drawing.Size(11, 13);
            this.lblRequired1.TabIndex = 23;
            this.lblRequired1.Text = "*";
            // 
            // lblRequired2
            // 
            this.lblRequired2.AutoSize = true;
            this.lblRequired2.ForeColor = System.Drawing.Color.Red;
            this.lblRequired2.Location = new System.Drawing.Point(96, 99);
            this.lblRequired2.Name = "lblRequired2";
            this.lblRequired2.Size = new System.Drawing.Size(11, 13);
            this.lblRequired2.TabIndex = 24;
            this.lblRequired2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(100, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "*";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 215);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.tabControlEncrptDecrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Locker";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.tabControlEncrptDecrypt.ResumeLayout(false);
            this.tabPageEncrypt.ResumeLayout(false);
            this.tabPageEncrypt.PerformLayout();
            this.tabPageDecrypt.ResumeLayout(false);
            this.tabPageDecrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEncrptDecrypt;
        private System.Windows.Forms.TabPage tabPageEncrypt;
        private System.Windows.Forms.TabPage tabPageDecrypt;
        internal System.Windows.Forms.Button btnEncrypt;
        internal System.Windows.Forms.TextBox txtConPassEncrypt;
        internal System.Windows.Forms.TextBox txtPassEncrypt;
        internal System.Windows.Forms.Label lblConPassEncrypt;
        internal System.Windows.Forms.Label lblPassEncrypt;
        internal System.Windows.Forms.Button btnChangeEncrypt;
        internal System.Windows.Forms.TextBox txtDestinationEncrypt;
        internal System.Windows.Forms.Label lblFileDestEncrypt;
        internal System.Windows.Forms.Label lblFileToEncrypt;
        internal System.Windows.Forms.Button btnBrowseEncrypt;
        internal System.Windows.Forms.TextBox txtFileToEncrypt;
        internal System.Windows.Forms.Button btnDecrypt;
        internal System.Windows.Forms.TextBox txtConPassDecrypt;
        internal System.Windows.Forms.TextBox txtPassDecrypt;
        internal System.Windows.Forms.Label lblConPassDecrypt;
        internal System.Windows.Forms.Label lblPassDecrypt;
        internal System.Windows.Forms.Button btnChangeDecrypt;
        internal System.Windows.Forms.TextBox txtDestinationDecrypt;
        internal System.Windows.Forms.Label lblFileDestDecrypt;
        internal System.Windows.Forms.Label lblFileToDecrypt;
        internal System.Windows.Forms.Button btnBrowseDecrypt;
        internal System.Windows.Forms.TextBox txtFileToDecrypt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        internal System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
        private System.Windows.Forms.Label lblRequired2;
        private System.Windows.Forms.Label lblRequired1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

