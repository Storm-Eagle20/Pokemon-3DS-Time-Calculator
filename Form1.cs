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
        public static readonly string[,] generation = { { "6", "7" } };

        public int realtime = -1;

        bool wasExecuted;

        public double targetframe;

        public static int Startingframe;

        public int framemin;
        public int framemax;

        public string RealTime => framemin == framemax ? "-" : Convert2timestr((framemin + 2 - Startingframe) / 60.0) + " ~ " + Convert2timestr((framemax - Startingframe) / 60.0);

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
                fidgetCheckBox.Checked = false;
                fidgetCheckBox.Enabled = false;
                }
            if (gen6RadioButton.Checked == false)
                {
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
                npcCount1.Visible = false;
                oldGenLabel.Visible = true;
                }
            if (oldGenRadioButton.Checked == false)
                {
                oldGenLabel.Visible = false;
                npcCount1.Visible = true;
                calculateButton.Enabled = true;
                }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Gen 7 starting frame is 478.
            if (gen7RadioButton.Checked == true && startingFrameBox.Value < 478)
            {
                startingFrameBox.Value = 478;
            }
        }
        private void targetFrameBox_ValueChanged(object sender, EventArgs e)
        {
            if (targetFrameBox.Value >= 100000000 && wasExecuted == false)
                {
                popupWindow popupWindow = new popupWindow();
                popupWindow.ShowDialog();

                wasExecuted = true;
                }
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
