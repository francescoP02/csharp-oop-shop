// See https://aka.ms/new-console-template for more information






public class Product
{
    private int code;
    string name;
    string productName;
    string description;
    double price;
    private double iva;

    public Product(string name, string description, double price)
    {
        this.code = SetCode();
        this.name = name;
        this.productName = CompleteName();
        this.description = description;
        this.price = price;
        this.iva = SetIva(); 
    }


    Random rnd = new Random();

    private int SetCode()
    {
        return rnd.Next(99999999);
    }

    private double SetIva()
    {
        Console.WriteLine("Vuoi il prezzo con l'iva? (yes/no)");
        string ivaFlag = Console.ReadLine();
        if (ivaFlag == "yes")
        {
            return this.price + (this.price * 0.22);
        }
        else
        {
            return 0;
        }
    }

    public string CompleteName()
    {
        Console.WriteLine("Vuoi il nome esteso? (yes/no)");
        string nameFlag = Console.ReadLine();

        if (nameFlag == "yes")
        {
            return this.name + " Cod." + this.code;
        } 
        else
        {
            return this.name;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Product code: {this.code}");
        Console.WriteLine($"Product name: {this.productName}");
        Console.WriteLine($"Product description: {this.description}");
        Console.WriteLine($"Product price: {this.price} euro");
        if (this.iva != 0)
        {
            Console.WriteLine($"Product price + iva: {this.iva} euro");
        }
    }
}
