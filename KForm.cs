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
    public partial class KForm : Form
    {
        Function myFunction = new Function();
        public KForm()
        {
            InitializeComponent();
            comboBox_k_model.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_a0.Text == string.Empty |
                textBox_ai.Text == string.Empty |
                textBox_lambda.Text == string.Empty
                )
            {
                NoInputMessage();
            }
            else
            {
                double ki, k0;
                double ri, r0, ai, a0, lambda,d0,di;
                ri = double.Parse(textBox_ri.Text);
                r0 = double.Parse(textBox_r0.Text);
                ai = double.Parse(textBox_ai.Text);
                a0 = double.Parse(textBox_a0.Text);
                di = double.Parse(textBox_di.Text);
                d0 = double.Parse(textBox_d0.Text);
                lambda = double.Parse(textBox_lambda.Text);

                ki = myFunction.K_in(a0,ai,r0,ri,d0,di,lambda);
                k0 = myFunction.K_out(a0, ai, r0, ri, d0, di,lambda);
                
                textBox_k.Text = myFunction.average_K(ki,k0,d0,di,lambda,comboBox_k_model.SelectedIndex).ToString();
                        
                
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
    }
}
