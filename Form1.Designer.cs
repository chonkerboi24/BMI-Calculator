namespace BMI_Calculator
{
    partial class bmiCalculator
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
            this.labelHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(13, 13);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 13);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "Height (cm)";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(16, 30);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 1;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(13, 67);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(62, 13);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight (kg)";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(16, 83);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 3;
            // 
            // bmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.labelHeight);
            this.Name = "bmiCalculator";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox tbWeight;
    }
}

