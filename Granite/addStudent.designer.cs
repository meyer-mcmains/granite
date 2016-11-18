namespace Granite
{
    partial class addStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudent));
            this.submit = new System.Windows.Forms.Button();
            this.lastLbl = new System.Windows.Forms.Label();
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.firstLbl = new System.Windows.Forms.Label();
            this.eNumberTxt = new System.Windows.Forms.TextBox();
            this.eNumber = new System.Windows.Forms.Label();
            this.concentration = new System.Windows.Forms.Label();
            this.concentratoinCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Enabled = false;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(121, 160);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(136, 36);
            this.submit.TabIndex = 24;
            this.submit.Text = "Submit Changes";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // lastLbl
            // 
            this.lastLbl.AutoSize = true;
            this.lastLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLbl.Location = new System.Drawing.Point(10, 78);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(95, 20);
            this.lastLbl.TabIndex = 30;
            this.lastLbl.Text = "Last Name";
            // 
            // lastTxt
            // 
            this.lastTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastTxt.Location = new System.Drawing.Point(138, 75);
            this.lastTxt.MaxLength = 12;
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(220, 26);
            this.lastTxt.TabIndex = 21;
            this.lastTxt.TextChanged += new System.EventHandler(this.lastTxt_TextChanged);
            // 
            // firstTxt
            // 
            this.firstTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTxt.Location = new System.Drawing.Point(138, 44);
            this.firstTxt.MaxLength = 12;
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(220, 26);
            this.firstTxt.TabIndex = 20;
            this.firstTxt.TextChanged += new System.EventHandler(this.firstTxt_TextChanged);
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLbl.Location = new System.Drawing.Point(10, 47);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(96, 20);
            this.firstLbl.TabIndex = 29;
            this.firstLbl.Text = "First Name";
            // 
            // eNumberTxt
            // 
            this.eNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNumberTxt.Location = new System.Drawing.Point(138, 12);
            this.eNumberTxt.MaxLength = 8;
            this.eNumberTxt.Name = "eNumberTxt";
            this.eNumberTxt.Size = new System.Drawing.Size(220, 26);
            this.eNumberTxt.TabIndex = 19;
            this.eNumberTxt.TextChanged += new System.EventHandler(this.eNumberTxt_TextChanged);
            // 
            // eNumber
            // 
            this.eNumber.AutoSize = true;
            this.eNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNumber.Location = new System.Drawing.Point(10, 15);
            this.eNumber.Name = "eNumber";
            this.eNumber.Size = new System.Drawing.Size(83, 20);
            this.eNumber.TabIndex = 25;
            this.eNumber.Text = "ENumber";
            // 
            // concentration
            // 
            this.concentration.AutoSize = true;
            this.concentration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentration.Location = new System.Drawing.Point(10, 110);
            this.concentration.Name = "concentration";
            this.concentration.Size = new System.Drawing.Size(122, 20);
            this.concentration.TabIndex = 31;
            this.concentration.Text = "Concentration";
            // 
            // concentratoinCombo
            // 
            this.concentratoinCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.concentratoinCombo.FormattingEnabled = true;
            this.concentratoinCombo.Location = new System.Drawing.Point(138, 107);
            this.concentratoinCombo.Name = "concentratoinCombo";
            this.concentratoinCombo.Size = new System.Drawing.Size(220, 28);
            this.concentratoinCombo.TabIndex = 32;
            this.concentratoinCombo.TextChanged += new System.EventHandler(this.concentratoinCombo_TextChanged);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 208);
            this.Controls.Add(this.concentratoinCombo);
            this.Controls.Add(this.concentration);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.lastLbl);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.firstLbl);
            this.Controls.Add(this.eNumberTxt);
            this.Controls.Add(this.eNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addStudent";
            this.Text = "addStudent";
            this.Load += new System.EventHandler(this.addStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.TextBox lastTxt;
        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.Label firstLbl;
        private System.Windows.Forms.TextBox eNumberTxt;
        private System.Windows.Forms.Label eNumber;
        private System.Windows.Forms.Label concentration;
        private System.Windows.Forms.ComboBox concentratoinCombo;
    }
}