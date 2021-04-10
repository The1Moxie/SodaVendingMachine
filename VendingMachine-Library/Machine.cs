using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Library
{
    public class Machine : IMachine
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
            Drink tempDrink = GetDrinkByID(drink_id);
            try
            {
                if (tempDrink.Quantity < 1)
                {
                    throw new OutOfStockException("The Drink is out of Stock", drink_id);
                }
                else
                {
                    tempDrink.Quantity--;
                    SQL.updateDrink(tempDrink);
                }
            }
            catch (OutOfStockException oex)
            {
                Console.WriteLine(oex.Message.ToString());
            }
            
        }


        public void CreateDrink(string Name, double Price, int Quantity)
        {
            SQL.AddDrink(new Drink(Name, Price, Quantity));
        }

        public void DeleteDrink(int drink_id)
        {
            Drink tempDrink = GetDrinkByID(drink_id);
            SQL.RemoveDrink(tempDrink);
            _drinks.Remove(tempDrink);

        }

        public Drink GetDrinkByID(int drink_id)
        {
            Drink tempDrink = _drinks.Find(drink => drink.DrinkID == drink_id);
            if (tempDrink !=null)
            {
                return tempDrink;
            }
            else
            {
                throw new DrinkNotFoundException("The Drink was not found", drink_id);
            }
        }

        public List<Drink> GetDrinks()
        {
            return _drinks;
        }      
    }
}
