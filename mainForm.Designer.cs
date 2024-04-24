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
            this.button_absorb = new System.Windows.Forms.Button();
            this.button_condenser = new System.Windows.Forms.Button();
            this.button_Evaporator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Evaporator);
            this.panel1.Controls.Add(this.button_absorb);
            this.panel1.Controls.Add(this.button_condenser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 433);
            this.panel1.TabIndex = 0;
            // 
            // button_absorb
            // 
            this.button_absorb.Location = new System.Drawing.Point(450, 80);
            this.button_absorb.Name = "button_absorb";
            this.button_absorb.Size = new System.Drawing.Size(100, 60);
            this.button_absorb.TabIndex = 1;
            this.button_absorb.Text = "吸收器";
            this.button_absorb.UseVisualStyleBackColor = true;
            this.button_absorb.Click += new System.EventHandler(this.button_absorb_Click);
            // 
            // button_condenser
            // 
            this.button_condenser.Location = new System.Drawing.Point(100, 80);
            this.button_condenser.Name = "button_condenser";
            this.button_condenser.Size = new System.Drawing.Size(100, 60);
            this.button_condenser.TabIndex = 0;
            this.button_condenser.Text = "冷凝器";
            this.button_condenser.UseVisualStyleBackColor = true;
            this.button_condenser.Click += new System.EventHandler(this.button_condenser_Click);
            // 
            // button_Evaporator
            // 
            this.button_Evaporator.Location = new System.Drawing.Point(100, 264);
            this.button_Evaporator.Name = "button_Evaporator";
            this.button_Evaporator.Size = new System.Drawing.Size(100, 60);
            this.button_Evaporator.TabIndex = 2;
            this.button_Evaporator.Text = "蒸发器";
            this.button_Evaporator.UseVisualStyleBackColor = true;
            this.button_Evaporator.Click += new System.EventHandler(this.button_Evaporator_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(702, 433);
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
    }
}