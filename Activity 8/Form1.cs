using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double FatCalories(double fat)
        {
            return fat * 9;
        }

        public double CarbCalories(double carbs)
        {
            return carbs * 4;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double fat, carbs, calories;
            if(double.TryParse(fatInput.Text, out fat) && double.TryParse(carbInput.Text, out carbs)) {
                calories = FatCalories(fat) + CarbCalories(carbs);
                MessageBox.Show("Your calorie intake is " + calories);
            } else
            {
                MessageBox.Show("Input Error");
            }
        }
    }
}
