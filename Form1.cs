using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverterLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_Input.Text = Convert(0);
        }

        public string Convert(int a)
        {
            string s = a.ToString();
            return s;
        }

        /// <summary>
        /// Event handler for the Clear button click. Resets input and output fields.
        /// </summary>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_Input.Text = Convert(0);
            lbl_Output.Text = "";
        }

        private void btn_InputClick(object sender, EventArgs e)
        {
            Button TemperatureButton = (Button)sender;

            if (lbl_Input.Text == "0")
            {
                if (TemperatureButton.Text == "0") return;
                else {
                    lbl_Input.Text = TemperatureButton.Text;
                    return;
                }
            }
            else if (TemperatureButton.Text == ".")
            {
                if (!lbl_Input.Text.Contains("."))
                {
                    lbl_Input.Text += TemperatureButton.Text;
                }
            }
            else lbl_Input.Text += TemperatureButton.Text;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Input.Text = "Pick Value";
            cb_Input.Items.Add("C");
            cb_Input.Items.Add("F");
            cb_Input.Items.Add("K");

            cb_Output.Text = "Pick Value";
            cb_Output.Items.Add("C");
            cb_Output.Items.Add("F");
            cb_Output.Items.Add("K");

        }

        /// <summary>
        /// Event handler for the Convert button click.
        /// </summary>
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double inputValue;

            // Validate that the input is a number
            if (!double.TryParse(lbl_Input.Text, out inputValue))
            {
                MessageBox.Show("Please enter a valid number for temperature.", "Input Error");
                return;
            }

            // Perform conversion
            string inputUnit = cb_Input.Text;
            string outputUnit = cb_Output.Text;

            if (inputUnit == outputUnit)
            {
                lbl_Output.Text = inputValue.ToString("F2"); // No conversion needed
                return;
            }

            double result = ConvertTemperature(inputValue, inputUnit, outputUnit);
            lbl_Output.Text = result.ToString("F2"); // Display result with 2 decimal places
        }

        /// <summary>
        /// Converts the temperature from one unit to another.
        /// </summary>
        private double ConvertTemperature(double value, string inputUnit, string outputUnit)
        {
            double tempInCelsius = value;

            // Convert input value to Celsius as a common base
            switch (inputUnit)
            {
                case "F":
                    tempInCelsius = (value - 32) * 5 / 9;
                    break;
                case "K":
                    tempInCelsius = value - 273.15;
                    break;
            }

            // Convert Celsius to the desired output unit
            switch (outputUnit)
            {
                case "F":
                    return (tempInCelsius * 9 / 5) + 32;
                case "K":
                    return tempInCelsius + 273.15;
                default: // Return Celsius directly
                    return tempInCelsius;
            }
        }
    }
}
