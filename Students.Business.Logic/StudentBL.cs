using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Common.Logic;
using Students.DataAccess.Dao;

namespace Students.Business.Logic
{
    public class StudentBL : IStudentBL
    {
        IStudentDao studentDao = new StudentDao();
        

        public Student Add(Student student)
        
        {
            student.Register = DateTime.Now;
            student.Age = CalculateAge(student.DateOfBirth, student.Register);
            return studentDao.Insert(student);

        }
        
        public int CalculateAge(DateTime DateOfBirth, DateTime CurrentDate)
        {
            return (CurrentDate - DateOfBirth).Days / 365;
        }
    }
}
