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
    public partial class TinhToan : Form
    {
        public TinhToan()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            Calculation c = new Calculator.Calculation(a, b);
            txtKetQua.Text = c.Execute("+").ToString();
            //if (txtSoA.Text!=String.Empty)

            //if (txtSoA.Text!=String.Empty && txtSoB.Text!=String.Empty)

            //{
            //    double a = double.Parse(txtSoA.Text);
            //    double b = double.Parse(txtSoB.Text);
            //    double c = a + b;
            //    txtKetQua.Text = c.ToString();
            //}

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double c = a - b;
            txtKetQua.Text = c.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double c = a * b;
            txtKetQua.Text = c.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double c = a / b;
            txtKetQua.Text = c.ToString();
        }
    }
    }

