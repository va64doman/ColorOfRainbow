using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ColorsOfRainbow
{
    class ReadTextFile
    {
        public List<ColorRainbow> getFromTextFile(string fileName)
        {
            List<ColorRainbow> list = new List<ColorRainbow>();

            try
            {
                string currentLine;
                StreamReader file = new StreamReader(fileName);

                currentLine = file.ReadLine();

                while (currentLine != null)
                {
                    string[] splits = currentLine.Split(',');

                    string name = splits[0];
                    string hexCode = splits[1];
                    int red = Convert.ToInt32(splits[2]);
                    int green = Convert.ToInt32(splits[3]);
                    int blue = Convert.ToInt32(splits[4]);
                    int alpha = Convert.ToInt32(splits[5]);

                    ColorRainbow colours = new ColorRainbow();
                    colours.name = name;
                    colours.hexCode = hexCode;
                    colours.rgba = new int[] { red, green, blue, alpha };
                    list.Add(colours);

                    currentLine = file.ReadLine();
                }

                file.Close();
            }

            catch (FileNotFoundException error)
            {

            }

            catch (IOException error)
            {

            }

            catch(ArgumentException error)
            {

            }

            return list;

        }

        public List<ColorRainbow> getFromJsonFile(string fileName)
        {
            List<ColorRainbow> list = new List<ColorRainbow>();

            try
            {
                list = JsonConvert.DeserializeObject<List<ColorRainbow>>(File.ReadAllText(fileName));
            }

            catch (FileNotFoundException error)
            {

            }

            catch (IOException error)
            {

            }

            catch (ArgumentException error)
            {

            }

            return list;
        }
    }
}
