using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookReader
{
    public partial class SearchResultsScreen : Form
    {
        private readonly List<Books> _searchResults;
        public SearchResultsScreen(List<Books> results)
        {
            InitializeComponent();
            _searchResults = results;
            DisplaySearchResults(_searchResults);
        }

        private void DisplaySearchResults(List<Books> searchResults)
        {
            flpSearchResults.Controls.Clear();

            foreach (var book in searchResults)
            {
                PictureBox picBox = new PictureBox
                {
                    Width = 60,
                    Height = 90,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = book.CoverImage,
                    Tag = book.ContentFilePath
                };
                picBox.Click += new System.EventHandler(PicBox_Click);
                flpSearchResults.Controls.Add(picBox);
            }
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            string bookContentFilePath = picBox.Tag.ToString();
            OpenBookInDefaultViewer(bookContentFilePath);
        }

        private void OpenBookInDefaultViewer(string filePath)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the book. Error: " + ex.Message);
            }
        }

    }
}
