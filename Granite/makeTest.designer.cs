namespace Granite
{
    partial class makeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(makeTest));
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveQuestion = new System.Windows.Forms.Button();
            this.finishCreating = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 123);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // saveQuestion
            // 
            this.saveQuestion.Location = new System.Drawing.Point(303, 300);
            this.saveQuestion.Name = "saveQuestion";
            this.saveQuestion.Size = new System.Drawing.Size(75, 23);
            this.saveQuestion.TabIndex = 4;
            this.saveQuestion.Text = "Save";
            this.saveQuestion.UseVisualStyleBackColor = true;
            this.saveQuestion.Click += new System.EventHandler(this.saveQuestion_Click);
            // 
            // finishCreating
            // 
            this.finishCreating.Location = new System.Drawing.Point(400, 300);
            this.finishCreating.Name = "finishCreating";
            this.finishCreating.Size = new System.Drawing.Size(75, 23);
            this.finishCreating.TabIndex = 5;
            this.finishCreating.Text = "Finish";
            this.finishCreating.UseVisualStyleBackColor = true;
            this.finishCreating.Click += new System.EventHandler(this.finishCreating_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(36, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Answer";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(400, 122);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(385, 123);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // makeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(822, 357);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.finishCreating);
            this.Controls.Add(this.saveQuestion);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "makeTest";
            this.Text = "Create Questions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.makeTest_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.makeTest_FormClosed);
            this.Load += new System.EventHandler(this.makeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveQuestion;
        private System.Windows.Forms.Button finishCreating;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}