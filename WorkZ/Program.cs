using SourceGeneratorSamples;
using System;
using WorkZ;


namespace WorkZ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HelloWorldGenerator.HelloWorldGenerated.SayHello(); // calls Console.WriteLine("Hello World!") and then prints out syntax trees
           
        }
    }
}
