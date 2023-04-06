using library_system.class_Library;
using library_system.class_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace library_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Library_system";
            string titleshow = @"                                   
        
                                                                                   make by discord: muffyn #9990
                                                                                     
       ██╗     ██╗██████╗ ██████╗  █████╗ ██████╗ ██╗   ██╗    ███████╗██╗   ██╗███████╗████████╗███████╗███╗   ███╗
       ██║     ██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝    ██╔════╝╚██╗ ██╔╝██╔════╝╚══██╔══╝██╔════╝████╗ ████║
       ██║     ██║██████╔╝██████╔╝███████║██████╔╝ ╚████╔╝     ███████╗ ╚████╔╝ ███████╗   ██║   █████╗  ██╔████╔██║
       ██║     ██║██╔══██╗██╔══██╗██╔══██║██╔══██╗  ╚██╔╝      ╚════██║  ╚██╔╝  ╚════██║   ██║   ██╔══╝  ██║╚██╔╝██║
       ███████╗██║██████╔╝██║  ██║██║  ██║██║  ██║   ██║       ███████║   ██║   ███████║   ██║   ███████╗██║ ╚═╝ ██║
       ╚══════╝╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚══════╝   ╚═╝   ╚══════╝   ╚═╝   ╚══════╝╚═╝     ╚═╝


                                           _________________ COMMAND __________________
                                         |  [1] : What you looking for                |
                                         |  [2] : Show all books in the library       |
                                         |  [3] : Shows all members of the library    |
                                         |  [4] : Show the books available            |
                                         |  [5] : Library member action               |
				         |  [6] : Librarian update books              |
                                         |  [7] : exit the program.            	      |
                                         |____________________________________________|

                                                                            
                                                                         
                                                                         
";

            Library library = new Library();

            Book book1 = new Book("C Programming", "Brian Kernighan", "978-0131103627");
            Book book2 = new Book("Python Programming", "David Beazley", "978-1914045110");


            library.AddBook(book1);
            library.AddBook(book2);



            //สมาชิก กี่คน
            Member member1 = new Member("Jack", "11");
            Member member2 = new Member("Pound", "22");
        

            // เพิ่มสมาชิกเข้าห้องสมุด
            library.AddMember(member1);
            library.AddMember(member2);

            // สร้างบรรณารักษ์

            Librarian librarian1 = new Librarian("Ashley Graham", "789");
            // เพิ่มหนังสือ
            Book book3 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "978-0439708180");
            Book book4 = new Book("The Ickabog", "J.K. Rowling", "978-1338732870");
   
          



            while (true)
            {
                int width = Console.WindowWidth;
                int leftPadding = (width - titleshow.Split('\n')[0].Length) / 2;
                Console.WriteLine(titleshow.PadLeft(leftPadding + titleshow.Length));

                Console.Write("                                                     Enter your choice: ");



                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("\nEnter the title or author: ");
                    string searchTitle = Console.ReadLine();

                    bool foundMatch = false;

                    foreach (Book book in library.GetBooks())
                    {
                        if (book.Title.ToLower() == searchTitle.ToLower() || book.Author.ToLower() == searchTitle.ToLower())
                        {
                            
                            Console.WriteLine($"{book.Title} by {book.Author} (ISBN-13: {book.Number})");
                            foundMatch = true; //เอาจน lloop หทด
                        }
                       
                    }

                    if (!foundMatch)
                    {
                        Console.WriteLine("No matching books found.");
                    }
                    Console.WriteLine();

                    Console.WriteLine("\nEnd of search.");


                   
                 
                }
                else if (input == "2")
                {
                    int bookCount = library.GetBooks().Count;
                    Console.WriteLine($"Total number of books: {bookCount}");
                    Console.WriteLine();



                    Console.WriteLine("Show all books in the library.");
                    foreach (Book book in library.GetBooks()) //book เอามาใช้
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} (ISBN-13 : {book.Number}) .");
                    }


                }
                else if (input == "3")
                {

                    int memberCount = library.GetMembers().Count;
                    Console.WriteLine($"Total number of members: {memberCount}");



                    //แสดงสมาชิกทั้งหมดในห้องสมุด
                    Console.WriteLine("\nMembers:");
                  
                    foreach (Member member in library.GetMembers())
                    {
                        Console.WriteLine($"{member.Id} : {member.Name}");
                    }
                   
                    


                }
                else if (input == "4")
                {

                    // แสดงหนังสือที่มีให้ยืมในห้องสมุด
                    Console.WriteLine("\nAvailableBooks:");
                    foreach (Book book in library.GetAvailableBooks())
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} (ISBN-13 : {book.Number}) .");
                    }
                }
                else if (input == "5")
                {
             


                    // สมาชิกยืมหนังสือ
                    Console.WriteLine();
                    member1.BorrowBook(book1);
                    member2.BorrowBook(book2);
                    //สมาชิกคืนหนังสือ
                    Console.WriteLine();
                    member1.ReturnBook(book1);

                }
                else if (input == "6")
                {
                    Console.WriteLine();
                    librarian1.AddBook(book3, library);
                    librarian1.AddBook(book4,library);
                  

                }
                else if (input == "7")
                {
                    Console.WriteLine("\nGoodbye!");
                    Thread.Sleep(2000);


                    break;

                }
            

                else
                {
                    Console.WriteLine("\nInvalid input. Please try again.");
                }

                Console.WriteLine("\nPress any key to HomePage...");
        

                Console.ReadKey(true);
          
                

            }
        }

 
            }

    }

