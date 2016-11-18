namespace Granite
{
    partial class ChooseStudent
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
            this.StudentLabel = new System.Windows.Forms.Label();
            this.StudentBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CourseBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.StudentLabel.Location = new System.Drawing.Point(14, 9);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(100, 25);
            this.StudentLabel.TabIndex = 0;
            this.StudentLabel.Text = "Student:";
            // 
            // StudentBox
            // 
            this.StudentBox.FormattingEnabled = true;
            this.StudentBox.Location = new System.Drawing.Point(19, 37);
            this.StudentBox.Name = "StudentBox";
            this.StudentBox.Size = new System.Drawing.Size(183, 21);
            this.StudentBox.TabIndex = 7;
            this.StudentBox.Text = "Choose a Student";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(213, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Student";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Location = new System.Drawing.Point(19, 114);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(269, 21);
            this.CourseBox.TabIndex = 9;
            this.CourseBox.Text = "Choose a Class";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.ClassLabel.Location = new System.Drawing.Point(14, 86);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(94, 25);
            this.ClassLabel.TabIndex = 10;
            this.ClassLabel.Text = "Course:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(147, 146);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start Test";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(66, 146);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ChooseStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(300, 181);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StudentBox);
            this.Controls.Add(this.StudentLabel);
            this.Name = "ChooseStudent";
            this.Text = "ChooseStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.ComboBox StudentBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BackButton;
    }
}