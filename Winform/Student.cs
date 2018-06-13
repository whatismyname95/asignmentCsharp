using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Student
    {
        string id;
        string name;
        int age;
        string gender;
        string Stdclass;

        public Student()
        {

        }
        public Student(string id, string name, int age, string gender, string stdclass)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            Stdclass = stdclass;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Stdclass1 { get => Stdclass; set => Stdclass = value; }
    }
}
