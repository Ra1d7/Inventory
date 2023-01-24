namespace Inventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.usernameLBL = new System.Windows.Forms.Label();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordcheckLBL = new System.Windows.Forms.Label();
            this.usernamecheckLBL = new System.Windows.Forms.Label();
            this.rememberCHKBOX = new System.Windows.Forms.CheckBox();
            this.exitBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTXT
            // 
            this.usernameTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTXT.Location = new System.Drawing.Point(47, 139);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(211, 23);
            this.usernameTXT.TabIndex = 0;
            // 
            // passwordTXT
            // 
            this.passwordTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTXT.Location = new System.Drawing.Point(47, 194);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.Size = new System.Drawing.Size(211, 23);
            this.passwordTXT.TabIndex = 1;
            this.passwordTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTXT_KeyPress);
            // 
            // usernameLBL
            // 
            this.usernameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.usernameLBL.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLBL.Location = new System.Drawing.Point(39, 115);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.usernameLBL.Size = new System.Drawing.Size(69, 21);
            this.usernameLBL.TabIndex = 1;
            this.usernameLBL.Text = "Username:";
            this.usernameLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLBL
            // 
            this.passwordLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.passwordLBL.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLBL.Location = new System.Drawing.Point(39, 172);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.passwordLBL.Size = new System.Drawing.Size(66, 21);
            this.passwordLBL.TabIndex = 1;
            this.passwordLBL.Text = "Password:";
            this.passwordLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(124)))), ((int)(((byte)(90)))));
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginBTN.Location = new System.Drawing.Point(65, 246);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(175, 45);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory.Properties.Resources.user_gc58f36953_640;
            this.pictureBox1.Location = new System.Drawing.Point(86, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // passwordcheckLBL
            // 
            this.passwordcheckLBL.AutoSize = true;
            this.passwordcheckLBL.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordcheckLBL.ForeColor = System.Drawing.Color.IndianRed;
            this.passwordcheckLBL.Location = new System.Drawing.Point(21, 310);
            this.passwordcheckLBL.Name = "passwordcheckLBL";
            this.passwordcheckLBL.Size = new System.Drawing.Size(269, 14);
            this.passwordcheckLBL.TabIndex = 4;
            this.passwordcheckLBL.Text = "Your password should be at least 6 characters long";
            this.passwordcheckLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.passwordcheckLBL.Visible = false;
            // 
            // usernamecheckLBL
            // 
            this.usernamecheckLBL.AutoSize = true;
            this.usernamecheckLBL.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamecheckLBL.ForeColor = System.Drawing.Color.IndianRed;
            this.usernamecheckLBL.Location = new System.Drawing.Point(21, 294);
            this.usernamecheckLBL.Name = "usernamecheckLBL";
            this.usernamecheckLBL.Size = new System.Drawing.Size(269, 14);
            this.usernamecheckLBL.TabIndex = 4;
            this.usernamecheckLBL.Text = "Your password should be at least 6 characters long";
            this.usernamecheckLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.usernamecheckLBL.Visible = false;
            // 
            // rememberCHKBOX
            // 
            this.rememberCHKBOX.AutoSize = true;
            this.rememberCHKBOX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rememberCHKBOX.Location = new System.Drawing.Point(86, 223);
            this.rememberCHKBOX.Name = "rememberCHKBOX";
            this.rememberCHKBOX.Size = new System.Drawing.Size(133, 17);
            this.rememberCHKBOX.TabIndex = 5;
            this.rememberCHKBOX.Text = "Remember username";
            this.rememberCHKBOX.UseVisualStyleBackColor = true;
            this.rememberCHKBOX.Visible = false;
            this.rememberCHKBOX.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(124)))), ((int)(((byte)(90)))));
            this.exitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(124)))), ((int)(((byte)(90)))));
            this.exitBTN.Location = new System.Drawing.Point(282, 6);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(0);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(23, 23);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(311, 330);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.rememberCHKBOX);
            this.Controls.Add(this.usernamecheckLBL);
            this.Controls.Add(this.passwordcheckLBL);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordLBL);
            this.Controls.Add(this.usernameLBL);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(327, 350);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "User Authentication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameTXT;
        private TextBox passwordTXT;
        private Label usernameLBL;
        private Label passwordLBL;
        private Button loginBTN;
        private PictureBox pictureBox1;
        private Label passwordcheckLBL;
        private Label usernamecheckLBL;
        private CheckBox rememberCHKBOX;
        private Button exitBTN;
    }
}