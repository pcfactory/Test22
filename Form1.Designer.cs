
namespace YouTube_DownloaderAPP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainUritextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Download = new System.Windows.Forms.Button();
            this.textBoxPlaylist = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // MainUritextBox
            // 
            this.MainUritextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainUritextBox.Location = new System.Drawing.Point(59, 85);
            this.MainUritextBox.Name = "MainUritextBox";
            this.MainUritextBox.Size = new System.Drawing.Size(500, 27);
            this.MainUritextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uri";
            // 
            // button1Download
            // 
            this.button1Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Download.Location = new System.Drawing.Point(565, 85);
            this.button1Download.Name = "button1Download";
            this.button1Download.Size = new System.Drawing.Size(215, 29);
            this.button1Download.TabIndex = 2;
            this.button1Download.Text = "Download";
            this.button1Download.UseVisualStyleBackColor = true;
            this.button1Download.Click += new System.EventHandler(this.button1Download_Click);
            // 
            // textBoxPlaylist
            // 
            this.textBoxPlaylist.Location = new System.Drawing.Point(59, 137);
            this.textBoxPlaylist.Multiline = true;
            this.textBoxPlaylist.Name = "textBoxPlaylist";
            this.textBoxPlaylist.Size = new System.Drawing.Size(500, 345);
            this.textBoxPlaylist.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "144",
            "240",
            "360",
            "480",
            "720"});
            this.comboBox1.Location = new System.Drawing.Point(565, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(566, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 498);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxPlaylist);
            this.Controls.Add(this.button1Download);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainUritextBox);
            this.Name = "Form1";
            this.Text = "YouTube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainUritextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Download;
        private System.Windows.Forms.TextBox textBoxPlaylist;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

