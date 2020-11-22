using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Book
    {

        public static List<string> categoryList = new List<string> { "detske", "romanticke", "naucne", "scifi", "doubrodruzne" };

        public string Title { get; set; }
        public int Pages { get; set; }
        public string Category { private get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }

        public void VypisInformacie()
        {
            Console.WriteLine($"{Title} {Pages} {Category} {Author} {ReleaseDate}");
        }

        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }
    }
}
