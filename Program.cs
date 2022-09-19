// See https://aka.ms/new-console-template for more information

Console.WriteLine("Inserisci il nome del prodotto:");
string productName = Console.ReadLine();

Console.WriteLine("Inserisci la descrizione del prodotto:");
string productDescription = Console.ReadLine();

Console.WriteLine("Inserisci il prezzo del prodotto:");
double productPrice = Convert.ToDouble(Console.ReadLine());


Product prod1 = new Product(productName, productDescription, productPrice);

prod1.Print();
