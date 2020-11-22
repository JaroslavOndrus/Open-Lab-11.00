using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library : Book
    {
        int NumberOfBooks { get; set; }
        int NumberOfStudents { get; set; }
        List<string> StudentList = new List<string>();
        List<Book> BooksList = new List<Book>();

        public Library(int numberOfBooks, int numberOfStudents, List<string> studentList, List<Book> booksList)
        {
            NumberOfBooks = numberOfBooks;
            NumberOfStudents = numberOfStudents;
            StudentList = studentList;
            BooksList = booksList;
        }

        public void VypisVsetkychPremennych()
        {
            Console.WriteLine($"{NumberOfBooks} {NumberOfStudents}");

            foreach(string student in StudentList)
            {
                Console.WriteLine(student);
            }

            foreach(Book book in BooksList)
            {
                book.VypisInformacie();
            }
        }

        public Library()
        {
            Book book = new Book();
            NumberOfBooks = -1;
            NumberOfStudents = -1;
            StudentList = null;
            BooksList = null;
        }
    }
}
