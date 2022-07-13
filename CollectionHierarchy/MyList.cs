using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IMyList
    {
        private readonly List<string> elements;

        public MyList()
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
            string item = this.elements[0];
            this.elements.RemoveAt(0);
            return item;
        }


        public int Used()
        {
            return this.elements.Count;
        }
    }
}
