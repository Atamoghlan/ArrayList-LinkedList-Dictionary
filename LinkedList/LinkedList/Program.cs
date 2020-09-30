using System;
using System.Collections;
using System.Collections.Generic;
namespace LinkedList
{
    class Program
    {
        public static void Main()
        {
            string answer = "";
            LinkedList<Student> AllStudents = new LinkedList<Student>();
            LinkedList<Aspirant> AllAspirants = new LinkedList<Aspirant>();
            LinkedListNode<Student> node;
            LinkedListNode<Aspirant> node2;
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
                        if (lastname !=null && lastname.Length > 2 && lastname.Length < 30)
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
                    Student newStudent = new Student(lastname, course, creditbooknumber);
                    AllStudents.AddLast(newStudent);
                    break;
                }
                while (answer == "2")
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
                    Aspirant newAspirant = new Aspirant(lastname, course, creditbooknumber, dissertation);
                    AllAspirants.AddLast(newAspirant);

                    break;
                }
                while (answer == "3")
                {
                    foreach (Student a in AllStudents)
                    {
                        a.Print();
                    }
                    Console.WriteLine("\n\nСписок студентов в обратном направлении: ");
                    for (node = AllStudents.Last; node != null; node = node.Previous)
                        node.Value.Print();

                    break;
                }
                while (answer == "4")
                {
                    foreach (Aspirant b in AllAspirants)
                    {
                        b.Print();
                    }
                    Console.WriteLine("\n\nСписок аспирантов в обратном направлении: ");
                    for (node2 = AllAspirants.Last; node2 != null; node2 = node2.Previous)
                        node2.Value.Print();
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
