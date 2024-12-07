using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class Team : INameAndCopy
    {
        protected string name;
        protected int id;

        public Team() { }
        public Team(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public int ID
        {
            get { return id; }
            set {
                if (id <= 0) throw new Exception("регистрационный номер");
                id = value; 
            }

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual object DeepCopy() { return new Team(Name, ID); }
    }
}
