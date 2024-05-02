namespace LiBr_Refrigerator_Design
{
    partial class mainForm
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Evaporator = new System.Windows.Forms.Button();
            this.button_absorb = new System.Windows.Forms.Button();
            this.button_condenser = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button_Evaporator);
            this.panel1.Controls.Add(this.button_absorb);
            this.panel1.Controls.Add(this.button_condenser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 473);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(515, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 60);
            this.button6.TabIndex = 8;
            this.button6.Text = "LiBr物性参数";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(515, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 60);
            this.button5.TabIndex = 7;
            this.button5.Text = "凝水换热器";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "低温换热器";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "高温换热器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "低压发生器";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "高压发生器";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Evaporator
            // 
            this.button_Evaporator.Location = new System.Drawing.Point(515, 60);
            this.button_Evaporator.Name = "button_Evaporator";
            this.button_Evaporator.Size = new System.Drawing.Size(100, 60);
            this.button_Evaporator.TabIndex = 2;
            this.button_Evaporator.Text = "蒸发器";
            this.button_Evaporator.UseVisualStyleBackColor = true;
            this.button_Evaporator.Click += new System.EventHandler(this.button_Evaporator_Click);
            // 
            // button_absorb
            // 
            this.button_absorb.Location = new System.Drawing.Point(300, 60);
            this.button_absorb.Name = "button_absorb";
            this.button_absorb.Size = new System.Drawing.Size(100, 60);
            this.button_absorb.TabIndex = 1;
            this.button_absorb.Text = "吸收器";
            this.button_absorb.UseVisualStyleBackColor = true;
            this.button_absorb.Click += new System.EventHandler(this.button_absorb_Click);
            // 
            // button_condenser
            // 
            this.button_condenser.Location = new System.Drawing.Point(85, 60);
            this.button_condenser.Name = "button_condenser";
            this.button_condenser.Size = new System.Drawing.Size(100, 60);
            this.button_condenser.TabIndex = 0;
            this.button_condenser.Text = "冷凝器";
            this.button_condenser.UseVisualStyleBackColor = true;
            this.button_condenser.Click += new System.EventHandler(this.button_condenser_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 400);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 60);
            this.button7.TabIndex = 9;
            this.button7.Text = "K值手动计算";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(702, 473);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "菜单";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_absorb;
        private System.Windows.Forms.Button button_condenser;
        private System.Windows.Forms.Button button_Evaporator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}