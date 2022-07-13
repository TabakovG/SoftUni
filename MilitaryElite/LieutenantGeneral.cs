using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private,ILieutenantGeneral
    {
       

        private readonly List<Private> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates) : base(id, firstName, lastName, salary)
        {
            this.privates = privates;
        }

        public IReadOnlyCollection<Private> Privates => this.privates;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Privates:");
            foreach (Private priv in privates)
            {
                sb.AppendLine(priv.ToString());
            }


            return base.ToString() + Environment.NewLine + sb.ToString().Trim();
        }
    }
}
