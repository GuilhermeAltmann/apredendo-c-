using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Calculator
{
    public partial class Form1 : Form
    {

        int startingMileage;
        int endingMileage;
        double milesTraveled, reimburseRate = .39, amountOwed;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.milesTraveled + " miles", "Miles Traveled");
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.startingMileage = (int) numericUpDown1.Value;
            this.endingMileage = (int) numericUpDown2.Value;
            if (this.startingMileage <= this.endingMileage)
            {

                this.milesTraveled = this.endingMileage - this.startingMileage;
                this.amountOwed = this.milesTraveled * this.reimburseRate;
                label4.Text = "$" + this.amountOwed;
            }
            else {

                MessageBox.Show("Starting mileage must be less than or equal to ending mileage", "Cannot calculate Mileage");
            }
        }
    }
}
