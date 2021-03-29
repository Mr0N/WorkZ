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
            HelloWorldGenerated.HelloWorld.Create();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
