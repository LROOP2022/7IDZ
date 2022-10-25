using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Kafedra
    {
        private string name;
        private string kabinet;
        private List<TeacherInfo> teachers;

        public Kafedra(string pName, string pkabinet)
        {
            name = pName;
            kabinet = pkabinet;
            teachers = new List<TeacherInfo>();
        }
        public void Add(TeacherInfo user)
        {
            teachers.Add(user);
        }
        public void Delete(TeacherInfo user)   
        {
            if (teachers.Contains(user))
            {
                teachers.Remove(user);
            }
            else
            {
                Console.WriteLine("Преподаватель не найден");
                Console.WriteLine();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название кафедры: {name} \n Кабинет кафедры: {kabinet} \n Количество преподавателей: {teachers.Count.ToString()}");
            Console.WriteLine();
        }
        public List<TeacherInfo> GetList()
        {
            return teachers;
        }
    }
}
