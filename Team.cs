﻿using System;
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

        public Team() { Name = "None"; ID = 1; }
        public Team(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public int ID
        {
            get { return id; }
            set {
                if (value <= 0) throw new Exception("регистрационный номер");
                id = value; 
            }

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual object DeepCopy() { return new Team(Name, ID); }

        public override string ToString()
        {
            return $"Название организации: {Name}, регистрационый номер: {ID}";
        }


    }
}
