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
    
    public partial class EvaporatorForm : Form
    {
        Function myFunction =new Function();

        Random random = new System.Random();
        Random random2 = new System.Random();

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

        public EvaporatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(random==random2)
            {
                NoInputMessage();
            }
            else
            {
                double k, a, l, n, speed, a0, ai, k0, ki, d0, di, r0, ri, tc1, tc2, t0, m, flu_qv, t_inTube, q_0, tube_lambda, C, Pr,nu,water_lambda,delta_x,omega;
                d0 = double.Parse(textBox_d0.Text);
                di = double.Parse(textBox_di.Text);
                r0 = double.Parse(textBox_r0.Text);
                ri = double.Parse(textBox_ri.Text);
                tc1 = double.Parse(textBox_tc1.Text);
                tc2 = double.Parse(textBox_tc2.Text);
                t0 = double.Parse(textBox_t0.Text);
                omega = double.Parse(textBox_omega.Text);
                tube_lambda = double.Parse(textBox_tube_lambda.Text);
                t_inTube = double.Parse(textBox_t_inTube.Text);
                delta_x = double.Parse(textBox_delta_x.Text);
                q_0 = double.Parse(textBox_absorb_q.Text);
                flu_qv = double.Parse(textBox_flu_qv.Text);
                l = double.Parse(textBox_tube_length.Text);
                m = double.Parse(textBox_m.Text);
                double mess = double.Parse(textBox_first_K.Text);
                nu = myFunction.L_H2O_nu(t0);
                water_lambda = myFunction.L_H20_lambda(t0);
                Pr = myFunction.L_H2O_Pr(t0);
                C = double.Parse(textBox_evaporator_c.Text);

                for (int i = 1000; i > 0; i--)
                {
                    a = myFunction.Evaporator_Area(q_0, mess, t0, tc1, tc2);
                    n = myFunction.tubeNumb(a, l, d0);
                    speed = myFunction.fluSpeed(flu_qv, n, m, di);
                    ai = myFunction.Evaporator_ai(speed, di, t_inTube);
                    a0 = myFunction.Evaporator_a0(C, Pr, omega, l, delta_x, nu, water_lambda);
                    ki = myFunction.K_in(a0, ai, r0, ri, d0, di, tube_lambda);
                    k0 = myFunction.K_out(a0, ai, r0, ri, d0, di, tube_lambda);
                    k = myFunction.average_K2(ki, k0);

                    if (Math.Abs(mess - k) > 0.1)
                    {
                        Console.WriteLine("a:" + a + "     n:" + n + "      speed:" + speed + "    ai:" + ai + "     a0:" + a0 + "    ki:" + ki + "     k0:" + k0 + "     k:" + k);
                        mess = k;
                    }
                    else
                    {
                        textBox_result.Text = mess.ToString();
                        textBox_area.Text = a.ToString();
                        break;
                    }
                }
            }
        }
    }
}
