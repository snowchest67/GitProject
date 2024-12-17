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
        public override bool Equals(object? obj)//переопределенный метод virtial bool Equals (object obj)
        {

            if (obj == null || !(obj is Team))
                return false;
            else
                return Name == (obj as Team).Name && ID == (obj as Team).ID;
        }
        public static bool operator ==(Team p1, Team p2)//переопределить оператор == 
        {
            if ((object)p1 == null) return (object)p2 == null;
            return p1.Equals(p2);
        }
        public static bool operator !=(Team p1, Team p2)//переопределить оператор != 
        {
            if ((object)p1 == null) return false;
            return !p1.Equals(p2);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
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
