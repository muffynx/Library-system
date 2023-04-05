using library_system.class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system.class_Person
{
    public class Librarian : Member
    {
        public Librarian(string name, string id) : base(name, id)
        {
        }

        public void AddBook(Book book,Library library)
        {
            library.AddBook(book);
            Console.WriteLine($"{name} added {book.Title} by {book.Author} to the library.");
        }
        public void UpdateBook(Book book, string[] newInfo)
        {
            book.Update(newInfo);
            Console.WriteLine($"{name} updated {book.Title} by {book.Author} with new information.");
        }
    }
}
