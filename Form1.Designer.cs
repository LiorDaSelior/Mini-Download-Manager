namespace Mini_Download_Manager
{
    partial class DownloaderForm
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
            DownloadButton = new Button();
            label1 = new Label();
            FileNameLabel = new Label();
            FileIconBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FileIconBox).BeginInit();
            SuspendLayout();
            // 
            // DownloadButton
            // 
            DownloadButton.Location = new Point(350, 365);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(75, 23);
            DownloadButton.TabIndex = 0;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(220, 50);
            label1.Name = "label1";
            label1.Size = new Size(340, 37);
            label1.TabIndex = 3;
            label1.Text = "Mini-Download Manager";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(359, 122);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(57, 15);
            FileNameLabel.TabIndex = 4;
            FileNameLabel.Text = "FileName";
            // 
            // FileIconBox
            // 
            FileIconBox.Location = new Point(329, 175);
            FileIconBox.Name = "FileIconBox";
            FileIconBox.Size = new Size(117, 107);
            FileIconBox.TabIndex = 5;
            FileIconBox.TabStop = false;
            FileIconBox.Visible = false;
            FileIconBox.Click += pictureBox1_Click;
            // 
            // DownloaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FileIconBox);
            Controls.Add(FileNameLabel);
            Controls.Add(label1);
            Controls.Add(DownloadButton);
            Name = "DownloaderForm";
            Text = "Mini Downloader Manager";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)FileIconBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DownloadButton;
        private Label label1;
        private Label FileNameLabel;
        private PictureBox FileIconBox;
    }
}
