using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

  
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }

}
 
