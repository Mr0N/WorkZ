using SourceGeneratorSamples;
using System;
using WorkZ;


namespace WorkZ
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldGenerated.HelloWorld.SayHello();
      
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
