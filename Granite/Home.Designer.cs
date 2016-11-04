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
            this.MakeQ = new System.Windows.Forms.Button();
            this.Analytics = new System.Windows.Forms.Button();
            this.editUsr = new System.Windows.Forms.Button();
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
            // MakeQ
            // 
            this.MakeQ.Location = new System.Drawing.Point(345, 143);
            this.MakeQ.Name = "MakeQ";
            this.MakeQ.Size = new System.Drawing.Size(92, 23);
            this.MakeQ.TabIndex = 1;
            this.MakeQ.Text = "Make Questions";
            this.MakeQ.UseVisualStyleBackColor = true;
            this.MakeQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // Analytics
            // 
            this.Analytics.Location = new System.Drawing.Point(345, 172);
            this.Analytics.Name = "Analytics";
            this.Analytics.Size = new System.Drawing.Size(92, 23);
            this.Analytics.TabIndex = 2;
            this.Analytics.Text = "Analystics";
            this.Analytics.UseVisualStyleBackColor = true;
            this.Analytics.Click += new System.EventHandler(this.button2_Click);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(822, 357);
            this.Controls.Add(this.editUsr);
            this.Controls.Add(this.Analytics);
            this.Controls.Add(this.MakeQ);
            this.Controls.Add(this.giveTest);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giveTest;
        private System.Windows.Forms.Button MakeQ;
        private System.Windows.Forms.Button Analytics;
        private System.Windows.Forms.Button editUsr;
    }
}