using library_system.class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system.class_Person
{
    public class Member : Guest
    {
        private List<Book> borrowedBooks;
        public Member(string name, string id) : base(name, id)
        {
            borrowedBooks= new List<Book>();
        }
        public void BorrowBook(Book book)
        {
            borrowedBooks.Add(book);
            Console.WriteLine($"{name} borrowed {book.Title} by {book.Author}.");
        }
        public void ReturnBook(Book book)
        {
            if(borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                Console.WriteLine($"{name} returned {book.Title} by {book.Author}.");
            }
            else
            {
                Console.WriteLine($"{name} did not borrow {book.Title} by {book.Author}.");
            }
        }
      
    }
}
