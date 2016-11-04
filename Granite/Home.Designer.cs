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
            this.giveTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.editUsr = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giveTest
            // 
            this.giveTest.Location = new System.Drawing.Point(345, 114);
            this.giveTest.Name = "giveTest";
            this.giveTest.Size = new System.Drawing.Size(92, 23);
            this.giveTest.TabIndex = 0;
            this.giveTest.Text = "Give Test";
            this.giveTest.UseVisualStyleBackColor = true;
            this.giveTest.Click += new System.EventHandler(this.giveTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Make Questions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Analystics";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editUsr
            // 
            this.editUsr.Location = new System.Drawing.Point(345, 201);
            this.editUsr.Name = "editUsr";
            this.editUsr.Size = new System.Drawing.Size(92, 23);
            this.editUsr.TabIndex = 3;
            this.editUsr.Text = "Edit User";
            this.editUsr.UseVisualStyleBackColor = true;
            this.editUsr.Click += new System.EventHandler(this.editUsr_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(345, 230);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(92, 23);
            this.addStudent.TabIndex = 4;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(822, 357);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.editUsr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.giveTest);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giveTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button editUsr;
        private System.Windows.Forms.Button addStudent;
    }
}