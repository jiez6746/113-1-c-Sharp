namespace tutorial3_1
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
            label4 = new Label();
            txtweek = new TextBox();
            txtyear = new TextBox();
            txtmounth = new TextBox();
            txtday = new TextBox();
            lblshow = new Label();
            btnshowday = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            label1.Location = new Point(308, 77);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            label2.Location = new Point(308, 141);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            label3.Location = new Point(308, 210);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            label4.Location = new Point(308, 269);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtweek
            // 
            txtweek.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtweek.Location = new Point(452, 77);
            txtweek.Name = "txtweek";
            txtweek.Size = new Size(198, 48);
            txtweek.TabIndex = 4;
            txtweek.TextChanged += txtdayweek_TextChanged;
            // 
            // txtyear
            // 
            txtyear.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtyear.Location = new Point(452, 269);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(198, 48);
            txtyear.TabIndex = 5;
            // 
            // txtmounth
            // 
            txtmounth.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtmounth.Location = new Point(452, 210);
            txtmounth.Name = "txtmounth";
            txtmounth.Size = new Size(198, 48);
            txtmounth.TabIndex = 6;
            // 
            // txtday
            // 
            txtday.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtday.Location = new Point(452, 141);
            txtday.Name = "txtday";
            txtday.Size = new Size(198, 48);
            txtday.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblshow.Location = new Point(276, 389);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(459, 77);
            lblshow.TabIndex = 8;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnshowday
            // 
            btnshowday.Location = new Point(151, 499);
            btnshowday.Name = "btnshowday";
            btnshowday.Size = new Size(160, 79);
            btnshowday.TabIndex = 9;
            btnshowday.Text = "顯示完整日期";
            btnshowday.UseVisualStyleBackColor = true;
            btnshowday.Click += btnshowday_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(435, 499);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(160, 79);
            btnclear.TabIndex = 10;
            btnclear.Text = "清空內容";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(745, 499);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(160, 79);
            btnexit.TabIndex = 11;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 636);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshowday);
            Controls.Add(lblshow);
            Controls.Add(txtday);
            Controls.Add(txtmounth);
            Controls.Add(txtyear);
            Controls.Add(txtweek);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtweek;
        private TextBox txtyear;
        private TextBox txtmounth;
        private TextBox txtday;
        private Label lblshow;
        private Button btnshowday;
        private Button btnclear;
        private Button btnexit;
    }
}
