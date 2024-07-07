using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookReader
{
    public partial class AdminScreen : Form
    {
        
        private List<Books> books;
        private const string BooksDataFilePath = "books_data.txt";
        public AdminScreen()
        {
            InitializeComponent();
            //LoadBooks();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var results = books.Where(book => book.Title.ToLower().Contains(query) ||
                                              book.Author.ToLower().Contains(query) ||
                                              book.Genre.ToLower().Contains(query) ||
                                              book.Category.ToLower().Contains(query)).ToList();
            dgvBooks.DataSource = results;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var selectedBook = (Books)dgvBooks.SelectedRows[0].DataBoundItem;
                books.Remove(selectedBook);
                SaveBooks();
                LoadBooks();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var book = new Books
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Genre = txtGenre.Text,
                //CoverImage = ,
                Category = txtCategory.Text,
                ContentFilePath = txtCoverImage.Text // Assuming the content file path is the same as the cover image for now
            };
            books.Add(book);
            SaveBooks();
            LoadBooks();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCoverImage.Text = openFileDialog.FileName;
            }
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
                        Category = parts[3]
                    });
                }
            }
            dgvBooks.DataSource = books.ToList();
        }
        private void SaveBooks()
        {
            var lines = books.Select(b => $"{b.Title}|{b.Author}|{b.Genre}|{b.CoverImage}|{b.Category}|{b.ContentFilePath}");
            File.WriteAllLines(BooksDataFilePath, lines);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
