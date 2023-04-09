using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student=new Student(16,123456,"Punhan","Aliyeva");
           Student student2 = new Student(26, 193456, "Selma", "Mammedli");
            //student.GetInfo();
           //Console.WriteLine(student.ID);
          




            Group group = new Group(8, 25337, "BB102", 11, 123344, "Punhan", "Aliyeva");
            group.AddStudent(student);
            group.AddStudent(student2);
 
            




        }
    }
}