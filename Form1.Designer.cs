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
            this.components = new System.ComponentModel.Container();
            this.labelHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.totalBMI = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.classType = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(14, 9);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(146, 66);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total BMI:";
            // 
            // totalBMI
            // 
            this.totalBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalBMI.Location = new System.Drawing.Point(208, 65);
            this.totalBMI.Name = "totalBMI";
            this.totalBMI.Size = new System.Drawing.Size(64, 23);
            this.totalBMI.TabIndex = 0;
            this.totalBMI.Text = "N/A";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(167, 90);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(35, 13);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "Class:";
            // 
            // classType
            // 
            this.classType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classType.Location = new System.Drawing.Point(208, 90);
            this.classType.Name = "classType";
            this.classType.Size = new System.Drawing.Size(64, 23);
            this.classType.TabIndex = 7;
            this.classType.Text = "N/A";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.classType);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.totalBMI);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.labelHeight);
            this.Name = "bmiCalculator";
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label totalBMI;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label classType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

