using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_BMI_Calculator
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void Btn_BMI(object sender, EventArgs e)
        {
			int Weight;
			int Height;
			int BMI=0;

			Weight = int.Parse(WeightBox1.Text);
			Height = int.Parse(HeightBox1.Text);

			if (MetricsConversionButton.Checked == true)
			{
				BMI = Weight / (Height * Height);
			}
			else if (ImperialConversionButton.Checked == true)
			{
				BMI = (Weight * 703) / (Height * Height);

			}

			if (BMI < 18.5)
			{
				ResultLabelBox.Text = BMI + "\n You are underWeight";
			}
			else if (BMI > 18.5 && BMI < 24.9)
			{
				ResultLabelBox.Text = BMI + "\n You are at Normal Weight";
			}
			else if (BMI > 25 && BMI < 29.9)
			{
				ResultLabelBox.Text = BMI + "You are Overweight,";
			}
			else if (BMI > 30 || BMI < 800)
			{
				ResultLabelBox.Text = BMI + "\n You are Obesed";
			}
        }

		private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
