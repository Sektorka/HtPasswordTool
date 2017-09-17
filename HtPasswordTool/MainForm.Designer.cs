namespace HtPasswordTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbHtpasswd = new System.Windows.Forms.TextBox();
            this.lblHtpasswd = new System.Windows.Forms.Label();
            this.lblHtaccess = new System.Windows.Forms.Label();
            this.tbHtaccess = new System.Windows.Forms.TextBox();
            this.tbHtpassPath = new System.Windows.Forms.TextBox();
            this.lblHtpassPath = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(97, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(380, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(97, 38);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(380, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(15, 116);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(462, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbHtpasswd
            // 
            this.tbHtpasswd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHtpasswd.Location = new System.Drawing.Point(15, 170);
            this.tbHtpasswd.Name = "tbHtpasswd";
            this.tbHtpasswd.ReadOnly = true;
            this.tbHtpasswd.Size = new System.Drawing.Size(462, 20);
            this.tbHtpasswd.TabIndex = 6;
            // 
            // lblHtpasswd
            // 
            this.lblHtpasswd.AutoSize = true;
            this.lblHtpasswd.Location = new System.Drawing.Point(13, 154);
            this.lblHtpasswd.Name = "lblHtpasswd";
            this.lblHtpasswd.Size = new System.Drawing.Size(55, 13);
            this.lblHtpasswd.TabIndex = 6;
            this.lblHtpasswd.Text = "htpasswd:";
            // 
            // lblHtaccess
            // 
            this.lblHtaccess.AutoSize = true;
            this.lblHtaccess.Location = new System.Drawing.Point(13, 203);
            this.lblHtaccess.Name = "lblHtaccess";
            this.lblHtaccess.Size = new System.Drawing.Size(53, 13);
            this.lblHtaccess.TabIndex = 7;
            this.lblHtaccess.Text = "htaccess:";
            // 
            // tbHtaccess
            // 
            this.tbHtaccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHtaccess.Location = new System.Drawing.Point(15, 219);
            this.tbHtaccess.Multiline = true;
            this.tbHtaccess.Name = "tbHtaccess";
            this.tbHtaccess.ReadOnly = true;
            this.tbHtaccess.Size = new System.Drawing.Size(462, 65);
            this.tbHtaccess.TabIndex = 7;
            // 
            // tbHtpassPath
            // 
            this.tbHtpassPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHtpassPath.Location = new System.Drawing.Point(97, 64);
            this.tbHtpassPath.Name = "tbHtpassPath";
            this.tbHtpassPath.Size = new System.Drawing.Size(380, 20);
            this.tbHtpassPath.TabIndex = 3;
            this.tbHtpassPath.Text = "/.htpasswd";
            // 
            // lblHtpassPath
            // 
            this.lblHtpassPath.AutoSize = true;
            this.lblHtpassPath.Location = new System.Drawing.Point(12, 67);
            this.lblHtpassPath.Name = "lblHtpassPath";
            this.lblHtpassPath.Size = new System.Drawing.Size(79, 13);
            this.lblHtpassPath.TabIndex = 9;
            this.lblHtpassPath.Text = "htpasswd path:";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(97, 90);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(380, 20);
            this.tbMessage.TabIndex = 4;
            this.tbMessage.Text = "Authorized users only!";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 93);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "Message:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 296);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbHtpassPath);
            this.Controls.Add(this.lblHtpassPath);
            this.Controls.Add(this.tbHtaccess);
            this.Controls.Add(this.lblHtaccess);
            this.Controls.Add(this.lblHtpasswd);
            this.Controls.Add(this.tbHtpasswd);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(454, 319);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HtPasswd tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbHtpasswd;
        private System.Windows.Forms.Label lblHtpasswd;
        private System.Windows.Forms.Label lblHtaccess;
        private System.Windows.Forms.TextBox tbHtaccess;
        private System.Windows.Forms.TextBox tbHtpassPath;
        private System.Windows.Forms.Label lblHtpassPath;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lblMessage;
    }
}

