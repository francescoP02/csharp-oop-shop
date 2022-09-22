// See https://aka.ms/new-console-template for more information

public class Appliance : Product
{

    public string EnergyRating { get; set; }

    public Appliance(string name, string description, double price, string energyRating) : base(name, description, price)
    {
        if(energyRating != "A++" || energyRating != "A+" || energyRating != "A" || energyRating != "B" || energyRating != "C" || energyRating != "D" || energyRating != "E" || energyRating != "F")
        {
            EnergyRating = energyRating;
        }
        else
        {
            throw new InvalidOperationException("Invalid energy rating");
        }
    }

    public string GetInformation()
    {
        return $"{GetCompleteName()} - Price: {Price} euro (With Iva: {GetIva()} euro) - Energy Rating: {EnergyRating}";
    }

}