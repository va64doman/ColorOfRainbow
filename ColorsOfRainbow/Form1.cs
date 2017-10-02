using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsOfRainbow
{
    public partial class RainbowForm : Form
    {
        // Get file methods from File class and set as object
        ReadTextFile file = new ReadTextFile();
        // Set new list from ColorRainbow attritubes
        List<ColorRainbow> list = new List<ColorRainbow>();
        // Get ColorParser method from this class and set as object
        ColorParser parse = new ColorParser();
        // Get ColorRainbow methods from this class and set as object
        ColorRainbow colours = new ColorRainbow();
        // Initialize component from form
        public RainbowForm()
        {
            InitializeComponent();
        }
        // When user click on this button, display the colours' data in JSON format and display colours
        private void buttonTextFile_Click(object sender, EventArgs e)
        {
            // Read through text file by user's input and send all lines into items from list
            list = file.getFromTextFile(textBoxTextFile.Text);
            // Check that the list is not empty
            if (!checkListNotEmpty(buttonTextFile))
            {
                // Set output as object was converted into JSON string
                string output = parse.serializeColours(list);
                // Add it to listColourBox to easily read JSON format as one line
                // as it wrote out for the form sight;
                listColourBox.Items.Add(output);
                // Set list as deserialize back to .NET format as List<ColorRainbow>
                List<ColorRainbow> rainbow = parse.deserializeColours(output);
                displayColour(buttonTextFile, list);
            }
        }
        // Check that after read file, check that list is not empty, if so, display message from error provider
        private bool checkListNotEmpty(Control control)
        {
            errorProvider.Dispose();

            if (list.Count == 0)
            {
                errorProvider.SetError(control, "Please check file name, file type and inside file correctly.");
                return true;
            }
            else
            {
                return false;
            }
        }
        // When form loaded, read text file from the system and set all lines to list in ColorRainbow's object 
        private void RainbowForm_Load(object sender, EventArgs e)
        {
            listColourBox.HorizontalScrollbar = true;
            // Display tool tip for all controls
            createToolTip(textBoxTextFile, "Enter .txt file.");
            createToolTip(textBoxJsonFile, "Enter .json file.");
            createToolTip(buttonTextFile, "Display colours from text file.");
            createToolTip(buttonJsonFile, "Display colours from json file.");
            createToolTip(listColourBox, "Display json strings for colour's details.");
            createToolTip(flowLayoutColorPanel, "Display colours from this layout.");
        }
        // When user clicks on this button, it reads the json file and convert them into a list of colours
        private void buttonJsonFile_Click(object sender, EventArgs e)
        {
            // Read through json file by user's input and send all lines into items from list
            list = file.getFromJsonFile(textBoxJsonFile.Text);
            if (!checkListNotEmpty(buttonJsonFile))
            {
                displayColour(buttonJsonFile, list);
                // Set output as object was converted into JSON string
                string output = parse.serializeColours(list);
                // Add it to listColourBox to easily read JSON format as one line
                // as it wrote out for the form sight;
                listColourBox.Items.Add(output);
            }
        }
        // Display the output by label and colour the label's background by details from each object in list
        private void displayColour(Control control, List<ColorRainbow> list)
        {
            try
            {
                // Go through each colours in a list
                foreach (ColorRainbow color in list)
                {
                    // Create new label
                    Label lblColor = new Label();
                    // Set label's text as this colour's name with tooltip to display colour's name
                    lblColor.Text = " ";
                    createToolTip(lblColor, String.Format("{0} {1}", color.name, color.hexCode));
                    // Translate color from this colour's hex code
                    Color setColor = ColorTranslator.FromHtml(color.hexCode);
                    // Set this label's backgorund colour as setColor
                    lblColor.BackColor = setColor;
                    // Set auto size to true to see full name of this colour
                    lblColor.AutoSize = true;
                    // Add label to flow layout panel
                    flowLayoutColorPanel.Controls.Add(lblColor);
                }
            }
            catch(FormatException error)
            {
                // If the hex code is not format correctly, display error
                errorProvider.Dispose();
                errorProvider.SetError(control, "Please check file name, file type and inside file correctly.");
                Console.WriteLine("Error message is " + error.Message);
            }
        }
        // Create tool tip for the form control with text for user to understand
        private void createToolTip(Control control, string text)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(control, text);
        }
    }
}
