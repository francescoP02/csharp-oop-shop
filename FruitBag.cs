// See https://aka.ms/new-console-template for more information

public class FruitBag : Product
{
    public int Quantity { get; private set; }
    public int MaxCapacity = 5;

    public FruitBag(string name, string description, double price, int quantity) : base(name, description, price)
    {
        if (quantity <= MaxCapacity)
        {
            Quantity = quantity;
        }
        else
        {
            throw new InvalidOperationException("Too much fruit");
        }
    }

    public string GetInformation()
    {
        return $"{GetCompleteName()} - Price: {Price} euro (With Iva: {GetIva()} euro) - Fruits: {Quantity}";
    }


}