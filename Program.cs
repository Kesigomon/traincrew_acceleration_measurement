namespace acceleration_measurement
{
    class Program{
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run().Wait();
        }
        private Task Run() {
            return Task.CompletedTask;
        }
    }
}

