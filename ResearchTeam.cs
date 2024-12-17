using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    enum TimeFrame // Объявление перечисления TimeFrame
    {
        Year, // Значение Year
        TwoYears, // Значение TwoYears
        Long // Значение Long
    }

    internal class ResearchTeam : Team, INameAndCopy // Объявление класса ResearchTeam, наследующего от Team и реализующего интерфейс INameAndCopy
    {
        private string researchTopics; // Поле для хранения названия темы исследования
        private string nameOrganizationr; // Поле для хранения названия организации
        private TimeFrame duration; // Поле для хранения продолжительности исследования
        private System.Collections.ArrayList papers; // Поле для хранения списка публикаций
        private System.Collections.ArrayList members; // Поле для хранения списка участников

        public ResearchTeam(string name, int id, string researchTopics, string nameOrganizationr, TimeFrame duration) : base(name, id) // Конструктор с параметрами
        {
            this.researchTopics = researchTopics; // Инициализация поля researchTopics
            this.nameOrganizationr = nameOrganizationr; // Инициализация поля nameOrganizationr
            this.id = id; // Инициализация поля id
            this.duration = duration; // Инициализация поля duration
        }

        public ResearchTeam() : base() // Конструктор без параметров
        {
            this.researchTopics = "researchTopics"; // Инициализация поля researchTopics значением по умолчанию
            this.nameOrganizationr = "nameOrganizationr"; // Инициализация поля nameOrganizationr значением по умолчанию
            this.duration = TimeFrame.Year; // Инициализация поля duration значением по умолчанию
        }

        public string ResearchTopics // Свойство для доступа к полю researchTopics
        {
            get { return this.researchTopics; } // Геттер для получения значения поля researchTopics
            set { this.researchTopics = value; } // Сеттер для установки значения поля researchTopics
        }

        public string NameOrganizationr // Свойство для доступа к полю nameOrganizationr
        {
            get { return this.nameOrganizationr; } // Геттер для получения значения поля nameOrganizationr
            set { this.nameOrganizationr = value; } // Сеттер для установки значения поля nameOrganizationr
        }

        public int Id // Свойство для доступа к полю id
        {
            get { return this.id; } // Геттер для получения значения поля id
            set { this.id = value; } // Сеттер для установки значения поля id
        }

        public TimeFrame Duration // Свойство для доступа к полю duration
        {
            get { return this.duration; } // Геттер для получения значения поля duration
            set { this.duration = value; } // Сеттер для установки значения поля duration
        }

        public bool this[TimeFrame key] // Индексатор для проверки соответствия значения duration ключу key
        {
            get { return (this.duration == key); } // Возвращает true, если duration равно key
        }

        public System.Collections.ArrayList Papers // Свойство для доступа к полю papers
        {
            get { return papers; } // Геттер для получения значения поля papers
            set { papers = value; } // Сеттер для установки значения поля papers
        }

        public System.Collections.ArrayList Members // Свойство для доступа к полю members
        {
            get { return members; } // Геттер для получения значения поля members
            set { members = value; } // Сеттер для установки значения поля members
        }

        public Paper? LatePaper // Свойство для получения последней публикации
        {
            get
            {
                if (papers == null) return null; // Возвращает null, если список публикаций пуст
                IEnumerator x = papers.GetEnumerator(); // Получение перечислителя для списка публикаций
                x.MoveNext();
                Paper item = (Paper)x.Current; // Получение текущего элемента списка публикаций
                DateTime max = item.DateOfPaper; // Переменная для хранения даты последней публикации
                Paper? index = item; // Переменная для хранения последней публикации
                while (x.MoveNext()) // Цикл для перебора всех публикаций
                {
                    item = (Paper)x.Current; // Получение текущего элемента списка публикаций
                    if (max < item.DateOfPaper) // Проверка, является ли текущая публикация более поздней
                    {
                        index = item; // Обновление переменной index
                        max = item.DateOfPaper; // Обновление переменной max
                    }
                }
                return index; // Возвращает последнюю публикацию
            }
        }
        private string CreateStr() // Метод для создания строки с информацией о публикациях
        {
            string str = ""; // Переменная для хранения строки
            if (papers == null) return "Публикации отсутствуют."; // Возвращает сообщение, если список публикаций пуст
            IEnumerator x = papers.GetEnumerator(); // Получение перечислителя для списка публикаций
            while (x.MoveNext()) // Цикл для перебора всех публикаций
            {
                Paper item = (Paper)x.Current; // Получение текущего элемента списка публикаций
                str += item.ToString() + '\n'; // Добавление информации о публикации в строку
            }
            return str; // Возвращает строку с информацией о публикациях
        }

        public void AddPapers(params Paper[] mas) // Метод для добавления публикаций
        {
            if (papers == null) throw new Exception("Ошибка, papers был null");
            foreach (Paper p in mas)
            {
                papers.Add(p);// Добавление публикаций в список
            }
        }

        public void AddMembers(params Person[] mas) // Метод для добавления публикаций
        {
            if (members == null) throw new Exception("Ошибка, members был null");
            foreach (Person p in mas)
            {
                members.Add(p);// Добавление людей в список
            }
        }
        public override string ToString() // Переопределение метода ToString для вывода информации о команде
        {
            return base.ToString() + $", названием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}\nCписок публикаций:\n" + CreateStr(); // Возвращает строку с информацией о команде
        }

        public virtual string ToShortString() // Метод для краткого вывода информации о команде
        {
            return base.ToString() + $"Названием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}"; // Возвращает строку с краткой информацией о команде
        }

        public override object DeepCopy() // Метод для глубокого копирования объекта
        {
            ResearchTeam a = new ResearchTeam(Name, Id, ResearchTopics, NameOrganizationr, Duration); // Возвращает новый объект ResearchTeam
            a.Members = Members;
            a.Papers = Papers;
            return a;
        }

        public Team Team // Свойство для получения объекта Team
        {
            get { return new Team(Name, Id); } // Возвращает новый объект Team
            set
            {
                if (value == null) throw new ArgumentNullException("value"); // Выбрасывает исключение, если значение null
                Name = value.Name; // Устанавливает значение Name
                Id = value.ID; // Устанавливает значение Id
            }
        }

        public IEnumerable<Person> GetMembersWithoutPublications() // Метод для получения участников без публикаций
        {
            foreach (Person member in members) // Перебор всех участников
            {
                bool hasPublications = false; // Переменная для проверки наличия публикаций
                foreach (Paper paper in papers) // Перебор всех публикаций
                {
                    if (paper.Author == member) // Проверка, является ли участник автором публикации
                    {
                        hasPublications = true; // Устанавливает значение true, если участник является автором публикации
                        break; // Прерывает цикл
                    }
                }
                if (!hasPublications) // Проверка, если участник не имеет публикаций
                {
                    yield return member; // Возвращает участника
                }
            }
        }
        public IEnumerable<Paper> GetRecentPublications()
        {
            DateTime oneYearAgo = DateTime.Now.AddYears(-1);
            foreach (Paper paper in papers)
            {
                if (paper.DateOfPaper >= oneYearAgo)
                {
                    yield return paper;
                }
            }
        }
        public IEnumerable<Paper> GetRecentPublications(int n) // Метод для получения последних публикаций за n лет
        {
            DateTime currentDate = DateTime.Now; // Текущая дата
            foreach (Paper paper in papers) // Перебор всех публикаций
            {
                if ((currentDate - paper.DateOfPaper).TotalDays <= n * 365) // Проверка, если публикация была сделана за последние n лет
                {
                    yield return paper; // Возвращает публикацию
                }
            }
        }

    }
}
