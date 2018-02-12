using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {

        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();

            this.lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            this.lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(this.lloyd.WhoAmI());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(this.lucinda.WhoAmI());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Elephant holder;
            holder = this.lloyd;
            this.lloyd = this.lucinda;
            this.lucinda = holder;

            MessageBox.Show("Objects swapped");
        }
    }
}
