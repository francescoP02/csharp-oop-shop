// See https://aka.ms/new-console-template for more information

public class FruitBag : Product
{
    public int Quantity { get; private set; }
    public int MaxCapacity { get; } = 5;

    public FruitBag(string name, string description, double price, int quantity) : base(name, description, price)
    {
        if (quantity <= MaxCapacity)
        {
            Quantity = quantity;
        }

    }


}