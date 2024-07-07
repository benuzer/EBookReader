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
        private List<Books> books;
        private string BooksDataFilePath = "C:\\Users\\saeed\\VS Projects 24\\EBookReader\\BooksInfo.txt";
        private static string booksFolder = "C:\\Users\\saeed\\VS Projects 24\\EBookReader\\Books\\";
        private static string imageCoversFolder = "C:\\Users\\saeed\\VS Projects 24\\EBookReader\\CoverImages\\";
        private string[] booksFiles = Directory.GetFiles(booksFolder);
        private string[] coverImagesFiles = Directory.GetFiles(imageCoversFolder);
        public UserScreen()
        {
            InitializeComponent();
            LoadBooks();
            DisplayBooksByCategory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var results = books.Where(book => book.Title.ToLower().Contains(query) ||
                                              book.Author.ToLower().Contains(query) ||
                                              book.Genre.ToLower().Contains(query) ||
                                              book.Category.ToLower().Contains(query)).ToList();

            SearchResultsScreen resultsForm = new SearchResultsScreen(results);
            resultsForm.Show();
        }

        private void LoadBooks()
        {
            books = new List<Books>();
            if (File.Exists(BooksDataFilePath))
            {
                var lines = File.ReadAllLines(BooksDataFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    books.Add(new Books
                    {
                        Title = parts[0],
                        Author = parts[1],
                        Genre = parts[2],
                        CoverImage = Image.FromFile(parts[3]),
                        Category = parts[4],
                        ContentFilePath = parts[5]
                    });
                }
            }
        }

        private void DisplayBooksByCategory()
        {
            flpStory.Controls.Clear();
            flpNovel.Controls.Clear();
            flpCartoon.Controls.Clear();
            flpTale.Controls.Clear();

            foreach (var book in books)
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
            //BookReaderForm readerForm = new BookReaderForm(bookContentFilePath);
            //readerForm.Show();
        }
    }
}
