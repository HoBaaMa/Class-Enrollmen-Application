using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Enrollmen_Application
{
    internal class Administrator
    {
        #region Module 1
        private static List<Student> students = new List<Student>();
        public Administrator()
        {
            
        }
        public void AddStudent(Student newStudent)
        {
            students.Add(newStudent);
        }

        public bool RemoveStudent(int id)
        {
            var student = students.Find(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);
                return true;
            }
            return false;
        }
        public bool UpdateStudent (int id, string name, int age, string grade)
        {
            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                student.Name = name;
                student.Age = age;
                student.Grade = grade;
                return true;
            }
            return false;
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        #endregion
    }

}
