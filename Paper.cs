using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class Paper
    {
        public string TitleOfPaper { get; set; }//открытое свойство типа стринг для названия публикации
        public Person Author { get; set; }//открытое свойство типа Person для автора
        public DateTime DateOfPaper { get; set; }//открытое свойство типа DateTime для даты публикации

        public Paper(string titleOfPaper, Person author, DateTime dateOfPaper)//конструктор для инициализации всех свойств класса
        {
            this.TitleOfPaper = titleOfPaper;
            this.Author = author;
            this.DateOfPaper = dateOfPaper;
        }
        public Paper ()//конструктор без параметров, для инициализации некоторыми значениями по умолчанию
        {
            this.TitleOfPaper = "Название неизвестно.";
            this.Author = new Person();
            this.DateOfPaper = DateTime.Now;
        }
        public override string ToString()//метод ToString()
        {
            return $"Название публикации: {TitleOfPaper}\nАвтор: {Author.ToShortString()}\nДата публикации: {DateOfPaper}";
        }
    }
}
