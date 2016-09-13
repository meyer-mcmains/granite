namespace Granite
{
    partial class Granite
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
            this.pswd = new System.Windows.Forms.TextBox();
            this.usrlabel = new System.Windows.Forms.Label();
            this.pswdLabel = new System.Windows.Forms.Label();
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
            this.pswd.TextChanged += new System.EventHandler(this.pswd_TextChanged);
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
            // Granite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 418);
            this.Controls.Add(this.pswdLabel);
            this.Controls.Add(this.usrlabel);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.username);
            this.Name = "Granite";
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
    }
}

