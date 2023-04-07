namespace Write_homework_helper_X
{
    partial class ReadForm
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            textBox1 = new TextBox();
            fwbtn = new Button();
            reloadbtn = new Button();
            qianbtn = new Button();
            houbtn = new Button();
            hideall = new Button();
            showbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(3, 68);
            webView21.Name = "webView21";
            webView21.Size = new Size(1129, 537);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(816, 23);
            textBox1.TabIndex = 1;
            // 
            // fwbtn
            // 
            fwbtn.Location = new Point(996, 3);
            fwbtn.Name = "fwbtn";
            fwbtn.Size = new Size(81, 25);
            fwbtn.TabIndex = 2;
            fwbtn.Text = "访问";
            fwbtn.UseVisualStyleBackColor = true;
            fwbtn.Click += fwbtn_Click;
            // 
            // reloadbtn
            // 
            reloadbtn.Location = new Point(85, -2);
            reloadbtn.Name = "reloadbtn";
            reloadbtn.Size = new Size(85, 32);
            reloadbtn.TabIndex = 3;
            reloadbtn.Text = "刷新";
            reloadbtn.UseVisualStyleBackColor = true;
            reloadbtn.Click += reloadbtn_Click;
            // 
            // qianbtn
            // 
            qianbtn.Location = new Point(5, -2);
            qianbtn.Name = "qianbtn";
            qianbtn.Size = new Size(36, 32);
            qianbtn.TabIndex = 4;
            qianbtn.Text = "前";
            qianbtn.UseVisualStyleBackColor = true;
            qianbtn.Click += qianbtn_Click;
            // 
            // houbtn
            // 
            houbtn.Location = new Point(43, -2);
            houbtn.Name = "houbtn";
            houbtn.Size = new Size(36, 32);
            houbtn.TabIndex = 5;
            houbtn.Text = "后";
            houbtn.UseVisualStyleBackColor = true;
            houbtn.Click += houbtn_Click;
            // 
            // hideall
            // 
            hideall.Location = new Point(1076, 2);
            hideall.Name = "hideall";
            hideall.Size = new Size(56, 24);
            hideall.TabIndex = 6;
            hideall.Text = "隐藏";
            hideall.UseVisualStyleBackColor = true;
            hideall.Click += hideall_Click;
            // 
            // showbtn
            // 
            showbtn.Location = new Point(1076, 4);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(56, 24);
            showbtn.TabIndex = 7;
            showbtn.Text = "显示";
            showbtn.UseVisualStyleBackColor = true;
            showbtn.Click += showbtn_Click;
            // 
            // ReadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 607);
            Controls.Add(hideall);
            Controls.Add(houbtn);
            Controls.Add(qianbtn);
            Controls.Add(reloadbtn);
            Controls.Add(fwbtn);
            Controls.Add(textBox1);
            Controls.Add(webView21);
            Controls.Add(showbtn);
            Name = "ReadForm";
            Text = "浏览器";
            Load += ReadForm_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox textBox1;
        private Button fwbtn;
        private Button reloadbtn;
        private Button qianbtn;
        private Button houbtn;
        private Button hideall;
        private Button showbtn;
    }
}