namespace AdventOfCode2020
{
    partial class IntToRoman
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtReturnedRoman = new System.Windows.Forms.TextBox();
            this.txtIntToConvert = new System.Windows.Forms.TextBox();
            this.lblIntToConvert = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReturnedRoman
            // 
            this.txtReturnedRoman.Location = new System.Drawing.Point(428, 170);
            this.txtReturnedRoman.Name = "txtReturnedRoman";
            this.txtReturnedRoman.Size = new System.Drawing.Size(100, 20);
            this.txtReturnedRoman.TabIndex = 1;
            // 
            // txtIntToConvert
            // 
            this.txtIntToConvert.Location = new System.Drawing.Point(428, 145);
            this.txtIntToConvert.Name = "txtIntToConvert";
            this.txtIntToConvert.Size = new System.Drawing.Size(100, 20);
            this.txtIntToConvert.TabIndex = 2;
            // 
            // lblIntToConvert
            // 
            this.lblIntToConvert.AutoSize = true;
            this.lblIntToConvert.Location = new System.Drawing.Point(282, 145);
            this.lblIntToConvert.Name = "lblIntToConvert";
            this.lblIntToConvert.Size = new System.Drawing.Size(140, 13);
            this.lblIntToConvert.TabIndex = 3;
            this.lblIntToConvert.Text = "Integer you want to convert:";
            this.lblIntToConvert.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // IntToRoman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIntToConvert);
            this.Controls.Add(this.txtIntToConvert);
            this.Controls.Add(this.txtReturnedRoman);
            this.Controls.Add(this.button1);
            this.Name = "IntToRoman";
            this.Text = "IntToRoman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReturnedRoman;
        private System.Windows.Forms.TextBox txtIntToConvert;
        private System.Windows.Forms.Label lblIntToConvert;
        private System.Windows.Forms.Label label2;
    }
}