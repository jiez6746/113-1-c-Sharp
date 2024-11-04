namespace Test_Average
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
            this.testBox1 = new System.Windows.Forms.TextBox();
            this.testBox2 = new System.Windows.Forms.TextBox();
            this.testBox3 = new System.Windows.Forms.TextBox();
            this.test1PromptLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBox1
            // 
            this.testBox1.Location = new System.Drawing.Point(153, 21);
            this.testBox1.Margin = new System.Windows.Forms.Padding(4);
            this.testBox1.Name = "testBox1";
            this.testBox1.Size = new System.Drawing.Size(148, 29);
            this.testBox1.TabIndex = 0;
            // 
            // testBox2
            // 
            this.testBox2.Location = new System.Drawing.Point(153, 57);
            this.testBox2.Margin = new System.Windows.Forms.Padding(4);
            this.testBox2.Name = "testBox2";
            this.testBox2.Size = new System.Drawing.Size(148, 29);
            this.testBox2.TabIndex = 1;
            // 
            // testBox3
            // 
            this.testBox3.Location = new System.Drawing.Point(153, 93);
            this.testBox3.Margin = new System.Windows.Forms.Padding(4);
            this.testBox3.Name = "testBox3";
            this.testBox3.Size = new System.Drawing.Size(148, 29);
            this.testBox3.TabIndex = 2;
            // 
            // test1PromptLabel
            // 
            this.test1PromptLabel.AutoSize = true;
            this.test1PromptLabel.Location = new System.Drawing.Point(78, 25);
            this.test1PromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test1PromptLabel.Name = "test1PromptLabel";
            this.test1PromptLabel.Size = new System.Drawing.Size(56, 18);
            this.test1PromptLabel.TabIndex = 3;
            this.test1PromptLabel.Text = "Test 1:";
            // 
            // test2PromptLabel
            // 
            this.test2PromptLabel.AutoSize = true;
            this.test2PromptLabel.Location = new System.Drawing.Point(78, 66);
            this.test2PromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(56, 18);
            this.test2PromptLabel.TabIndex = 4;
            this.test2PromptLabel.Text = "Test 2:";
            // 
            // test3PromptLabel
            // 
            this.test3PromptLabel.AutoSize = true;
            this.test3PromptLabel.Location = new System.Drawing.Point(78, 102);
            this.test3PromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(56, 18);
            this.test3PromptLabel.TabIndex = 5;
            this.test3PromptLabel.Text = "Test 3:";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(200, 138);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(149, 31);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(33, 145);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(150, 18);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "Average Test Score:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(14, 198);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 50);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(135, 198);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 50);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(256, 198);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 50);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 270);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromptLabel);
            this.Controls.Add(this.testBox3);
            this.Controls.Add(this.testBox2);
            this.Controls.Add(this.testBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testBox1;
        private System.Windows.Forms.TextBox testBox2;
        private System.Windows.Forms.TextBox testBox3;
        private System.Windows.Forms.Label test1PromptLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

