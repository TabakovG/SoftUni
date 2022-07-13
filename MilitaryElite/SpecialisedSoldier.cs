using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get { return this.corps; }
            set 
            {
                if (value == "Marines" || value == "Airforces")
                {
                this.corps = value; 
                }
                else
                {
                    throw new ArgumentException("");
                }
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Corps: {this.Corps}");
            return base.ToString() + Environment.NewLine + sb.ToString().Trim();
        }

    }
}
