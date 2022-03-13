using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FarenheitButton_CheckedChanged(object sender, EventArgs e)
        {
            InputLabel.Text = "Celsius:";
            OutputLabel.Text = "Farenheit:";
        }

        private void CelsiusButton_CheckedChanged(object sender, EventArgs e)
        {
            InputLabel.Text = "Farenheit:";
            OutputLabel.Text = "Celsius:";
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // Input cannot be left empty
            if (InputNumericUpDown.Text == "")
            {
                // Display the error message
                ErrorToolTip.Show("Input cannot be left empty!", InputNumericUpDown);
                // Avoid calculating if input is empty
                return;
            }

            // Valid input, do the conversion

            // Grab input from the control
            double input = (double)InputNumericUpDown.Value;
            double result;  // Result of the calculation

            // Decide which calculation based on the radio button selection
            if (CelsiusButton.Checked)  // Convert to Celsius
                result = (input - 32) * 5.0/9.0;    // (input - 32) * (5 / 9);
            else    // Convert to Farenheit
                result = (input * 9.0/5.0) + 32;    // (input * (9 / 5)) + 32;

            // Show the result format formatting to one decimal place
            ResultTextBox.Text = string.Format("{0:0.0}", result);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Reset form to the default state
            InputNumericUpDown.Value = 0;    // Reset input
            ResultTextBox.Text = "";        // Reset output
            CelsiusButton.Checked = true;   // Reset selection to celsius



        }
    }
}
