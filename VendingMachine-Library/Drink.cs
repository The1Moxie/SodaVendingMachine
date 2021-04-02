using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace VendingMachine_Library
{
    public class Drink
    {
        [PrimaryKey, AutoIncrement]
        public int DrinkID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Drink()
        { 

        }

        public Drink(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
