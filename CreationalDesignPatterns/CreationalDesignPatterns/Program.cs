using CreationalDesignPatterns;
using CreationalDesignPatterns.Cars;
using CreationalDesignPatterns.Motorcycles;

// ABSTRACT FACTORY ---- FACTORY METHOD ---- SINGLETON
VehicleFactory carFactory = CarFactory.GetInstance();
Vehicle sedan = carFactory.CreateVehicle("sedan");
Vehicle universal = carFactory.CreateVehicle("universal");

VehicleFactory motorcycleFactory = MotorcycleFactory.GetInstance();
Vehicle scooter = motorcycleFactory.CreateVehicle("scooter");
Vehicle sportBike = motorcycleFactory.CreateVehicle("sportbike");