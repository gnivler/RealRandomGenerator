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
        int numIterations = 50000000;
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
            ResetForm();
        }

        public void Go_click(object sender, EventArgs e)
        {
            for (int i = 0; i < numIterations; i++)
            {
                dotNetNumber = JustRNG();
                myNumber = GenerateRealRandom(highestRoll);
                dotNetRNG.Add(dotNetNumber);
                myNumbers.Add(myNumber);
                UpdateAverages();
            }

            double absDotNetAvgMedian = Math.Abs(Convert.ToDouble(dotNetAvg.Text) - highestRoll / 2);
            double absMyAvgMedian = Math.Abs(Convert.ToDouble(myAvg.Text) - highestRoll / 2);

            ShowWinner(absDotNetAvgMedian, absMyAvgMedian);
        }

        private void ShowWinner(double absDotNetAvgMedian, double absMyAvgMedian)
        {
            if (absDotNetAvgMedian == absMyAvgMedian)
            {
                dotNetAvg.Text = $"Same results";
                myAvg.Text = $"Same results";
            }
            else if (absMyAvgMedian < absDotNetAvgMedian)
            {
                myAvg.Text = $"{myAvg.Text} is closest";
            }
            else
            {
                dotNetAvg.Text = $"{dotNetAvg.Text} is closest";
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
            myNumbers.Clear();
            dotNetRNG.Clear();
            myAvg.Text = "0";
            dotNetAvg.Text = "0";
            lblDrops.Text = "0";
            lblhighestRoll.Text = highestRoll.ToString();
            dotNetNumber = 0;
            myNumber = 0;
            r = 0;
            dropNum = 0;
            lblnumIterations.Text = $"Need {numIterations} results!{Environment.NewLine}(Twice)";
            lblRollsDone.Text = "0";
            lblRAND_MAX.Text = RAND_MAX.ToString();
            lblnumIterations.Update();
            lblRollsDone.Update();
            lblRAND_MAX.Update();
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
                if (r < (RAND_MAX - (RAND_MAX % highestRoll +1)))
                {
                    return r % highestRoll +1;
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
