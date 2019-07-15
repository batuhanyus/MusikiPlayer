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
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            logic.PullVideoAsync();

        }

        

        private void ExplorerSearchButton_Click(object sender, EventArgs e)
        {
            logic.SearchYoutube(explorerSearchTextBox.Text, searchResultsGrid);
        }

        private void SearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var v = searchResultsGrid.SelectedCells;
            var rowIndex = v[0].RowIndex;
            //MessageBox.Show(foundVideos[rowIndex].ID.ToString());
        }
    }
}
