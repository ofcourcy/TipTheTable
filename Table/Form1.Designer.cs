namespace Table
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toplen = new System.Windows.Forms.NumericUpDown();
            this.baselen = new System.Windows.Forms.NumericUpDown();
            this.toplb = new System.Windows.Forms.NumericUpDown();
            this.baselb = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toplen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Top Length:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Top Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Base Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(942, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "lb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "in";
            // 
            // toplen
            // 
            this.toplen.AccessibleName = "TopLen";
            this.toplen.DecimalPlaces = 1;
            this.toplen.Location = new System.Drawing.Point(292, 124);
            this.toplen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toplen.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.toplen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toplen.Name = "toplen";
            this.toplen.Size = new System.Drawing.Size(240, 38);
            this.toplen.TabIndex = 10;
            this.toplen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toplen.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // baselen
            // 
            this.baselen.DecimalPlaces = 1;
            this.baselen.Location = new System.Drawing.Point(292, 200);
            this.baselen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.baselen.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.baselen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baselen.Name = "baselen";
            this.baselen.Size = new System.Drawing.Size(240, 38);
            this.baselen.TabIndex = 11;
            this.baselen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baselen.ValueChanged += new System.EventHandler(this.baselen_ValueChanged);
            // 
            // toplb
            // 
            this.toplb.DecimalPlaces = 1;
            this.toplb.Location = new System.Drawing.Point(914, 122);
            this.toplb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.toplb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.toplb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toplb.Name = "toplb";
            this.toplb.Size = new System.Drawing.Size(240, 38);
            this.toplb.TabIndex = 12;
            this.toplb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toplb.ValueChanged += new System.EventHandler(this.toplb_ValueChanged);
            // 
            // baselb
            // 
            this.baselb.DecimalPlaces = 1;
            this.baselb.Location = new System.Drawing.Point(914, 209);
            this.baselb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.baselb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.baselb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baselb.Name = "baselb";
            this.baselb.Size = new System.Drawing.Size(240, 38);
            this.baselb.TabIndex = 13;
            this.baselb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baselb.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // output
            // 
            this.output.AccessibleName = "Output";
            this.output.Location = new System.Drawing.Point(914, 463);
            this.output.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(372, 38);
            this.output.TabIndex = 14;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 473);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipping Point (lb)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 711);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.output);
            this.Controls.Add(this.baselb);
            this.Controls.Add(this.toplb);
            this.Controls.Add(this.baselen);
            this.Controls.Add(this.toplen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Table Balance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baselb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown toplen;
        private System.Windows.Forms.NumericUpDown baselen;
        private System.Windows.Forms.NumericUpDown toplb;
        private System.Windows.Forms.NumericUpDown baselb;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label7;
    }
}

