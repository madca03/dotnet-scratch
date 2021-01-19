using System;

namespace scratch_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testEnv = Environment.GetEnvironmentVariable("testEnv");
            Console.WriteLine($"Hello World! testEnv: {testEnv}");
        }
    }
}
