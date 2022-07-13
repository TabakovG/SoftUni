using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionExercises
{
    public class Citizen : IIdentifiable, IBirthtable, IBuyer
    {
        private string id;
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Birthdate { get; private set; }

        public string Id
        {
            get => this.id; 
            set => this.id = value;
        }

        public int Food { get; private set; }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthday;
            this.Food = 0;

        }

        public void BuyFood()
        {
            this.Food+=10;
        }
    }
}
