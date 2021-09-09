using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computo2practica10921
{
    class Student
    {
        
        public int idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string genero { get; set; }

        //crear coleccion de datos 
        public static List<Student> GetStudents()
        {

            List<Student> Students = new List<Student>
            {
               new Student {idStudent = 1001, firstName ="Angie",lastName ="Segovia", age = 17, genero = "femenino" },
               new Student{idStudent = 1002, firstName ="Ashlee", lastName ="Calix", age=17, genero = "Femenino"},
               new Student {idStudent = 1003, firstName ="Flor", lastName ="Torres", age = 34, genero = "Femenino" },
               new Student { idStudent = 1004, firstName ="walter", lastName ="Calix", age = 43, genero = "Masculino" },
               new Student {idStudent = 1005, firstName ="Alexis", lastName ="Calix", age = 18, genero = "Masculino" },
               new Student {idStudent = 1006, firstName ="Carmen", lastName ="Rodriguez", age = 20, genero = "Femenino" },
               new Student {idStudent = 1007, firstName ="Carlos", lastName = " Rojas", age = 25, genero = " Masculino"},
            };

            //valor de reotorno sera la lista del estudiante 

            return Students;

        }
    }
}


    

