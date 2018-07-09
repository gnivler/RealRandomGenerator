using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace RealRandomGenerator
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int highestRoll = 100;
        int numIterations = 10000;
        int RAND_MAX = Int16.MaxValue;
        int rollIterations;
        int dropNum;
        int r;
        int dotNetNumber;
        int myNumber;
        List<int> myNumbers = new List<int>();
        List<int> dotNetRNG = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Go_click(object sender, EventArgs e)
        {
            ResetForm();

            for (int i = 0; i < numIterations; i++)
            {
                dotNetNumber = JustRNG();
                myNumber = GenerateRealRandom(highestRoll);
                dotNetRNG.Add(dotNetNumber);
                myNumbers.Add(myNumber);
                UpdateAverages();
            }
        }

        private void UpdateAverages()
        {
            double goodNum = myNumbers.Average();
            double badNum = dotNetRNG.Average();
            myAvg.Text = string.Format("{0:0.000}", goodNum);
            dotNetAvg.Text = string.Format("{0:0.000}", badNum);
            myAvg.Update();
            dotNetAvg.Update();
        }

        private void ResetForm()
        {
            lblMaxRolls.Text = $"Need {numIterations} results!{Environment.NewLine}(Twice)";
            lblMaxRolls.Update();
            lblRollsDone.Text = numIterations.ToString();
            lblRAND_MAX.Text = RAND_MAX.ToString();
            myAvg.Text = "0";
            dotNetAvg.Text = "0";
            lblDrops.Text = "0";
            lblRolls.Text = "0";
            myNumbers.Clear();
            dotNetRNG.Clear();
            dotNetNumber = 0;
            myNumber = 0;
            r = 0;
            dropNum = 0;
        }

        public int JustRNG()
        {
            IncrementRollLabel();
            return rng.Next(1, highestRoll + 1);
        }

        private void IncrementRollLabel()
        {
            rollIterations = (Convert.ToInt32(lblRollsDone.Text) + 1);
            lblRollsDone.Text = rollIterations.ToString();
            lblRollsDone.Update();
        }

        public int GenerateRealRandom(int highestRoll)
        {
            while (true)
            {
                r = rng.Next(1, highestRoll + 1);  // exclusive upper bound
                IncrementRollLabel();
                if (r < (RAND_MAX - (RAND_MAX % highestRoll)))
                {
                    return r % highestRoll;
                }
                else
                {
                    UpdateDrops();
                }
            }
        }
        
        private void UpdateDrops()
        {
            dropNum = Convert.ToInt32(lblDrops.Text.ToString());
            dropNum++;
            lblDrops.Text = dropNum.ToString();
            lblDrops.Update();
        }
    }
}
