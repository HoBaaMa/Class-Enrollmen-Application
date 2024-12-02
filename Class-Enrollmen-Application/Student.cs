using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Enrollmen_Application
{
    internal class Student
    {
        #region Module 1
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name}, Age: {Age}, Grade: {Grade}";
        }
        #endregion
    }
}
