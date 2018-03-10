using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Status
    {

        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey) {

            this.Total++;

            if (!correctKey)
            {

                this.Missed++;
            }
            else
            {

                this.Correct++;
            }

            this.Accuracy = 100 * this.Correct / (this.Missed + this.Correct);
        }
    }
}
