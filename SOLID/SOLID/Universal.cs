namespace SOLID
{
    // Liskov Substitution Principle (LSP)
    class Universal : Car, IDriveable
    {
        public Universal(Engine engine) : base(engine)
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
            Console.WriteLine("Driving an universal");
        }
    }
}
