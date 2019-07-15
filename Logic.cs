using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
using YoutubeSearch;

namespace MusikiPlayer
{
    public class Logic
    {
        public ListBox logsBox;

        public List<Video> foundVideos = new List<Video>();

        public Video selectedVideo;

        public async Task PullVideoAsync()
        {
            logsBox.Items.Add("Pulling video with ID: " + selectedVideo.ID);

            var client = new YoutubeClient();

            // Get metadata for all streams in this video
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync("t1TcDHrkQYg");

            // Select one of the streams, e.g. highest quality muxed stream
            //var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();

            //...or highest bitrate audio stream
            var streamInfo = streamInfoSet.Audio.WithHighestBitrate();

            // ...or highest quality & highest framerate MP4 video stream
            // var streamInfo = streamInfoSet.Video
            //    .Where(s => s.Container == Container.Mp4)
            //    .OrderByDescending(s => s.VideoQuality)
            //    .ThenByDescending(s => s.Framerate)
            //    .First();

            // Get file extension based on stream's container
            var ext = streamInfo.Container.GetFileExtension();

            // Download stream to file
            logsBox.Items.Add("LOL"+Settings.libraryLocation);
            await client.DownloadMediaStreamAsync(streamInfo, $"C:/Users/Raki/Desktop/Debug/Library");

            GC.Collect();
        }

        public void SearchYoutube(string text, DataGridView searchResultsGrid)
        {
            int previousVideoCount = foundVideos.Count;

            VideoSearch search = new VideoSearch();
            var results = search.SearchQuery(text, 1);

            foreach (var item in results)
            {
                Video v = new Video();
                v.Title = item.Title;
                //logsBox.Items.Add(v.Title);
                v.Author = item.Author;
                v.Url = item.Url;
                v.ID = YoutubeClient.ParseVideoId(v.Url);
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    v.Thumbnail = Image.FromStream(ms);
                }

                foundVideos.Add(v);
            }

            for (int i = 0; i < previousVideoCount; i++)
            {
                foundVideos.RemoveAt(0);
            }

            logsBox.Items.Add("Found videos count: " + foundVideos.Count.ToString());

            searchResultsGrid.DataSource = null;
            searchResultsGrid.DataSource = foundVideos;
        }
    }
}
