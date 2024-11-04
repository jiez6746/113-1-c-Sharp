namespace HW2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbltocketc = new Label();
            lblticketb = new Label();
            lblticketa = new Label();
            groupBox2 = new GroupBox();
            lbltotal = new Label();
            label10 = new Label();
            saleC = new Label();
            Saleb = new Label();
            lblclassA = new Label();
            label6 = new Label();
            label5 = new Label();
            saleA = new Label();
            btncalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lbltocketc);
            groupBox1.Controls.Add(lblticketb);
            groupBox1.Controls.Add(lblticketa);
            groupBox1.Location = new Point(29, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "已售門票";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox3.Location = new Point(219, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 35);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox2.Location = new Point(219, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 35);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(219, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 35);
            textBox1.TabIndex = 3;
            // 
            // lbltocketc
            // 
            lbltocketc.AutoSize = true;
            lbltocketc.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbltocketc.Location = new Point(90, 232);
            lbltocketc.Name = "lbltocketc";
            lbltocketc.Size = new Size(103, 36);
            lbltocketc.TabIndex = 2;
            lbltocketc.Text = "ClassC";
            lbltocketc.Click += label3_Click;
            // 
            // lblticketb
            // 
            lblticketb.AutoSize = true;
            lblticketb.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblticketb.Location = new Point(90, 150);
            lblticketb.Name = "lblticketb";
            lblticketb.Size = new Size(102, 36);
            lblticketb.TabIndex = 1;
            lblticketb.Text = "ClassB";
            // 
            // lblticketa
            // 
            lblticketa.AutoSize = true;
            lblticketa.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblticketa.Location = new Point(90, 67);
            lblticketa.Name = "lblticketa";
            lblticketa.Size = new Size(104, 36);
            lblticketa.TabIndex = 0;
            lblticketa.Text = "ClassA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbltotal);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(saleC);
            groupBox2.Controls.Add(Saleb);
            groupBox2.Controls.Add(lblclassA);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(saleA);
            groupBox2.Location = new Point(652, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(576, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "總收入";
            // 
            // lbltotal
            // 
            lbltotal.BorderStyle = BorderStyle.Fixed3D;
            lbltotal.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            lbltotal.Location = new Point(201, 276);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(219, 46);
            lbltotal.TabIndex = 11;
            lbltotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label10.Location = new Point(58, 276);
            label10.Name = "label10";
            label10.Size = new Size(85, 36);
            label10.TabIndex = 10;
            label10.Text = "Total";
            // 
            // saleC
            // 
            saleC.BorderStyle = BorderStyle.Fixed3D;
            saleC.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            saleC.Location = new Point(201, 202);
            saleC.Name = "saleC";
            saleC.Size = new Size(219, 46);
            saleC.TabIndex = 9;
            saleC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Saleb
            // 
            Saleb.BorderStyle = BorderStyle.Fixed3D;
            Saleb.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            Saleb.Location = new Point(201, 126);
            Saleb.Name = "Saleb";
            Saleb.Size = new Size(219, 46);
            Saleb.TabIndex = 8;
            Saleb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblclassA
            // 
            lblclassA.BorderStyle = BorderStyle.Fixed3D;
            lblclassA.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            lblclassA.Location = new Point(201, 60);
            lblclassA.Name = "lblclassA";
            lblclassA.Size = new Size(219, 46);
            lblclassA.TabIndex = 7;
            lblclassA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label6.Location = new Point(56, 213);
            label6.Name = "label6";
            label6.Size = new Size(103, 36);
            label6.TabIndex = 6;
            label6.Text = "ClassC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(57, 143);
            label5.Name = "label5";
            label5.Size = new Size(102, 36);
            label5.TabIndex = 6;
            label5.Text = "ClassB";
            // 
            // saleA
            // 
            saleA.AutoSize = true;
            saleA.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            saleA.Location = new Point(57, 55);
            saleA.Name = "saleA";
            saleA.Size = new Size(104, 36);
            saleA.TabIndex = 6;
            saleA.Text = "ClassA";
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(248, 411);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(217, 113);
            btncalculate.TabIndex = 2;
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(578, 411);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(217, 113);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(885, 411);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(217, 113);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 598);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btncalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblticketa;
        private Label lbltocketc;
        private Label lblticketb;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label lblclassA;
        private Label label6;
        private Label label5;
        private Label saleA;
        private Label saleC;
        private Label Saleb;
        private Button btncalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lbltotal;
        private Label label10;
    }
}
