namespace LiBr_Refrigerator_Design
{
    partial class KForm
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
            this.textBox_ai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_a0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox_k_model = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lambda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_r0 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_di = new System.Windows.Forms.TextBox();
            this.label_di = new System.Windows.Forms.Label();
            this.textBox_d0 = new System.Windows.Forms.TextBox();
            this.label_d0 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ai
            // 
            this.textBox_ai.Location = new System.Drawing.Point(520, 117);
            this.textBox_ai.Name = "textBox_ai";
            this.textBox_ai.Size = new System.Drawing.Size(75, 25);
            this.textBox_ai.TabIndex = 27;
            this.textBox_ai.Text = "5000";
            this.textBox_ai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "ai：";
            // 
            // textBox_a0
            // 
            this.textBox_a0.Location = new System.Drawing.Point(520, 77);
            this.textBox_a0.Name = "textBox_a0";
            this.textBox_a0.Size = new System.Drawing.Size(75, 25);
            this.textBox_a0.TabIndex = 25;
            this.textBox_a0.Text = "5000";
            this.textBox_a0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "a0：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(30, 250);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 15);
            this.label28.TabIndex = 71;
            this.label28.Text = "K取值模式";
            // 
            // comboBox_k_model
            // 
            this.comboBox_k_model.FormattingEnabled = true;
            this.comboBox_k_model.Items.AddRange(new object[] {
            "K=K0",
            "K=Ki",
            "k=(K0+Ki)/2",
            "k=f(Ki,K0,lambda)(热阻法)"});
            this.comboBox_k_model.Location = new System.Drawing.Point(111, 249);
            this.comboBox_k_model.Name = "comboBox_k_model";
            this.comboBox_k_model.Size = new System.Drawing.Size(204, 23);
            this.comboBox_k_model.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 60);
            this.button1.TabIndex = 72;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(445, 164);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.ReadOnly = true;
            this.textBox_k.Size = new System.Drawing.Size(150, 25);
            this.textBox_k.TabIndex = 74;
            this.textBox_k.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "K：";
            // 
            // textBox_lambda
            // 
            this.textBox_lambda.Location = new System.Drawing.Point(520, 37);
            this.textBox_lambda.Name = "textBox_lambda";
            this.textBox_lambda.Size = new System.Drawing.Size(75, 25);
            this.textBox_lambda.TabIndex = 76;
            this.textBox_lambda.Text = "16";
            this.textBox_lambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "Lambda：";
            // 
            // textBox_ri
            // 
            this.textBox_ri.Location = new System.Drawing.Point(240, 164);
            this.textBox_ri.Name = "textBox_ri";
            this.textBox_ri.Size = new System.Drawing.Size(75, 25);
            this.textBox_ri.TabIndex = 84;
            this.textBox_ri.Text = "0.9";
            this.textBox_ri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 15);
            this.label10.TabIndex = 83;
            this.label10.Text = "(*10^-4)管内污垢热阻系数：";
            // 
            // textBox_r0
            // 
            this.textBox_r0.Location = new System.Drawing.Point(240, 117);
            this.textBox_r0.Name = "textBox_r0";
            this.textBox_r0.Size = new System.Drawing.Size(75, 25);
            this.textBox_r0.TabIndex = 82;
            this.textBox_r0.Text = "0";
            this.textBox_r0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 15);
            this.label14.TabIndex = 81;
            this.label14.Text = "(*10^-4)管外污垢热阻系数：";
            // 
            // textBox_di
            // 
            this.textBox_di.Location = new System.Drawing.Point(240, 77);
            this.textBox_di.Name = "textBox_di";
            this.textBox_di.Size = new System.Drawing.Size(75, 25);
            this.textBox_di.TabIndex = 80;
            this.textBox_di.Text = "0.017";
            this.textBox_di.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label_di
            // 
            this.label_di.AutoSize = true;
            this.label_di.Location = new System.Drawing.Point(30, 80);
            this.label_di.Name = "label_di";
            this.label_di.Size = new System.Drawing.Size(91, 15);
            this.label_di.TabIndex = 79;
            this.label_di.Text = "(m)管内径：";
            // 
            // textBox_d0
            // 
            this.textBox_d0.Location = new System.Drawing.Point(240, 37);
            this.textBox_d0.Name = "textBox_d0";
            this.textBox_d0.Size = new System.Drawing.Size(75, 25);
            this.textBox_d0.TabIndex = 78;
            this.textBox_d0.Text = "0.019";
            this.textBox_d0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbles);
            // 
            // label_d0
            // 
            this.label_d0.AutoSize = true;
            this.label_d0.Location = new System.Drawing.Point(30, 40);
            this.label_d0.Name = "label_d0";
            this.label_d0.Size = new System.Drawing.Size(91, 15);
            this.label_d0.TabIndex = 77;
            this.label_d0.Text = "(m)管外径：";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(363, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 89;
            this.button2.Text = "置于顶层";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_ri);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_r0);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_di);
            this.Controls.Add(this.label_di);
            this.Controls.Add(this.textBox_d0);
            this.Controls.Add(this.label_d0);
            this.Controls.Add(this.textBox_lambda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_k);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.comboBox_k_model);
            this.Controls.Add(this.textBox_ai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_a0);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "KForm";
            this.ShowIcon = false;
            this.Text = "KForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_a0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBox_k_model;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lambda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_r0;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_di;
        private System.Windows.Forms.Label label_di;
        private System.Windows.Forms.TextBox textBox_d0;
        private System.Windows.Forms.Label label_d0;
        private System.Windows.Forms.Button button2;
    }
}