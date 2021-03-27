using System;
using System.Collections.Generic;
using CBDataLibrary;
using CBDataLibrary.DTOs;
using Newtonsoft.Json;

namespace CBApp
{
    class Program
    {
        static void Main()
        {
            LearnerDTO output = JsonFactory.LoadJson();
            var jsonOutput = JsonConvert.SerializeObject(output);
            Console.WriteLine(jsonOutput);
        }
    }
}
