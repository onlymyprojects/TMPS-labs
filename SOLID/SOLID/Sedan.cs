namespace SOLID
{
    // Liskov Substitution Principle (LSP)
    class Sedan : Car, IDriveable
    {
        public Sedan(Engine engine) : base(engine)
        {
        }

        public void Start()
        {
            engine.Ignite();
        }

        public void Stop()
        {
            engine.ShutDown();
        }

        public void Drive()
        {
            Console.WriteLine("Driving a sedan");
        }
    }
}
