using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

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
            list = file.getFromTextFile(textBoxTextFile.Text);
            // Check that the list is not empty
            checkListNotEmpty(buttonTextFile);
            // Set output as object was converted into JSON string
            string output = parse.serializeColours(list);
            // Add it to listColourBox to easily read JSON format as one line
            // as it wrote out for the form sight;
            listColourBox.Items.Add(output);
            // Set list as deserialize back to .NET format as List<ColorRainbow>
            List<ColorRainbow> rainbow = parse.deserializeColours(output);
            // Go through each colour from the rainbow (list)
            foreach(ColorRainbow color in rainbow)
            {
                // Create new label
                Label lblColor = new Label();
                // Set label's text as this colour's name
                lblColor.Text = color.name;
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
        // Check that after read file, check that list is not empty, if so, display message
        private void checkListNotEmpty(Control control)
        {
            errorProvider.Dispose();

            if (list.Count == 0)
            {
                errorProvider.SetError(control, "Please check file correctly.");
            }
        }
        // When form loaded, read text file from the system and set all lines to list in ColorRainbow's object 
        private void RainbowForm_Load(object sender, EventArgs e)
        {
            listColourBox.HorizontalScrollbar = true;
        }

        private void buttonJsonFile_Click(object sender, EventArgs e)
        {
            list = file.getFromJsonFile(textBoxJsonFile.Text);
            checkListNotEmpty(buttonJsonFile);
            foreach(ColorRainbow color in list)
            {
                // Create new label
                Label lblColor = new Label();
                // Set label's text as this colour's name
                lblColor.Text = color.name;
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
    }
}
