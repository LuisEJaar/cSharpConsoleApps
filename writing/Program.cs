using System;

internal class Program
{
    private static void Main(string[] args)
    {

        var fullCommandLineString = Environment.CommandLine;

        //Console.WriteLine("fullCommandLineString");

        //Console.WriteLine(fullCommandLineString);

        var message = args[0];
        var iterations = Convert.ToInt32(args[1]);

        //Console.WriteLine("Args: ");

        for(int i = 0; i < iterations; i++)
        {
            Console.WriteLine(message);
        }

        Console.ReadLine();
    }
}