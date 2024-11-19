using GitProject;

try
{
    ResearchTeam r1 = new ResearchTeam("Автоматы по экзаменам.", "БГУиР", 542, TimeFrame.Long);
    Console.WriteLine(r1);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Long]);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Year]);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.TwoYears]);
    r1.ResearchTopics = "Интиги";
    r1.NameOrganizationr = "КБиП";
    r1.Id = 291;
    
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Ошибка! " + ex.Message);
}