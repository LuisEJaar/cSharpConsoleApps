using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writing
{
    internal class MyOptions
    {
        [Option('m', "message", Required = true)]
        public string Message { get; set; } = "";

        [Option('t', "times")]
        public int Times { get; set; } = 0;
    }
}
