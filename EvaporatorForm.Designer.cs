namespace LiBr_Refrigerator_Design
{
    partial class EvaporatorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_r0 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_tube_lambda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_t_inTube = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_flu_qv = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_evaporator_c = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_delta_x = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_t0 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_tube_length = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_evaporator_q = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tc2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tc1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_omega = new System.Windows.Forms.TextBox();
            this.label_r0_out = new System.Windows.Forms.Label();
            this.textBox_di = new System.Windows.Forms.TextBox();
            this.label_di = new System.Windows.Forms.Label();
            this.textBox_d0 = new System.Windows.Forms.TextBox();
            this.label_d0 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_result_v = new System.Windows.Forms.TextBox();
            this.textBox_result_ai = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_result_n = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_result_a0 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_result_k = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_result_a = new System.Windows.Forms.TextBox();
            this.textBox_middle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_first_K = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_nu = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox_lambda = new System.Windows.Forms.TextBox();
            this.textBox_ai = new System.Windows.Forms.TextBox();
            this.textBox_pr = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_a0 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_v = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.textBox_t_inTube.Text = "9.5";
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
            this.textBox_flu_qv.Text = "0.0136";
            this.textBox_flu_qv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.textBox_evaporator_c);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.textBox_delta_x);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBox_t0);
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
            this.panel1.Controls.Add(this.textBox_evaporator_q);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_tc2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_tc1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_omega);
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
            // textBox_evaporator_c
            // 
            this.textBox_evaporator_c.Location = new System.Drawing.Point(640, 387);
            this.textBox_evaporator_c.Name = "textBox_evaporator_c";
            this.textBox_evaporator_c.Size = new System.Drawing.Size(75, 25);
            this.textBox_evaporator_c.TabIndex = 37;
            this.textBox_evaporator_c.Text = "1";
            this.textBox_evaporator_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(430, 390);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "系数C：";
            // 
            // textBox_delta_x
            // 
            this.textBox_delta_x.Location = new System.Drawing.Point(640, 337);
            this.textBox_delta_x.Name = "textBox_delta_x";
            this.textBox_delta_x.Size = new System.Drawing.Size(75, 25);
            this.textBox_delta_x.TabIndex = 35;
            this.textBox_delta_x.Text = "0.005";
            this.textBox_delta_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(430, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "(m)液膜厚度：";
            // 
            // textBox_t0
            // 
            this.textBox_t0.Location = new System.Drawing.Point(240, 387);
            this.textBox_t0.Name = "textBox_t0";
            this.textBox_t0.Size = new System.Drawing.Size(75, 25);
            this.textBox_t0.TabIndex = 33;
            this.textBox_t0.Text = "5";
            this.textBox_t0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "(℃)t0：";
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
            // textBox_tube_length
            // 
            this.textBox_tube_length.Location = new System.Drawing.Point(640, 47);
            this.textBox_tube_length.Name = "textBox_tube_length";
            this.textBox_tube_length.Size = new System.Drawing.Size(75, 25);
            this.textBox_tube_length.TabIndex = 17;
            this.textBox_tube_length.Text = "5";
            this.textBox_tube_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
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
            // textBox_evaporator_q
            // 
            this.textBox_evaporator_q.Location = new System.Drawing.Point(240, 337);
            this.textBox_evaporator_q.Name = "textBox_evaporator_q";
            this.textBox_evaporator_q.Size = new System.Drawing.Size(75, 25);
            this.textBox_evaporator_q.TabIndex = 15;
            this.textBox_evaporator_q.Text = "3198";
            this.textBox_evaporator_q.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "(kW)蒸发热负荷:";
            // 
            // textBox_tc2
            // 
            this.textBox_tc2.Location = new System.Drawing.Point(240, 287);
            this.textBox_tc2.Name = "textBox_tc2";
            this.textBox_tc2.Size = new System.Drawing.Size(75, 25);
            this.textBox_tc2.TabIndex = 13;
            this.textBox_tc2.Text = "7";
            this.textBox_tc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "(℃)冷水出口温度tc2:";
            // 
            // textBox_tc1
            // 
            this.textBox_tc1.Location = new System.Drawing.Point(240, 237);
            this.textBox_tc1.Name = "textBox_tc1";
            this.textBox_tc1.Size = new System.Drawing.Size(75, 25);
            this.textBox_tc1.TabIndex = 11;
            this.textBox_tc1.Text = "12";
            this.textBox_tc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "(℃)冷水入口温度tc1:";
            // 
            // textBox_omega
            // 
            this.textBox_omega.Location = new System.Drawing.Point(640, 290);
            this.textBox_omega.Name = "textBox_omega";
            this.textBox_omega.Size = new System.Drawing.Size(75, 25);
            this.textBox_omega.TabIndex = 5;
            this.textBox_omega.Text = "1500";
            this.textBox_omega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label_r0_out
            // 
            this.label_r0_out.AutoSize = true;
            this.label_r0_out.Location = new System.Drawing.Point(430, 293);
            this.label_r0_out.Name = "label_r0_out";
            this.label_r0_out.Size = new System.Drawing.Size(220, 15);
            this.label_r0_out.TabIndex = 4;
            this.label_r0_out.Text = "(kg/h)一排管子上冷剂喷淋量：";
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
            this.tableLayoutPanel1.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.textBox_result_v);
            this.panel3.Controls.Add(this.textBox_result_ai);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.textBox_result_n);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.textBox_result_a0);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.textBox_result_k);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.textBox_result_a);
            this.panel3.Controls.Add(this.textBox_middle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox_first_K);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(760, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 466);
            this.panel3.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 397);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 15);
            this.label23.TabIndex = 41;
            this.label23.Text = "管内传热系数ai：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 15);
            this.label21.TabIndex = 37;
            this.label21.Text = "流速：";
            // 
            // textBox_result_v
            // 
            this.textBox_result_v.Location = new System.Drawing.Point(52, 323);
            this.textBox_result_v.Name = "textBox_result_v";
            this.textBox_result_v.ReadOnly = true;
            this.textBox_result_v.Size = new System.Drawing.Size(107, 25);
            this.textBox_result_v.TabIndex = 36;
            // 
            // textBox_result_ai
            // 
            this.textBox_result_ai.Location = new System.Drawing.Point(52, 415);
            this.textBox_result_ai.Name = "textBox_result_ai";
            this.textBox_result_ai.ReadOnly = true;
            this.textBox_result_ai.Size = new System.Drawing.Size(107, 25);
            this.textBox_result_ai.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 35;
            this.label20.Text = "管子数：";
            // 
            // textBox_result_n
            // 
            this.textBox_result_n.Location = new System.Drawing.Point(52, 279);
            this.textBox_result_n.Name = "textBox_result_n";
            this.textBox_result_n.ReadOnly = true;
            this.textBox_result_n.Size = new System.Drawing.Size(107, 25);
            this.textBox_result_n.TabIndex = 34;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 351);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 15);
            this.label22.TabIndex = 39;
            this.label22.Text = "管外传热系数a0：";
            // 
            // textBox_result_a0
            // 
            this.textBox_result_a0.Location = new System.Drawing.Point(52, 369);
            this.textBox_result_a0.Name = "textBox_result_a0";
            this.textBox_result_a0.ReadOnly = true;
            this.textBox_result_a0.Size = new System.Drawing.Size(107, 25);
            this.textBox_result_a0.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 33;
            this.label19.Text = "传热系数：";
            // 
            // textBox_result_k
            // 
            this.textBox_result_k.Location = new System.Drawing.Point(52, 236);
            this.textBox_result_k.Name = "textBox_result_k";
            this.textBox_result_k.ReadOnly = true;
            this.textBox_result_k.Size = new System.Drawing.Size(107, 25);
            this.textBox_result_k.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 31;
            this.label18.Text = "传热面积：";
            // 
            // textBox_result_a
            // 
            this.textBox_result_a.Location = new System.Drawing.Point(52, 186);
            this.textBox_result_a.Name = "textBox_result_a";
            this.textBox_result_a.ReadOnly = true;
            this.textBox_result_a.Size = new System.Drawing.Size(107, 25);
            this.textBox_result_a.TabIndex = 30;
            // 
            // textBox_middle
            // 
            this.textBox_middle.Location = new System.Drawing.Point(52, 130);
            this.textBox_middle.Name = "textBox_middle";
            this.textBox_middle.Size = new System.Drawing.Size(107, 25);
            this.textBox_middle.TabIndex = 5;
            this.textBox_middle.Text = "0.1";
            this.textBox_middle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "允许误差值：";
            // 
            // textBox_first_K
            // 
            this.textBox_first_K.Location = new System.Drawing.Point(52, 65);
            this.textBox_first_K.Name = "textBox_first_K";
            this.textBox_first_K.Size = new System.Drawing.Size(107, 25);
            this.textBox_first_K.TabIndex = 3;
            this.textBox_first_K.Text = "3600";
            this.textBox_first_K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "假设的k值";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.textBox_nu);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.textBox_lambda);
            this.panel4.Controls.Add(this.textBox_ai);
            this.panel4.Controls.Add(this.textBox_pr);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.textBox_a0);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.textBox_n);
            this.panel4.Controls.Add(this.textBox_v);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.textBox_a);
            this.panel4.Controls.Add(this.textBox_k);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(751, 115);
            this.panel4.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(525, 81);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 15);
            this.label26.TabIndex = 63;
            this.label26.Text = "nu：";
            // 
            // textBox_nu
            // 
            this.textBox_nu.Location = new System.Drawing.Point(621, 78);
            this.textBox_nu.Name = "textBox_nu";
            this.textBox_nu.ReadOnly = true;
            this.textBox_nu.Size = new System.Drawing.Size(125, 25);
            this.textBox_nu.TabIndex = 62;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(525, 50);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 15);
            this.label30.TabIndex = 61;
            this.label30.Text = "Pr：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(268, 84);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(128, 15);
            this.label27.TabIndex = 57;
            this.label27.Text = "管内传热系数ai：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(525, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 15);
            this.label31.TabIndex = 60;
            this.label31.Text = "lambda：";
            // 
            // textBox_lambda
            // 
            this.textBox_lambda.Location = new System.Drawing.Point(621, 13);
            this.textBox_lambda.Name = "textBox_lambda";
            this.textBox_lambda.ReadOnly = true;
            this.textBox_lambda.Size = new System.Drawing.Size(125, 25);
            this.textBox_lambda.TabIndex = 59;
            // 
            // textBox_ai
            // 
            this.textBox_ai.Location = new System.Drawing.Point(402, 78);
            this.textBox_ai.Name = "textBox_ai";
            this.textBox_ai.ReadOnly = true;
            this.textBox_ai.Size = new System.Drawing.Size(107, 25);
            this.textBox_ai.TabIndex = 56;
            // 
            // textBox_pr
            // 
            this.textBox_pr.Location = new System.Drawing.Point(621, 47);
            this.textBox_pr.Name = "textBox_pr";
            this.textBox_pr.ReadOnly = true;
            this.textBox_pr.Size = new System.Drawing.Size(125, 25);
            this.textBox_pr.TabIndex = 58;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 84);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 15);
            this.label28.TabIndex = 55;
            this.label28.Text = "管外传热系数a0：";
            // 
            // textBox_a0
            // 
            this.textBox_a0.Location = new System.Drawing.Point(143, 81);
            this.textBox_a0.Name = "textBox_a0";
            this.textBox_a0.ReadOnly = true;
            this.textBox_a0.Size = new System.Drawing.Size(107, 25);
            this.textBox_a0.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(268, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 15);
            this.label24.TabIndex = 33;
            this.label24.Text = "流速v：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(268, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 15);
            this.label25.TabIndex = 32;
            this.label25.Text = "管子数n：";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(364, 13);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.ReadOnly = true;
            this.textBox_n.Size = new System.Drawing.Size(125, 25);
            this.textBox_n.TabIndex = 31;
            // 
            // textBox_v
            // 
            this.textBox_v.Location = new System.Drawing.Point(364, 47);
            this.textBox_v.Name = "textBox_v";
            this.textBox_v.ReadOnly = true;
            this.textBox_v.Size = new System.Drawing.Size(125, 25);
            this.textBox_v.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "传热系数K：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "传热面积A：";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(105, 13);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.ReadOnly = true;
            this.textBox_a.Size = new System.Drawing.Size(125, 25);
            this.textBox_a.TabIndex = 1;
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(105, 47);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.ReadOnly = true;
            this.textBox_k.Size = new System.Drawing.Size(125, 25);
            this.textBox_k.TabIndex = 0;
            // 
            // EvaporatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "EvaporatorForm";
            this.ShowIcon = false;
            this.Text = "蒸发器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_r0;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_tube_lambda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_t_inTube;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_flu_qv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_t0;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_tube_length;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_evaporator_q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tc2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_omega;
        private System.Windows.Forms.Label label_r0_out;
        private System.Windows.Forms.TextBox textBox_di;
        private System.Windows.Forms.Label label_di;
        private System.Windows.Forms.TextBox textBox_d0;
        private System.Windows.Forms.Label label_d0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_first_K;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.TextBox textBox_delta_x;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_evaporator_c;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_middle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_result_a0;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_result_v;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_result_n;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_result_k;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_result_a;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_result_ai;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_v;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_ai;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox_a0;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox_lambda;
        private System.Windows.Forms.TextBox textBox_pr;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_nu;
    }
}