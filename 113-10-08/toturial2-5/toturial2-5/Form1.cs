
/*-------------------------------------------------------------------
    �Z��:��ޤ@�A
    �Ǹ�:A113221038
    �m�W:�Ѥl�_
------------------------------------------------------------------*/











namespace toturial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ptxfront_Click(object sender, EventArgs e)
        {

        }
        //��ܼ��J�P�I��
        private void btnBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;     //���visible�ݩʬ���
            ptxfront.Visible = false;

        }
        //��ܼ��J�P����
        private void btnFront_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;

            ptxfront.Visible = true;

        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
