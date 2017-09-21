using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ColorsOfRainbow
{
    class ColorParser
    {
        public string serializeColours(List<ColorRainbow> list)
        {
            string jsonString = JsonConvert.SerializeObject(list);
            return jsonString;
        }

        public List<ColorRainbow> deserializeColours(string inputJsonString)
        {
            List<ColorRainbow> colours = JsonConvert.DeserializeObject<List<ColorRainbow>>(inputJsonString);
            return colours;
        }
    }
}
