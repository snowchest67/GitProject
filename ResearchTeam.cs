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
        //private Paper[] papers;

        public ResearchTeam(string researchTopics, string nameOrganizationr, int id, TimeFrame duration)
        {
            this.researchTopics = researchTopics;
            this.nameOrganizationr = nameOrganizationr;
            this.id = id;
            this.duration = duration;
            //Paper[] papers = papers;
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

        public override string ToString()
        {
            string str = "";
            str += $"названием темы исследования: {researchTopics}\nназванием организации: {nameOrganizationr}\nрегистрационный номер: {id}\nпродолжительность исследования{duration}";
            return str;
        }

        public virtual string ToShortString()
        {
            return $"названием темы исследования: {researchTopics}\nназванием организации: {nameOrganizationr}\nрегистрационный номер: {id}\nпродолжительность исследования{duration}";
        }
    }
}
