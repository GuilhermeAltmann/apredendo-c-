using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Um_dia_de_Corridas
{
    public class Guy
    {

        public string Name;
        public Bet Mybet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {

            MyLabel.Text = Name + " tem " + Cash + " reais";
        }

        public void ClearBeat()
        {

            Mybet.Amount = 0;
        }
    }
}
