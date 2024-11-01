using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMI_Calculator
{
    public partial class bmiCalculator : Form
    {
        public bmiCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double heightM = 0;
            double weightKg = 0;

            try
            {
                heightM = Convert.ToDouble(tbHeight.Text);
                weightKg = Convert.ToDouble(tbWeight.Text);
            }
            catch (Exception error)
            {
                tbHeight.Clear();
                tbWeight.Clear();
                MessageBox.Show("Input is not a valid number...");
                
            }
            
                // Convert height to meters as a double to avoid integer division issues
                heightM = heightM / 100;
                double bmi = weightKg / (heightM * heightM);

                // Display the BMI result
                totalBMI.Text = bmi.ToString("F2"); // Format to 2 decimal places

                // Determine BMI category
                if (bmi <= 18.5)
                {
                    classType.Text = "Thin";
                }
                else if (bmi <= 24.9)
                {
                    classType.Text = "Normal";
                }
                else if (bmi <= 29.9)
                {
                    classType.Text = "Overweight";
                }
                else if (bmi <= 34.9)
                {
                    classType.Text = "Obese";
                }
                else if (bmi >= 35)
                {
                    classType.Text = "Extremely Obese";
                }
        }
    }
}


