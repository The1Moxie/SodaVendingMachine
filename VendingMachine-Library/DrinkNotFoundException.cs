using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Library
{
    class DrinkNotFoundException: Exception
    {
        public int DrinkID;
        public DrinkNotFoundException(string message, int drinkId): base(message)
        {
            DrinkID = drinkId;
        }
    }
}
