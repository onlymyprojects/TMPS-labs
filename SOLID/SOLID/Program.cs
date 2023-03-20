using SOLID;

Engine engine = new Engine();
Car sedan = new Sedan(engine);
Car universal = new Universal(engine);

CarController sedanController = new CarController((IDriveable)sedan);
CarController suvController = new CarController((IDriveable)universal);

sedanController.StartCar();
sedanController.DriveCar();
sedanController.StopCar();

Console.WriteLine();

suvController.StartCar();
suvController.DriveCar();
suvController.StopCar();