using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giải_Phương_Trình
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dar;
            dar = (MessageBox.Show("Bạn có muốn thoát ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (dar == DialogResult.Yes)
            Application.Exit();
        }

        private void giai_Click_1(object sender, EventArgs e)
        {
            int number;
            double kqptb1;
            double kqptb2, aa, bb, cc;
            double delta;
            double x2;

            if (ptb1.Checked)
            {
                if (int.TryParse(a.Text, out number) && int.TryParse(b.Text, out number))
                {
                    aa = double.Parse(a.Text);
                    bb = double.Parse(b.Text);
                    kqptb1 = -(bb) / (aa);
                    pt.Text = "(" + a.Text + ")" + "X +" + " (" + b.Text + ")";
                    kq.Text = "Phương trình có nghiệm = " + kqptb1.ToString();
                }
                else
                    MessageBox.Show("Vui lòng nhập số!!!");
            }
            else
            {
                if (int.TryParse(a.Text, out number) && int.TryParse(b.Text, out number) && int.TryParse(c.Text, out number))
                {
                    aa = double.Parse(a.Text);
                    bb = double.Parse(b.Text);
                    cc = double.Parse(c.Text);
                    pt.Text = "(" + a.Text + ")" + "X^2 +" + " (" + b.Text + ")" + "X +" + " (" + c.Text + ")";
                    delta = (bb * bb) - (4 * aa * cc);
                    if (delta < 0)
                        kq.Text = "Phương trình vô nghiệm vì delta = " + delta + " < 0";
                    else if (delta == 0)
                    {
                        kqptb2 = (-bb) / (2 * aa);
                        kq.Text = "Phương trình có nghiệm kép x1 = x2 = " + kqptb2 + " và delta = " + delta;
                    }
                    else
                    {
                        kqptb2 = (((-bb) + Math.Sqrt(delta)) / (2 * aa));
                        x2 = (((-bb) - Math.Sqrt(delta)) / (2 * aa));
                        kq.Text = "Phương trình có 2 nghiệm : x1 = " + kqptb2 + ", x2 = " + x2 + " và delta = " + delta;
                    }

                }
                else
                    MessageBox.Show("Vui lòng nhập số!!!");
            }
        }

        private void ptb2_CheckedChanged_1(object sender, EventArgs e)
        {
            c.Enabled = true;
        }

        private void ptb1_CheckedChanged(object sender, EventArgs e)
        {
            c.Enabled = false;
        }
    }
}
