using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        public static void Main()
        {
            string answer = "";
            int RemoveOrNot = 0;
            int remove = 0;
            int S_count = 0;
            int A_count = 0;
            Dictionary<int, Student> AllStudents = new Dictionary<int, Student>();
            Dictionary <int, Aspirant> AllAspirants = new Dictionary<int, Aspirant>();
        Link1:
            Console.WriteLine("Ввести студента - 1\nВвести аспиранта - 2\nСписок студентов - 3\nСписок аспирантов -4");
            answer = Console.ReadLine();
         
            switch (answer)
            {
                case ("1"):
                     CreateArrayList();
                     goto Link1;
                case ("2"):
                    CreateArrayList();
                    goto Link1;
                case ("3"):
                    CreateArrayList();
                    goto Link1;
                case ("4"):
                    CreateArrayList();
                    goto Link1;
                default:
                    Console.WriteLine("\t   Ошибка! Выберите из меню");
                    goto Link1;
            }
            void CreateArrayList()
            {
                string lastname = null;
                int course = 0;
                int creditbooknumber = 0;
                int dissertation = 0;
                
                while (answer == "1")
                {
                    
                    while (lastname == null || lastname.Length < 2 || lastname.Length > 30)
                    {
                        Console.WriteLine("Введите фамилию студента");
                        try
                        {
                            lastname = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка! Фамилия должна состоять из английских букв и быть не длиннее 30-ти символов");
                            continue;
                        }
                        if (lastname != null && lastname.Length > 2 && lastname.Length < 30)
                        {
                            continue;
                        }
                        else { Console.WriteLine("Ошибка!"); }
                        
                    }
                    while (course < 1 || course > 5)
                    {
                        Console.WriteLine("Введите курс студента");
                        try
                        {
                            course = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введите цифру от 1 до 5 (включительно)");
                            continue;
                        }
                        if (course > 0 && course < 6)
                        {
                            continue;
                        }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    while (creditbooknumber < 1 || creditbooknumber > 10000)
                    {
                        Console.WriteLine("Введите номер зачетной книги");
                        try
                        {
                            creditbooknumber = Convert.ToInt32(Console.ReadLine());
                        }
                        catch 
                        {
                            Console.WriteLine("Введите цифру от 1 до 10000(включительно)");
                            continue;
                        }
                        if (creditbooknumber > 0 && creditbooknumber <= 10000)
                        {
                            continue;
                        }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    S_count += 1;
                    AllStudents.Add(S_count, new Student(lastname, course, creditbooknumber));
                    break;   
                }
                while(answer =="2")
                {
                    while (lastname == null || lastname.Length < 2 || lastname.Length > 30)
                    {
                        Console.WriteLine("Введите фамилию аспиранта");
                        try
                        {
                            lastname = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ошибка! Фамилия должна состоять из английских букв и быть не длиннее 30-ти символов");
                            continue;
                        }
                        if (lastname != null && lastname.Length > 2 && lastname.Length < 30)
                        {
                            continue;
                        }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    while (course < 1 || course > 5)
                    {
                        Console.WriteLine("Введите курс аспиранта");
                        try
                        {
                            course = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введите цифру от 1 до 5 (включительно)");
                            continue;
                        }
                        if (course > 0 && course < 6)
                        {
                            continue;
                        }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    while (creditbooknumber < 1 || creditbooknumber > 10000)
                    {
                        Console.WriteLine("Введите номер зачетной книги");
                        try
                        {
                            creditbooknumber = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введите цифру от 1 до 10000(включительно)");
                            continue;
                        }
                        if (creditbooknumber > 0 && creditbooknumber <= 10000)
                        {
                            continue;
                        }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    while (dissertation < 1 || dissertation > 10000)
                    {
                        Console.WriteLine("Введите номер диссертации");
                        dissertation = Convert.ToInt32(Console.ReadLine());
                        if (dissertation > 0 && dissertation < 10000)
                        {
                            continue;
                        }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    Aspirant newAspirant = new Aspirant(lastname, course, creditbooknumber,dissertation);
                    A_count += 1;
                    AllAspirants.Add(A_count, newAspirant);
                    break;
                }
                while (answer == "3")
                {

                    foreach (Student a in AllStudents.Values)
                    {
                        a.Print();
                    }
                    while (RemoveOrNot != 1 && RemoveOrNot != 2)
                    {
                        Console.WriteLine("Хотите удалить студента из списка?\n1 - Да \t 2 - Нет");
                        try
                        {
                            RemoveOrNot = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введите либо 1, либо 2");
                            continue;
                        }
                        if (RemoveOrNot ==1 || RemoveOrNot ==2)
                        {
                            while (RemoveOrNot == 1)
                            {
                                Console.WriteLine("Введите какого по счету студента хотите удалить из списка (пример: 1 - удалить первого, 2 - удалить второго т.д.");
                                try
                                {
                                    remove = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Ошибка! Введите цифру в соответствии от списка");
                                    continue;
                                }
                                foreach (KeyValuePair<int, Student> g in AllStudents)
                                {
                                    if (remove == g.Key)
                                    {
                                        AllStudents.Remove(remove);
                                        Console.WriteLine("Студент под индексом {remove} успешно удален\n");
                                        break;
                                    }
                                    else
                                    { Console.WriteLine("Ошибка!"); }
                                    continue;
                                }
                                break;
                            }
                           
                        }
                        else { Console.WriteLine("Ошибка!Введите либо 1, либо 2"); }

                    }
                    break;
                }
                while (answer == "4")
                {
                    foreach(Aspirant b in AllAspirants.Values)
                    {
                        b.Print();
                    }
                    while (RemoveOrNot != 1 && RemoveOrNot != 2)
                    {
                        Console.WriteLine("Хотите удалить студента из списка?\n1 - Да \t 2 - Нет");
                        try
                        {
                            RemoveOrNot = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введите либо 1, либо 2");
                            continue;
                        }
                        if (RemoveOrNot == 1 || RemoveOrNot == 2)
                        {
                            while (RemoveOrNot == 1)
                            {
                                Console.WriteLine("Введите какого по счету студента хотите удалить из списка (пример: 1 - удалить первого, 2 - удалить второго т.д.");
                                try
                                {
                                    remove = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Ошибка! Введите цифру в соответствии от списка");
                                    continue;
                                }
                                foreach (KeyValuePair<int, Student> g in AllStudents)
                                {
                                    if (remove == g.Key)
                                    {
                                        AllStudents.Remove(remove);
                                        Console.WriteLine("Студент под индексом {remove} успешно удален\n");
                                        break;
                                    }
                                    else
                                    { Console.WriteLine("Ошибка!"); }
                                    continue;
                                }
                                break;
                            }

                        }
                        else { Console.WriteLine("Ошибка!Введите либо 1, либо 2"); }

                    }
                    break;
                }
            }
        }
    }
    public abstract class Educated
    {
        public abstract string Lastname { get; set; }
        public abstract int Course { get; set; }
        public abstract int CreditBookNumber { get; set; }
        public abstract void Print();
    }
    public class Student : Educated
    {
        public override string Lastname { get; set; }
        public override int Course { get; set; }
        public override int CreditBookNumber { get; set; }
        public Student(string lastname, int course, int creditbooknumber)
        { Lastname = lastname; Course = course; CreditBookNumber = creditbooknumber; }
        public override void Print()
        { Console.WriteLine($"Студент {Lastname} учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}"); }
    }
    public class Aspirant : Educated
    {
        public override string Lastname { get; set; }
        public override int Course { get; set; }
        public override int CreditBookNumber { get; set; }
        public int Dissertation { get; set; }
        public Aspirant(string lastname, int course, int creditbooknumber, int dissertation)
        { Lastname = lastname; Course = course; CreditBookNumber = creditbooknumber; Dissertation = dissertation; }
        public override void Print()
        { Console.WriteLine($"Студент {Lastname} учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}. Номер диссертации: {Dissertation}"); }
    }
}

