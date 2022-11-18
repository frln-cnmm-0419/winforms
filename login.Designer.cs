
namespace winforms
{
    partial class login
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usrnmLbl = new System.Windows.Forms.Label();
            this.pssrdLbl = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(61, 111);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(329, 20);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(61, 262);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(329, 20);
            this.password.TabIndex = 1;
            // 
            // usrnmLbl
            // 
            this.usrnmLbl.AutoSize = true;
            this.usrnmLbl.Location = new System.Drawing.Point(58, 84);
            this.usrnmLbl.Name = "usrnmLbl";
            this.usrnmLbl.Size = new System.Drawing.Size(74, 13);
            this.usrnmLbl.TabIndex = 2;
            this.usrnmLbl.Text = "USERNAME: ";
            // 
            // pssrdLbl
            // 
            this.pssrdLbl.AutoSize = true;
            this.pssrdLbl.Location = new System.Drawing.Point(58, 236);
            this.pssrdLbl.Name = "pssrdLbl";
            this.pssrdLbl.Size = new System.Drawing.Size(76, 13);
            this.pssrdLbl.TabIndex = 3;
            this.pssrdLbl.Text = "PASSWORD: ";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Location = new System.Drawing.Point(487, 138);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(245, 73);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "LOG IN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.pssrdLbl);
            this.Controls.Add(this.usrnmLbl);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "login";
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label usrnmLbl;
        private System.Windows.Forms.Label pssrdLbl;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label3;
    }
}

