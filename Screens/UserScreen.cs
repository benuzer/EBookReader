using System.IO;
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
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();
            DisplayBooksByCategory();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var results = BooksDataManager.books.Where(book => book.Title.ToLower().Contains(query) ||
                                                               book.Author.ToLower().Contains(query) ||
                                                               book.Genre.ToLower().Contains(query) ||
                                                               book.Category.ToLower().Contains(query)).ToList();

            SearchResultsScreen resultsForm = new SearchResultsScreen(results);
            resultsForm.Show();
        }

        private void DisplayBooksByCategory()
        {
            flpStory.Controls.Clear();
            flpNovel.Controls.Clear();
            flpCartoon.Controls.Clear();
            flpTale.Controls.Clear();

            foreach (var book in BooksDataManager.books)
            {
                PictureBox picBox = new PictureBox
                {
                    Width = 60,
                    Height = 90,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = book.CoverImage,
                    Tag = book.ContentFilePath
                };
                picBox.Click += new EventHandler(PicBox_Click);

                switch (book.Category.ToLower())
                {
                    case "story":
                        flpStory.Controls.Add(picBox);
                        break;
                    case "novel":
                        flpNovel.Controls.Add(picBox);
                        break;
                    case "cartoon":
                        flpCartoon.Controls.Add(picBox);
                        break;
                    case "tale":
                        flpTale.Controls.Add(picBox);
                        break;
                }
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
