using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Group:Student
    {
        public static Group[] groups = new Group[0];
        public static int GroupCount { get; set; }
        public static int GroupId { get; set; }
        public static string GroupName { get; set; } 
        Student[] students=new Student[0];
        public Group(int groupcount,int groupid,string groupname,int staticcount,int id,string name,string surname):base(staticcount,id,name,surname)
        {
            GroupCount = groupcount;
            GroupId = groupid;
            GroupName = groupname;
        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"GroupCount:{GroupCount} GroupId:{GroupId} GroupName:{GroupName}");
            Console.WriteLine(Student.Count);
        }
        public string GetStudent(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].ID == id)
                {
                    return students[i].Name;
                }
            }
            return null;
            
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length-1] = student;
        }
        public void Search(string name)
        {
            foreach (Student student in students)
            {
                if(student.Name.Contains(name) || student.Surname.Contains(name)){
                    student.GetInfo();
                }
            }
        }
        public void RemoveStudent(int id)
        {
            
        }
        public void ShowStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
        public static void ShowAllGroups()
        {
            Console.WriteLine($"GroupCount:{GroupCount}, GroupId:{GroupId} GroupName:{GroupName}");
        }
        public static void AddGroup(Group group)
        {
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1]=group;
        }

        
    }
}
