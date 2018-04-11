using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students.Business.Logic;
using Students.Common.Logic;

namespace Students.Presentation.WinSite
{
    public partial class Form1 : Form
    {
        Student student = new Student();
        IStudentBL studentBL = new StudentBL();

        public Form1()
        {
            InitializeComponent();
        }

        private void btTXT_Click(object sender, EventArgs e)

        {
            CargaDatos();
            studentBL.AddTxt(student);

        }

        private void btJSON_Click(object sender, EventArgs e)
        {
            CargaDatos();
            studentBL.AddJson(student);

        }

        private void btXML_Click(object sender, EventArgs e)
        {
            CargaDatos();
            studentBL.AddXml(student);

        }

        private void CargaDatos()
        {
            student.ID = Convert.ToInt32(txID.Text);
            student.Name = txName.Text;
            student.Surname = txSurname.Text;
            student.DNI = txDNI.Text;
            student.DateOfBirth = dtDate.Value;
            student.SetGuid();
        }
    }

}
