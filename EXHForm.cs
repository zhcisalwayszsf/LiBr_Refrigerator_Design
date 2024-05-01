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
    public partial class EXHForm : Form
    {

        Function myFunction = new Function();
        public EXHForm()
        {
            InitializeComponent();
            comboBox_k_model.SelectedIndex = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox_d0.Text == string.Empty|
                textBox_di.Text == string.Empty|
                textBox_r0.Text == string.Empty|
                textBox_ri.Text == string.Empty|
                textBox_t10.Text == string.Empty |
                textBox_t12.Text == string.Empty |
                textBox_t2.Text == string.Empty |
                textBox_tw.Text == string.Empty |
                textBox_t9.Text == string.Empty |
                textBox_Pr.Text == string.Empty |
                textBox_phi.Text == string.Empty |
                textBox_tube_lambda.Text == string.Empty |
                textBox_gh_q.Text == string.Empty |
                textBox_flu_qv.Text == string.Empty |
                textBox_G.Text == string.Empty |
                textBox_tube_length.Text == string.Empty |
                textBox_lambda.Text == string.Empty |
                textBox_mu.Text == string.Empty |
                textBox_m.Text == string.Empty |
                textBox_n3.Text == string.Empty |
                textBox_n4.Text == string.Empty |
                textBox_s.Text == string.Empty |
                textBox_s1.Text == string.Empty |
                textBox_const_Di.Text == string.Empty)
            {
                NoInputMessage();
            }
            else
            {
                bool first_conculate = true;
                double mess = double.Parse(textBox_first_K.Text);
                double k, a, l, n, speed, a0, ai, k0, ki, d0, di, r0, ri, t10, t12, t2,tw,t9, m, flu_qv,G,Di, phi, q_exh, tube_lambda, mu, lambda, Pr,n3,n4,Nb,s1,s;
                d0 = double.Parse(textBox_d0.Text);
                di = double.Parse(textBox_di.Text);
                r0 = double.Parse(textBox_r0.Text);
                ri = double.Parse(textBox_ri.Text);
                t10 = double.Parse(textBox_t10.Text);
                t12 = double.Parse(textBox_t12.Text);
                t2 = double.Parse(textBox_t2.Text);
                tw = double.Parse(textBox_tw.Text);
                t9 = double.Parse(textBox_t9.Text);
                Pr = double.Parse(textBox_Pr.Text);
                tube_lambda = double.Parse(textBox_tube_lambda.Text);
                phi = double.Parse(textBox_phi.Text);
                q_exh = double.Parse(textBox_gh_q.Text);
                flu_qv = double.Parse(textBox_flu_qv.Text);
                G = double.Parse(textBox_G.Text);
                l = double.Parse(textBox_tube_length.Text);
                m = double.Parse(textBox_m.Text);
                mu = double.Parse(textBox_mu.Text); ;
                lambda = double.Parse(textBox_lambda.Text);
                n3 = double.Parse(textBox_n3.Text);
                n4 = double.Parse(textBox_n4.Text);
                Nb = double.Parse(textBox_Nb.Text);
                s = double.Parse(textBox_s.Text);
                s1 = double.Parse(textBox_s1.Text);
                Di = double.Parse(textBox_const_Di.Text);

                for (int i = 1000; i > 0; i--)
                {
                    a = myFunction.EXH_Area(q_exh,mess,t12,t10,t9,t2,tw);
                    n = myFunction.tubeNumb(a, l, d0);
                    speed = myFunction.fluSpeed(flu_qv, n, m, di);
                    ai = double.Parse(textBox_ai_input.Text);//ai查表
                    double omega = myFunction.EX_Omega(G,s1,s,Nb,Di,d0,n3,n4,phi);
                    a0 = myFunction.EX_a0(lambda,mu,Pr,phi,omega,d0);
                    ki = myFunction.K_in(a0, ai, r0, ri, d0, di, tube_lambda);
                    k0 = myFunction.K_out(a0, ai, r0, ri, d0, di, tube_lambda);
                    k = myFunction.average_K(ki, k0, double.Parse(textBox_d0.Text), double.Parse(textBox_di.Text), double.Parse(textBox_tube_lambda.Text), comboBox_k_model.SelectedIndex);
                  
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
                        
                        mess = k;
                    }
                    else
                    {
                        textBox_k.Text = mess.ToString();
                        textBox_a.Text = a.ToString();
                        textBox_v.Text = speed.ToString();
                        textBox_n.Text = n.ToString();
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
    }
}
