// See https://aka.ms/new-console-template for more information

public class Product
{
    private string code;
    private string name;
    private string description;
    private double price;

    public Product(string name, string description, double price)
    {
        this.code = SetCode();
        this.name = name;
        this.description = description;
        this.price = price;
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

    public double GetIva()
    {
        return this.price + (this.price * 0.22);
    }

    public string GetCompleteName()
    {
        return this.name + " Cod." + this.code;
    }

    public void getProduct()
    {
        Console.WriteLine($"Product code: {this.code}");
        Console.WriteLine($"Product name: {this.name}");
        Console.WriteLine($"Product description: {this.description}");
        Console.WriteLine($"Product price: {this.price} euro");
    }
}
