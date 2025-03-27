public class Car : Vehicle
{
    public int DoorCount;

    public Car(string brand, int modelYear, int doorCount) : base(brand, modelYear)
    {
        DoorCount = doorCount;

    }
    public void ViewCarInfo()
    {
        ViewInfo(); // Calling a method in the Base class
        Console.WriteLine("Door count: 0" + DoorCount);
    }
    public void WriteBrand()
    {
        Console.WriteLine($"This car belongs to a {Brand} brand.");
    }
    public override void Drive()
    {
        Console.WriteLine("The car is being driven.");
    }
}