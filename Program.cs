﻿using GitProject;

try
{
    ResearchTeam r1 = new ResearchTeam("Автоматы по экзаменам.", "БГУиР", 542, TimeFrame.Long);
    Console.WriteLine(r1);

    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Long]);
    Console.WriteLine("Значение индексатора для TimeFrame.Year: " + r1[TimeFrame.Year]);
    Console.WriteLine("Значение индексатора для TimeFrame.TwoYears: " + r1[TimeFrame.TwoYears]);

    r1.ResearchTopics = "Интриги";//set
    Console.WriteLine("Изменили название топика: " + r1.ResearchTopics);//get
    r1.NameOrganizationr = "КБиП";//set
    Console.WriteLine("Изменили название организации: " + r1.NameOrganizationr);//get
    r1.Id = 291;//set
    Console.WriteLine("Изменили регистрационный номер: " + r1.Id);//get
    r1.Duration = TimeFrame.Year;//set
    Console.WriteLine("Изменили продолжительность исследования: " + r1.Duration);//get
    Console.WriteLine("Введите количество публикаций: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Paper[] masPaper = Paper.fillMasPap(n);
    r1.Papers = masPaper;//set
    Console.WriteLine("Добавили список публикаций:");
    foreach (var paper in r1.Papers)
    {
        Console.WriteLine(paper.TitleOfPaper);//get
    }
    Console.WriteLine("ОБЩАЯ ИНФОРМАЦИЯ:");
    Console.WriteLine(r1);

    Paper p1 = new Paper("Сватко о пандосах!", new Person("Тимофей", "Логвин", new DateTime(2006, 04, 03)), new DateTime(2021, 11, 20));
    Paper p2 = new Paper("Как выжить на IT", new Person("Злата", "Гросул", new DateTime(2006, 11, 24)), new DateTime(2023, 11, 15));
    Paper p3 = new Paper("Куда идти на практику?", new Person("Анна", "Архипцева", new DateTime(2007, 02, 17)), new DateTime(2024, 11, 18));
    r1.AddPapers(p1, p2, p3);
    Console.WriteLine(r1);

    Console.WriteLine("Публикация с самой поздней датой выхода:\n" + r1.LatePaper);

    Console.WriteLine("Введите размер массивов: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    DateTime startTime, endTime;
    TimeSpan duration;

    //Одномерный массив
    Paper[] mas = new Paper[n1*n1];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Paper();
    }
    startTime = DateTime.Now;
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i].Author.FirstName = "gkjgk";
    }
    endTime = DateTime.Now;
    duration = endTime - startTime;
    Console.WriteLine("Время выполнения для одномерного массива: " + duration.TotalMilliseconds + " мс");

    // Двумерный массив
    Paper[,] masDvum = new Paper[n1, n1];
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            masDvum[i, j] = new Paper();
        }
    }
    startTime = DateTime.Now;
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            masDvum[i, j].Author.FirstName = "gkjgk";
        }
    }
    endTime = DateTime.Now;
    duration = endTime - startTime;
    Console.WriteLine("Время выполнения для двумерного массива: " + duration.TotalMilliseconds + " мс");

    // Двумерный ступенчатый массив
    Paper[][] masDvumStep = new Paper[n1][];
    for (int i = 0; i < n1; i++)
    {
        masDvumStep[i] = new Paper[n1];
        for (int j = 0; j < n1; j++)
        {
            masDvumStep[i][j] = new Paper();
        }
    }
    startTime = DateTime.Now;
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            masDvumStep[i][j].Author.FirstName = "gkjgk";
        }
    }
    endTime = DateTime.Now;
    duration = endTime - startTime;
    Console.WriteLine("Время выполнения для двумерного ступенчатого массива: " + duration.TotalMilliseconds + " мс");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Ошибка нулевой ссылки! " + ex.Message);
}
catch(ArgumentException ex)
{
    Console.WriteLine("Ошибка аргумента! " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Ошибка но фиг знает какая! " + ex.Message);
}