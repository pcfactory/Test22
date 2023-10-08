using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VideoLibrary;

namespace YouTube_DownloaderAPP
{
    class progress
    {
          static void Main (string[] args)
        {

            try
            {
                Console.WriteLine("Input Link To Video");
                string videolink = Console.ReadLine();
                Console.WriteLine("Input Resolution ");
                int resolution = int.Parse(Console.ReadLine());

                SaveVideoToDisk(videolink, resolution);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        } // end main


      static  void SaveVideoToDisk(string link,int Resolution)
        {
            try
            {
                int[] restion = { 144, 240, 360, 480, 720, 1080 };
            GetBack:;
                foreach (int ii in restion)
                {
                    if (ii == Resolution)
                    {
                        Resolution = ii;
                    }
                    else
                    {
                        Console.WriteLine("Please Input Corrected Resolution  144/240/360/480/720/1080");
                        goto GetBack;
                    }

                }
                var youTube = YouTube.Default; // starting point for YouTube actions
                var video = youTube.GetVideo(link); // gets a Video object with info about the video
                var videoInfos = youTube.GetAllVideosAsync(link).GetAwaiter().GetResult();
                var maxResolution = videoInfos.First(i => i.Resolution == videoInfos.Max(j => Resolution));
                var videoFormat = videoInfos.First(i => i.Format == VideoFormat.Mp4);
                var adaptive = videoInfos.First(i => i.IsAdaptive);


                if (!File.Exists(@"D:\YOUTUBE"))
                {
                    Directory.CreateDirectory(@"D:\YOUTUBE");
                }

                File.WriteAllBytes(@"D:\" + video.FullName, maxResolution.GetBytes());

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }


        private async Task Progress(string link)
        {


            try
            {
                var youtube = YouTube.Default;
                var video = youtube.GetVideo(link);
                var client = new HttpClient();
                long? totalByte = 0;
                using (Stream output = File.OpenWrite("C:\\Users" + video.Title))
                {
                    using (var request = new HttpRequestMessage(HttpMethod.Head, video.Uri))
                    {
                        totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                    }
                    using (var input = await client.GetStreamAsync(video.Uri))
                    {
                        byte[] buffer = new byte[16 * 1024];
                        int read;
                        int totalRead = 0;
                        Console.WriteLine("Download Started");
                        while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            output.Write(buffer, 0, read);
                            totalRead += read;
                            Console.Write($"\rDownloading {totalRead}/{totalByte} ...");
                        }
                        Console.WriteLine("Download Complete");
                    }
                }
            }
            catch(Exception ex)
            {

            }
            Console.ReadLine();

        }



    }
}
