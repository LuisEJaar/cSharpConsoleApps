using CommandLine;
using System;
using writing;

namespace Writing
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOptions options = new MyOptions();

            var answer  = CommandLine.Parser.Default.ParseArguments<MyOptions>(args)
                .WithParsed<MyOptions>(opts => options = opts);
            
            if(answer != null)
            {
                for (int i = 0; i < options.Times; i++)
                {
                    Console.WriteLine(options.Message);
                }
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Didn't work eh");
                Console.ReadLine();
            }
        }
    }
}
