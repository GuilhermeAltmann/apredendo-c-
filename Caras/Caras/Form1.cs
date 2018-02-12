using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caras
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            this.bob = new Guy() { cash = 100, name = "Bob" };


            this.joe = new Guy() { cash = 50, name = "Joe" };


            this.UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (bank >= 10)
            {

                bank -= joe.ReceiveCash(10);
                this.UpdateForm();
            }
            else {

                MessageBox.Show("The bank is out of money.");
            }
        }

        public void UpdateForm() {

            joesCashLabel.Text = joe.name + " has $" + joe.cash;
            bobsCashLabel.Text = bob.name + " has $" + bob.cash;
            banksCashLabel.Text = " The bank $" + bank;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int giveCash;

            if ((giveCash = this.bob.GiveCash(5)) != -1)
            {
                bank += giveCash;
                this.UpdateForm();
            }
            else
            {

                MessageBox.Show("Bob is poor.");
            }
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {

            int giveCash;
            if ((giveCash = this.joe.GiveCash(10)) != -1)
            {
                if (this.bob.ReceiveCash(giveCash) == -1) {

                    MessageBox.Show("Isn't an amount I'll take");
                }

                this.UpdateForm();
            }
            else {

                MessageBox.Show("I don't have enough cash to give you");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {

            int giveCash;
            if ((giveCash = this.bob.GiveCash(10)) != -1)
            {
                if (this.joe.ReceiveCash(giveCash) == -1)
                {

                    MessageBox.Show("Isn't an amount I'll take");
                }

                this.UpdateForm();
            }
            else
            {

                MessageBox.Show("I don't have enough cash to give you");
            }
        }
    }
}
