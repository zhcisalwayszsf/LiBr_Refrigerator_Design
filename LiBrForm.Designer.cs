namespace LiBr_Refrigerator_Design
{
    partial class LiBrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Pr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_mu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lambda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_cp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox_Pr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_mu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_lambda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_t);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_x);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 313);
            this.panel1.TabIndex = 0;
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(500, 187);
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.ReadOnly = true;
            this.textBox_cp.Size = new System.Drawing.Size(75, 25);
            this.textBox_cp.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "(kJ/kg·K)Cp：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 70);
            this.button1.TabIndex = 30;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Pr
            // 
            this.textBox_Pr.Location = new System.Drawing.Point(200, 187);
            this.textBox_Pr.Name = "textBox_Pr";
            this.textBox_Pr.ReadOnly = true;
            this.textBox_Pr.Size = new System.Drawing.Size(75, 25);
            this.textBox_Pr.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Pr：";
            // 
            // textBox_mu
            // 
            this.textBox_mu.Location = new System.Drawing.Point(500, 114);
            this.textBox_mu.Name = "textBox_mu";
            this.textBox_mu.ReadOnly = true;
            this.textBox_mu.Size = new System.Drawing.Size(75, 25);
            this.textBox_mu.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "(10^-3)mu：";
            // 
            // textBox_lambda
            // 
            this.textBox_lambda.Location = new System.Drawing.Point(500, 27);
            this.textBox_lambda.Name = "textBox_lambda";
            this.textBox_lambda.ReadOnly = true;
            this.textBox_lambda.Size = new System.Drawing.Size(75, 25);
            this.textBox_lambda.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lambda：";
            // 
            // textBox_t
            // 
            this.textBox_t.Location = new System.Drawing.Point(200, 107);
            this.textBox_t.Name = "textBox_t";
            this.textBox_t.Size = new System.Drawing.Size(75, 25);
            this.textBox_t.TabIndex = 23;
            this.textBox_t.Text = "30";
            this.textBox_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "温度(℃)：";
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(200, 27);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(75, 25);
            this.textBox_x.TabIndex = 21;
            this.textBox_x.Text = "50";
            this.textBox_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "浓度(0-100)：";
            // 
            // LiBrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 313);
            this.Controls.Add(this.panel1);
            this.Name = "LiBrForm";
            this.Text = "LiBrForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_lambda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Pr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_mu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.Label label5;
    }
}