namespace Write_homework_helper_X
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            fullscreenbtn = new Button();
            unfullscreenbtn = new Button();
            zdbtn = new Button();
            unzdbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 23);
            label1.Name = "label1";
            label1.Size = new Size(820, 124);
            label1.TabIndex = 0;
            label1.Text = "认真写作业！！！";
            // 
            // fullscreenbtn
            // 
            fullscreenbtn.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            fullscreenbtn.Location = new Point(113, 150);
            fullscreenbtn.Name = "fullscreenbtn";
            fullscreenbtn.Size = new Size(287, 83);
            fullscreenbtn.TabIndex = 1;
            fullscreenbtn.Text = "全屏";
            fullscreenbtn.UseVisualStyleBackColor = true;
            fullscreenbtn.Click += fullscreenbtn_Click;
            // 
            // unfullscreenbtn
            // 
            unfullscreenbtn.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            unfullscreenbtn.Location = new Point(113, 150);
            unfullscreenbtn.Name = "unfullscreenbtn";
            unfullscreenbtn.Size = new Size(287, 83);
            unfullscreenbtn.TabIndex = 2;
            unfullscreenbtn.Text = "取消全屏";
            unfullscreenbtn.UseVisualStyleBackColor = true;
            unfullscreenbtn.Click += unfullscreenbtn_Click;
            // 
            // zdbtn
            // 
            zdbtn.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            zdbtn.Location = new Point(532, 150);
            zdbtn.Name = "zdbtn";
            zdbtn.Size = new Size(287, 83);
            zdbtn.TabIndex = 3;
            zdbtn.Text = "置顶";
            zdbtn.UseVisualStyleBackColor = true;
            zdbtn.Click += zdbtn_Click;
            // 
            // unzdbtn
            // 
            unzdbtn.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            unzdbtn.Location = new Point(532, 150);
            unzdbtn.Name = "unzdbtn";
            unzdbtn.Size = new Size(287, 83);
            unzdbtn.TabIndex = 4;
            unzdbtn.Text = "取消置顶";
            unzdbtn.UseVisualStyleBackColor = true;
            unzdbtn.Click += unzdbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 543);
            Controls.Add(zdbtn);
            Controls.Add(unzdbtn);
            Controls.Add(fullscreenbtn);
            Controls.Add(unfullscreenbtn);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button fullscreenbtn;
        private Button unfullscreenbtn;
        private Button zdbtn;
        private Button unzdbtn;
    }
}