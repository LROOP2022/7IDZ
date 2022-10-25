using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class TeacherInfo
    {
        public string fio { get; private set; }
        public string mail { get; private set; }
        public string work { get; private set; }
        public TeacherInfo(string pFio, string pMail, string pWork)
        {
            fio = pFio;
            mail = pMail;
            work = pWork;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ФИО: {fio} \n Почта: {mail} \n Преподаваемый предмет: {work}");
            Console.WriteLine();
        }
    }
}
