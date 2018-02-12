using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephant
{
    class Elephant
    {

        public string Name;
        public int EarSize;

        public string WhoAmI() {

            return "My ears are " + this.EarSize + " inches tall.";
        }
    }
}
