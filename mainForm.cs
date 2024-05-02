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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button_condenser_Click(object sender, EventArgs e)
        {
            Form A_ConsenderForm = new CondenserForm();
            A_ConsenderForm.ShowDialog();
        }

        private void button_absorb_Click(object sender, EventArgs e)
        {
            Form A_AbsorbForm = new AbsorbForm();
            A_AbsorbForm.ShowDialog();
        }

        private void button_Evaporator_Click(object sender, EventArgs e)
        {
            Form A_Evaporator = new EvaporatorForm();
            A_Evaporator.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form A_Gh = new GhForm();
            A_Gh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form A_Gl = new GlForm();
            A_Gl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form A_EXH = new EXHForm();
            A_EXH.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form A_EXL = new EXLForm();
            A_EXL.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form A_LiBr = new LiBrForm();
            A_LiBr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form A_K_conculator = new KForm();
            A_K_conculator.ShowDialog();
        }
    }
}
