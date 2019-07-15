using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
using YoutubeSearch;

namespace MusikiPlayer
{
    public partial class MusikiPlayer : Form
    {
        
        Logic logic;
        Task t;

        public MusikiPlayer()
        {
            InitializeComponent();

            logic = new Logic();
            logic.logsBox = logsBox;

            Settings.Run(logic);
        }       

        private void ExplorerSearchButton_Click(object sender, EventArgs e)
        {
            logic.SearchYoutube(explorerSearchTextBox.Text, searchResultsGrid);
        }

        private void SearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var v = searchResultsGrid.SelectedCells;
            var rowIndex = v[0].RowIndex;

            var selectedVideo = logic.foundVideos[rowIndex];
            logic.selectedVideo = selectedVideo;

            string s = String.Empty;
            s += "TITLE: " + selectedVideo.Title + "\n";
            s += "AUTHOR: " + selectedVideo.Author + "\n";
            if (selectedVideo.isInLibrary && !selectedVideo.isDownloading)
                s += "STATUS: In Library";
            else if (selectedVideo.isDownloading)
                s += "STATUS: Downloading";
            else if(!selectedVideo.isInLibrary && !selectedVideo.isDownloading)
                s += "STATUS: Not In Library";

            searchResultDetailTextBox.Text = s;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        { 
            t = logic.PullVideoAsync();            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(logic.currentFile != null)
            {
                var size = new FileInfo(logic.currentFile).Length;
                size /= 1024;
                size /= 1024;

                MessageBox.Show(size.ToString());
                logsBox.Items.Add("Downloaded Size:" + size.ToString());
            }

            if (t != null)
            {
                //logsBox.Items.Add(t.Status.ToString());

                if (t.IsFaulted)
                    logsBox.Items.Add(t.Exception.InnerExceptions[0].ToString());
            }
        }
    }
}
