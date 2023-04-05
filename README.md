# Library-system
#ระบบโดยรวมสำหรับผู้ที่มาใช้งาน มีทั้ง ค้นหาหนังสือ รายชื่อหนังสือ ประวัติการยืม และการอัปเดทหนังสือ ในห้องสมุดของเรา 
##ผู้เขียน Name : ณัฐดนัย ภาคภูมิ ID : 653450088-3 E-mail :Natdanai.pa@kkumail.com


#using information hiding, Encapsulation, Inheritance
[{"state":{"code":"---\ntitle: Animal example\n---\nclassDiagram\n   \n    Member <|-- Librarian\n    note for Librarian \"add book ,Inheritance name, id\"\n    Guest <|-- Member\n  \n    Guest : +id name\n    Guest : protec String name\n    Guest: +Guest()\n    Guest: +ViewCatalog()\n    class Librarian{\n        +AddBook()\n        +Librarian()\n       \n    }\n    class Member{\n        -list borrowedBooks\n        +BorrowBook()\n        +Member()\n        +ReturnBook()\n    }\n    class Program{\n    \n        -main()\n    }\n       class Book{\n        -titlepri\n        -authorpri\n        -numberpri\n        Author\n        Available\n        Number\n        Title\n        +book()\n    }\n       class Library{\n    \n        -books\n        -members\n        +Addbook()\n        +AddMember()\n        +GetAvailableBooks()\n        +GetBooks()\n        +GetMembers()\n        +Library()\n\n\n    }\n","mermaid":"{\n  \"theme\": \"dark\"\n}","autoSync":true,"updateDiagram":false,"editorMode":"code"},"time":1680722665683,"type":"manual","id":"b6194a9f-384a-4487-80de-6018e23c6adc","name":"stocky-state"}]
