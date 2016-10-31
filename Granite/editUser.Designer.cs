namespace Granite
{
    partial class EditUser
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
            this.usrName = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.firstLbl = new System.Windows.Forms.Label();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.lastLbl = new System.Windows.Forms.Label();
            this.lvlLbl = new System.Windows.Forms.Label();
            this.lvlTxt = new System.Windows.Forms.TextBox();
            this.chngPswd = new System.Windows.Forms.Button();
            this.changePswdTxt = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.enterPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usrName
            // 
            this.usrName.AutoSize = true;
            this.usrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrName.Location = new System.Drawing.Point(12, 9);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(91, 20);
            this.usrName.TabIndex = 9;
            this.usrName.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(133, 6);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.ReadOnly = true;
            this.usernameTxt.Size = new System.Drawing.Size(220, 26);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(12, 41);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(86, 20);
            this.passwordLbl.TabIndex = 10;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(133, 38);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.ReadOnly = true;
            this.passwordTxt.Size = new System.Drawing.Size(220, 26);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.TabStop = false;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(12, 105);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(53, 20);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(133, 102);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(220, 26);
            this.emailTxt.TabIndex = 3;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLbl.Location = new System.Drawing.Point(12, 137);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(96, 20);
            this.firstLbl.TabIndex = 13;
            this.firstLbl.Text = "First Name";
            // 
            // firstTxt
            // 
            this.firstTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTxt.Location = new System.Drawing.Point(133, 134);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(220, 26);
            this.firstTxt.TabIndex = 4;
            this.firstTxt.TextChanged += new System.EventHandler(this.firstTxt_TextChanged);
            // 
            // lastTxt
            // 
            this.lastTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastTxt.Location = new System.Drawing.Point(133, 165);
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(220, 26);
            this.lastTxt.TabIndex = 5;
            this.lastTxt.TextChanged += new System.EventHandler(this.lastTxt_TextChanged);
            // 
            // lastLbl
            // 
            this.lastLbl.AutoSize = true;
            this.lastLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLbl.Location = new System.Drawing.Point(13, 168);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(95, 20);
            this.lastLbl.TabIndex = 14;
            this.lastLbl.Text = "Last Name";
            // 
            // lvlLbl
            // 
            this.lvlLbl.AutoSize = true;
            this.lvlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLbl.Location = new System.Drawing.Point(14, 200);
            this.lvlLbl.Name = "lvlLbl";
            this.lvlLbl.Size = new System.Drawing.Size(51, 20);
            this.lvlLbl.TabIndex = 15;
            this.lvlLbl.Text = "Level";
            // 
            // lvlTxt
            // 
            this.lvlTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlTxt.Location = new System.Drawing.Point(133, 197);
            this.lvlTxt.Name = "lvlTxt";
            this.lvlTxt.ReadOnly = true;
            this.lvlTxt.Size = new System.Drawing.Size(220, 26);
            this.lvlTxt.TabIndex = 6;
            // 
            // chngPswd
            // 
            this.chngPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chngPswd.Location = new System.Drawing.Point(12, 70);
            this.chngPswd.Name = "chngPswd";
            this.chngPswd.Size = new System.Drawing.Size(109, 26);
            this.chngPswd.TabIndex = 11;
            this.chngPswd.Text = "Change Password";
            this.chngPswd.UseVisualStyleBackColor = true;
            this.chngPswd.Click += new System.EventHandler(this.chngPswd_Click);
            // 
            // changePswdTxt
            // 
            this.changePswdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePswdTxt.Location = new System.Drawing.Point(133, 70);
            this.changePswdTxt.Name = "changePswdTxt";
            this.changePswdTxt.ReadOnly = true;
            this.changePswdTxt.Size = new System.Drawing.Size(220, 26);
            this.changePswdTxt.TabIndex = 2;
            this.changePswdTxt.TabStop = false;
            this.changePswdTxt.Enter += new System.EventHandler(this.changePswdTxt_Enter);
            this.changePswdTxt.Leave += new System.EventHandler(this.changePswdTxt_Leave);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Enabled = false;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(104, 289);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(150, 36);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit Changes";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // enterPassword
            // 
            this.enterPassword.Location = new System.Drawing.Point(104, 263);
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.Size = new System.Drawing.Size(150, 20);
            this.enterPassword.TabIndex = 7;
            this.enterPassword.Text = "Enter Password to Submit";
            this.enterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterPassword.Visible = false;
            this.enterPassword.TextChanged += new System.EventHandler(this.enterPassword_TextChanged);
            this.enterPassword.Enter += new System.EventHandler(this.enterPassword_Enter);
            // 
            // EditUser
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 337);
            this.Controls.Add(this.enterPassword);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.changePswdTxt);
            this.Controls.Add(this.chngPswd);
            this.Controls.Add(this.lvlTxt);
            this.Controls.Add(this.lvlLbl);
            this.Controls.Add(this.lastLbl);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usrName);
            this.Name = "EditUser";
            this.Text = "editUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrName;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label firstLbl;
        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.TextBox lastTxt;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.Label lvlLbl;
        private System.Windows.Forms.TextBox lvlTxt;
        private System.Windows.Forms.Button chngPswd;
        private System.Windows.Forms.TextBox changePswdTxt;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox enterPassword;
    }
}