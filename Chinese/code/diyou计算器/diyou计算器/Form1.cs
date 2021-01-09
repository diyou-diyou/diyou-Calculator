using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyou计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zuz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作者：diyou（sotl工作室）\n注：本项目只有工作室diyou开发。","作者",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void lj1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lj1.LinkVisited = false;
            System.Diagnostics.Process.Start("https://github.com/diyou-diyou/diyou-Calculator");
        }

        private void jia_Click(object sender, EventArgs e)
        {   
            wd.Text = "+";
            if (su1.Text == ""||su2.Text=="")
            {
                MessageBox.Show("输入不完整！\n请补充数字！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                double a = Convert.ToDouble(su2.Text);
                double b = Convert.ToDouble(su1.Text);
                jg.Text =  (a+b).ToString();
            }
        }

        private void jian_Click(object sender, EventArgs e)
        {
            wd.Text = "-";
            if (su1.Text == "" || su2.Text == "")
            {
                MessageBox.Show("输入不完整！\n请补充数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double a = Convert.ToDouble(su2.Text);
                double b = Convert.ToDouble(su1.Text);
                jg.Text = (b-a).ToString();
            }
        }

        private void cheng_Click(object sender, EventArgs e)
        {
            wd.Text = "*";
            if (su1.Text == "" || su2.Text == "")
            {
                MessageBox.Show("输入不完整！\n请补充数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double a = Convert.ToDouble(su2.Text);
                double b = Convert.ToDouble(su1.Text);
                jg.Text = (a * b).ToString();
            }
        }

        private void chu_Click(object sender, EventArgs e)
        {
            wd.Text = "/";
            if (su1.Text == "" || su2.Text == "")
            {
                MessageBox.Show("输入不完整！\n请补充数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double a = Convert.ToDouble(su2.Text);
                double b = Convert.ToDouble(su1.Text);
                jg.Text = (b/a).ToString();
            }
        }

        private void yu_Click(object sender, EventArgs e)
        {
            wd.Text = "取余";
            if (su1.Text == "" || su2.Text == "")
            {
                MessageBox.Show("输入不完整！\n请补充数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double a = Convert.ToDouble(su1.Text);
                double b = Convert.ToDouble(su2.Text);
                jg.Text = (a % b).ToString();
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            wd.Text = "⊕";
            if (su1.Text == "" || su2.Text == "")
            {
                MessageBox.Show("输入不完整！\n请补充数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = (int)Convert.ToDouble(su1.Text);
                int b = (int)Convert.ToDouble(su2.Text);
                jg.Text = (a^b).ToString();
            }
        }

        private void ayh_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://baike.baidu.com/item/%E5%BC%82%E6%88%96");
        }

        private void s1_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 1;
            }
            else
            {
                su2.Text += 1;
            }
        }

        private void s2_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 2;
            }
            else
            {
                su2.Text += 2;
            }
        }

        private void s3_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 3;
            }
            else
            {
                su2.Text += 3;
            }
        }

        private void s4_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 4;
            }
            else
            {
                su2.Text += 4;
            }
        }

        private void s5_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 5;
            }
            else
            {
                su2.Text += 5;
            }
        }

        private void s6_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 6;
            }
            else
            {
                su2.Text += 6;
            }
        }

        private void s7_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 7;
            }
            else
            {
                su2.Text += 7;
            }
        }

        private void s8_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 8;
            }
            else
            {
                su2.Text += 8;
            }
        }

        private void s9_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 9;
            }
            else
            {
                su2.Text += 9;
            }
        }

        private void s0_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += 0;
            }
            else
            {
                su2.Text += 0;
            }
        }

        private void tiuge_Click(object sender, EventArgs e)
        {
            string s;
            if (to1.Checked)
            {   
                s = su1.Text;
                if(Encoding.Default.GetByteCount(s)!=0)
                su1.Text=s.Substring(0, s.Length - 1);
            }
            else
            {
                s = su2.Text;
                if (Encoding.Default.GetByteCount(s) != 0)
                    su2.Text = s.Substring(0, s.Length - 1);
            }
        }

        private void dian_Click(object sender, EventArgs e)
        {
            if (to1.Checked)
            {
                su1.Text += '.';
            }
            else
            {
                su2.Text += '.';
            }
        }
    }
}
