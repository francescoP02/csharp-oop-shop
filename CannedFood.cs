// See https://aka.ms/new-console-template for more information

public class CannedFood : Product
{
    public int Quantity { get; private set; }

    public int maxQuantity = 300;

    public CannedFood(string name, string description, double price, int quantity) : base(name, description, price)
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

    public string GetInformation()
    {
        return $"{GetCompleteName()} - Price: {Price} euro (With Iva: {GetIva()} euro) - Quantity: {Quantity}g";
    }

}