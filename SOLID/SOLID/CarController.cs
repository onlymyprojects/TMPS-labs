namespace SOLID
{
    // Dependency Inversion Principle (DIP)
    class CarController
    {
        private readonly IDriveable car;

        public CarController(IDriveable car)
        {
            this.car = car;
        }

        public void StartCar()
        {
            car.Start();
        }

        public void StopCar()
        {
            car.Stop();
        }

        public void DriveCar()
        {
            car.Drive();
        }
    }
}
