namespace Write_homework_helper_X
{
    partial class PlayerForm
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
            openFileDialog = new OpenFileDialog();
            openButton = new Button();
            pauseButton = new Button();
            label1 = new Label();
            button1 = new Button();
            stopButton = new Button();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // openButton
            // 
            openButton.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            openButton.Location = new Point(33, 12);
            openButton.Name = "openButton";
            openButton.Size = new Size(208, 70);
            openButton.TabIndex = 3;
            openButton.Text = "打开.mp3文件";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pauseButton.Location = new Point(33, 195);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(208, 70);
            pauseButton.TabIndex = 4;
            pauseButton.Text = "暂停";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 85);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(33, 119);
            button1.Name = "button1";
            button1.Size = new Size(208, 70);
            button1.TabIndex = 6;
            button1.Text = "播放";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // stopButton
            // 
            stopButton.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stopButton.Location = new Point(33, 271);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(208, 70);
            stopButton.TabIndex = 7;
            stopButton.Text = "停止";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 454);
            Controls.Add(stopButton);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pauseButton);
            Controls.Add(openButton);
            MaximizeBox = false;
            Name = "PlayerForm";
            Text = "音乐播放器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Button openButton;
        private Button pauseButton;
        private Label label1;
        private Button button1;
        private Button stopButton;
    }
}