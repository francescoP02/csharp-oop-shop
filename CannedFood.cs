// See https://aka.ms/new-console-template for more information

public class CannedFood : Product
{
    public int Quantity { get; private set; }
    public int Capacity { get; }

    public int maxQuantity = 300;

    public CannedFood(string name, string description, double price, int quantity, int capacity) : base(name, description, price)
    {
        if (quantity <= maxQuantity)
        {
            Quantity = quantity;
        }

        else
        {
            throw new InvalidOperationException("Too much capacity");
        }
    }


}