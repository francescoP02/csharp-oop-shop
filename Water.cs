// See https://aka.ms/new-console-template for more information

public class Water : Product
{
    public double Liters { get; set; }
    public int Ph { get; set; }
    public string Source { get; set; }

    float maxCapacity = 1.5f;

    public Water(string name, string description, double price, double liters, int ph, string source) : base(name, description, price)
    {
        if (liters <= maxCapacity)
        {
            Liters = liters;
        }

        else
        {
            throw new InvalidOperationException("Too much capacity");
        }

        if (Ph < 0 || Ph > 14)
        {
            throw new Exception("The ph entered is not valid");
        }
        else
        {
            Ph = ph;
        }

        Source = source;
    }

    public void Drink(double Quantity)
    {
        float floatLiters = (float)Quantity;
        if (floatLiters <= Liters)
        {
            Liters -= floatLiters;
        }
        else if (Liters == 0)
        {
            throw new Exception("You can't drink, the bottle is empty");
        }
        else
        {
            throw new Exception("It's not possible to drink more water than is in the bottle!");
        }
    }

    public void Fill(double Quantity)
    {
        float floatQuantity = (float)Quantity;
        if (floatQuantity + Liters <= this.maxCapacity)
        {
            Liters += floatQuantity;
        }
        else
        {
            throw new Exception("I can't fill the bottle that much, it would go beyond its maximum capacity");
        }
    }

    public void Empty()
    {
        Liters = 0;
    }

    public string GetInformation()
    {
        return $"{GetCompleteName()} - Price: {Price} euro (With Iva: {GetIva()} euro) - Source: {Source} - PH: {this.Ph} - Liters: {Liters}";
    }

}
