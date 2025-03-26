public class Vehicle
{
    protected string Brand; // 'Protected' are accessible from derived class
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