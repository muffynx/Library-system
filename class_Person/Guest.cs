using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system.class_Person
{
    public class Guest
    {
        protected string name;
        private string id;
                                           
        public Guest(string name, string id)  
        {
            this.name=name;
            this.id=id;
        }
        public string Name
        {
            get { return name; } // encap
        }
        public string Id
        {
            get { return id; }
        }
       

    }
}
