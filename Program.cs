using GitProject;

try
{
    ResearchTeam r1 = new ResearchTeam("Автоматы по экзаменам.", "БГУиР", 542, TimeFrame.Long);
    Console.WriteLine(r1);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Long]);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Year]);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.TwoYears]);
    r1.ResearchTopics = "Интриги";
    r1.NameOrganizationr = "КБиП";
    r1.Id = 291;
    r1.Duration = TimeFrame.Year;
    Console.WriteLine("Введите количество публикаций: ");
    Paper[] masPaper = Paper.fillMasPap(Console.Read());
    r1.Papers = masPaper;
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Ошибка! " + ex.Message);
}