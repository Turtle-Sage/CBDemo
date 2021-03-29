using System;
using System.Collections.Generic;
using CBDataLibrary.BusinessLogic;
using CBDataLibrary.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace CBApp
{
    class Program
    {
        static void Main()
        {
            //Setups AutoMapper at start-up
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddTransient<ILearner, Learner>();
            services.AddTransient<IMappers, Mappers>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            ILearner learner = serviceProvider.GetRequiredService<ILearner>();

            //Calls into the Data Library to grab the Json from Resources, 
            //deserialize it, map it across DTOs and Models, then serialize it into the output format.
            string jsonOutput = learner.GetLearner();
            Console.WriteLine(jsonOutput);
            Console.ReadLine();
        }
    }

}
