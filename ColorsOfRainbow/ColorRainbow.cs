using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ColorsOfRainbow
{
    class ColorRainbow
    {
        public string name { get; set; }
        public string hexCode { get; set; }
        public int[] rgba { get; set; }
    }
}
