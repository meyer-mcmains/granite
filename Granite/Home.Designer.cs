namespace Granite
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.giveTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.editUsr = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.editAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giveTest
            // 
            this.giveTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giveTest.BackgroundImage")));
            this.giveTest.Location = new System.Drawing.Point(12, 64);
            this.giveTest.Name = "giveTest";
            this.giveTest.Size = new System.Drawing.Size(160, 250);
            this.giveTest.TabIndex = 0;
            this.giveTest.UseVisualStyleBackColor = true;
            this.giveTest.Click += new System.EventHandler(this.giveTest_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(178, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 250);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(344, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 250);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editUsr
            // 
            this.editUsr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editUsr.BackgroundImage")));
            this.editUsr.Location = new System.Drawing.Point(510, 64);
            this.editUsr.Name = "editUsr";
            this.editUsr.Size = new System.Drawing.Size(160, 250);
            this.editUsr.TabIndex = 3;
            this.editUsr.UseVisualStyleBackColor = true;
            this.editUsr.Click += new System.EventHandler(this.editUsr_Click);
            // 
            // addStudent
            // 
            this.addStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addStudent.BackgroundImage")));
            this.addStudent.Location = new System.Drawing.Point(676, 64);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(160, 250);
            this.addStudent.TabIndex = 4;
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // editAccount
            // 
            this.editAccount.Location = new System.Drawing.Point(12, 12);
            this.editAccount.Name = "editAccount";
            this.editAccount.Size = new System.Drawing.Size(86, 23);
            this.editAccount.TabIndex = 5;
            this.editAccount.Text = "Edit Account";
            this.editAccount.UseVisualStyleBackColor = true;
            this.editAccount.Click += new System.EventHandler(this.editAccount_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(849, 357);
            this.Controls.Add(this.editAccount);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.editUsr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.giveTest);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giveTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button editUsr;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button editAccount;
    }
}