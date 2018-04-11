using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Common.Logic;

namespace Students.DataAccess.Dao
{
     public interface IStudentDao
    {
        Student InsertTxt(Student student);
        Student InsertJson(Student student);
        Student InsertXml(Student student);
    }
}
