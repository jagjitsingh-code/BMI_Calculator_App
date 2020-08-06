using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator_App
{
    public partial class BMICalculator : Form
    {
        private bool _isImperial;

        public bool IsImperial
        { 
            get { return _isImperial; }
            set { _isImperial = value; }
        }

        public BMICalculator()
        {
            InitializeComponent();

            //Default unit system
            IsImperial = true;

            //Bind event listeners
            ImperialUnitsRadio.Click+= new EventHandler(RadioButtonChange);
            MetricUnitsRadio.Click += new EventHandler(RadioButtonChange);
            CalculateBMIButton.Click+= new EventHandler(CalculateBMIButton_Click);
            ResetAppButton.Click += new EventHandler(ResetApp);

            HeightTextbox.TextChanged += new EventHandler(ValidateInputTextbox);
            WeightTextbox.TextChanged += new EventHandler(ValidateInputTextbox);
        }

        //Validate Input - If non-numeric character is detected, it is deleted and the cursor is moved to the end of textbox
        private void ValidateInputTextbox(object sender, System.EventArgs e)
        {
            TextBox textbox=(TextBox) sender;

            if(!float.TryParse(textbox.Text,out _))
            {
                if (textbox.Text.Length > 0)
                    textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1, 1);
                else
                    textbox.Text = "";

                textbox.SelectionStart = textbox.Text.Length;
                textbox.SelectionLength = 0;
            }   
        }

            //Calculate BMI button click handler
        private void CalculateBMIButton_Click(object sender, System.EventArgs e)
        {
            try{
                float height = float.Parse(HeightTextbox.Text);
                float weight = float.Parse(WeightTextbox.Text);
                bool isImperial = true;

                if (MetricUnitsRadio.Checked)
                    isImperial = false;

                CalculateBMI(weight, height, isImperial);
            } catch(Exception error) {
                Console.WriteLine("Error: " + error);
            }
        }

        //Change unit system and update height and weight values accordingly
        private void RadioButtonChange(object sender, System.EventArgs e)
        {
            try
            {
                if (MetricUnitsRadio.Checked && IsImperial == true)
                {
                    IsImperial = false;
                    HeightLabel.Text = "My Height (m)";
                    WeightLabel.Text = "My Weight (kgs)";

                    HeightTextbox.Text = "" + Math.Round(float.Parse(HeightTextbox.Text) / 39.37, 1);
                    WeightTextbox.Text = "" + Math.Round(float.Parse(WeightTextbox.Text) / 2.205, 1);
                }
                else if (ImperialUnitsRadio.Checked && IsImperial == false)
                {
                    IsImperial = true;
                    HeightLabel.Text = "My Height (in)";
                    WeightLabel.Text = "My Weight (lbs)";

                    HeightTextbox.Text = "" + Math.Round(float.Parse(HeightTextbox.Text) * 39.37, 1);
                    WeightTextbox.Text = "" + Math.Round(float.Parse(WeightTextbox.Text) * 2.205, 1);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error: " + e);
            }

        }

        //Calculate BMI
        private float CalculateBMI(float weight, float height, Boolean isImperial)
        {
            float bmi, conversionFactor;
            conversionFactor = 703;

            bmi = (weight * 703) / (height * height);
            if (!IsImperial)
                bmi/= conversionFactor;

            OutputBMITextbox.Text = "Body Mass Index: "+(int)bmi+"\nResult: "+BMIResult(bmi);
            OutputBMIProgressBar.Value = (int)bmi;

            return bmi;
        }

        //Calculate BMI result string based on BMI
        private string BMIResult(float bmi)
        {
            string result="";

            if (bmi < 18.5)
                result = "Underweight";
            else if (bmi >= 18.5 && bmi < 24.9)
                result = "Normal";
            else if (bmi >= 25 && bmi < 29.9)
                result = "Overweight";
            else if (bmi >= 30)
                result = "Obese";

            return result;
        }

        //Reset User interface
        private void ResetApp(object sender, System.EventArgs e)
        {
            HeightTextbox.Text = "";
            WeightTextbox.Text = "";

            ImperialUnitsRadio.Checked = true;
            IsImperial = true;

            OutputBMITextbox.Text="";
            OutputBMIProgressBar.Value=0;
        }
    }
}
