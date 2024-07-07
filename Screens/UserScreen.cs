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
        private string BooksDataFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\BooksInfo.txt";
        public UserScreen()
        {
            InitializeComponent();
            InitilizeBooks();
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

        private void InitilizeBooks()
        {
            #region
            books = new List<Books>
            {
                new Books
            {
                Title = "Ahmet Hamdi Tanpınar   Saatleri Ayarlama Enstitüsü.pdf",
                Author = "Author A",
                Genre = "Genre A",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Ahmet Hamdi Tanpınar   Saatleri Ayarlama Enstitüsü cover.jpg"),
                Category = "Story",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Ahmet Hamdi Tanpınar   Saatleri Ayarlama Enstitüsü.pdf"
            },
            new Books
            {
                Title = "Alfred Mill Herkes İçin Ekonomi 101 Say Yayınları.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Alfred Mill Herkes İçin Ekonomi 101 Say Yayınları.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Alfred Mill Herkes İçin Ekonomi 101 Say Yayınları.pdf"
            },
            new Books
            {
                Title = "Carl Sagan Kozmos Altın Kitaplar.pdf",
                Author = "Author C",
                Genre = "Genre C",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Carl Sagan Kozmos Altın Kitaplar.jpg"),
                Category = "Cartoon",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Carl Sagan Kozmos Altın Kitaplar.pdf"
            },
            new Books
            {
                Title = "Dan Brown - İhanet Noktası.pdf",
                Author = "Author D",
                Genre = "Genre D",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Dan Brown - İhanet Noktası.jpg"),
                Category = "Tale",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Dan Brown - İhanet Noktası.pdf"
            },
            new Books
            {
                Title = "David Eagleman - Incognito  Beynin Gizli Hayatı.pdf",
                Author = "Author E",
                Genre = "Genre E",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\David Eagleman - Incognito  Beynin Gizli Hayatı.jpg"),
                Category = "Story",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\David Eagleman - Incognito  Beynin Gizli Hayatı.pdf"
            },
            new Books
            {
                Title = "Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.pdf",
                Author = "Author F",
                Genre = "Genre F",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.pdf"
            },
            new Books
            {
                Title = "Evren 101.pdf",
                Author = "Author G",
                Genre = "Genre G",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Evren 101.jpg"),
                Category = "Cartoon",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Evren 101.pdf"
            },
            new Books
            {
                Title = "Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.pdf",
                Author = "Author H",
                Genre = "Genre H",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.jpg"),
                Category = "Tale",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.pdf"
            },
            new Books
            {
                Title = "Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.pdf",
                Author = "Author I",
                Genre = "Genre I",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.jpg"),
                Category = "Story",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.pdf"
            },
            new Books
            {
                Title = "Jack Schwager - Borsa Sihirbazları.pdf",
                Author = "Author J",
                Genre = "Genre J",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Jack Schwager - Borsa Sihirbazları.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Jack Schwager - Borsa Sihirbazları.pdf"
            },
            new Books
            {
                Title = "Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.pdf",
                Author = "Author K",
                Genre = "Genre K",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.jpg"),
                Category = "Cartoon",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.pdf"
            },
            new Books
            {
                Title = "Sabahattin Ali Kürk Mantolu Madonna YKY (2).pdf",
                Author = "Author L",
                Genre = "Genre L",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Sabahattin Ali Kürk Mantolu Madonna YKY (2).jpg"),
                Category = "Tale",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Sabahattin Ali Kürk Mantolu Madonna YKY (2).pdf"
            },
            new Books
            {
                Title = "Stephen King - Peri Masalı.pdf",
                Author = "Author M",
                Genre = "Genre M",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Stephen King - Peri Masalı.jpg"),
                Category = "Story",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Stephen King - Peri Masalı.pdf"
            },
            new Books
            {
                Title = "Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.pdf",
                Author = "Author N",
                Genre = "Genre N",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.jpg"),
                Category = "Cartoon",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.pdf"
            },
            // Add more books as needed
            };

            SaveBooksToFile(BooksDataFilePath, books);
            #endregion
        }

        public void SaveBooksToFile(string filePath, List<Books> books)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (Books book in books)
                {
                    string bookData = $"{book.Title}|{book.Author}|{book.Genre}|{book.CoverImage.Tag}|{book.Category}|{book.ContentFilePath}";
                    writer.WriteLine(bookData);
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
