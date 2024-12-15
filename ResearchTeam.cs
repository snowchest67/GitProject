using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    enum TimeFrame
    {
        Year, TwoYears, Long
    }
    internal class ResearchTeam : Team, INameAndCopy, IE
    {
        private string researchTopics;//Названием темы исследования
        private string nameOrganizationr;//Названием организации
        private TimeFrame duration;//Продолжительность исследования
        private System.Collections.ArrayList papers;//Список публикаций

        public ResearchTeam(string name, int id, string researchTopics, string nameOrganizationr, TimeFrame duration) : base(name,id)
        {
            this.researchTopics = researchTopics;
            this.nameOrganizationr = nameOrganizationr;
            this.id = id;
            this.duration = duration;
        }

        public ResearchTeam() : base() 
        {
            this.researchTopics = "researchTopics";
            this.nameOrganizationr = "nameOrganizationr";
            this.duration = TimeFrame.Year;
          
        }

        public string ResearchTopics
        {
            get { return this.researchTopics; }
            set { this.researchTopics = value; }
        }

        public string NameOrganizationr
        {
            get { return this.nameOrganizationr; }
            set { this.nameOrganizationr = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public TimeFrame Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public bool this[TimeFrame key]
        {
            get { return (this.duration == key); }
        }

        public System.Collections.ArrayList Papers
        {
            get { return papers; }
            set { papers = value; }
        }

        public Paper? LatePaper
        {
            get
            {
                if (papers == null) return null;
                Paper? index = null;
                IEnumerator x = papers.GetEnumerator();
                Paper item = (Paper)x.Current;
                DateTime max = item.DateOfPaper;
                while (x.MoveNext())
                {
                    item = (Paper)x.Current;
                    if (max < item.DateOfPaper)
                    {
                        index = item;
                        max = item.DateOfPaper;
                    }
                }
                return index;
            }
        }

        private string CreateStr()
        {
            string str = "";
            if (papers == null) return "Публкации отсутствуют.";
            IEnumerator x = papers.GetEnumerator();
            while (x.MoveNext())
            {
                Paper item = (Paper)x.Current;
                str += item.ToString() + '\n';
            }
            return str;
        }

        public void AddPapers(params Paper[] mas)
        {
            papers.Add(mas);
        }

        public override string ToString()
        {
            return base.ToString() + $", названием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}\nCписок публикаций:\n" + CreateStr();
        }

        public virtual string ToShortString()
        {
            return base.ToString() + $"Названием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}";
        }

        public override object DeepCopy()
        {
            return new ResearchTeam(Name,Id, ResearchTopics, NameOrganizationr, Duration);
        }

        public Team Team
        {
            get { return new Team(Name, Id); }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                Name = value.Name;
                Id = value.ID;
            }
        }



    }
}
