using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace YouTube_DownloaderAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                button1Download.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      //  BackgroundWorker backgroundWorker;
        private void ProgressBar_test1(byte [] bytes)
        { // this is first try  - not working from internet  bcse buffer is not recgnised
            var array = bytes;
            using (Stream stream = new MemoryStream(array))

            using (var writer = new BinaryWriter(stream))
            {
                var bytesleft = array.Length;
                
                var bytesWriten = 0;
                while (bytesleft > 0)
                {
                    var chunksize = Math.Min(64, bytesleft);
                    writer.Write(array, bytesWriten, chunksize);
                    bytesWriten += chunksize;
                    bytesleft -= chunksize;
                   // backgroundWorker = new BackgroundWorker();
                    //backgroundWorker.ReportProgress(bytesWriten * 100 / array.Length);
                    progressBar1.Value = (bytesWriten * 100 / array.Length);
                }

            }
        }

        private void ProgressBar_tes2(byte [] buffer,string filepathname)
        {
            Stream stream = File.OpenRead(filepathname);
            
            while(stream.Read(buffer,0,256)>0)
            {
                progressBar1.Value = (100 * buffer.Length) / buffer.Length;
            }

                       

        }
        private void button1Download_Click(object sender, EventArgs e)
        {
            DownloadOneVideo();


        }
         
        private void DownloadOneVideo()
        {
             

            
            VideoDownload videoDownload = new VideoDownload();
            videoDownload.PATH = AppDomain.CurrentDomain.BaseDirectory;
            videoDownload.url = MainUritextBox.Text;
            

            if (comboBox1.SelectedItem.ToString() != null)
            {
                videoDownload.qualityX = int.Parse(comboBox1.SelectedItem.ToString());
            }
            else
            {
                comboBox1.SelectedIndex = 3;
            }
            videoDownload.StartAction() ;
            ProgressBar_tes2(videoDownload.VideoStreambytes, videoDownload.fullpathfile);
            MessageBox.Show(videoDownload.ErrorexceptionMessage);
        }



        
    }
}
