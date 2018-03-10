using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotoraEventos
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetHealthyOption(healthyOption.Checked);
            dinnerParty.SetPartyOptions((int)numberOfPeople.Value, fancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void NumberOfPeople_ValueChanged(object sender, EventArgs e)
        {

            dinnerParty.SetPartyOptions((int)numberOfPeople.Value, fancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost() {

            decimal Cost = dinnerParty.CalculateCost(healthyOption.Checked);
            labelCost.Text = Cost.ToString("c");
        }

        private void fancyDecorations_CheckedChanged(object sender, EventArgs e)
        {

            dinnerParty.CalculateCostOfDecorations(fancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {

            dinnerParty.SetHealthyOption(healthyOption.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
