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
            ticketC = new Label();
            ticketB = new Label();
            ticketA = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            label10 = new Label();
            lblclassC = new Label();
            lblclassB = new Label();
            lblclassA = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxC);
            groupBox1.Controls.Add(textBoxB);
            groupBox1.Controls.Add(textBoxA);
            groupBox1.Controls.Add(ticketC);
            groupBox1.Controls.Add(ticketB);
            groupBox1.Controls.Add(ticketA);
            groupBox1.Location = new Point(49, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets sold";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(182, 214);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(149, 30);
            textBoxC.TabIndex = 6;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(182, 138);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(149, 30);
            textBoxB.TabIndex = 5;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(182, 62);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(149, 30);
            textBoxA.TabIndex = 4;
            // 
            // ticketC
            // 
            ticketC.AutoSize = true;
            ticketC.Location = new Point(31, 217);
            ticketC.Name = "ticketC";
            ticketC.Size = new Size(65, 23);
            ticketC.TabIndex = 3;
            ticketC.Text = "ClassC";
            // 
            // ticketB
            // 
            ticketB.AutoSize = true;
            ticketB.Location = new Point(31, 145);
            ticketB.Name = "ticketB";
            ticketB.Size = new Size(64, 23);
            ticketB.TabIndex = 2;
            ticketB.Text = "ClassB";
            // 
            // ticketA
            // 
            ticketA.AutoSize = true;
            ticketA.Location = new Point(31, 62);
            ticketA.Name = "ticketA";
            ticketA.Size = new Size(65, 23);
            ticketA.TabIndex = 1;
            ticketA.Text = "ClassA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lblclassC);
            groupBox2.Controls.Add(lblclassB);
            groupBox2.Controls.Add(lblclassA);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(547, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 363);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(170, 283);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(209, 42);
            lblTotal.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 302);
            label10.Name = "label10";
            label10.Size = new Size(53, 23);
            label10.TabIndex = 6;
            label10.Text = "Total";
            // 
            // lblclassC
            // 
            lblclassC.BorderStyle = BorderStyle.Fixed3D;
            lblclassC.Location = new Point(170, 221);
            lblclassC.Name = "lblclassC";
            lblclassC.Size = new Size(209, 42);
            lblclassC.TabIndex = 5;
            // 
            // lblclassB
            // 
            lblclassB.BorderStyle = BorderStyle.Fixed3D;
            lblclassB.Location = new Point(170, 145);
            lblclassB.Name = "lblclassB";
            lblclassB.Size = new Size(209, 47);
            lblclassB.TabIndex = 4;
            lblclassB.Click += label8_Click;
            // 
            // lblclassA
            // 
            lblclassA.BorderStyle = BorderStyle.Fixed3D;
            lblclassA.Location = new Point(170, 56);
            lblclassA.Name = "lblclassA";
            lblclassA.Size = new Size(209, 39);
            lblclassA.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 217);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "ClassC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 145);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "ClassB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 62);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "ClassA";
            // 
            // button1
            // 
            button1.Location = new Point(206, 472);
            button1.Name = "button1";
            button1.Size = new Size(195, 79);
            button1.TabIndex = 2;
            button1.Text = "Calculater";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(500, 472);
            button2.Name = "button2";
            button2.Size = new Size(195, 79);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(809, 472);
            button3.Name = "button3";
            button3.Size = new Size(195, 79);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 616);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private GroupBox groupBox2;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private Label ticketC;
        private Label ticketB;
        private Label ticketA;
        private Label lblclassC;
        private Label lblclassB;
        private Label lblclassA;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTotal;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
