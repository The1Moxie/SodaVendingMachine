using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Library
{
    interface IMachine
    {
        void buyDrink(int drink_id);
        Drink GetDrinkByID(int id);
        List<Drink> GetDrinks();
        void CreateDrink(string Name, double Price);
        void DeleteDrink(int drink_id);
    }
}
