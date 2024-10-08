
/*-------------------------------------------------------------------
    班級:資管一乙
    學號:A113221038
    姓名:解子嫻
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
        //顯示撲克牌背面
        private void btnBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;     //顯示visible屬性為假
            ptxfront.Visible = false;

        }
        //顯示撲克牌正面
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
