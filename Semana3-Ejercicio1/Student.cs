using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio1
{
    class Student
    {
        private string name;
        private float grade1;
        private float grade2;
        private float grade3;

        public Student(string name, float grade1, float grade2, float grade3)
        {
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }

        public float GetAverage()
        {
            return (grade1 + grade2 + 2 * grade3) / 4;
        }

        public string GetName()
        {
            return name;
        }
    }
}

