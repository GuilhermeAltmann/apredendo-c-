using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotoraEventos
{
    class DinnerParty
    {

        public const int CostFoodPerPerson = 25;
        private int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;

        public void SetHealthyOption(bool healthOption)
        {
            if (healthOption)
            {

                CostOfBeveragesPerPerson = 5.00M;
            }
            else {

                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void SetPartyOptions(int people, bool fancy) {

            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public void CalculateCostOfDecorations(bool fancy)
        {

            if (fancy)
            {

                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else {

                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOptions)
        {

            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostFoodPerPerson) * NumberOfPeople);

            if (healthyOptions)
            {

                return totalCost * .95M;
            }
            else {

                return totalCost;
            }
        }
    }
}
