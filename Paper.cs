using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class Paper
    {
        public string? TitleOfPaper { get; set; } // открытое свойство типа стринг для названия публикации
        public Person? Author { get; set; } // открытое свойство типа Person для автора
        public DateTime DateOfPaper { get; set; } // открытое свойство типа DateTime для даты публикации

        public Paper(string titleOfPaper, Person author, DateTime dateOfPaper) // конструктор для инициализации всех свойств класса
        {
            this.TitleOfPaper = titleOfPaper;
            this.Author = author;
            this.DateOfPaper = dateOfPaper;
        }

        public Paper() // конструктор без параметров, для инициализации некоторыми значениями по умолчанию
        {
            this.TitleOfPaper = "Название неизвестно.";
            this.Author = new Person(); // Инициализация объекта Author
            this.DateOfPaper = DateTime.Now;
        }

        public static Paper[] fillMasPap(int n)
        {
            Paper[] masPaper = new Paper[n];
            for (int i = 0; i < masPaper.Length; i++)
            {
                masPaper[i] = new Paper();
            }
            for (int i = 0; i < masPaper.Length; i++)
            {
                Console.Write("Введите названия публикации: ");
                masPaper[i].TitleOfPaper = Console.ReadLine();
                Console.Write("Введите имя автора: ");
                masPaper[i].Author.FirstName = Console.ReadLine();
                Console.Write("Введите фамилию автора: ");
                masPaper[i].Author.LastName = Console.ReadLine();
                Console.Write("Введите дату рождения автора: ");
                masPaper[i].Author.Birthday = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите дату публикации: ");
                masPaper[i].DateOfPaper = Convert.ToDateTime(Console.ReadLine());
            }
            return masPaper;
        }

        public override string ToString() // метод ToString()
        {
            return $"\nНазвание публикации: {TitleOfPaper}\nАвтор: {Author.ToShortString()}\nДата публикации: {DateOfPaper}";
        }
    }
}
