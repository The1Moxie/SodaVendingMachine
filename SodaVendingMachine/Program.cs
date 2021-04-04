using System;
using System.Collections.Generic;
using VendingMachine_Library;

namespace SodaVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            IMachine vm = new Machine();

            vm.CreateDrink("Coke", 1.99);
            vm.CreateDrink("Pepsi", 1.19);

            bool exit = false;
            while (!exit)

            {
                int i = 1;
                List<Drink> drinks = vm.GetDrinks();
                foreach ( Drink drink in drinks)
                {
                    Console.WriteLine($"{i}: {drink.Name} - {drink.Price} t-{drink.DrinkID}");
                    i++;
                }
                Console.WriteLine("Select your Drink by Number:");
                string choice = Console.ReadLine();
                Drink pickedDrink = drinks.ToArray()[int.Parse(choice)-1];
                Console.WriteLine($"You bouts a {pickedDrink.Name} for ${pickedDrink.Price} t-{pickedDrink.DrinkID}");
                vm.DeleteDrink(pickedDrink.DrinkID);
            }
        }
    }
}
