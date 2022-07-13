using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main()
        {
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] data = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var citizen = new Citizen(data[0], data[1], int.Parse(data[2]));
                IPerson person = citizen;
                IResident resident = citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
                cmd = Console.ReadLine();
            }
        }
    }
}
