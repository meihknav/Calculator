using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
           

            int a = int.Parse(txtsoa.Text);
            int b = int.Parse(txtsob.Text);
            Calculation cal = new Calculation(a, b);
            txtKq.Text = cal.Execute("+").ToString();

            //if (txtsoa.Text != String.Empty && txtsob.Text != String.Empty)
            //{
            //    double a = double.Parse(txtsoa.Text);
            //    double b = double.Parse(txtsob.Text);
            //    double c = a + b;
            //    txtKq.Text = c.ToString(); 
            //}
            //else
            //{
            //    txtKq.Text = "Khong tinh";
            //}
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtsob.Text != String.Empty)
            {
                double a = double.Parse(txtsoa.Text);
                double b = double.Parse(txtsob.Text);
                double c = a - b;
                txtKq.Text = c.ToString(); 
            }
            else
            {
                txtKq.Text = "Khong tinh";
            }
        }

    }
}
