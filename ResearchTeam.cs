using System;
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
    internal class ResearchTeam : Team
    {
        private string researchTopics;//Названием темы исследования
        private string nameOrganizationr;//Названием организации
        private int id;//Регистрационный номер
        private TimeFrame duration;//Продолжительность исследования
        private Paper[]? papers;//Список публикаций

        public ResearchTeam(string researchTopics, string nameOrganizationr, int id, TimeFrame duration)
        {
            this.researchTopics = researchTopics;
            this.nameOrganizationr = nameOrganizationr;
            this.id = id;
            this.duration = duration;
        }

        public ResearchTeam()
        {
            this.researchTopics = "researchTopics";
            this.nameOrganizationr = "nameOrganizationr";
            this.id = 0;
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

        public Paper[] Papers
        {
            get { return papers; }
            set { papers = value; }
        }

        public Paper LatePaper
        {
            get
            {
                int index = 0;
                DateTime max = papers[0].DateOfPaper;
                if (papers == null) throw new ArgumentNullException("Ссылка равна null");
                else
                {
                    for(int i = 0; i < papers.Length; i++)
                    {
                        if(max < papers[i].DateOfPaper)
                        {
                            index = i;
                            max = papers[i].DateOfPaper;
                        }
                    }
                }
                return papers[index];
            }
        }

        private string CreateStr()
        {
            string str = "";
            if (papers == null) return "Публкации отсутствуют.";
            for (int i = 0; i < this.papers.Length; i++)
            {
                str += this.papers[i].ToString() + '\n';
            }
            return str;
        }

        public void AddPapers(params Paper[] mas)
        {
            if (papers == null)
            {
                papers = new Paper[mas.Length];
                for(int i = 0;i < papers.Length;i++)
                {
                    papers[i] = mas[i];
                }
            }
            else
            {
                int j = papers.Length;
                Array.Resize(ref papers, papers.Length + mas.Length);
                for(int i = 0; j < papers.Length; i++, j++)
                {
                    papers[j] = mas[i];
                }
                
            }
        }

        public override string ToString()
        {
            return $"\nНазванием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}\nCписок публикаций:\n" + CreateStr();
        }

        public virtual string ToShortString()
        {
            return $"\nНазванием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}";
        }
    }
}
