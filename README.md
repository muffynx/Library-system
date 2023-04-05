# Library-system
#ระบบโดยรวมสำหรับผู้ที่มาใช้งาน มีทั้ง ค้นหาหนังสือ รายชื่อหนังสือ ประวัติการยืม และการอัปเดทหนังสือ ในห้องสมุดของเรา 
##ผู้เขียน Name : ณัฐดนัย ภาคภูมิ ID : 653450088-3 E-mail :Natdanai.pa@kkumail.com


#using information hiding, Encapsulation, Inheritance
---
title: Animal example
---
classDiagram
   
Member <|-- Librarian
    note for Librarian "add book ,Inheritance name, id"
    Guest <|-- Member
  
 Guest : +id name
    Guest : protec String name
    Guest: +Guest()
    Guest: +ViewCatalog()
    class Librarian{
        +AddBook()
        +Librarian()
       
   }
   class Member{
        -list borrowedBooks
        +BorrowBook()
        +Member()
        +ReturnBook()
    }
    class Program{
    
       -main()
   }
       class Book{
        -titlepri
        -authorpri
        -numberpri
        Author
        Available
        Number
        Title
        +book()
    }
      class Library{
    
   -books
    -members
        +Addbook()
        +AddMember()
        +GetAvailableBooks()
        +GetBooks()
        +GetMembers()
        +Library()


  }

