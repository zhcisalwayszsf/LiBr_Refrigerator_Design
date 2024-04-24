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
    }
}
