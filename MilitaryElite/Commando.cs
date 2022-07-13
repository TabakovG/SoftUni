using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier,ICommando
    {

        private readonly List<Mission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) : base(id, firstName, lastName, salary, corps)
        {
            this.missions = missions;
        }

        public IReadOnlyCollection<Mission> Missions
        {
            get { return this.missions.AsReadOnly(); }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Missions:");
            foreach (var mission in missions)
            {
                sb.AppendLine(mission.ToString());
            }
            return base.ToString() + Environment.NewLine + sb.ToString().Trim();
        }
    }
}
