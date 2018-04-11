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
        Student AddTxt(Student student);
        Student AddJson(Student student);
        Student AddXml(Student student);
        int CalculateAge(DateTime DateOfBirth, DateTime CurrentDate);

    }
}
