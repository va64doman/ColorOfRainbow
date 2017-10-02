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
            // Read through all lines from text file
            // Initialise empty list
            List<ColorRainbow> list = new List<ColorRainbow>();
            // Try and catch if file is not existed or line is incorrect
            try
            {
                // Set current line as string
                string currentLine;
                // Access stream reader class methods using the file by user input
                StreamReader file = new StreamReader(fileName);
                // Read the first line and set as currentLine
                currentLine = file.ReadLine();
                // While this line is not null
                while (currentLine != null)
                {
                    // Set string arrays when spliting the line from commas
                    string[] splits = currentLine.Split(',');
                    // Set name from splits[0]
                    string name = splits[0];
                    // Set hex code from splits[1]
                    string hexCode = splits[1];
                    // Set red from splits[2]
                    int red = Convert.ToInt32(splits[2]);
                    // Set green from splits[3]
                    int green = Convert.ToInt32(splits[3]);
                    // Set blue from splits[4]
                    int blue = Convert.ToInt32(splits[4]);
                    // Set alpha from splits[5]
                    int alpha = Convert.ToInt32(splits[5]);
                    // Set ColorRainbow object
                    ColorRainbow colours = new ColorRainbow();
                    // Set object's name by name
                    colours.name = name;
                    // Set object's hex code by hex code
                    colours.hexCode = hexCode;
                    // Set object rgba attribute by red, green, blue and alpha
                    colours.rgba = new int[] { red, green, blue, alpha };
                    // Add object to list
                    list.Add(colours);
                    // Read the next line
                    currentLine = file.ReadLine();
                }
                // Close file
                file.Close();
            }
            // Throw error where file is not existed
            catch (FileNotFoundException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Throw error where line is not matched with the attribute from class
            catch (IOException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Throw error where there are not enough attributes from file
            catch (ArgumentException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Throw error where the file is existed but transferring data is incorrect
            catch(IndexOutOfRangeException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Return list of colour
            return list;
        }

        public List<ColorRainbow> getFromJsonFile(string fileName)
        {
            // Read JSON file and deserialize them into ColorRainbow list
            List<ColorRainbow> list = new List<ColorRainbow>();
            // Try and catch if file is not existed or line is incorrect
            try
            {
                // Deserialize JSON string from file into list of colours
                list = JsonConvert.DeserializeObject<List<ColorRainbow>>(File.ReadAllText(fileName));
            }
            // Throw error where file is not existed
            catch (FileNotFoundException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Throw error where line is not matched with the attribute from class
            catch (IOException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Throw error where there are not enough attributes from file
            catch (ArgumentException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Throw error where read the file is not in JSON format
            catch(JsonReaderException error)
            {
                Console.WriteLine("Error message is " + error.Message);
            }
            // Return list of colours
            return list;
        }
    }
}
