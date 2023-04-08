using SOLID;

Engine engine = new Engine();
Car sedan = new Sedan(engine);
Car universal = new Universal(engine);

CarController sedanController = new CarController((IDriveable)sedan);
CarController universalController = new CarController((IDriveable)universal);

sedanController.StartCar();
sedanController.DriveCar();
sedanController.StopCar();

Console.WriteLine();

universalController.StartCar();
universalController.DriveCar();
universalController.StopCar();