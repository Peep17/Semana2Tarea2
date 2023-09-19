using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejercicio1
{
    class Menu
    {
        private List<Classroom> classroomList;
        private Classroom currentClassroom;

        public Menu()
        {
            classroomList = new List<Classroom>();
        }

        public void Start()
        {
            ClassroomMenu();
        }

        private void ClassroomMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la operación a realizar: ");
                Console.WriteLine("1: Crear un salón");
                Console.WriteLine("2: Seleccionar un salón");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CreateClassroom();
                        break;
                    case "2":
                        SelectClassroom();
                        StudentMenu();
                        break;
                    default:
                        Console.WriteLine("La opción no existe");
                        break;
                }
                Console.WriteLine("Desea continuar? Si/No");
                string continueOption = Console.ReadLine();
                if (continueOption == "No")
                {
                    continueFlag = false;
                }
            }
        }

        private void CreateClassroom()
        {
            Console.WriteLine("Introduce el nombre del salón: ");
            string name = Console.ReadLine();
            Classroom classroom = new Classroom(name);
            classroomList.Add(classroom);
        }

        private void SelectClassroom()
        {
            Console.WriteLine("Introduce el número del salón a seleccionar");
            for (int i = 0; i < classroomList.Count; i++)
            {
                Console.WriteLine($"{i}: {classroomList[i].GetName()}");
            }
            int option = int.Parse(Console.ReadLine());
            if (option >= 0 && option < classroomList.Count)
            {
                currentClassroom = classroomList[option];
                Console.WriteLine($"Se ha seleccionado el salón {currentClassroom.GetName()}");
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }
        }

        private void StudentMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine($"Introduce la operación a realizar en el salón {currentClassroom.GetName()}: ");
                Console.WriteLine("1: Registrar un alumno");
                Console.WriteLine("2: Remover un alumno");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    default:
                        Console.WriteLine("La opción no existe");
                        break;
                }
                Console.WriteLine("Desea continuar? Si/No");
                string continueOption = Console.ReadLine();
                if (continueOption == "No")
                {
                    continueFlag = false;
                }
            }

        }

        private void CreateStudent()
        {
            Console.WriteLine("Introduce el nombre del alumno: ");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce la nota 1 del alumno: ");
            float grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota 2 del alumno: ");
            float grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota 3 del alumno: ");
            float grade3 = float.Parse(Console.ReadLine());
            Student student = new Student(name, grade1, grade2, grade3);

            currentClassroom.AddStudent(student);
        }

        private void RemoveStudent()
        {
            Console.WriteLine("Introducir el número del alumno a eliminar:");
            List<Student> studentList = currentClassroom.GetStudentList();
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine($"{i}: {studentList[i].GetName()} - {studentList[i].GetAverage()}");
            }

            int option = int.Parse(Console.ReadLine());
            if (option >= 0 && option < studentList.Count)
            {
                currentClassroom.RemoveStudent(option);
            }
            else
            {
                Console.WriteLine("El número de alumno no existe");
            }
        }
    }
}

