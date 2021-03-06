using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_RNG_Time_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Convert2timestr(double sec)
        {
            if (sec < 60)
                return sec.ToString("F3") + "s";
            int min = (int)Math.Floor(sec) / 60;
            sec -= 60 * min;
            if (min < 60)
                return min.ToString() + "m " + sec.ToString("00.000s");
            int hour = min / 60;
            min -= 60 * hour;
            return hour.ToString() + "h " + min.ToString("D2") + "m " + sec.ToString("00.0s");
        }

        public int realtime = -1;

        public static decimal targetFrame { get; internal set; }

        public static int startingFrame;

        bool wasExecuted;

        public decimal frameDifference;

        public static int starter;
        public static int target;

        public string gen7Result => starter == target ? "-" : Convert2timestr((starter + 2 - startingFrame) / 60.0) + " ~ " + Convert2timestr((target - startingFrame) / 60.0);

        private static int g6SecondsFraction;
        public static int g6Seconds;
        public static int g6Minutes;
        public static int g6Hours;
        public static int g6Days;

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label5_Click_2(object sender, EventArgs e)
        {
            oldGenLabel.Visible = false;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
        }
        private void gen6RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Disable fidget when Gen 6 is selected
            //to prevent any issues arising.
            if (gen6RadioButton.Checked == true)
            {
                npcCount.Enabled = false;
                fidgetCheckBox.Checked = false;
                fidgetCheckBox.Enabled = false;
            }
            if (gen6RadioButton.Checked == false)
            {
                numberofnpcsLabel.Visible = true;
                npcCount.Enabled = true;
                fidgetCheckBox.Enabled = true;
            }
        }

        private void oldGenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Disable calculator button when Older
            //Generations is selected. Switch NPC
            //dialogue with new dialogue explaining
            //the status of the older gens.
            if (oldGenRadioButton.Checked == true)
            {
                calculateButton.Enabled = false;
                npcCount.Enabled = false;
                npcCountLabel.Visible = false;
                oldGenLabel.Visible = true;
            }
            if (oldGenRadioButton.Checked == false)
            {
                calculateButton.Enabled = true;
                npcCountLabel.Visible = true;
                oldGenLabel.Visible = false;
                npcCount.Enabled = true;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //gen 7 starting frame is 478.
            if (gen7RadioButton.Checked == true && startingFrameBox.Value < 478)
            {
                startingFrameBox.Value = 478;
            }
        }
        private void targetFrameBox_ValueChanged(object sender, EventArgs e)
        {    
            frameDifference = targetFrameBox.Value - startingFrameBox.Value;

            //warn user if they select an exorbitantly high frame
            if (gen7RadioButton.Checked == false)
            {
                if (frameDifference >= 100000000 && wasExecuted == false)
                {
                    popupWindow popupWindow = new popupWindow();
                    popupWindow.ShowDialog();

                    wasExecuted = true;
                }
            }
            else if (gen7RadioButton.Checked == true)
            {
                if (frameDifference >= 99999028 && wasExecuted == false)
                {
                    popupWindow popupWindow = new popupWindow();
                    popupWindow.ShowDialog();

                    wasExecuted = true;
                }
            }
        }
        public void calculateButton_Click(object sender, EventArgs e)
        {
            starter = (int)startingFrameBox.Value;
            target = (int)targetFrameBox.Value;

            //turn frame difference into time for gen 6 use
            g6SecondsFraction = (int)targetFrameBox.Value - (int)startingFrameBox.Value / 120;
            g6Seconds = (int)Math.Ceiling((decimal)g6SecondsFraction);
            while (g6Seconds >= 60)
            {
                g6Minutes += 1;
                g6Seconds -= 60;
            }
            while (g6Minutes >= 60)
            {
                g6Hours += 1;
                g6Minutes -= 60;
            }
            while (g6Hours >= 24)
            {
                g6Days += 1;
                g6Hours -= 24;
            }

            void frames(ref int starter, ref decimal target)
            {
                Calculator.startingFrame = starter;
                Calculator.targetFrame = target;
            }

            if (targetFrameBox.Value < startingFrameBox.Value)
            {
                //failsafe
                popupWindow targetFrameLowerError = new popupWindow();
                targetFrameLowerError.ShowDialog();
            }
            else
            {
                if (gen6RadioButton.Checked == true)
                {
                    //more failsafes, inserted here in specific as it only applies to gen 6
                    if (targetFrameBox.Value % 2 == 1 && startingFrameBox.Value % 2 == 0)
                    {
                        popupWindow popupWindow2 = new popupWindow();
                        popupWindow2.ShowDialog();
                    }
                    else if (targetFrameBox.Value % 2 == 0 && startingFrameBox.Value % 2 == 1)
                    {
                        popupWindow popupWindow3 = new popupWindow();
                        popupWindow3.ShowDialog();
                    }
                    else if (g6Seconds > 0 && g6Minutes == 0 && g6Hours == 0 && g6Days == 0)
                    {
                        timeOutputBox.Text = "You will hit your target frame in: /n {0} seconds." + g6Seconds;
                    }
                    else if (g6Hours == 0 && g6Minutes > 0)
                    {
                        timeOutputBox.Text = "You will hit your target frame in: /n {0} minutes and {1} seconds." + g6Minutes + g6Seconds;
                    }
                    else if (g6Days == 0 && g6Hours > 0)
                    {
                        timeOutputBox.Text = "You will hit your target frame in: /n {0} hours, {1} minutes, and {2} seconds." + g6Hours + g6Minutes + g6Seconds;
                    }
                    else
                    {
                        timeOutputBox.Text = "You will hit your target frame in: /n {0} days, {1} hours, {2} minutes, amd {3} seconds" + g6Days + g6Hours + g6Minutes + g6Seconds;
                    }
                }
                else if (gen7RadioButton.Checked == true)
                {
                    timeOutputBox.Text = "You will hit your target frame in: /n {0}" + gen7Result;
                }
            }
        }
    }
}
