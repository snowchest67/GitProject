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
    internal class ResearchTeam
    {
        private string researchTopics;
        private string nameOrganizationr;
        private int id;
        private TimeFrame duration;
        private Paper[] papers;

        public ResearchTeam(string researchTopics, string nameOrganizationr, int id, TimeFrame duration, int n)
        {
            this.researchTopics = researchTopics;
            this.nameOrganizationr = nameOrganizationr;
            this.id = id;
            this.duration = duration;
            papers = new Paper[n];
            for (int i = 0;i < n; i++)
            {
                papers[i] = new Paper();
            }
        }

        public ResearchTeam()
        {
            this.researchTopics = "researchTopics";
            this.nameOrganizationr = "nameOrganizationr";
            this.id = 0;
            this.duration = TimeFrame.Year;
            papers = new Paper[3];
            for (int i = 0; i < 3; i++)
            {
                papers[i] = new Paper();
            }
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
            set { Papers = value; }
        }

        public Paper LatePaper
        {
            get
            {
                int index = 0;
                DateTime max = papers[0].DateOfPaper;
                if (LatePaper == null) throw new Exception("Ссылка равна null");
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

        public override string ToString()
        {
            string str = "";
            str += $"Названием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}\nCписок публикаций:\n";
            for (int i = 0;i < this.papers.Length;i++)
            {
                str += this.papers[i].ToString();
            }    
            return str;
        }

        public virtual string ToShortString()
        {
            return $"Названием темы исследования: {researchTopics}\nНазванием организации: {nameOrganizationr}\nРегистрационный номер: {id}\nПродолжительность исследования: {duration}";
        }
    }
}
