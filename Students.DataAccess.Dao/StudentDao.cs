using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Students.Common.Logic;

namespace Students.DataAccess.Dao
{
    public class StudentDao : IStudentDao

    {
         string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Student InsertTxt(Student student)
        {  
            string line = (Convert.ToString(student.ID) + "," + student.Name + "," +  student.Surname + "," + student.DNI + ","  + Convert.ToString(student.DateOfBirth) + "," + Convert.ToString(student.Guid) + "," + Convert.ToString(student.Register) + "," + Convert.ToString(student.Age));
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\Students.txt"))
            {              
                    outputFile.WriteLine(line);
            }
            return GetLastStudent();

        }
         public Student GetLastStudent()
        {
            
            using (StreamReader inputFile = new StreamReader(mydocpath + @"\Students.txt"))
            {
                var arrayStrings = new string[8];
                while (inputFile.Peek() != -1)
                {
                    var stringLine = inputFile.ReadLine();
                    arrayStrings = stringLine.Split(',');
                }
                Student student = new Student(Convert.ToInt32(arrayStrings[0]), arrayStrings[1], arrayStrings[2], arrayStrings[3], DateTime.Parse(arrayStrings[4]), new Guid(arrayStrings[5]), Convert.ToInt32(arrayStrings[7]), DateTime.Parse(arrayStrings[6]));
                return student;
            }
        }

        public Student InsertJson(Student student)
        {
            {
                string json = JsonConvert.SerializeObject(student);
                //write string to file
                System.IO.File.WriteAllText((mydocpath + @"\Students.json"), json);
            }
            return GetLastJsonStudent();
        }

        public Student GetLastJsonStudent()
        {
            using (StreamReader r = new StreamReader(mydocpath + @"\Students.json"))
            {
                string json = r.ReadToEnd();
                Student student = JsonConvert.DeserializeObject<Student>(json);
                return student;
            }
        }

        public Student InsertXml(Student student)
        {
            {
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Student));
                System.IO.FileStream file = System.IO.File.Create(mydocpath + @"\Students.xml");
                writer.Serialize(file, student);
                file.Close();
            }
            return student;
        }
            
    }
}

