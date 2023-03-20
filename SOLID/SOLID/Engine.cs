namespace SOLID
{
    // Single Responsibility Principle (SRP)
    class Engine
    {
        public void Ignite()
        {
            Console.WriteLine("Engine ignited");
        }

        public void ShutDown()
        {
            Console.WriteLine("Engine shut down");
        }
    }
}
