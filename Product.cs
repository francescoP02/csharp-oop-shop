// See https://aka.ms/new-console-template for more information

public class Product
{
    private string Code { get; set; }
    private string Name { get; set; }
    private string Description { get; set; }
    private double Price { get; set; }

    public Product(string name, string description, double price)
    {
        Code = SetCode();
        Name = name;
        Description = description;
        Price = price;
    }

    private string SetCode()
    {
        Random rnd = new Random();

        string Code = Convert.ToString(rnd.Next(1, 999999));

        Code = Code.PadLeft(8, '0');

        //if (code.Length >= 8)
        //{
        //    return code;
        //}
        //for (int i = code.Length; i < 8; i++)
        //{
        //    code = '0' + code;
        //}

        return Code;

    }

    public double GetIva()
    {
        return this.Price + (this.Price * 0.22);
    }

    public string GetCompleteName()
    {
        return this.Name + " Cod." + this.Code;
    }

    public void GetProduct()
    {
        Console.WriteLine($"Product code: {Code}");
        Console.WriteLine($"Product name: {Name}");
        Console.WriteLine($"Product description: {Description}");
        Console.WriteLine($"Product price: {Price} euro");
    }
}
