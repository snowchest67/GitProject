﻿using GitProject;
using System;

try
{
    Person person1 = new Person("Иван", "Иванов", new DateTime(1985, 5, 20));
    Person person2 = new Person("Петр", "Петров", new DateTime(1990, 8, 15));
    Person person3 = new Person("Полина", "Белевич", new DateTime(2007, 02, 17));

    ResearchTeam r1 = new ResearchTeam("Тема исследования", 1, "Организация", "Название организации", TimeFrame.Year);//Создать объект типа ResearchTeam
    //добавить элементы в список участников проекта
    r1.Members = new System.Collections.ArrayList { person1, person2 };
    r1.AddMembers(person3);

    Paper p1 = new Paper("Сватко о пандосах!", new Person("Тимофей", "Логвин", new DateTime(2006, 04, 03)), new DateTime(2021, 11, 20));
    Paper p2 = new Paper("Как выжить на IT", new Person("Злата", "Гросул", new DateTime(2006, 11, 24)), new DateTime(2023, 11, 15));
    Paper p3 = new Paper("Куда идти на практику?", new Person("Полина", "Белевич", new DateTime(2007, 02, 17)), new DateTime(2024, 11, 18));
    Paper p4 = new Paper("Куда идти на практику?2.0", new Person("Полина", "Белевич", new DateTime(2007, 02, 17)), new DateTime(2024, 11, 18));

    //добавить элементы в список публикаций
    r1.Papers = new System.Collections.ArrayList { p1, p2 };
    r1.AddPapers(p3,p4);
    Console.WriteLine("Добавили список публикаций:");
    foreach (Paper paper in r1.Papers)
    {
        Console.WriteLine(paper.TitleOfPaper);
    }

    //вывод данных
    Console.WriteLine("ОБЩАЯ ИНФОРМАЦИЯ:");
    Console.WriteLine(r1);
    ResearchTeam rCopy = (ResearchTeam)r1.DeepCopy(); //создаем глубокую копию

    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Long]);
    Console.WriteLine("Значение индексатора для TimeFrame.Year: " + r1[TimeFrame.Year]);
    Console.WriteLine("Значение индексатора для TimeFrame.TwoYears: " + r1[TimeFrame.TwoYears]);

    r1.ResearchTopics = "Интриги";
    Console.WriteLine("Изменили название топика: " + r1.ResearchTopics);

    r1.NameOrganizationr = "КБиП";
    Console.WriteLine("Изменили название организации: " + r1.NameOrganizationr);

    r1.Id = 291;
    Console.WriteLine("Изменили регистрационный номер: " + r1.Id);

    r1.Duration = TimeFrame.Year;
    Console.WriteLine("Изменили продолжительность исследования: " + r1.Duration);
    Console.WriteLine("НОВАЯ ИНФОРМАЦИЯ r1:");
    Console.WriteLine(r1);
    Console.WriteLine("ИНФОРМАЦИЯ rCopy:");
    Console.WriteLine(rCopy);

    Console.WriteLine("Значение свойства team: " + r1.Team); //значение свойства Team для объекта ResearchTeam

    Console.WriteLine("\nПубликация с самой поздней датой выхода:\n" + r1.LatePaper);

    // Используем итератор для перебора участников без публикаций
    Console.WriteLine("Участники без публикаций:");
    foreach (Person member in r1.GetMembersWithoutPublications())
    {
        Console.WriteLine(member);
    }

    // Используем итератор для перебора публикаций за последние 2 года
    Console.WriteLine("\nПубликации за последние 2 года:");
    foreach (Paper paper in r1.GetRecentPublications(2))
    {
        Console.WriteLine(paper);
    }
    Console.WriteLine("В ЭТОМ ГОДУ");
    foreach (Paper paper in r1.GetRecentPublications())
    {
        Console.WriteLine(paper);
    }
    Console.WriteLine("ХОТЯ БЫ ОДНА ПУБЛИКАЦИЯ");
    foreach (Person person in r1.GetMembersWithMultiplePublications())
    {
        Console.WriteLine(person);
    }
    Console.WriteLine("\nСРАВНЕНИЕ TEAM\n");

    Team t1 = new Team("Команда1", 12);
    Team t2 = new Team("Команда1", 12); // Создаем объект с теми же данными

    Console.WriteLine((t1 == t2) ? "Объекты равны" : "Объекты не равны");

    // Проверяем ссылки на объекты
    Console.WriteLine($"Ссылки на объекты равны: {ReferenceEquals(t1, t2)}");

    // Выводим значения хэш-кодов
    Console.WriteLine($"Хэш-код t1: {t1.GetHashCode()}");
    Console.WriteLine($"Хэш-код t2: {t2.GetHashCode()}");

    try
    {
        r1.ID = -1;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    //Console.WriteLine("Введите размер массивов: ");
    //int n1 = Convert.ToInt32(Console.ReadLine());

    //DateTime startTime, endTime;
    //TimeSpan duration;


    ////Одномерный массив
    //Paper[] mas = new Paper[n1 * n1];
    //for (int i = 0; i < mas.Length; i++)
    //{
    //    mas[i] = new Paper();
    //}
    //startTime = DateTime.Now;
    //for (int i = 0; i < mas.Length; i++)
    //{
    //    mas[i].Author.FirstName = "gkjgk";
    //}
    //endTime = DateTime.Now;
    //duration = endTime - startTime;
    //Console.WriteLine("Время выполнения для одномерного массива: " + duration.TotalMilliseconds + " мс");

    //// Двумерный массив
    //Paper[,] masDvum = new Paper[n1, n1];
    //for (int i = 0; i < n1; i++)
    //{
    //    for (int j = 0; j < n1; j++)
    //    {
    //        masDvum[i, j] = new Paper();
    //    }
    //}
    //startTime = DateTime.Now;
    //for (int i = 0; i < n1; i++)
    //{
    //    for (int j = 0; j < n1; j++)
    //    {
    //        masDvum[i, j].Author.FirstName = "gkjgk";
    //    }
    //}
    //endTime = DateTime.Now;
    //duration = endTime - startTime;
    //Console.WriteLine("Время выполнения для двумерного массива: " + duration.TotalMilliseconds + " мс");

    //// Двумерный ступенчатый массив
    //Paper[][] masDvumStep = new Paper[n1][];
    //for (int i = 0; i < n1; i++)
    //{
    //    masDvumStep[i] = new Paper[n1];
    //    for (int j = 0; j < n1; j++)
    //    {
    //        masDvumStep[i][j] = new Paper();
    //    }
    //}
    //startTime = DateTime.Now;
    //for (int i = 0; i < n1; i++)
    //{
    //    for (int j = 0; j < n1; j++)
    //    {
    //        masDvumStep[i][j].Author.FirstName = "gkjgk";
    //    }
    //}
    //endTime = DateTime.Now;
    //duration = endTime - startTime;
    //Console.WriteLine("Время выполнения для двумерного ступенчатого массива: " + duration.TotalMilliseconds + " мс");

    Console.WriteLine("\nТЕСТ ENumerable\n");
    Person person10 = new Person { FirstName = "Иван", LastName = "Иванов", Birthday = new DateTime(1985, 5, 20) };
    Person person20 = new Person { FirstName = "Петр", LastName = "Петров", Birthday = new DateTime(1990, 8, 15) };
    Person person30 = new Person { FirstName = "Сергей", LastName = "Сергеев", Birthday = new DateTime(1988, 12, 10) };

    // Создаем публикации
    Paper paper10 = new Paper("Исследование 1", person10, new DateTime(2020, 1, 10));
    Paper paper20 = new Paper("Исследование 2", person20, new DateTime(2021, 3, 5));
    Paper paper30 = new Paper("Исследование 3", person10, new DateTime(2022, 7, 20));

    // Создаем исследовательскую команду и добавляем участников и публикации
    ResearchTeam researchTeam = new ResearchTeam();
    researchTeam.Members = new System.Collections.ArrayList { person10, person20, person30 };
    researchTeam.Papers = new System.Collections.ArrayList { paper10, paper20, paper30 };

    // Перебираем участников, у которых есть публикации
    Console.WriteLine("Перебираем участников, у которых есть публикации\n");
    foreach (Person person in researchTeam)
    {
        Console.WriteLine($"{person.FirstName} {person.LastName} имеет публикации.");
    }

}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Ошибка нулевой ссылки! " + ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ошибка аргумента! " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка но фиг знает какая! " + ex.Message);
}



