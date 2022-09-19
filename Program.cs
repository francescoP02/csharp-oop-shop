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

prod1.getProduct();

if (nameFlag == "yes")
{
    Console.WriteLine($"Il nome intero è {prod1.GetCompleteName()}");
}

if  (ivaFlag == "yes")
{
    Console.WriteLine($"Product price + iva: {prod1.GetIva()} euro");
}