namespace tutorial3_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbkm = new TextBox();
            txbliter = new TextBox();
            lblshow = new Label();
            btncalculate = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(211, 68);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(211, 149);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 1;
            label2.Text = "耗油量";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(211, 232);
            label3.Name = "label3";
            label3.Size = new Size(253, 30);
            label3.TabIndex = 2;
            label3.Text = "平均一公升跑多少公里";
            // 
            // txbkm
            // 
            txbkm.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbkm.Location = new Point(476, 77);
            txbkm.Name = "txbkm";
            txbkm.Size = new Size(197, 34);
            txbkm.TabIndex = 3;
            // 
            // txbliter
            // 
            txbliter.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbliter.Location = new Point(476, 160);
            txbliter.Name = "txbliter";
            txbliter.Size = new Size(197, 32);
            txbliter.TabIndex = 5;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblshow.Location = new Point(476, 222);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(263, 56);
            lblshow.TabIndex = 6;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btncalculate
            // 
            btncalculate.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btncalculate.Location = new Point(305, 334);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(177, 96);
            btncalculate.TabIndex = 7;
            btncalculate.Text = "計算";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnexit.Location = new Point(562, 334);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(177, 96);
            btnexit.TabIndex = 8;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexit);
            Controls.Add(btncalculate);
            Controls.Add(lblshow);
            Controls.Add(txbliter);
            Controls.Add(txbkm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbkm;
        private TextBox txbliter;
        private Label lblshow;
        private Button btncalculate;
        private Button btnexit;
    }
}
