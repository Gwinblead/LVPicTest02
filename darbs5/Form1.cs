using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace darbs5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double Y1(double x) { return x * 5/18; }
        public static double Y2(double x) { return x * 5/18; }

        public delegate double DY(double x);

        public DY[] Y = new DY[2] { Y1, Y2 };

        private void DoTable(DY y)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(((RadioButton)sender).Tag);

        }
    }
}
