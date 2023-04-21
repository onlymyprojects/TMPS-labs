using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Bridge;
using StructuralDesignPatterns.Decorator;

// BRIDGE
IEngineStartStopActivator carStartStopActivator = new CarStartStopActivator();
IEngineStartStop carStartStop = new CarStartStop(carStartStopActivator);
carStartStop.Start();
// ADAPTER
ICar myCar = new Car();
myCar.Ride();
// BRIDGE
carStartStop.Stop();


// BRIDGE
IEngineStartStopActivator motorcycleStartStopActivator = new MotorcycleStartStopActivator();
IEngineStartStop motorcycleStartStop = new MotorcycleStartStop(motorcycleStartStopActivator);
motorcycleStartStop.Start();
// ADAPTER
IMotorcycle motorcycle = new Motorcycle();
ICar myMotorcycle = new MotorcycleAdapter(motorcycle);
myMotorcycle.Ride();
// BRIDGE
motorcycleStartStop.Stop();


// DECORATOR
ICarInterior carInterior = new LeftHandDriveCarInterior();
carInterior = new Coaster(carInterior);
carInterior = new SeatMassager(carInterior);
carInterior = new Fridge(carInterior);
Console.WriteLine($"{carInterior.Description} => ${carInterior.Cost()}");

ICarInterior carInterior2 = new RightHandDriveCarInterior();
carInterior2 = new Coaster(carInterior2);
Console.WriteLine($"{carInterior2.Description} => ${carInterior2.Cost()}");
