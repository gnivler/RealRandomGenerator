using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace RealRandomGenerator
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int maxRoll = 101;  // +1 for exclusive upper bound
        int numRolls = 1000;
        int randomCeiling = 100;
        List<int> numbers = new List<int>();
        List<int> badNumbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Go_click(object sender, EventArgs e)
        {
            ResetForm();
            for (int i = 0; i < numRolls; i++)
            {
                var badNumber = JustRNG();
                badNumbers.Add(badNumber);
                var number = GenerateRealRandom();
                numbers.Add(number);
            }

            double goodNum = numbers.Average();
            double badNum = badNumbers.Average();

            avg.Text = string.Format("{0:0.000}", goodNum);
            badAvg.Text = string.Format("{0:0.000}", badNum);
        }

        private void ResetForm()
        {
            avg.Text = "0";
            badAvg.Text = "0";
            lblDrops.Text = "0";
            lblMaxRolls.Text = numRolls.ToString();
            lblRAND_MAX.Text = randomCeiling.ToString();
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

        private void UpdateDrops()
        {
            int dropNum = Convert.ToInt32(lblDrops.Text.ToString());
            dropNum++;
            lblDrops.Text = dropNum.ToString();
            lblDrops.Update();
        }
    }
}
