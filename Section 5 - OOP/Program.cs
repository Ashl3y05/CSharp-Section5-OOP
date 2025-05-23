﻿namespace Section_5___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toolName, brandName;
            int modelNumber;

            Console.WriteLine("Please enter new kitchen tools:");

            Console.Write("Name of tool: ");
            toolName = Console.ReadLine();

            Console.Write("Brand Name: ");
            brandName = Console.ReadLine();

            Console.Write("Model Number: ");
            modelNumber = int.Parse(Console.ReadLine());

            KitchenTools knife = new KitchenTools(toolName, brandName, modelNumber);

            Console.WriteLine($"Name of tool: {knife.Name}\nBrand: {knife.Brand}\nModel: {knife.ModelNumber}");

            Cooks adam = new Cooks(name: "Adam", position: "Dishwasher", experiences:[ "NA" ]);
            Cooks eve = new Cooks(name: "Eve", position: "Cashier", experiences: ["NA"]);
            adam.ShowCookDetails();
            eve.ShowCookDetails();
            KitchenTools.Knife knife1 = new KitchenTools.Knife();
            knife1.KnifeName = "Chef's Knife";
            knife1.Cut();
            Console.ReadKey();
        }
    }
}
