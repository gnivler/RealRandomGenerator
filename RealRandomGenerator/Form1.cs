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
        int numRolls = 1000;
        int RAND_MAX = 15;
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

            for (int i = 0; i < numRolls; i++)
            {
                dotNetNumber = JustRNG();
                dotNetRNG.Add(dotNetNumber);
                myNumbers.Add(myNumber);
                myNumber = GenerateRealRandom();
            }

            double goodNum = myNumbers.Average();
            double badNum = dotNetRNG.Average();
            myAvg.Text = string.Format("{0:0.000}", goodNum);
            dotNetAvg.Text = string.Format("{0:0.000}", badNum);
        }

        private void ResetForm()
        {
            lblMaxRolls.Text = $"Need {numRolls} results!{Environment.NewLine}(Twice)";
            lblMaxRolls.Update();
            lblRollsDone.Text = numRolls.ToString();
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

        public int GenerateRealRandom()
        {
            r = 0;
            while (true)
            {
                r = rng.Next(1, highestRoll);
                IncrementRollLabel();
                if (r < (RAND_MAX - (RAND_MAX % r)))
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
