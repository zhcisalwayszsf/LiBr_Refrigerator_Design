﻿namespace LiBr_Refrigerator_Design
{
    partial class AbsorbForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_tube_lambda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_t_inTube = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_flu_qv = new System.Windows.Forms.TextBox();
            this.textBox_first_K = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_area = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_tube_length = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_absorb_q = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tw1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_xi = new System.Windows.Forms.TextBox();
            this.label_ri_in = new System.Windows.Forms.Label();
            this.textBox_gamma = new System.Windows.Forms.TextBox();
            this.label_r0_out = new System.Windows.Forms.Label();
            this.textBox_di = new System.Windows.Forms.TextBox();
            this.label_di = new System.Windows.Forms.Label();
            this.textBox_d0 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_t2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_t9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_ri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_r0 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_d0 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "传热系数K：";
            // 
            // textBox_tube_lambda
            // 
            this.textBox_tube_lambda.Location = new System.Drawing.Point(640, 240);
            this.textBox_tube_lambda.Name = "textBox_tube_lambda";
            this.textBox_tube_lambda.Size = new System.Drawing.Size(75, 25);
            this.textBox_tube_lambda.TabIndex = 27;
            this.textBox_tube_lambda.Text = "15";
            this.textBox_tube_lambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "管材导热率：";
            // 
            // textBox_t_inTube
            // 
            this.textBox_t_inTube.Location = new System.Drawing.Point(640, 190);
            this.textBox_t_inTube.Name = "textBox_t_inTube";
            this.textBox_t_inTube.Size = new System.Drawing.Size(75, 25);
            this.textBox_t_inTube.TabIndex = 23;
            this.textBox_t_inTube.Text = "33.3";
            this.textBox_t_inTube.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "管内流体平均温度Δt：";
            // 
            // textBox_flu_qv
            // 
            this.textBox_flu_qv.Location = new System.Drawing.Point(640, 140);
            this.textBox_flu_qv.Name = "textBox_flu_qv";
            this.textBox_flu_qv.Size = new System.Drawing.Size(75, 25);
            this.textBox_flu_qv.TabIndex = 21;
            this.textBox_flu_qv.Text = "0.281";
            this.textBox_flu_qv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // textBox_first_K
            // 
            this.textBox_first_K.Location = new System.Drawing.Point(48, 167);
            this.textBox_first_K.Name = "textBox_first_K";
            this.textBox_first_K.Size = new System.Drawing.Size(107, 25);
            this.textBox_first_K.TabIndex = 3;
            this.textBox_first_K.Text = "3600";
            this.textBox_first_K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "假设的k值";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "(m3/s)管内流体的体积流量：";
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(640, 97);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(75, 25);
            this.textBox_m.TabIndex = 19;
            this.textBox_m.Text = "2";
            this.textBox_m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "管程数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "(m)有效管长：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_first_K);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(760, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 466);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.textBox_area);
            this.panel4.Controls.Add(this.textBox_result);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(751, 115);
            this.panel4.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "传热面积：";
            // 
            // textBox_area
            // 
            this.textBox_area.Location = new System.Drawing.Point(117, 54);
            this.textBox_area.Name = "textBox_area";
            this.textBox_area.ReadOnly = true;
            this.textBox_area.Size = new System.Drawing.Size(158, 25);
            this.textBox_area.TabIndex = 1;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(526, 54);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(158, 25);
            this.textBox_result.TabIndex = 0;
            // 
            // textBox_tube_length
            // 
            this.textBox_tube_length.Location = new System.Drawing.Point(640, 47);
            this.textBox_tube_length.Name = "textBox_tube_length";
            this.textBox_tube_length.Size = new System.Drawing.Size(75, 25);
            this.textBox_tube_length.TabIndex = 17;
            this.textBox_tube_length.Text = "5";
            this.textBox_tube_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(760, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 115);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_absorb_q
            // 
            this.textBox_absorb_q.Location = new System.Drawing.Point(240, 337);
            this.textBox_absorb_q.Name = "textBox_absorb_q";
            this.textBox_absorb_q.Size = new System.Drawing.Size(75, 25);
            this.textBox_absorb_q.TabIndex = 15;
            this.textBox_absorb_q.Text = "4358.9";
            this.textBox_absorb_q.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "(kW)吸收器热负荷:";
            // 
            // textBox_tw1
            // 
            this.textBox_tw1.Location = new System.Drawing.Point(240, 287);
            this.textBox_tw1.Name = "textBox_tw1";
            this.textBox_tw1.Size = new System.Drawing.Size(75, 25);
            this.textBox_tw1.TabIndex = 13;
            this.textBox_tw1.Text = "34.6";
            this.textBox_tw1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "(℃)冷却水出口温度tw1:";
            // 
            // textBox_tw
            // 
            this.textBox_tw.Location = new System.Drawing.Point(240, 237);
            this.textBox_tw.Name = "textBox_tw";
            this.textBox_tw.Size = new System.Drawing.Size(75, 25);
            this.textBox_tw.TabIndex = 11;
            this.textBox_tw.Text = "32";
            this.textBox_tw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "(℃)冷却水入口温度tw:";
            // 
            // textBox_xi
            // 
            this.textBox_xi.Location = new System.Drawing.Point(640, 337);
            this.textBox_xi.Name = "textBox_xi";
            this.textBox_xi.Size = new System.Drawing.Size(75, 25);
            this.textBox_xi.TabIndex = 7;
            this.textBox_xi.Text = "0.560";
            this.textBox_xi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label_ri_in
            // 
            this.label_ri_in.AutoSize = true;
            this.label_ri_in.Location = new System.Drawing.Point(430, 340);
            this.label_ri_in.Name = "label_ri_in";
            this.label_ri_in.Size = new System.Drawing.Size(197, 15);
            this.label_ri_in.TabIndex = 6;
            this.label_ri_in.Text = "喷淋溶液的质量分数(0-1)：";
            // 
            // textBox_gamma
            // 
            this.textBox_gamma.Location = new System.Drawing.Point(640, 290);
            this.textBox_gamma.Name = "textBox_gamma";
            this.textBox_gamma.Size = new System.Drawing.Size(75, 25);
            this.textBox_gamma.TabIndex = 5;
            this.textBox_gamma.Text = "150000";
            this.textBox_gamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label_r0_out
            // 
            this.label_r0_out.AutoSize = true;
            this.label_r0_out.Location = new System.Drawing.Point(430, 293);
            this.label_r0_out.Name = "label_r0_out";
            this.label_r0_out.Size = new System.Drawing.Size(153, 15);
            this.label_r0_out.TabIndex = 4;
            this.label_r0_out.Text = "kg/(m·h)喷淋密度：";
            // 
            // textBox_di
            // 
            this.textBox_di.Location = new System.Drawing.Point(240, 97);
            this.textBox_di.Name = "textBox_di";
            this.textBox_di.Size = new System.Drawing.Size(75, 25);
            this.textBox_di.TabIndex = 3;
            this.textBox_di.Text = "0.017";
            this.textBox_di.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label_di
            // 
            this.label_di.AutoSize = true;
            this.label_di.Location = new System.Drawing.Point(30, 100);
            this.label_di.Name = "label_di";
            this.label_di.Size = new System.Drawing.Size(91, 15);
            this.label_di.TabIndex = 2;
            this.label_di.Text = "(m)管内径：";
            // 
            // textBox_d0
            // 
            this.textBox_d0.Location = new System.Drawing.Point(240, 47);
            this.textBox_d0.Name = "textBox_d0";
            this.textBox_d0.Size = new System.Drawing.Size(75, 25);
            this.textBox_d0.TabIndex = 1;
            this.textBox_d0.Text = "0.019";
            this.textBox_d0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_t2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBox_t9);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBox_ri);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_r0);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBox_tube_lambda);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox_t_inTube);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_flu_qv);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_m);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_tube_length);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_absorb_q);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_tw1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_tw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_xi);
            this.panel1.Controls.Add(this.label_ri_in);
            this.panel1.Controls.Add(this.textBox_gamma);
            this.panel1.Controls.Add(this.label_r0_out);
            this.panel1.Controls.Add(this.textBox_di);
            this.panel1.Controls.Add(this.label_di);
            this.panel1.Controls.Add(this.textBox_d0);
            this.panel1.Controls.Add(this.label_d0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 466);
            this.panel1.TabIndex = 0;
            // 
            // textBox_t2
            // 
            this.textBox_t2.Location = new System.Drawing.Point(640, 387);
            this.textBox_t2.Name = "textBox_t2";
            this.textBox_t2.Size = new System.Drawing.Size(75, 25);
            this.textBox_t2.TabIndex = 35;
            this.textBox_t2.Text = "40.5";
            this.textBox_t2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(430, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "(℃)t2：";
            // 
            // textBox_t9
            // 
            this.textBox_t9.Location = new System.Drawing.Point(240, 387);
            this.textBox_t9.Name = "textBox_t9";
            this.textBox_t9.Size = new System.Drawing.Size(75, 25);
            this.textBox_t9.TabIndex = 33;
            this.textBox_t9.Text = "49.2";
            this.textBox_t9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "(℃)t9：";
            // 
            // textBox_ri
            // 
            this.textBox_ri.Location = new System.Drawing.Point(240, 184);
            this.textBox_ri.Name = "textBox_ri";
            this.textBox_ri.Size = new System.Drawing.Size(75, 25);
            this.textBox_ri.TabIndex = 31;
            this.textBox_ri.Text = "0.9";
            this.textBox_ri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "(*10^-4)管内污垢热阻系数：";
            // 
            // textBox_r0
            // 
            this.textBox_r0.Location = new System.Drawing.Point(240, 137);
            this.textBox_r0.Name = "textBox_r0";
            this.textBox_r0.Size = new System.Drawing.Size(75, 25);
            this.textBox_r0.TabIndex = 29;
            this.textBox_r0.Text = "2";
            this.textBox_r0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "(*10^-4)管外污垢热阻系数：";
            // 
            // label_d0
            // 
            this.label_d0.AutoSize = true;
            this.label_d0.Location = new System.Drawing.Point(30, 50);
            this.label_d0.Name = "label_d0";
            this.label_d0.Size = new System.Drawing.Size(91, 15);
            this.label_d0.TabIndex = 0;
            this.label_d0.Text = "(m)管外径：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.46709F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.53291F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.59528F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40472F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 593);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AbsorbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "AbsorbForm";
            this.ShowIcon = false;
            this.Text = "吸收器";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_tube_lambda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_t_inTube;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_flu_qv;
        private System.Windows.Forms.TextBox textBox_first_K;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_area;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_tube_length;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_absorb_q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tw1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_xi;
        private System.Windows.Forms.Label label_ri_in;
        private System.Windows.Forms.TextBox textBox_gamma;
        private System.Windows.Forms.Label label_r0_out;
        private System.Windows.Forms.TextBox textBox_di;
        private System.Windows.Forms.Label label_di;
        private System.Windows.Forms.TextBox textBox_d0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_d0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_ri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_r0;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_t2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_t9;
        private System.Windows.Forms.Label label15;
    }
}