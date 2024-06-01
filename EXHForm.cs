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
        bool inputBool = false;
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

        public void inputCheck()
        {

            foreach (Control control in panel1.Controls)
            {
                //遍历所有TextBox...

                if (control is TextBox && control.Tag != null)
                {

                    if (control.Tag.ToString() == "input")
                    {

                        if (control.Text == string.Empty)
                        {
                            inputBool = true;
                        }
                    }

                }

            }
            foreach (Control control in panel3.Controls)
            {
                //遍历所有TextBox...

                if (control is TextBox && control.Tag != null)
                {

                    if (control.Tag.ToString() == "input")
                    {

                        if (control.Text == string.Empty)
                        {
                            inputBool = true;
                        }
                    }

                }

            }



        }


        private void button1_Click(object sender, EventArgs e)
        {

            inputCheck();
            if (inputBool)
            {

                NoInputMessage();
                inputBool = false;
            }
            else
            {
                //先按假定的传热系数和管子数迭代到充分管子数，再从充分的管子数开始迭代到正确的传热系数
                bool first_conculate = true;
                double mess = double.Parse(textBox_first_K.Text);

                double k, a, l, n, speed, a0, ai, k0, ki, d0, di, r0, ri, t1, t2, ta2, ta1, tb1, tb2,m, flu_qv, G, Di, phi, q_exh, tube_lambda, mu_xi, mu_nong, lambda_xi, lambda_nong, Pr_xi, Pr_nong, h, Nb, ls, s, Cp_xi, Cp_nong, x_xi, x_nong, b3;

                d0 = double.Parse(textBox_d0.Text);
                di = double.Parse(textBox_di.Text);
                r0 = double.Parse(textBox_r0.Text);
                ri = double.Parse(textBox_ri.Text);
                t1 = double.Parse(textBox_t1.Text);
                t2 = double.Parse(textBox_t2.Text);
                ta1 = double.Parse(textBox_ta1.Text);
                ta2 = double.Parse(textBox_ta2.Text);
                tb1 = double.Parse(textBox_tb1.Text);
                tb2= double.Parse(textBox_tb2.Text);
                tube_lambda = double.Parse(textBox_tube_lambda.Text);
                phi = double.Parse(textBox_phi.Text);
                q_exh = double.Parse(textBox_gh_q.Text);
                flu_qv = double.Parse(textBox_flu_qv.Text);
                G = double.Parse(textBox_G.Text);
                l = double.Parse(textBox_tube_length.Text);
                m = double.Parse(textBox_m.Text);
                h = double.Parse(textBox_h.Text);
                Nb = double.Parse(textBox_Nb.Text);
                s = double.Parse(textBox_s.Text);
                ls = double.Parse(textBox_ls.Text);
                Di = double.Parse(textBox_const_Di.Text);
                x_xi = double.Parse(textBox_x_xi.Text);
                x_nong = double.Parse(textBox_x_nong.Text);
                b3 = double.Parse(textBox_b3.Text);

                /*double Dl;
                double theta;
                double Fc;
                double Awg;
                double Awt;
                double Ab;
                double Ac;
                double As;*/
                double omega; double[] results;
                string[] names = new string[] { "D1", "theta", "Fc", "Awg", "Awt", "Ab", "Ac", "As" };

                mu_nong = myFunction.LiBr_mu2((tb1 + tb2) / 2, x_nong * 100d);
                mu_xi = myFunction.LiBr_mu2((ta1 + ta2) / 2, x_xi * 100d);
                lambda_xi = myFunction.Libr_Lambda((ta1 + ta2) / 2, x_xi * 100d);
                lambda_nong = myFunction.Libr_Lambda((tb1 + tb2) / 2, x_nong * 100d); ;
                Cp_xi = myFunction.LiBr_Cp((ta1 + ta2) / 2, x_xi * 100d);
                Cp_nong = myFunction.LiBr_Cp((tb1 + tb2) / 2, x_nong * 100d);
                Pr_xi = Cp_xi * mu_xi / lambda_xi;
                Pr_nong = Cp_nong * mu_nong / lambda_nong;
                for (int i = 1000; i > 0; i--)
                {
                    a = myFunction.EXH_Area(q_exh, mess, t1, t2, ta1, ta2, tb1,tb2);
                    n = myFunction.tubeNumb(a, l, d0);
                    speed = myFunction.fluSpeed(flu_qv, n, m, di);
                    ai = double.Parse(textBox_ai_input.Text);//ai查表
                    results = myFunction.EX_Conculator(G, h, b3, Di, d0, ls, s, n);

                    omega = results[8];
                    a0 = myFunction.EX_a0(lambda_nong, mu_nong * 1E-3, Pr_nong, phi, omega, d0);
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

                        mess = (k + mess) / 2d;
                    }
                    else
                    {
                        textBox_k.Text = k.ToString();
                        textBox_a.Text = a.ToString();
                        textBox_v.Text = speed.ToString();
                        textBox_n.Text = n.ToString();
                        textBox_a0.Text = a0.ToString();
                        textBox_ai.Text = ai.ToString();
                        textBox_results.Text = null;
                        for (int j = 0; j < results.Length - 1; j++)
                        {
                            textBox_results.Text += names[j] + "：" + results[j].ToString() + "\r\n";
                        }
                        textBox_omega.Text = omega.ToString();
                        textBox_Pr.Text = Pr_nong.ToString();
                        textBox_Pr2.Text = Pr_xi.ToString();
                        textBox_Cp.Text = Cp_nong.ToString();
                        textBox_Cp2.Text = Cp_xi.ToString();
                        textBox_lambda.Text = lambda_nong.ToString();
                        textBox_lambda2.Text = lambda_xi.ToString();
                        textBox_mu.Text = mu_nong.ToString();
                        textBox_mu2.Text = mu_xi.ToString();
                        textBox_Dl.Text = results[0].ToString();
                        textBox_Fc.Text = results[2].ToString();
                        textBox_ang.Text = results[1].ToString();
                        double r = Di / 2;
                        textBox_phi.Text = ((r * r * (results[1] - Math.Sin(results[1])) / 2) / (Math.PI * r * r - (r * r * (results[1] - Math.Sin(results[1])) / 2))).ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form imageDetails = new imageForm();
            imageDetails.Show();
        }
    }
}
