// See https://aka.ms/new-console-template for more information

using System;

List<Water> waterProducts = new List<Water>();
List<Appliance> applianceProducts = new List<Appliance>();
List<FruitBag> fruitBagProducts = new List<FruitBag>();
List<CannedFood> cannedFoodProducts = new List<CannedFood>();

//prod1.GetProduct();

//if (nameFlag == "yes")
//{
//    Console.WriteLine($"Il nome intero è {prod1.GetCompleteName()}");
//}

//if  (ivaFlag == "yes")
//{
//    Console.WriteLine($"Product price + iva: {prod1.GetIva()} euro");
//}


bool success = false;
string choice;

Random rnd = new Random();

do
{
    Console.WriteLine("Whic product do you want to add?");
    Console.WriteLine("'water' for water section");
    Console.WriteLine("'fruit bag' for add fruit bag");
    Console.WriteLine("'appliance' for add appliance");
    Console.WriteLine("'canned food' for add canned food");
    Console.WriteLine("'exit' for terminate process");


    choice = Console.ReadLine();

    if (choice == "water")
    {
        string userInput;

        do
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("'add' for add water");
            Console.WriteLine("'drink' for drink water");
            Console.WriteLine("'fill' for fill water");
            Console.WriteLine("'empty' for empty water");
            Console.WriteLine("'exit' for add water");
            userInput = Console.ReadLine();
            if (userInput == "add")
            {
                AddNewWater();
                Console.Clear();
            }
            if (userInput == "drink")
            {
                bool found = false;
                Console.WriteLine("Which water do you want to drink?");
                string name = Console.ReadLine();
                foreach (Water water in waterProducts)
                {
                    if (water.Name == name)
                    {
                        found = true;
                        Console.WriteLine($"Liters available: {water.Liters}");
                        Console.WriteLine("How much do you want to drink?");
                        double Quantity = Convert.ToDouble(Console.ReadLine());
                        water.Drink(Quantity);
                    }
                }
                Console.Clear();
            }
            if (userInput == "fill")
            {
                bool found = false;
                Console.WriteLine("Which water do you want to fill?");
                string name = Console.ReadLine();
                foreach (Water water in waterProducts)
                {
                    if (water.Name == name)
                    {
                        found = true;
                        Console.WriteLine($"Liters available: {water.Liters}");
                        Console.WriteLine("How much do you want to fill it?");
                        double Quantity = Convert.ToDouble(Console.ReadLine());
                        water.Fill(Quantity);
                    }
                }
                Console.Clear();
            }
            if(userInput == "empty")
            {
                bool found = false;
                Console.WriteLine("Which water do you want to empty?");
                string name = Console.ReadLine();
                foreach (Water water in waterProducts)
                {
                    if (water.Name == name)
                    {
                        found = true;
                        water.Empty();
                    }
                }
                Console.Clear();
            }
        } while (userInput != "exit");
    }
    else if (choice == "fruit bag")
    {
        Console.WriteLine("fruit bag");
    }
    else if (choice == "appliance")
    {
        AddNewAppliance();
    }
    else if (choice == "canned food")
    {
        Console.WriteLine("canned food");
    }

} while (choice != "exit");

Console.Clear();

Console.WriteLine(Environment.NewLine);
Console.WriteLine("****All Waters' Informations****");
Console.WriteLine(Environment.NewLine);

foreach (Water water in waterProducts)
{
    Console.WriteLine($"{water.GetInformation()}");
}

Console.WriteLine(Environment.NewLine);
Console.WriteLine("****All Appliances' Informations****");
Console.WriteLine(Environment.NewLine);

foreach (Appliance appliance in applianceProducts)
{
    Console.WriteLine($"{appliance.GetInformation()}");
}




void AddNewWater()
{

    try
    {
        Console.WriteLine("Inserisci il nome del prodotto:");
        string productName = Console.ReadLine();

        Console.WriteLine("Inserisci la descrizione del prodotto:");
        string productDescription = Console.ReadLine();

        Console.WriteLine("Inserisci il prezzo del prodotto:");
        double productPrice = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Vuoi il nome esteso? (yes/no)");
        //string nameFlag = Console.ReadLine();

        //Console.WriteLine("Vuoi il prezzo con l'iva? (yes/no)");
        //string ivaFlag = Console.ReadLine();

        Console.WriteLine("How many liters does it have?");
        double liters = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("How much ph does it have?");
        int ph = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Indicates the source of origin");
        string source = Console.ReadLine();

        Water newWater = new Water(productName, productDescription, productPrice, liters, ph, source);

        waterProducts.Add(newWater);

        Console.Clear();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void AddNewAppliance()
{
    try
    {
        Console.WriteLine("Inserisci il nome del prodotto:");
        string productName = Console.ReadLine();

        Console.WriteLine("Inserisci la descrizione del prodotto:");
        string productDescription = Console.ReadLine();

        Console.WriteLine("Inserisci il prezzo del prodotto:");
        double productPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insert energy rating");
        Console.WriteLine("(Insert one of this: A++, A+, A, B, C, D, E, F)");
        string energyRating = Console.ReadLine();

        Appliance newAppliance = new Appliance(productName, productDescription, productPrice, energyRating);

        applianceProducts.Add(newAppliance);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}