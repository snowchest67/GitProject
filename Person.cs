using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class Person
    {
        String? firstName;
        String? lastName;
        DateTime birthday;

        public DateTime Birthday
        {
            get => birthday;
            set
            {
                if (DateTime.Today >= value)
                    birthday = value;
                else
                    throw new ArgumentException("День рождения не может быть больше сегодняшнего дня");
            }
        }
        public String? FirstName
        {
            get => firstName;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Значение имеет null или пустая строка");

                firstName = value;
            }
        }
        public String? LastName
        {
            get => lastName;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Значение имеет null или пустая строка");

                lastName = value;
            }
        }

        public int Yers
        {
            get => birthday.Year;
            set
            {
                if (value > DateTime.Now.Year)
                    throw new ArgumentException("Передаваемый год больше года в данный момент");

                int differenceYers = DateTime.Now.Year - value;

                birthday = birthday.AddYears(-differenceYers);
            }
        }

        public Person()
        {
            this.firstName = "Имя неизвестно";
            this.lastName = "Фамилия неизвестна";
            this.birthday = DateTime.Today;
        }

        public Person(String firstName, String lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }
   
        public override bool Equals(object? obj)//переопределенный метод virtial bool Equals (object obj)
        {

            if (obj == null || !(obj is Person))
                return false;
            else
                return FirstName == (obj as Person).FirstName && Birthday == (obj as Person).Birthday && LastName == (obj as Person).LastName;
        }
        public static bool operator ==(Person p1, Person p2)//переопределить оператор == 
        {
            if ((object)p1 == null) return (object)p2 == null;
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)//переопределить оператор != 
        {
            if ((object)p1 == null) return false;
            return !p1.Equals(p2);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public virtual object DeepCopy() 
        { 
            return new Person { FirstName = this.FirstName, LastName = this.LastName, Birthday = this.Birthday }; 
        }
        public override string ToString() => $"\nИмя: {firstName}; Фамилия: {LastName}; год рождения: {birthday.ToShortDateString()}";

        public virtual string ToShortString() => $"Имя: {firstName}; Фамилия: {LastName}";
    }
}
