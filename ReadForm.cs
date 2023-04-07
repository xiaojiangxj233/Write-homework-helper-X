using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write_homework_helper_X
{
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
            webView21.Dock = DockStyle.Fill;
            Controls.Add(webView21);
            webView21.Source = new Uri("https://www.baidu.com");
            webView21.EnsureCoreWebView2Async();


        }

        private void qianbtn_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();

        }

        private void houbtn_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }

        private void reloadbtn_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();

        }

        private void fwbtn_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(textBox1.Text);

        }

        private void ReadForm_Load(object sender, EventArgs e)
        {

        }

        private void ReadForm_SizeChanged(object sender, EventArgs e)
        {
            webView21.Width = this.Width - 10;
            webView21.Height = this.Height;
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            hideall.Show();
            textBox1.Show();
            qianbtn.Show();
            houbtn.Show();
            reloadbtn.Show();
            fwbtn.Show();
        }

        private void hideall_Click(object sender, EventArgs e)
        {
            hideall.Hide();
            textBox1.Hide();
            qianbtn.Hide();
            houbtn.Hide();
            reloadbtn.Hide();
            fwbtn.Hide();
        }
    }
}
