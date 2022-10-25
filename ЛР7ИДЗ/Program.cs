using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Programm
    {
        static void Main(string[] args)
        {
            TeacherInfo t1 = new TeacherInfo("Панкратова", "панкратова@mail.ru", "Цифры");
            TeacherInfo t2 = new TeacherInfo("Ардеев", "Ардеев@mail.ru", "ООП");
            TeacherInfo t3 = new TeacherInfo("Багдасарян", "Багдасарян@mail.ru", "Java");
            TeacherInfo t4 = new TeacherInfo("Герасимова", "Герасимова@mail.ru", "C#");
            TeacherInfo t5 = new TeacherInfo("Плетухина", "Плетухина@mail.ru", "Cisco");
            TeacherInfo t6 = new TeacherInfo("Шевченко", "Шевченко@mail.ru", "ООП");
            Kafedra k1 = new Kafedra("Прикладная информатика", "321");
            k1.Add(t1);
            k1.Add(t2);
            Kafedra k2 = new Kafedra("Инфоком-С", "330");
            k2.Add(t3);
            k2.Add(t4);
            Kafedra k3 = new Kafedra("Инфокоммуникаций", "302");
            k3.Add(t5);
            k3.Add(t6);
            Storage data = new Storage();
            data.Add(k1);
            data.Add(k2);
            data.Add(k3);

            k3.GetInfo();
            List<TeacherInfo> info = k3.GetList();
            foreach (TeacherInfo t in info)
            {
                Console.WriteLine(t.fio);
            }
            Console.WriteLine();
            t1.GetInfo();
            data.Find("Панкратова");
        }
    }
}
