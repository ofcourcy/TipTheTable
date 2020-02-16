using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void update()
        {
            
            float bH = (float)(baselen.Value / 2);
            float bW = (float)(baselb.Value);
            float bX = (float)(baselen.Value);
            float tH = (float)(toplen.Value / 2);
            float tX = (float)(tH + bH);
            float L = tH - bH;
            float tW = (float)(toplb.Value/toplen.Value * baselen.Value);
            float topbalance = fulcrum(tW, L, L);
            float botbalance = fulcrum((float)(bW), bH, L);
            output.Text = (botbalance+topbalance).ToString();
        }
        private float fulcrum(float W, float X, float L)
        {
            float fulcrum = (W * X) / L;
            return fulcrum;
        }
            private void baselen_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void toplb_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
