using CBDataLibrary.DTOs;
using CBDataLibrary.Models;
using CBDataLibrary.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CBDataLibrary
{
    public class JsonFactory
    {
        /// <summary>
        /// Loads Json from resources.resx. Deserializes it into a LearnerDTO
        /// </summary>
        /// <returns>LearnerDTO</returns>
        public static LearnerDTO LoadJson()
        {
            string inputJsonLocation = Resources.InputJson;
            using (StreamReader r = new StreamReader(inputJsonLocation))
            {
                string json = r.ReadToEnd();
                LearnerDTO result = JsonConvert.DeserializeObject<LearnerDTO>(json);

                return result;
            }
        }




    }
}
