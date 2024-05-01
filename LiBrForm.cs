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
            double Pr, mu, lambda,Cp,t,x;
            t = double.Parse(textBox_t.Text);
            x = double.Parse(textBox_x.Text);
            mu =myFunction.LiBr_mu2(t,x);
            Cp=myFunction.LiBr_Cp(t,x);
            lambda = myFunction.Libr_Lambda(t, x);
            Pr = Cp * mu / lambda;
            textBox_cp.Text = Cp.ToString();
            textBox_lambda.Text = lambda.ToString();
            textBox_mu.Text = mu.ToString();
            textBox_Pr.Text = Pr.ToString();
        }
    }
}
