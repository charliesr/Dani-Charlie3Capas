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

        public Student()
        {

        }
        
        public Student(int id, string name, string surname, string dni, DateTime dateofbirth, Guid guid, int age, DateTime register)
        {
            ID = id;
            Name = name;
            Surname = surname;
            DNI = dni;
            DateOfBirth = dateofbirth;
            Guid = guid;
            Age = age;
            Register = register;

        }

        public void SetGuid()
        {
            Guid = Guid.NewGuid();
        }

    }
}
