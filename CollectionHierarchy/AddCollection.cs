using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : ICollection<string>
    {

        private readonly List<string> elements;

        public AddCollection()
        {
            this.elements = new List<string>();
        }

        public IReadOnlyCollection<string> Elements => this.elements.AsReadOnly();

        public int Add(string item)
        {
            this.elements.Add(item);
            return this.elements.Count-1;
        }
    }
}
