using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class Paper
    {
        public string titleOfPaper { get; set; }//открытое свойство типа стринг для названия публикации
        public Person author { get; set; }//открытое свойство типа Person для автора
        public DateTime dateOfPaper { get; set; }//открытое свойство типа DateTime для даты публикации

        public Paper(string titleOfPaper, Person author, DateTime dateOfPaper)//конструктор для инициализации всех свойств класса
        {
            this.titleOfPaper = titleOfPaper;
            this.author = author;
            this.dateOfPaper = dateOfPaper;
        }
    }
}
