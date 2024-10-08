namespace toturial2_5
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
            ptxBack = new PictureBox();
            ptxfront = new PictureBox();
            btnBack = new Button();
            btnFront = new Button();
            btnesit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(140, 43);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(177, 262);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            ptxBack.Click += pictureBox1_Click;
            // 
            // ptxfront
            // 
            ptxfront.Image = Properties.Resources.Ace_Spades;
            ptxfront.Location = new Point(417, 43);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(177, 262);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            ptxfront.Click += ptxfront_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(140, 334);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 88);
            btnBack.TabIndex = 2;
            btnBack.Text = "背面";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnFront
            // 
            btnFront.Location = new Point(432, 334);
            btnFront.Name = "btnFront";
            btnFront.Size = new Size(162, 88);
            btnFront.TabIndex = 3;
            btnFront.Text = "正面";
            btnFront.UseVisualStyleBackColor = true;
            btnFront.Click += btnFront_Click;
            // 
            // btnesit
            // 
            btnesit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnesit.Location = new Point(266, 485);
            btnesit.Name = "btnesit";
            btnesit.Size = new Size(231, 131);
            btnesit.TabIndex = 4;
            btnesit.Text = "離開";
            btnesit.UseVisualStyleBackColor = true;
            btnesit.Click += btnesit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 728);
            Controls.Add(btnesit);
            Controls.Add(btnFront);
            Controls.Add(btnBack);
            Controls.Add(ptxfront);
            Controls.Add(ptxBack);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxfront;
        private Button btnBack;
        private Button btnFront;
        private Button btnesit;
    }
}
