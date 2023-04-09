using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Student
    {
        public static int Count { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(int count,int id,string name,string surname)
        {
            Count= count;
            ID= id;
            Name= name;
            Surname = surname;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Count:{Count} ID:{ID} Name:{Name} Surname:{Surname}");
        }
    
    }
}
