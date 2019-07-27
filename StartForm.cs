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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

		private void StartForm_Load(object sender, EventArgs e)
		{
			BMI_Timmer.Enabled = true;
		}

		private void BMI_Timmer_Tick(object sender, EventArgs e)
		{
			BMI_Timmer.Enabled = false;

			Program.bMI.Show();
			this.Hide()
				
				;
		}
	}
}
