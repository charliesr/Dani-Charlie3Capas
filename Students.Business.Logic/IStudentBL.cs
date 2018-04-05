using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Common.Logic;

namespace Students.Business.Logic
{
    public interface IStudentBL
    {
        Student Add(Student student);
        int CalculateAge(DateTime DateOfBirth, DateTime CurrentDate);

    }
}
