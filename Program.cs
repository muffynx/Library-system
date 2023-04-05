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
                                         |  [1] : Show all books in the library       |
                                         |  [2] : Shows all members of the library    |
                                         |  [3] : Show the books available            |
                                         |  [4] : Library member action               |
				         |  [5] : Librarian update books                   |
                                         |  [6] : Show the books available            |
                                         |  [7] : exit the program.            	      |
                                         |____________________________________________|

                                                                            
                                                                         
                                                                         
";

            Library library = new Library();

            Book book1 = new Book("C Programming", "Brian W", "978-0131103627");
            Book book2 = new Book("Python Programming ", "Brain W2", "0131103627");


            library.AddBook(book1);
            library.AddBook(book2);



            //สมาชิก กี่คน
            Member member1 = new Member("Jack", "11");
            Member member2 = new Member("Pound", "22");

            // เพิ่มสมาชิกเข้าห้องสมุด
            library.AddMember(member1);
            library.AddMember(member2);


            // สร้างหนังสือ
            Book book3 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling, Mary GrandPré", "978-0439708180");

            // สร้างบรรณารักษ์
            Librarian librarian = new Librarian("Ashley Graham", "789");



            while (true)
            {
                int width = Console.WindowWidth;
                int leftPadding = (width - titleshow.Split('\n')[0].Length) / 2;
                Console.WriteLine(titleshow.PadLeft(leftPadding + titleshow.Length));

                Console.Write("                                                     Enter your choice: ");



                string input = Console.ReadLine();

                if (input == "1")
                {


                    Console.WriteLine("\nBooks:");
                    foreach (Book book in library.GetBooks())
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} (ISBN-13 : {book.Number}) .");
                    }


                }
                else if (input == "2")
                {

                    //แสดงสมาชิกทั้งหมดในห้องสมุด
                    Console.WriteLine("\nMembers:");
                    foreach (Member member in library.GetMembers())
                    {
                        Console.WriteLine($"{member.Id} : {member.Name}");
                    }


                }
                else if (input == "3")
                {

                    // แสดงหนังสือที่มีให้ยืมในห้องสมุด
                    Console.WriteLine("\nAvailableBooks:");
                    foreach (Book book in library.GetAvailableBooks())
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} (ISBN-13 : {book.Number}) .");
                    }
                }
                else if (input == "4")
                {
                    // สมาชิกไม่ได้เอาหนังสือไป
                    Console.WriteLine();
                    member1.ReturnBook(book1);


                    // สมาชิกยืมหนังสือ
                    Console.WriteLine();
                    member1.BorrowBook(book1);
                    //สมาชิกคืนหนังสือ
                    Console.WriteLine();
                    member1.ReturnBook(book1);

                }
                else if (input == "5")
                {
                    Console.WriteLine();
                    librarian.AddBook(book3, library);

                }
                else if (input == "6")
                {
                    //        // แสดงหนังสือทั้งหมดในห้องสมุด
                    foreach (Book book in library.GetBooks())
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} (ISBN-13 : {book.Number}) .");
                    }

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

