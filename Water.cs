// See https://aka.ms/new-console-template for more information

public class Water : Product
{
    public int Liters { get; set; }
    public string Ph { get; set; }
    public string Source { get; set; }

    public Water(string name, string description, double price, int liters, string ph, string source) : base(name, description, price)
    {
        if (liters <= 1.5f)
        {
            Liters = liters;
        }

        else
        {
            throw new InvalidOperationException("Too much capacity");
        }

        Ph = ph;

        Source = source;
    }


}
