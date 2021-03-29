using CBDataLibrary.DTOs;
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
                return JsonConvert.DeserializeObject<LearnerDTO>(json);
            }
        }

        /// <summary>
        /// Takes a OutputDTO Object and serializes it.
        /// </summary>
        /// <returns>string</returns>
        public static string JsonSerialize(OutputDTO output)
        {
            return JsonConvert.SerializeObject(output);
        }

    }
}
