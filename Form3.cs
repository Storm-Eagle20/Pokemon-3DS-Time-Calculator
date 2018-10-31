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
    public partial class popupWindow2 : Form
    {
        public popupWindow2()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
