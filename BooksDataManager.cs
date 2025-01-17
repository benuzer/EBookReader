﻿using DevExpress.Utils.Svg;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace EBookReader
{
    internal static class BooksDataManager
    {
        private const string BooksDataFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\BooksInfo.txt";
        public static List<Books> books;

        static BooksDataManager()
        {
            books = new List<Books>();
            if (File.Exists(BooksDataFilePath)) 
                InitilizeBooks();
            else
                LoadBooks();
        }


        public static void LoadBooks()
        {
            
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
                        CoverImagePath =parts[3],
                        Category = parts[4],
                        ContentFilePath = parts[5]
                    });
                }
            }
        }

        public static void SaveBooks()
        {
            var lines = books.Select(b =>
                $"{b.Title}|{b.Author}|{b.Genre}|{b.CoverImage}|{b.Category}|{b.ContentFilePath}");
            File.WriteAllLines(BooksDataFilePath, lines);
        }

        public static void AddBook(Books book)
        {
            books.Add(book);
            SaveBooks();
        }

        public static void RemoveBook(Books book)
        {
            books.Remove(book);
            SaveBooks();
        }

        private static void InitilizeBooks()
        {
            #region

            books.AddRange(new List<Books>
            {
                new Books
                {
                    Title = "Ahmet Hamdi Tanpınar   Saatleri Ayarlama Enstitüsü.pdf",
                    Author = "Author A",
                    Genre = "Genre A",
                    CoverImage =
                        Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Ahmet Hamdi Tanpınar   Saatleri Ayarlama Enstitüsü cover.jpg"),
                    Category = "Story",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Ahmet Hamdi Tanpınar   Saatleri Ayarlama Enstitüsü.pdf"
                },
                new Books
                {
                    Title = "Alfred Mill Herkes İçin Ekonomi 101 Say Yayınları.pdf",
                    Author = "Author B",
                    Genre = "Genre B",
                    CoverImage =
                        Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Alfred Mill Herkes İçin Ekonomi 101 Say Yayınları.jpg"),
                    Category = "Novel",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Alfred Mill Herkes İçin Ekonomi 101 Say Yayınları.pdf"
                },
                new Books
                {
                    Title = "Carl Sagan Kozmos Altın Kitaplar.pdf",
                    Author = "Author C",
                    Genre = "Genre C",
                    CoverImage =
                        Image.FromFile("C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Carl Sagan Kozmos Altın Kitaplar.jpg"),
                    Category = "Cartoon",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Carl Sagan Kozmos Altın Kitaplar.pdf"
                },
                new Books
                {
                    Title = "Dan Brown - İhanet Noktası.pdf",
                    Author = "Author D",
                    Genre = "Genre D",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Dan Brown - İhanet Noktası.jpg"),
                    Category = "Tale",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Dan Brown - İhanet Noktası.pdf"
                },
                new Books
                {
                    Title = "David Eagleman - Incognito  Beynin Gizli Hayatı.pdf",
                    Author = "Author E",
                    Genre = "Genre E",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\David Eagleman - Incognito  Beynin Gizli Hayatı.jpg"),
                    Category = "Story",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\David Eagleman - Incognito  Beynin Gizli Hayatı.pdf"
                },
                new Books
                {
                    Title = "Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.pdf",
                    Author = "Author F",
                    Genre = "Genre F",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.jpg"),
                    Category = "Novel",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Eric Grzymkowski Herkes İçin Sanat 101 Say Yayınları.pdf"
                },
                new Books
                {
                    Title = "Evren 101.pdf",
                    Author = "Author G",
                    Genre = "Genre G",
                    CoverImage = Image.FromFile( "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Evren 101.jpg"),
                    Category = "Cartoon",
                    ContentFilePath = "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Evren 101.pdf"
                },
                new Books
                {
                    Title = "Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.pdf",
                    Author = "Author H",
                    Genre = "Genre H",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.jpg"),
                    Category = "Tale",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Gottfried_Wilhelm_Leibniz_Monadoloji_İş_Bankası_Yayınları.pdf"
                },
                new Books
                {
                    Title = "Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.pdf",
                    Author = "Author I",
                    Genre = "Genre I",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.jpg"),
                    Category = "Story",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Gottfried_Wilhelm_Leibniz_Monadoloji_ve_Metafizik_Üzerine_Konuşma.pdf"
                },
                new Books
                {
                    Title = "Jack Schwager - Borsa Sihirbazları.pdf",
                    Author = "Author J",
                    Genre = "Genre J",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Jack Schwager - Borsa Sihirbazları.jpg"),
                    Category = "Novel",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Jack Schwager - Borsa Sihirbazları.pdf"
                },
                new Books
                {
                    Title = "Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.pdf",
                    Author = "Author K",
                    Genre = "Genre K",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.jpg"),
                    Category = "Cartoon",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Patrick_Rothfuss_Kralkatili_Güncesi_2_Bilge_Adamın_Korkusu.pdf"
                },
                new Books
                {
                    Title = "Sabahattin Ali Kürk Mantolu Madonna YKY (2).pdf",
                    Author = "Author L",
                    Genre = "Genre L",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Sabahattin Ali Kürk Mantolu Madonna YKY (2).jpg"),
                    Category = "Tale",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Sabahattin Ali Kürk Mantolu Madonna YKY (2).pdf"
                },
                new Books
                {
                    Title = "Stephen King - Peri Masalı.pdf",
                    Author = "Author M",
                    Genre = "Genre M",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Stephen King - Peri Masalı.jpg"),
                    Category = "Story",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Stephen King - Peri Masalı.pdf"
                },
                new Books
                {
                    Title = "Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.pdf",
                    Author = "Author N",
                    Genre = "Genre N",
                    CoverImage = Image.FromFile(
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\CoverImages\\Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.jpg"),
                    Category = "Cartoon",
                    ContentFilePath =
                        "C:\\Users\\VICTUS\\Desktop\\EBookReader-master\\Books\\Yılan-Avı-“Dave-Gurney-–-8”-John-verdon.pdf"
                }
                // Add more books as needed
            });

            SaveBooks();

            #endregion
        }
    }
}