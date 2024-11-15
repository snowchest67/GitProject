using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class ResearchTeam
    {
        private string researchTopics;
        private string nameOrganizationr;
        private int id;
        private DateTime duration;
        //private Paper[] papers;

        public ResearchTeam(string researchTopics, string nameOrganizationr, int id, DateTime duration)
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
            //this.duration = 0;
        }
    }
}
