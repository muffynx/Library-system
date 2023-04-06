using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system.class_Library
{
    public class Book
    {
        private string titlepri;
        private string authorpri;
        private string numberpri;
        private bool available;   

        public Book(string title, string author, string number) 
        {
            this.titlepri = title;
            this.authorpri = author;
            this.numberpri = number;
            available = true;
        }

        public string Title    
        {
            get { return titlepri; }
        }
        public string Author
        {
            get { return authorpri; }
        }
        public string Number
        {
            get { return numberpri; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
    }
}
