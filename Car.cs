public class Car : Vehicle
{
    public int DoorCount;
    public void ViewCarInfo()
    {
        ViewInfo(); // Calling a method in the Base class
        Console.WriteLine("Door count: 0" + DoorCount);
    }
}