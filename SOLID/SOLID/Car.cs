namespace SOLID
{
    // Open-Closed Principle (OCP)
    class Car
    {
        protected readonly Engine engine;
        public const int nrOfDoors = 4;
        public const int nrOfSeats = 5;
        public const int maxSpeed = 200;

        public Car(Engine engine)
        {
            this.engine = engine;
        }
    }
}
