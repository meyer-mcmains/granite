namespace Granite
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username = new System.Windows.Forms.TextBox();
            this.pswd = new System.Windows.Forms.TextBox();
            this.usrlabel = new System.Windows.Forms.Label();
            this.pswdLabel = new System.Windows.Forms.Label();
            this.indicator = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Window;
            this.username.Location = new System.Drawing.Point(244, 213);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(120, 20);
            this.username.TabIndex = 1;
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(244, 259);
            this.pswd.Name = "pswd";
            this.pswd.PasswordChar = '*';
            this.pswd.Size = new System.Drawing.Size(120, 20);
            this.pswd.TabIndex = 2;
            // 
            // usrlabel
            // 
            this.usrlabel.AutoSize = true;
            this.usrlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlabel.Location = new System.Drawing.Point(264, 190);
            this.usrlabel.Name = "usrlabel";
            this.usrlabel.Size = new System.Drawing.Size(83, 20);
            this.usrlabel.TabIndex = 3;
            this.usrlabel.Text = "Username";
            // 
            // pswdLabel
            // 
            this.pswdLabel.AutoSize = true;
            this.pswdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdLabel.Location = new System.Drawing.Point(264, 236);
            this.pswdLabel.Name = "pswdLabel";
            this.pswdLabel.Size = new System.Drawing.Size(78, 20);
            this.pswdLabel.TabIndex = 4;
            this.pswdLabel.Text = "Password";
            // 
            // indicator
            // 
            this.indicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.indicator.AutoSize = true;
            this.indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator.Location = new System.Drawing.Point(-10, 384);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(42, 55);
            this.indicator.TabIndex = 5;
            this.indicator.Text = "•";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(244, 285);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(536, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(582, 418);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.pswdLabel);
            this.Controls.Add(this.usrlabel);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.Label usrlabel;
        private System.Windows.Forms.Label pswdLabel;
        private System.Windows.Forms.Label indicator;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exit;
    }
}

