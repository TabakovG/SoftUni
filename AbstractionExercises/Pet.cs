using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionExercises
{
    internal class Pet : IBirthtable
    {
        public string Name { get; private set; }

        public string Birthdate { get; private set; }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
