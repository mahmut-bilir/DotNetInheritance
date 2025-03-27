Car car = new Car("Toyota", 2024, 4);

car.ViewCarInfo();
car.WriteBrand();

Vehicle vehicle = new Vehicle("BMW", 2025);
vehicle.Drive(); // Calls the base class method.
car.Drive();     //Calls the derived class method.