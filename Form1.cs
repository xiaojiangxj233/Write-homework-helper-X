namespace Write_homework_helper_X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void zdbtn_Click(object sender, EventArgs e)
        {
            zdbtn.Hide(); // 隐藏当前控件
            this.TopMost = true; // 将窗体置顶
        }

        private void unzdbtn_Click(object sender, EventArgs e)
        {
            zdbtn.Show();
            this.TopMost = false;
        }

        private void fullscreenbtn_Click(object sender, EventArgs e)
        {
            // 隐藏当前控件
            this.fullscreenbtn.Hide();
            // 将窗体状态设置为最大化
            // 隐藏标题栏
            this.FormBorderStyle = FormBorderStyle.None;
            // 设置全屏
            this.WindowState = FormWindowState.Maximized;
        }

        private void unfullscreenbtn_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 将窗口状态设置为正常大小
            this.WindowState = FormWindowState.Normal;
            // 显示全屏按钮
            fullscreenbtn.Show();
        }
    }
}