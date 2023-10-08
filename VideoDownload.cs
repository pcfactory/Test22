using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace YouTube_DownloaderAPP
{
    class VideoDownload
    {
        public virtual string url { get; set; }
        public virtual string[] urls { get; set; }
        public int qualityX { get; set; }
        public string fullpathfile { get; set; }
        public byte[] VideoStreambytes { get; set; }
        public Stream videostream { get; set; }
        public string Uris { get; set; }
        public virtual string ErrorexceptionMessage { get; set; }

        public virtual string PATH { get; set; }

        public VideoDownload()
        {

            

        }

        private void ProcessClosed()
        {

        }

        
            void DownloadOneVideo()
        {

            var youtube = YouTube.Default;
            
            var videoInfos = youtube.GetAllVideosAsync(url).GetAwaiter().GetResult();
            var video = youtube.GetVideo(url);
           

            // не работает 

            try
            {
                var maxResolution = videoInfos.First(i => i.Resolution == qualityX);
                VideoStreambytes = maxResolution.GetBytes();
                
                if (!Directory.Exists(PATH + @"\YOUTUBE"))
                {

                    Directory.CreateDirectory(PATH + @"\YOUTUBE");

                }
                // progress 
                                 
                
              



                File.WriteAllBytes(PATH + @"\YOUTUBE\" + video.FullName, maxResolution.GetBytes());

            

            }
            catch(Exception ex)
            {

                ErrorexceptionMessage = ex.Message;
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Errorslog_add2.txt", "\n" +"Error time is -"+
                    DateTime.Now.ToString() +" URL= "+ url+" Quality= " + qualityX.ToString());
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"Errorslog.txt","\n"+DateTime.Now.ToString()+"  "+ex.Message);
                ProcessClosed();
                
            }

        }
        
        public   void  StartAction()
        {


            Thread thread = new Thread(new ThreadStart(DownloadOneVideo));
            thread.Start();
            



           // Action action = new Action(DownloadOneVideo);
            
            
             

        }
         



    }
}
