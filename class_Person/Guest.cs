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
                                           //สร้าง ตัวแปรเพื่อใช้งาน
        public Guest(string name, string id)
        {
            this.name=name;
            this.id=id;
        }
        public string Name
        {
            get { return name; }
        }
        public string Id
        {
            get { return id; }
        }
       

        public void ViewCatalog()
        {
            Console.WriteLine("Viewing Library Catalog");
        }
    }
}
