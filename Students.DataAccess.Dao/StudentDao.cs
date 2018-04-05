using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Common.Logic;

namespace Students.DataAccess.Dao
{
    public class StudentDao : IStudentDao
    {
        public Student Insert(Student student)
        {   // Create a string array with the lines of text
            string line = (Convert.ToString(student.ID) + "," + student.Surname + "," + student.DNI + "," + Convert.ToString(student.Guid) + "," + Convert.ToString(student.Register) + "," + Convert.ToString(student.Age));
            // Set a variable to the My Documents path.
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Write the string array to a new file named "Student.txt".
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\Students.txt"))
            {
                
                    outputFile.WriteLine(line);

            }

            return null;
        }


    }
}
