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
    public partial class TubeForm : Form
    {
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
        public TubeForm()
        {
            InitializeComponent();
        }
        int[] T_Angel = {1,7,19,37,61,91,127,169,217,271,331,397,469,547, 631,721,817,919,1027,1141,1261,1387,1519,1657, 1801,
                        1951,2107,2269,2437,2611,2791,2977,3169,3367, 3571,3781,3997,4219,4447,4681,4921,5167,5419,5677, 5941,6211,6487,6769 };

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_tn.Text == string.Empty)
            {
                NoInputMessage();
            }
            else
            {
                textBox2.Text = null;
                double tube_numb = double.Parse(textBox_tn.Text);
                int avilible_tube_numb = 1;
                int m = 0, n = 0;
                for (int i = 0; i < T_Angel.Length; i++)
                {
                    if (T_Angel[i] > tube_numb)
                    {
                        avilible_tube_numb = T_Angel[i - 1];
                        m = i;
                        n = i - 1;
                        break;
                    }
                }
                label2.Text = m.ToString() + "层" + avilible_tube_numb.ToString() + "根";
                //最外层一边m个（带重复）外圈共6*(m-1)个
                double x = 3 * n - 2;//列数
                double y = 2 * n - 1;//行数
                for (int i = 0; i <= y / 2; i++)
                {
                    textBox2.Text += " ";
                    for (int j = 0; j < (x - m) / 2 - i; j++)
                    {
                        textBox2.Text += " ";
                    }
                    for (int j = 0; j < m + i; j++)
                    {
                        textBox2.Text += " O";
                    }

                    textBox2.Text += "\r\n";
                }


                if ((x - m) % 2 != 0)
                {
                    for (int i = 0; i < y + 2; i++)
                    {
                        textBox2.Text += " O";
                    }
                    textBox2.Text += "\r\n";
                }
                else
                { }

            }
        }
    }
}
