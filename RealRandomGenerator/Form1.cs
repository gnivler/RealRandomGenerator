using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace RealRandomGenerator
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int maxRoll = 101;  // +1 for exclusive upper bound
        int numRolls = 200;
        int randomCeiling = int.MaxValue;
        List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        public void Go_click(object sender, EventArgs e)
        {
            ResetForm();
            for (int i = 0; i < numRolls; i++)
            {
                var number = JustRNG();
                //var number = GenerateRealRandom();
                numbers.Add(number);
                textBox1.Text = $"{textBox1.Text}{number.ToString()}{Environment.NewLine}";
                if (isNewMin(number))
                {
                    min.Text = number.ToString();
                    min.Update();
                }
                if (isNewMax(number))
                {
                    max.Text = number.ToString();
                    max.Update();
                }
            }
            avg.Text = numbers.Average().ToString();
        }

        private void ResetForm()
        {
            textBox1.Clear();
            numbers.Clear();
            min.Text = "0";
            max.Text = "0";
            avg.Text = "0";
            minValue = int.MinValue;
            maxValue = int.MaxValue;
        }

        public int JustRNG()
        {
            return rng.Next(1, maxRoll);
        }

        public int GenerateRealRandom()
        {
            int r = 0;
            while (true)
            {
                r = rng.Next(1, maxRoll);
                if (r < (randomCeiling) - (randomCeiling % r))
                {
                    return r % maxRoll;
                }
                else
                {
                    UpdateDrops();
                }
            }
        }

        public bool isNewMin(int number)
        {
            if (number < minValue)
            {
                minValue = number;
                return true;
            }
            return false;
        }

        public bool isNewMax(int number)
        {
            if (number > maxValue)
            {
                maxValue = number;
                return true;
            }
            return false;
        }

        private void UpdateDrops()
        {
            int dropNum = Convert.ToInt32(drops.Text.ToString());
            dropNum++;
            drops.Text = dropNum.ToString();
            drops.Update();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
