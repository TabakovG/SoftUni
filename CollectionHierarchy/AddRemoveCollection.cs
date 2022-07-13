using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private readonly List<string> elements;

        public AddRemoveCollection()
        {
            this.elements = new List<string>();
        }

        public IReadOnlyCollection<string> Elements => this.elements;

        public int Add(string item)
        {
            this.elements.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            if (this.elements.Count > 0)
            {
                string item = this.elements[this.elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count -1);
                return item;
            }
            return null;
        }
    }
}
