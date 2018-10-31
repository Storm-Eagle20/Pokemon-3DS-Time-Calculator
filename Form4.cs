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
    public partial class popupWindow3 : Form
    {
        public popupWindow3()
        {
            InitializeComponent();
        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
