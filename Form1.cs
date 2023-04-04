using System.Diagnostics;
using System;

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

        private void playerbtn_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();
            playerForm.Show(this);
        }

        private void setbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ŀǰ��û��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������xiaojiang233\n������ChatGPT", "����");
        }

        private void morebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ŀǰ��û�и��๦����", "���๦��", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}