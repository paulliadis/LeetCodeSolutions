namespace AdventOfCode2020
{
    partial class IntToEnglish
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblIntToConvert = new System.Windows.Forms.Label();
            this.txtIntToConvert = new System.Windows.Forms.TextBox();
            this.txtReturnedRoman = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Answer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIntToConvert
            // 
            this.lblIntToConvert.AutoSize = true;
            this.lblIntToConvert.Location = new System.Drawing.Point(277, 182);
            this.lblIntToConvert.Name = "lblIntToConvert";
            this.lblIntToConvert.Size = new System.Drawing.Size(140, 13);
            this.lblIntToConvert.TabIndex = 8;
            this.lblIntToConvert.Text = "Integer you want to convert:";
            this.lblIntToConvert.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIntToConvert
            // 
            this.txtIntToConvert.Location = new System.Drawing.Point(423, 182);
            this.txtIntToConvert.Name = "txtIntToConvert";
            this.txtIntToConvert.Size = new System.Drawing.Size(100, 20);
            this.txtIntToConvert.TabIndex = 7;
            // 
            // txtReturnedRoman
            // 
            this.txtReturnedRoman.Location = new System.Drawing.Point(423, 207);
            this.txtReturnedRoman.Name = "txtReturnedRoman";
            this.txtReturnedRoman.Size = new System.Drawing.Size(334, 20);
            this.txtReturnedRoman.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntToEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIntToConvert);
            this.Controls.Add(this.txtIntToConvert);
            this.Controls.Add(this.txtReturnedRoman);
            this.Controls.Add(this.button1);
            this.Name = "IntToEnglish";
            this.Text = "IntToEnglish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIntToConvert;
        private System.Windows.Forms.TextBox txtIntToConvert;
        private System.Windows.Forms.TextBox txtReturnedRoman;
        private System.Windows.Forms.Button button1;
    }
}