using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА ===");
        Console.WriteLine("Выберите задание:");
        Console.WriteLine("1. Задание 1.3: Имена");
        Console.WriteLine("2. Задание 1.2: Человек");
        Console.WriteLine("3. Задание 2.4: Сотрудники и отделы");
        Console.WriteLine("4. Задание 3.4: Продолжение 2.4 (Сотрудники и отделы)");
        Console.WriteLine("5. Задание 4.5: Продолжение 1.3 (Создаём имена)");
        Console.WriteLine("6. Задание 5.1: Пистолет стреляет");
        Console.WriteLine("0. Выход");

        bool running = true;

        while (running)
        {
            Console.Write("\nВведите номер задания (0-6): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 0:
                        running = false;
                        Console.WriteLine("Программа завершена.");
                        break;

                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
                        break;

                    case 6:
                        Task6();
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите число от 0 до 6.");
            }
        }
    }

    static void Task1()
    {
        Console.WriteLine("\n=== ЗАДАНИЕ 1.3: ИМЕНА ===");

        Name name1 = new Name("", "Клеопатра", "");
        Name name2 = new Name("Пушкин", "Александр", "Сергеевич");
        Name name3 = new Name("Маяковский", "Владимир", "");

        Console.WriteLine("Имя 1: " + name1.ToString());
        Console.WriteLine("Имя 2: " + name2.ToString());
        Console.WriteLine("Имя 3: " + name3.ToString());
    }

    static void Task2()
    {
        Console.WriteLine("\n=== ЗАДАНИЕ 1.2: ЧЕЛОВЕК ===");

        Person person1 = new Person("Клеопатра", 152);
        Person person2 = new Person("Пушкин", 167);
        Person person3 = new Person("Владимир", 189);

        Console.WriteLine("Человек 1: " + person1.ToString());
        Console.WriteLine("Человек 2: " + person2.ToString());
        Console.WriteLine("Человек 3: " + person3.ToString());
    }

    static void Task3()
    {
        Console.WriteLine("\n=== ЗАДАНИЕ 2.4: СОТРУДНИКИ И ОТДЕЛЫ ===");

        Department department = new Department("IT", null);
        Employee petrov = new Employee("Петров", department);
        Employee kozlov = new Employee("Козлов", department);
        Employee sidorov = new Employee("Сидоров", department);
        department.SetBoss(kozlov);

        Console.WriteLine(petrov.ToString());
        Console.WriteLine(kozlov.ToString());
        Console.WriteLine(sidorov.ToString());
    }

    static void Task4()
    {
        Console.WriteLine("\n=== ЗАДАНИЕ 3.4: СОТРУДНИКИ ОТДЕЛА ===");

        DepartmentWithList department = new DepartmentWithList("IT", null);
        EmployeeWithList petrov = new EmployeeWithList("Петров", department);
        EmployeeWithList kozlov = new EmployeeWithList("Козлов", department);
        EmployeeWithList sidorov = new EmployeeWithList("Сидоров", department);
        EmployeeWithList ivanov = new EmployeeWithList("Иванов", department);
        department.SetBoss(kozlov);

        Console.WriteLine("Все сотрудники:");
        Console.WriteLine(petrov.ToString());
        Console.WriteLine(kozlov.ToString());
        Console.WriteLine(sidorov.ToString());
        Console.WriteLine(ivanov.ToString());

        Console.WriteLine("\nСписок всех сотрудников отдела через Петрова:");
        EmployeeWithList[] employees = petrov.GetDepartmentEmployees();
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i].Name);
        }
    }

    static void Task5()
    {
        Console.WriteLine("\n=== ЗАДАНИЕ 4.5: СОЗДАЁМ ИМЕНА ===");

        NameNew name1 = new NameNew("Клеопатра");
        NameNew name2 = new NameNew("Александр", "Пушкин", "Сергеевич");
        NameNew name3 = new NameNew("Владимир", "Маяковский");
        NameNew name4 = new NameNew("Христофор", "Бонифатьевич");

        Console.WriteLine("Имя 1: " + name1.ToString());
        Console.WriteLine("Имя 2: " + name2.ToString());
        Console.WriteLine("Имя 3: " + name3.ToString());
        Console.WriteLine("Имя 4: " + name4.ToString());
    }

    static void Task6()
    {
        Console.WriteLine("\n=== ЗАДАНИЕ 5.1: ПИСТОЛЕТ СТРЕЛЯЕТ ===");

        Gun gun = new Gun(3);

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Выстрел " + i + ": ");
            gun.Shoot();
        }

        Console.WriteLine("\n" + gun.ToString());
    }
}