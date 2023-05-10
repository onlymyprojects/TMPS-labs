using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Bridge;
using StructuralDesignPatterns.Decorator;

// BRIDGE
IEngineStartStopActivator carStartStopActivator = new CarStartStopActivator();
EngineStartStop carStartStop = new CarStartStop(carStartStopActivator);
carStartStop.StartEngine();
// ADAPTER
ICar myCar = new Car();
myCar.Ride();
// BRIDGE
carStartStop.StopEngine();


// BRIDGE
IEngineStartStopActivator motorcycleStartStopActivator = new MotorcycleStartStopActivator();
EngineStartStop motorcycleStartStop = new MotorcycleStartStop(motorcycleStartStopActivator);
motorcycleStartStop.StartEngine();
// ADAPTER
IMotorcycle motorcycle = new Motorcycle();
ICar myMotorcycle = new MotorcycleAdapter(motorcycle);
myMotorcycle.Ride();
// BRIDGE
motorcycleStartStop.StopEngine();


// DECORATOR
ICarInterior carInterior = new LeftHandDriveCarInterior();
carInterior = new Coaster(carInterior);
carInterior = new SeatMassager(carInterior);
carInterior = new Fridge(carInterior);
Console.WriteLine($"{carInterior.Description} => ${carInterior.Cost()}");

ICarInterior carInterior2 = new RightHandDriveCarInterior();
carInterior2 = new Coaster(carInterior2);
Console.WriteLine($"{carInterior2.Description} => ${carInterior2.Cost()}");
