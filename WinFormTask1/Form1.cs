using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (double.TryParse(x.Text, out a) == false && double.TryParse(y.Text, out b) == false && double.TryParse(z.Text, out c) == false) {
                MessageBox.Show("Помилка введення значення x, y, z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(x.Text, out a) == false && double.TryParse(y.Text, out b) == false)
            {
                MessageBox.Show("Помилка введення значення x, y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(x.Text, out a) == false && double.TryParse(z.Text, out c) == false)
            {
                MessageBox.Show("Помилка введення значення x, z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(y.Text, out b) == false && double.TryParse(z.Text, out c) == false)
            {
                MessageBox.Show("Помилка введення значення y, z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(x.Text, out a) == false)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(y.Text, out b) == false)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(z.Text, out c) == false)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double r = (2 * Math.Cos(a * a) - 1 / 2.0) / (1 / 2.0 + Math.Sin(Math.Pow(b, 2 - c))) + c * c / (7 - c / 3);
            res.Text = r.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }
    }
}
