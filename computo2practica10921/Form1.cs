using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computo2practica10921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("idStudent", "Codigo");
            dgData.Columns.Add("firstName", "Nombre");
            dgData.Columns.Add("lastName", "Apellido");
            dgData.Columns.Add("age", "Edad");
            dgData.Columns.Add("gender", "Genero");

            foreach ( var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firstName, student.lastName, student.age, student.genero);

            }

           
        }

        private List<Student> selectAllData()
        {
            List<Student> result = (
                                    from student in Student .GetStudents()
                                    select new Student()
                                    {
                                        idStudent = student.idStudent,
                                        firstName = student.firstName,
                                        lastName = student.lastName,
                                        age = student.age,
                                        genero = student.genero,
                                    }

                ).ToList();

            return result;
            

        }







        

    }
}
