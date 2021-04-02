using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Library
{
    class Machine : IMachine
    {
        private List<Drink> _drinks = new List<Drink>();

        public Machine()
        {
            LoadDrinks(ref _drinks);
        }

        private void LoadDrinks(ref List<Drink> drinks)
        {
            SQL.CreateDrinkTable();
            _drinks.AddRange(SQL.GetDrinks());
        }

        public void buyDrink(int drink_id)
        {
            throw new NotImplementedException();
        }

        public void CreateDrink(string Name, double Price)
        {
            SQL.AddDrink(new Drink(Name, Price));
        }

        public void DeleteDrink(int drink_id)
        {
            throw new NotImplementedException();
        }

        public Drink GetDrinkByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Drink> GetDrinks()
        {
            return _drinks;
        }

        
        
    }
}
