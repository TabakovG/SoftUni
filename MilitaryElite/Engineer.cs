using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps,List<Repair> repairs) : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = repairs;
        }

        public IReadOnlyCollection<Repair> Repairs => this.repairs.AsReadOnly();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Repairs:");
            foreach (var rep in repairs)
            {
                sb.AppendLine(rep.ToString());
            }
            return base.ToString() + Environment.NewLine + sb.ToString().Trim();
        }
    }
}
