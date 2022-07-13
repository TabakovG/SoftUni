using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    internal class Citizen : IResident, IPerson
    {
        private string name;
        

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age { get; private set; }

        public string Country { get; private set; }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }
        string IPerson.GetName()
        {
            return this.name;
        }

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
    }
}
