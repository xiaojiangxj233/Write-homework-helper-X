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
            zdbtn.Hide(); // ���ص�ǰ�ؼ�
            this.TopMost = true; // �������ö�
        }

        private void unzdbtn_Click(object sender, EventArgs e)
        {
            zdbtn.Show();
            this.TopMost = false;
        }

        private void fullscreenbtn_Click(object sender, EventArgs e)
        {
            // ���ص�ǰ�ؼ�
            this.fullscreenbtn.Hide();
            // ������״̬����Ϊ���
            // ���ر�����
            this.FormBorderStyle = FormBorderStyle.None;
            // ����ȫ��
            this.WindowState = FormWindowState.Maximized;
        }

        private void unfullscreenbtn_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // ������״̬����Ϊ������С
            this.WindowState = FormWindowState.Normal;
            // ��ʾȫ����ť
            fullscreenbtn.Show();
        }
    }
}