// See https://aka.ms/new-console-template for more information

public class Product
{
    private string code;
    private string name;
    private string productName;
    private string description;
    private double price;
    private double iva;

    public Product(string name, string description, double price)
    {
        this.code = SetCode();
        this.name = name;
        this.productName = SetCompleteName();
        this.description = description;
        this.price = price;
        this.iva = SetIva(); 
    }

    private string SetCode()
    {
        Random rnd = new Random();

        string code = Convert.ToString(rnd.Next(1, 999999));

        //code = code.PadLeft(8, '0');

        if (code.Length >= 8)
        {
            return code;
        }
        for (int i = code.Length; i < 8; i++)
        {
            code = '0' + code;
        }

        return code;

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

    private string SetCompleteName()
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

    public void getProduct()
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
