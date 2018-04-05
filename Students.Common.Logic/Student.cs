using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Common.Logic
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DNI { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid Guid { get; set; }
        public int Age { get; set; }
        public DateTime Register { get; set; }

        public void SetGuid()
        {
            Guid = Guid.NewGuid();
        }

    }
}
