using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Storage
    {
        private List<Kafedra> data;

        public Storage()
        {
            data = new List<Kafedra>();
        }
        public void Add(Kafedra kafedra)
        {
            data.Add(kafedra);
        }
        public void Delete(Kafedra kafedra)
        {
            if (data.Contains(kafedra))
            {
                data.Remove(kafedra);
            }
            else
            {
                Console.WriteLine("Кафедра с таким названием не найдена");
            }
        }
        public void Find(string name)
        {
            bool found = false;
            foreach (Kafedra kafedra in data)
            {
                List<TeacherInfo> teachers = kafedra.GetList();
                foreach (TeacherInfo teacher in teachers)
                {
                    if (name.Equals(teacher.fio))
                    {
                        Console.WriteLine("Информация о кафедре преподавателя:");
                        kafedra.GetInfo();
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Преподаватель не найден");
            }
        }
    }
}
