using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caras
{
    class Guy
    {

        public string name;
        public int cash;

        public int GiveCash(int amount) {

            if (amount <= this.cash && amount > 0)
            {

                this.cash -= amount;
                return amount;
            }
            else {

                return -1;
            }
        }

        public int ReceiveCash(int amount) {

            if (amount > 0)
            {

                this.cash += amount;
                return amount;
            }
            else {

                return -1;
            }
        }
    }
}
