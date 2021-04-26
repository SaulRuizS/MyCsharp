namespace Basic_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.digitsBox = new System.Windows.Forms.RichTextBox();
            this.btndot = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btneq = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digitsBox
            // 
            this.digitsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.digitsBox.BackColor = System.Drawing.SystemColors.Window;
            this.digitsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.digitsBox.DetectUrls = false;
            this.digitsBox.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitsBox.ForeColor = System.Drawing.Color.DimGray;
            this.digitsBox.Location = new System.Drawing.Point(8, 12);
            this.digitsBox.MaxLength = 9999;
            this.digitsBox.Multiline = false;
            this.digitsBox.Name = "digitsBox";
            this.digitsBox.ReadOnly = true;
            this.digitsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.digitsBox.Size = new System.Drawing.Size(230, 57);
            this.digitsBox.TabIndex = 6;
            this.digitsBox.Text = "";
            this.digitsBox.TextChanged += new System.EventHandler(this.DigitsBox_TextChanged);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btndot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndot.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btndot.FlatAppearance.BorderSize = 0;
            this.btndot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btndot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btndot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndot.Image = global::Basic_Calculator.Properties.Resources.dot;
            this.btndot.Location = new System.Drawing.Point(128, 294);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(67, 62);
            this.btndot.TabIndex = 40;
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.Btndot_Click);
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsum.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnsum.FlatAppearance.BorderSize = 0;
            this.btnsum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnsum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnsum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsum.Image = global::Basic_Calculator.Properties.Resources.Char_plus;
            this.btnsum.Location = new System.Drawing.Point(227, 243);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(64, 45);
            this.btnsum.TabIndex = 39;
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.Btnsum_Click);
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnrest.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnrest.FlatAppearance.BorderSize = 0;
            this.btnrest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnrest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrest.Image = global::Basic_Calculator.Properties.Resources.Char_minus1;
            this.btnrest.Location = new System.Drawing.Point(227, 192);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(64, 45);
            this.btnrest.TabIndex = 38;
            this.btnrest.UseVisualStyleBackColor = false;
            this.btnrest.Click += new System.EventHandler(this.Btnrest_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmult.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnmult.FlatAppearance.BorderSize = 0;
            this.btnmult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnmult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Image = global::Basic_Calculator.Properties.Resources.Char_mult;
            this.btnmult.Location = new System.Drawing.Point(227, 141);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(64, 45);
            this.btnmult.TabIndex = 37;
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.Btnmult_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Image = global::Basic_Calculator.Properties.Resources.Char_3;
            this.btn3.Location = new System.Drawing.Point(154, 226);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 62);
            this.btn3.TabIndex = 36;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = global::Basic_Calculator.Properties.Resources.Char_2;
            this.btn2.Location = new System.Drawing.Point(81, 226);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 62);
            this.btn2.TabIndex = 35;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::Basic_Calculator.Properties.Resources.Char_1;
            this.btn1.Location = new System.Drawing.Point(8, 226);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 62);
            this.btn1.TabIndex = 34;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = global::Basic_Calculator.Properties.Resources.Char_6;
            this.btn6.Location = new System.Drawing.Point(154, 158);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 62);
            this.btn6.TabIndex = 33;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = global::Basic_Calculator.Properties.Resources.Char_5;
            this.btn5.Location = new System.Drawing.Point(81, 158);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 62);
            this.btn5.TabIndex = 32;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = global::Basic_Calculator.Properties.Resources.Char_4;
            this.btn4.Location = new System.Drawing.Point(8, 158);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 62);
            this.btn4.TabIndex = 31;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Image = global::Basic_Calculator.Properties.Resources.Char_9;
            this.btn9.Location = new System.Drawing.Point(154, 90);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 62);
            this.btn9.TabIndex = 30;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Image = global::Basic_Calculator.Properties.Resources.Char_8;
            this.btn8.Location = new System.Drawing.Point(81, 90);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 62);
            this.btn8.TabIndex = 29;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btneq
            // 
            this.btneq.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btneq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneq.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btneq.FlatAppearance.BorderSize = 0;
            this.btneq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btneq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btneq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneq.Image = global::Basic_Calculator.Properties.Resources.equal;
            this.btneq.Location = new System.Drawing.Point(201, 294);
            this.btneq.Name = "btneq";
            this.btneq.Size = new System.Drawing.Size(90, 62);
            this.btneq.TabIndex = 17;
            this.btneq.UseVisualStyleBackColor = false;
            this.btneq.Click += new System.EventHandler(this.btneq_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Image = global::Basic_Calculator.Properties.Resources.Char_0;
            this.btn0.Location = new System.Drawing.Point(8, 294);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(114, 62);
            this.btn0.TabIndex = 16;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Image = global::Basic_Calculator.Properties.Resources.Char_7;
            this.btn7.Location = new System.Drawing.Point(8, 90);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 62);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndiv.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btndiv.FlatAppearance.BorderSize = 0;
            this.btndiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btndiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Image = global::Basic_Calculator.Properties.Resources.Char_divisor1;
            this.btndiv.Location = new System.Drawing.Point(227, 90);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(64, 45);
            this.btndiv.TabIndex = 1;
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.Btndiv_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnc.FlatAppearance.BorderSize = 0;
            this.btnc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnc.Image = global::Basic_Calculator.Properties.Resources.Char_clear;
            this.btnc.Location = new System.Drawing.Point(244, 12);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(47, 57);
            this.btnc.TabIndex = 0;
            this.btnc.Text = "\r\n";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.Btnc_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(298, 368);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btneq);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.digitsBox);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.RichTextBox digitsBox;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btneq;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btndot;
    }
}

