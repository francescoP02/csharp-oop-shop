// See https://aka.ms/new-console-template for more information

Console.WriteLine("Inserisci il nome del prodotto:");
string productName = Console.ReadLine();

Console.WriteLine("Inserisci la descrizione del prodotto:");
string productDescription = Console.ReadLine();

Console.WriteLine("Inserisci il prezzo del prodotto:");
double productPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Vuoi il nome esteso? (yes/no)");
string nameFlag = Console.ReadLine();

Console.WriteLine("Vuoi il prezzo con l'iva? (yes/no)");
string ivaFlag = Console.ReadLine();

Product prod1 = new Product(productName, productDescription, productPrice);

prod1.GetProduct();

if (nameFlag == "yes")
{
    Console.WriteLine($"Il nome intero è {prod1.GetCompleteName()}");
}

if  (ivaFlag == "yes")
{
    Console.WriteLine($"Product price + iva: {prod1.GetIva()} euro");
}


bool success = false;
string choice;

Random rnd = new Random();

do
{
    Console.WriteLine("Whic product do you want to add?");
    Console.WriteLine("'water' for add water");
    Console.WriteLine("'fruit bag' for add fruit bag");
    Console.WriteLine("'appliance' for add appliance");
    Console.WriteLine("'canned food' for add canned food");
    Console.WriteLine("'exit' for terminate process");


    choice = Console.ReadLine();

    if (choice == "water")
    {
        Console.WriteLine("water");
    }
    else if (choice == "fruit bag")
    {
        Console.WriteLine("fruit bag");
    }
    else if (choice == "appliance")
    {
        Console.WriteLine("appliance");
    }
    else if (choice == "canned food")
    {
        Console.WriteLine("canned food");
    }

} while (choice != "exit");