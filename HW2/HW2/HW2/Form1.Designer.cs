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
            textBoxC = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            lblclassC = new Label();
            lblclassB = new Label();
            lblclassA = new Label();
            groupBox2 = new GroupBox();
            lbltotal = new Label();
            label10 = new Label();
            saleC = new Label();
            Saleb = new Label();
            saleA = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btncalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxC);
            groupBox1.Controls.Add(textBoxB);
            groupBox1.Controls.Add(textBoxA);
            groupBox1.Controls.Add(lblclassC);
            groupBox1.Controls.Add(lblclassB);
            groupBox1.Controls.Add(lblclassA);
            groupBox1.Location = new Point(29, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "已售門票";
            // 
            // textBoxC
            // 
            textBoxC.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxC.Location = new Point(219, 232);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(201, 35);
            textBoxC.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxB.Location = new Point(219, 150);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(201, 35);
            textBoxB.TabIndex = 4;
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxA.Location = new Point(219, 74);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(201, 35);
            textBoxA.TabIndex = 3;
            // 
            // lblclassC
            // 
            lblclassC.AutoSize = true;
            lblclassC.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblclassC.Location = new Point(90, 232);
            lblclassC.Name = "lblclassC";
            lblclassC.Size = new Size(103, 36);
            lblclassC.TabIndex = 2;
            lblclassC.Text = "ClassC";
            lblclassC.Click += label3_Click;
            // 
            // lblclassB
            // 
            lblclassB.AutoSize = true;
            lblclassB.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblclassB.Location = new Point(90, 150);
            lblclassB.Name = "lblclassB";
            lblclassB.Size = new Size(102, 36);
            lblclassB.TabIndex = 1;
            lblclassB.Text = "ClassB";
            // 
            // lblclassA
            // 
            lblclassA.AutoSize = true;
            lblclassA.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblclassA.Location = new Point(90, 67);
            lblclassA.Name = "lblclassA";
            lblclassA.Size = new Size(104, 36);
            lblclassA.TabIndex = 0;
            lblclassA.Text = "ClassA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbltotal);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(saleC);
            groupBox2.Controls.Add(Saleb);
            groupBox2.Controls.Add(saleA);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(649, 53);
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
            // saleA
            // 
            saleA.BorderStyle = BorderStyle.Fixed3D;
            saleA.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            saleA.Location = new Point(201, 60);
            saleA.Name = "saleA";
            saleA.Size = new Size(219, 46);
            saleA.TabIndex = 7;
            saleA.TextAlign = ContentAlignment.MiddleCenter;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(57, 55);
            label4.Name = "label4";
            label4.Size = new Size(104, 36);
            label4.TabIndex = 6;
            label4.Text = "ClassA";
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
        private Label lblclassA;
        private Label lblclassC;
        private Label lblclassB;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private GroupBox groupBox2;
        private Label saleA;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label saleC;
        private Label Saleb;
        private Button btncalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lbltotal;
        private Label label10;
    }
}
