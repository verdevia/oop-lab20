using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(x1TextBox.Text);
                double y1 = double.Parse(y1TextBox.Text);
                double A = double.Parse(ATextBox.Text);
                double B = double.Parse(BTextBox.Text);
                double C = double.Parse(CTextBox.Text);

                double distance = DistanceFromPointToLine(x1, y1, A, B, C);

                resultLabel.Text = "Відстань: " + distance.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть числові значення у всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private double DistanceFromPointToLine(double x1, double y1, double A, double B, double C)
        {
            double numerator = Math.Abs(A * x1 + B * y1 + C);
            double denominator = Math.Sqrt(A * A + B * B);
            double distance = numerator / denominator;
            return distance;
        }

    }
}
