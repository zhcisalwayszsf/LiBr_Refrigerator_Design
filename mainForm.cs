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
            this.Visible = false;
            if (A_ConsenderForm.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_ConsenderForm.Dispose();
            }
        }

        private void button_absorb_Click(object sender, EventArgs e)
        {
            Form A_AbsorbForm = new AbsorbForm();
            this.Visible = false;
            if (A_AbsorbForm.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_AbsorbForm.Dispose();
            }
        }

        private void button_Evaporator_Click(object sender, EventArgs e)
        {
            Form A_Evaporator = new EvaporatorForm();
            this.Visible = false;
            if (A_Evaporator.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_Evaporator.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form A_Gh = new GhForm();
            this.Visible = false;
            if (A_Gh.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_Gh.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form A_Gl = new GlForm();
            this.Visible = false;
            if (A_Gl.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_Gl.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form A_EXH = new EXHForm();
            this.Visible = false;
            if (A_EXH.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_EXH.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form A_EXL = new EXLForm();
            this.Visible = false;
            if (A_EXL.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_EXL.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form A_LiBr = new LiBrForm();
            this.Visible = false;
            if (A_LiBr.ShowDialog(this) != DialogResult.OK)
            {
                this.Visible = true;
                A_LiBr.Dispose();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form A_K_conculator = new KForm();
           // A_K_conculator.ShowDialog();
            this.Visible=false;
            if (A_K_conculator.ShowDialog(this) != DialogResult.OK)
            {
                 this.Visible = true;
                A_K_conculator.Dispose(); 
            }
           

        }
    }
}
