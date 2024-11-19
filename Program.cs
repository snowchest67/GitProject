using GitProject;

try
{
    ResearchTeam r1 = new ResearchTeam("Автоматы по экзаменам.", "КБиП", 291, TimeFrame.Long);
    Console.WriteLine(r1.ToShortString());
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Long]);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.Year]);
    Console.WriteLine("Значение индексатора для TimeFrame.Long: " + r1[TimeFrame.TwoYears]);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Ошибка! " + ex.Message);
}