using library_system.class_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace library_system.class_Library
{
    

    public class Library
    {
        private List<Book> books;
        private List<Member> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public List<Book> GetAvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Available)
                {
                    availableBooks.Add(book);
                }
            }
            return availableBooks;
        }
        public void AddMember(Member member)
        {
           members.Add(member);
        }
        public List<Member> GetMembers()
        {
            return members;
        }

      
    }





}
