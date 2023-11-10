using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG54310_Exercise_2
{
    public partial class ControlYUV : Form
    {
        public ControlYUV()
        {
            InitializeComponent();
        }

        public int Y { get; set; }
        public int U { get; set; }
        public int V { get; set; }
        public bool InvertColors { get; set; }

        private void ControlYUV_Load(object sender, EventArgs e)
        {
            Y = 100;
            U = 100;
            V = 100;
            InvertColors = false;
        }

        private void slider_Y_Scroll(object sender, EventArgs e)
        {
            Y = slider_Y.Value;
            lbl_Y_val.Text = Y.ToString() + "%";
        }

        private void slider_U_Scroll(object sender, EventArgs e)
        {
            U = slider_U.Value;
            lbl_U_val.Text = U.ToString() + "%";
        }

        private void slider_V_Scroll(object sender, EventArgs e)
        {
            V = slider_V.Value;
            lbl_V_val.Text = V.ToString() + "%";
        }

        private void chk_InvertColors_CheckedChanged(object sender, EventArgs e)
        {
            InvertColors = chk_InvertColors.Checked;
        }
    }
}
