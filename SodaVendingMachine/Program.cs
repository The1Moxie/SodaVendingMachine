using System;
using System.Collections.Generic;
using VendingMachine_Library;

namespace SodaVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

            bool exit = false;
            while (!exit)

            {
                IMachine vm = new Machine();
                int i = 1;
                List<Drink> drinks = vm.GetDrinks();
                foreach ( Drink drink in drinks)
                {
                    Console.WriteLine($"{i}: {drink.Name} - ${drink.Price} Quantity: {drink.Quantity}");
                    i++;
                }
                Console.WriteLine("Select your Drink by Number:");
                string choice = Console.ReadLine();
                if (choice.StartsWith("a/add"))
                {
                    CreateDrinks(vm);
                }
                else if (choice.StartsWith("a/refill"))
                {
                    Refill(vm);
                }
                else
                {
                    Drink pickedDrink = drinks.ToArray()[int.Parse(choice) - 1];
                    Console.WriteLine($"You bought a {pickedDrink.Name} for ${pickedDrink.Price}");
                    vm.buyDrink(pickedDrink.DrinkID);
                }
                
            }
        }
        static void CreateDrinks(IMachine vm) 
        {
            vm.CreateDrink("Coke", 1.99, 10);
            vm.CreateDrink("Pepsi", 1.19, 10);
        }
        static void Refill(IMachine vm) 
        {
            foreach (Drink drink in vm.GetDrinks())
            {
                drink.Quantity = 10;
            }
        }
    }
}
