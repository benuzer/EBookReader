using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookReader
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Image CoverImage { get; set; }
        public string Category { get; set; }
        public string ContentFilePath { get; set; }


        List<Books> books = new List<Books>
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
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Carl Sagan Kozmos Altın Kitaplar.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Carl Sagan Kozmos Altın Kitaplar.pdf"
            },
            new Books
            {
                Title = "Dan Brown - İhanet Noktası.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Dan Brown - İhanet Noktası.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Dan Brown - İhanet Noktası.pdf"
            },
            new Books
            {
                Title = "David Eagleman - Incognito  Beynin Gizli Hayatı.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\David Eagleman - Incognito  Beynin Gizli Hayatı.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\David Eagleman - Incognito  Beynin Gizli Hayatı.pdf"
            },
            new Books
            {
                Title = "Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.pdf",
                Author = "Author A",
                Genre = "Genre A",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.jpg"),
                Category = "Story",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.pdf"
            },
            new Books
            {
                Title = "Evren 101.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Evren 101.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Evren 101.pdf"
            },
            new Books
            {
                Title = "Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.pdf"
            },
            new Books
            {
                Title = "Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.pdf"
            },
            new Books
            {
                Title = "Jack Schwager - Borsa Sihirbazları.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Jack Schwager - Borsa Sihirbazları.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Jack Schwager - Borsa Sihirbazları.pdf"
            },
            new Books
            {
                Title = "Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.pdf",
                Author = "Author A",
                Genre = "Genre A",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.jpg"),
                Category = "Story",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.pdf"
            },
            new Books
            {
                Title = "Sabahattin Ali Kürk Mantolu Madonna YKY (2).pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Sabahattin Ali Kürk Mantolu Madonna YKY (2).jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Sabahattin Ali Kürk Mantolu Madonna YKY (2).pdf"
            },
            new Books
            {
                Title = "Stephen King - Peri Masalı.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Stephen King - Peri Masalı.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Stephen King - Peri Masalı.pdf"
            },
            new Books
            {
                Title = "Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.pdf",
                Author = "Author B",
                Genre = "Genre B",
                CoverImage = Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.jpg"),
                Category = "Novel",
                ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.pdf"
            },
            // Add more books as needed
        };
    }
}
