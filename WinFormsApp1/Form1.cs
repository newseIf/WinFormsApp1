using System.Linq.Expressions;
using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, я помогу быстро посчитать нужные тебе примеры!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")

            {
                if (dn2 == 0)
                {
                    MessageBox.Show("На ноль делить нельзя","Вход");
                }
                res = dn1 / dn2;
            }
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res  = MessageBox.Show("Завершить работу программу?", "Выход", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            { e.Cancel = false; }
            if (res == DialogResult.No)
            { e.Cancel = true; }

        }
    }
}
