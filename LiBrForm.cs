using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiBr_Refrigerator_Design
{
    public partial class LiBrForm : Form
    {
        Function myFunction = new Function();
        public LiBrForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_t.Text == string.Empty |
                textBox_x.Text == string.Empty
                )
            {
                NoInputMessage();
            }
            else
            {

                double Pr, mu, lambda, Cp, t, x;
                t = double.Parse(textBox_t.Text);
                x = double.Parse(textBox_x.Text);
                mu = myFunction.LiBr_mu2(t, x);
                Cp = myFunction.LiBr_Cp(t, x);
                lambda = myFunction.Libr_Lambda(t, x);
                Pr = Cp * mu / lambda;
                textBox_cp.Text = Cp.ToString();
                textBox_lambda.Text = lambda.ToString();
                textBox_mu.Text = mu.ToString();
                textBox_Pr.Text = Pr.ToString();

            }
        }

        private void NoInputMessage()
        {
            string Message = "请输入完整数据";
            string Caption = "提示";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(Message, Caption, buttons, icon);

        }
        //输入框只能输入数字0-9和退格以及小数点和delete。
        private void OnlyNumbles(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back | e.KeyChar == (char)Keys.Delete)  // 检查输入的字符是否退格，delete
            {
                e.Handled = false;//处理输入
                if (e.KeyChar == '.' && (((System.Windows.Forms.TextBox)sender).Text.IndexOf(".") != -1 | ((System.Windows.Forms.TextBox)sender).Text.Length == 0))
                //判断输入框已经有小数点或是为空
                {
                    e.Handled = true;//符合条件，屏蔽输入
                }
            }
            else
            {
                // 检查输入的字符是否为数字（0-9）
                char[] digits = e.KeyChar.ToString().ToCharArray();
                foreach (char digit in digits)
                {
                    if (!Char.IsDigit(digit))
                    {
                        e.Handled = true; // 不是数字，不处理输入
                        break;
                    }
                    e.Handled = false; // 是数字，处理输入
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                button2.Text = "置于顶层";
            }
            else
            {
                this.TopMost = true;
                button2.Text = "取消顶层";
            }
        }
    }
}
