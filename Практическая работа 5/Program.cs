using System;
using System.Collections;

namespace Практическая_работа_5
{
    public class Student
    {
        public static ArrayList stud = new ArrayList() { 122, "Васькинa", 34, "fgddd" };
        public static void Smotr()
        {
            for (int i = 0; i < stud.Count - 3; i += 4)
            {
                Console.WriteLine("Индекс студента: " + stud[i] + "\nФИО студента: " + stud[i + 1] + "\nГруппа студента: " + stud[i + 2] + "\nДата рождения студента: " + stud[i + 3] + "\n");
            }
            Console.WriteLine();
        }
        public static void Dobavlen(int id, string fio, string group, string data)
        {
            for (int i = 0; i <= stud.Count; i += 4)
            {
                stud.Add(id);
                if (Convert.ToString(id) == Convert.ToString(stud[i]))
                {
                    Console.WriteLine("Введённый ID занят");
                    break;
                }
                else if (Convert.ToString(id) != Convert.ToString(stud[i]))
                {
                    stud.Add(fio);
                    stud.Add(group);
                    stud.Add(data);
                    Console.WriteLine("Студент успешно добавлен!");
                    break;
                }
            }
            Console.WriteLine();
        }
        public static void Udalit(int id)
        {
            for (int i = 0; i < stud.Count - 2; i++)
            {
                if (stud[i].ToString().Equals(id.ToString()))
                {
                    stud.RemoveAt(i + 3);
                    stud.RemoveAt(i + 2);
                    stud.RemoveAt(i + 1);
                    stud.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine();
        }
        public static void Izmen()
        {
            Console.WriteLine();
            Console.WriteLine("Введите ID студента, которого хотите изменить");
            int ss = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= stud.Count; i += 4)
            {
                if(Convert.ToString(stud[i]) == Convert.ToString(ss))
                {
                    Console.Write("Введите нужный ID: ");
                    stud[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите нужное ФИО: ");
                    stud[i + 1] = Console.ReadLine();
                    Console.Write("Введите нужную Группу: ");
                    stud[i + 2] = Console.ReadLine();
                    Console.Write("Введите нужную Дату Рождения: ");
                    stud[i + 3] = Console.ReadLine();
                    break;
                }
                else if(i == stud.Count - 4 && Convert.ToString(stud[i]) != Convert.ToString(ss))
                {
                    Console.WriteLine("Студент не найден");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" 1 - Посмотреть студентов \n 2 - Добавить студента \n 3 - Изменить данные студента \n 4 - Удалить студента \n");
                int cp = Convert.ToInt32(Console.ReadLine());
                switch (cp)
                {
                    case 1:
                        Student.Smotr();
                        break;
                    case 2:
                        Console.WriteLine(" 1.Введите ID студента \n 2.Введите ФИО студента \n 3.Введите групу студента \n 4.Введите дату рождения студента");
                        Student.Dobavlen(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                        break;
                    case 3:
                        Student.Izmen();
                        break;
                    case 4:
                        Console.WriteLine("Введите ID студента для удаления \n");
                        int cc = Convert.ToInt32(Console.ReadLine());
                        Student.Udalit(cc);
                        break;
                }
            }
        }
    }
}
