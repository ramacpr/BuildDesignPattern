using HelloBuilder.Contracts;
using HelloBuilder.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace HelloBuilder.Concretions
{


    public class MakeYourOwnBurgerBuilder : IBurgerBuilder
    {
        IBurger burger = new Burger(); 

        public IBurgerBuilder BunType(string bunVariety)
        {
            burger.BunType = bunVariety;
            return this;
        }

        public IBurger PrepareBurger()
        {
            // check if valid
            if (!burger.IsBurgerValid())
                throw new InvalidBurgerException();

            // now prepare
            BurgerAssemble();

            return burger;
        }

        void BurgerAssemble()
        {
            Console.Write($"--- tosting {burger.BunType} bun... ");
            Thread.Sleep(2000);
            Console.Write("DONE\n");

            Console.Write($"--- prepping {burger.PattyType} patty...");
            Thread.Sleep(5000);
            Console.Write("DONE\n");

            Console.Write($"--- BURGER, assemble...\n");
            Console.Write($"------ adding toppings... ");
            foreach (var topping in burger.Toppings)
            {
                Thread.Sleep(3000);
                Console.Write(topping + "... ");
            }
            Console.Write("DONE\n");

            Console.Write($"------ adding sauses... ");
            foreach (var sause in burger.Sauses)
            {
                Thread.Sleep(3000);
                Console.Write(sause + "... ");
            }
            Console.Write("DONE\n");

            Console.Write("--- Packing your yummy burger... ");
            Thread.Sleep(5000);
            Console.Write("DONE\n\n\n");
        }

        public IBurgerBuilder PattyType(string patty)
        {
            burger.PattyType = patty;
            return this;
        }

        public IBurgerBuilder PrepMethod(string prepMethod)
        {
            burger.PrepMethod = prepMethod;
            return this;
        }

        public IBurgerBuilder SauseType(string sause)
        {
            (burger.Sauses as List<string>).Add(sause);
            return this;
        }

        public IBurgerBuilder Topping(string topping)
        {
            (burger.Toppings as List<string>).Add(topping);
            return this;
        }
    }
}
