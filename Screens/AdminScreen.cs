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
            LoadBooks();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var results = BooksDataManager.Books.Where(book => book.Title.ToLower().Contains(query) ||
                                              book.Author.ToLower().Contains(query) ||
                                              book.Genre.ToLower().Contains(query) ||
                                              book.Category.ToLower().Contains(query)).ToList();
            SearchResultsScreen resultsForm = new SearchResultsScreen(results);
            resultsForm.Show();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var selectedBook = (Books)dgvBooks.SelectedRows[0].DataBoundItem;
                BooksDataManager.RemoveBook(selectedBook);
                LoadBooks();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Cover Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string coverImagePath = openFileDialog.FileName;

                openFileDialog.Title = "Select Content File";
                openFileDialog.Filter = "PDF Files|*.pdf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string contentFilePath = openFileDialog.FileName;

                    var book = new Books
                    {
                        Title = txtTitle.Text,
                        Author = txtAuthor.Text,
                        Genre = txtGenre.Text,
                        CoverImagePath = coverImagePath,
                        Category = txtCategory.Text,
                        ContentFilePath = contentFilePath
                    };

                    BooksDataManager.AddBook(book);
                    LoadBooks();
                }
            }
        }
    

        private void LoadBooks()
        {
            dgvBooks.DataSource = BooksDataManager.Books.ToList();
        }
        private void SaveBooks()
        {
            var lines = books.Select(b => $"{b.Title}|{b.Author}|{b.Genre}|{b.CoverImage}|{b.Category}|{b.ContentFilePath}");
            File.WriteAllLines(BooksDataFilePath, lines);
        }




    }
}
