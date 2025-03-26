public class Vehicle
{
    public string Brand;
    public int ModelYera;
    public Vehicle(string brand, int modelYear)
    {
        Brand = brand;
        ModelYera = modelYear;
    }

    public void ViewInfo()
    {
        Console.WriteLine($"Brand:{Brand}, Model Year: {ModelYera}");
    }

}