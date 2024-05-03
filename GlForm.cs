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
    public partial class GlForm : Form
    {

        Function myFunction = new Function();
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

        public GlForm()
        {
            InitializeComponent();
            comboBox_k_model.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_di.Text == string.Empty |
                textBox_d0.Text == string.Empty |
                textBox_ri.Text == string.Empty |
                textBox_r0.Text == string.Empty |
                textBox_gh_q.Text == string.Empty |
                textBox_t3b.Text == string.Empty |
                textBox_t3.Text == string.Empty |
                textBox_t4.Text == string.Empty |
                textBox_tube_length.Text == string.Empty |
                textBox_flu_qv.Text == string.Empty |
                textBox_m.Text == string.Empty |
                textBox_middle.Text == string.Empty |
                textBox_tube_lambda.Text == string.Empty |
                textBox_pho_l.Text == string.Empty |
                textBox_pho_g.Text == string.Empty |
                textBox_cp.Text == string.Empty |
                textBox_mixed_m.Text == string.Empty |
                textBox_first_K.Text == string.Empty |
                textBox_a0_input.Text == string.Empty)
            {
                NoInputMessage();
            }
            else
            {
                bool first_conculate = true;
                double mess = double.Parse(textBox_first_K.Text);
                double k, a, l, n, speed, a0, ai, k0, ki, d0, di, r0, ri, t3, t4, t3b, m, flu_qv, mixed_m, q_gl, tube_lambda, pho_g, pho_l, mu, water_lambda, cp;
                d0 = double.Parse(textBox_d0.Text);
                di = double.Parse(textBox_di.Text);
                r0 = double.Parse(textBox_r0.Text);
                ri = double.Parse(textBox_ri.Text);
                t3 = double.Parse(textBox_t3.Text);
                t4 = double.Parse(textBox_t4.Text);
                t3b = double.Parse(textBox_t3b.Text);
                cp = double.Parse(textBox_cp.Text);
                tube_lambda = double.Parse(textBox_tube_lambda.Text);
                mixed_m = double.Parse(textBox_mixed_m.Text);
                pho_g = double.Parse(textBox_pho_g.Text);
                q_gl = double.Parse(textBox_gh_q.Text);
                flu_qv = double.Parse(textBox_flu_qv.Text);
                l = double.Parse(textBox_tube_length.Text);
                m = double.Parse(textBox_m.Text);
                mu = myFunction.L_H20_mu(t3);
                water_lambda = myFunction.L_H20_lambda(t3);
                pho_l = double.Parse(textBox_pho_l.Text);

                for (int i = 1000; i > 0; i--)
                {

                    a = myFunction.Gl_Area(q_gl, mess, t3b, t3, t4);
                    n = myFunction.tubeNumb(a, l, d0);
                    speed = myFunction.fluSpeed(flu_qv, n, m, di);
                    ai = myFunction.Gl_ai(water_lambda, mu, cp, di, mixed_m, pho_l, pho_g);
                    a0 = double.Parse(textBox_a0_input.Text);//a0查表
                    ki = myFunction.K_in(a0, ai, r0, ri, d0, di, tube_lambda);
                    k0 = myFunction.K_out(a0, ai, r0, ri, d0, di, tube_lambda);
                    k = myFunction.average_K(ki, k0, double.Parse(textBox_d0.Text), double.Parse(textBox_di.Text), double.Parse(textBox_tube_lambda.Text),comboBox_k_model.SelectedIndex);


                    if (first_conculate)
                    {
                        textBox_result_k.Text = mess.ToString();
                        textBox_result_a.Text = a.ToString();
                        textBox_result_v.Text = speed.ToString();
                        textBox_result_n.Text = n.ToString();
                        textBox_result_a0.Text = a0.ToString();
                        textBox_result_ai.Text = ai.ToString();
                        first_conculate = false;
                    }


                    if (Math.Abs(mess - k) > Math.Abs(double.Parse(textBox_middle.Text)))
                    {
                        Console.WriteLine("a:" + a + "     n:" + n + "      speed:" + speed + "    ai:" + ai + "     a0:" + a0 + "    ki:" + ki + "     k0:" + k0 + "     k:" + k);
                        mess = k;
                    }
                    else
                    {
                        textBox_k.Text = mess.ToString();
                        textBox_a.Text = a.ToString();
                        textBox_v.Text = speed.ToString();
                        textBox_n.Text = n.ToString();
                        textBox_mu.Text = mu.ToString();
                        textBox_lambda.Text = water_lambda.ToString();
                        textBox_a0.Text = a0.ToString();
                        textBox_ai.Text = ai.ToString();
                        if (!first_conculate)
                        {
                            first_conculate = true;
                        }
                        break;
                    }
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
