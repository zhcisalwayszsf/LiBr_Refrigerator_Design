using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LiBr_Refrigerator_Design
{
    public partial class CondenserForm : Form
    {
        Function myFunction = new Function();
        public double g = 9.8d;
        public double pho = 999d;

        //确保输入
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



        public CondenserForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_di.Text == string.Empty |
                textBox_d0.Text == string.Empty |
                textBox_ri.Text == string.Empty |
                textBox_r0.Text == string.Empty |
                textBox_condenser_q.Text == string.Empty |
                textBox_tk.Text == string.Empty |
                textBox_tw1.Text == string.Empty |
                textBox_tw2.Text == string.Empty |
                textBox_tube_length.Text == string.Empty |
                textBox_flu_qv.Text == string.Empty |
                textBox_m.Text == string.Empty |
                textBox_h2o_r.Text == string.Empty |
                textBox_tube_lambda.Text == string.Empty|
                textBox_middle.Text == string.Empty |
                textBox_first_K.Text == string.Empty)
            {
                NoInputMessage();
            }
            else
            {
                double mess = double.Parse(textBox_first_K.Text);
                bool first_conculate = true;

                for (int i = 1000; i > 0.1; i--)
                {


                    double a = myFunction.Condenser_Aera(double.Parse(textBox_condenser_q.Text), mess, double.Parse(textBox_tk.Text), double.Parse(textBox_tw1.Text), double.Parse(textBox_tw2.Text));
                    double n = myFunction.tubeNumb(a, double.Parse(textBox_tube_length.Text), double.Parse(textBox_d0.Text));
                    double speed = myFunction.fluSpeed(double.Parse(textBox_flu_qv.Text), n, double.Parse(textBox_m.Text), double.Parse(textBox_di.Text));
                    double ai = myFunction.Condenser_ai(double.Parse(textBox_tw1.Text), double.Parse(textBox_tw2.Text), speed, double.Parse(textBox_di.Text));
                    double a0 = myFunction.Condenser_a0(double.Parse(textBox_h2o_r.Text), g, pho, myFunction.L_H20_mu(double.Parse(textBox_tk.Text)), myFunction.L_H20_lambda(double.Parse(textBox_tk.Text)), double.Parse(textBox_tk.Text), double.Parse(textBox_tk.Text) + 2d, 0.019d * 10d);
                    //double a0 = myFunction.Condenser_a02(double.Parse(textBox_h2o_r.Text), g, pho, myFunction.L_H20_mu(double.Parse(textBox_tk.Text)), myFunction.L_H20_lambda(double.Parse(textBox_tk.Text)), double.Parse(textBox_d0.Text),10d);
                    double ki = myFunction.K_in(a0, ai, double.Parse(textBox_r0.Text), double.Parse(textBox_ri.Text), double.Parse(textBox_d0.Text), double.Parse(textBox_di.Text), double.Parse(textBox_tube_lambda.Text));
                    double k0 = myFunction.K_out(a0, ai, double.Parse(textBox_r0.Text), double.Parse(textBox_ri.Text), double.Parse(textBox_d0.Text), double.Parse(textBox_di.Text), double.Parse(textBox_tube_lambda.Text));
                    double k = myFunction.average_K2(ki, k0);
                    //double k = myFunction.average_K(ki, k0,double.Parse(textBox_d0.Text),double.Parse(textBox_di.Text),double.Parse(textBox_tube_lambda.Text));
                    
                    if(first_conculate)
                    {
                        textBox_result_k.Text = mess.ToString();
                        textBox_result_a.Text = a.ToString();
                        textBox_result_v.Text = speed.ToString();
                        textBox_result_n.Text = n.ToString();
                        textBox_result_a0.Text = a0.ToString();
                        textBox_result_ai.Text = ai.ToString();
                        first_conculate = false;
                    }
                    
                    if (Math.Abs(mess - k) > double.Parse(textBox_middle.Text))
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
                        textBox_mu.Text = myFunction.L_H20_mu(double.Parse(textBox_tk.Text)).ToString();
                        textBox_lambda.Text = myFunction.L_H20_lambda(double.Parse(textBox_tk.Text)).ToString();
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
