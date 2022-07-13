using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main()
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            List<string> addCollOutput = new List<string>();
            List<string> addRemCollOutput = new List<string>();
            List<string> myListOutput = new List<string>();

            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in elements)
            {
                addCollOutput.Add(addCollection.Add(item).ToString());
                addRemCollOutput.Add(addRemoveCollection.Add(item).ToString());
                myListOutput.Add(myList.Add(item).ToString());
            }
            Console.WriteLine(String.Join(" ", addCollOutput));
            Console.WriteLine(String.Join(" ", addRemCollOutput));
            Console.WriteLine(String.Join(" ", myListOutput));

            int num = int.Parse(Console.ReadLine());

            addRemCollOutput = new List<string>();
            myListOutput = new List<string>();

            for (int i = 0; i < num; i++)
            {
                addRemCollOutput.Add(addRemoveCollection.Remove());
                myListOutput.Add(myList.Remove());
            }

            Console.WriteLine(String.Join(" ", addRemCollOutput));
            Console.WriteLine(String.Join(" ", myListOutput));
        }
    }
}
