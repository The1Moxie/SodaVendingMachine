using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace VendingMachine_Library
{
    static internal class SQL
    {
        static string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "drinks.db");

        static internal void CreateDrinkTable()
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Drink>();
        }

        static internal List<Drink> GetDrinks()
        {
            var db = new SQLiteConnection(dbPath);
            List<Drink> drinks = new List<Drink>();

            var query = db.Table<Drink>();

            foreach (Drink drink in query)
            {
                drinks.Add(drink);
            }

            return drinks;
        }

        static internal void AddDrink(Drink drink)
        {
            var db = new SQLiteConnection(dbPath);
            _ = db.Insert(drink);
        }

        static internal void RemoveDrink(Drink drink)
        {
            var db = new SQLiteConnection(dbPath);
            _ = db.Delete(drink);
        }
    }

}
