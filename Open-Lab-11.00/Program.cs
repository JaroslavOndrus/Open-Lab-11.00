using System;
using System.Collections.Generic;
namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book slovenskyJazyk = new Book("Slovensky jazyk", 150, "Naucne", "Autor sjl", 2019);
            Book matematika = new Book("Matematika", 2585, "Naucne", "Autor sjl", 2015);

            List<Book> books = new List<Book>() { slovenskyJazyk,matematika};

            List<string> students = new List<string>() { "John", "Poul"};

            Library schoolLibrary = new Library(books.Count,students.Count,students,books);

            schoolLibrary.VypisVsetkychPremennych();
            
            
        }
    }
}
