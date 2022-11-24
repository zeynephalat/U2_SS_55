using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS_55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boykilo;
            boykilo = Convert.ToDouble(textBox1.Text);
            if (boykilo>25 && boykilo <40)
            {
                MessageBox.Show("zayıf");
            }
            else if (boykilo >50 && boykilo <70)
            {
                MessageBox.Show("normal");
            }
            else
            {
                MessageBox.Show("kilolu");
            }
        }
    }
}
