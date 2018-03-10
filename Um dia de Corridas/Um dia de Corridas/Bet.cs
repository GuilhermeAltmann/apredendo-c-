using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Um_dia_de_Corridas
{
    public class Bet
    {

        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount <= 0) {
                return Bettor.Name + "não apostou";
            }
            return Bettor.Name + " apostou " + Amount + " no cão #" + Dog;
        }
    }
}
