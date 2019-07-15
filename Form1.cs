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
            logic.PullVideoAsync();
        }
    }
}
