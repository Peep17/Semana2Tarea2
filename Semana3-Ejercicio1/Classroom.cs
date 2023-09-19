using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio1
{
    class Classroom
    {
        private List<Student> studentList;
        private string name;
        
        public Classroom(string name)
        {
            studentList = new List<Student>();
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public void RemoveStudent(int i)
        {
            studentList.RemoveAt(i);
        }

        public string GetName()
        {
            return name;
        }

        public List<Student> GetStudentList()
        {
            return studentList;
        }
    }
}

