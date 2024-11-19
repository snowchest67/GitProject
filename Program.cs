using GitProject;

try
{
    ResearchTeam r1 = new ResearchTeam("Автоматы по экзаменам.", "БГУиР", 542, TimeFrame.Long);
    Console.WriteLine(r1);
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
    Console.WriteLine("Введите количество публикаций: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Paper[] masPaper = Paper.fillMasPap(n);
    r1.Papers = masPaper;
    Console.WriteLine("Добавили список публикаций: " + string.Join(", ", r1.Papers.Select(p => p.TitleOfPaper)));
    Console.WriteLine("ОБЩАЯ ИНФОРМАЦИЯ:");
    Console.WriteLine(r1);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Ошибка! " + ex.Message);
}