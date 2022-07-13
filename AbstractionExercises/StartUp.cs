using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractionExercises
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            /*List<IIdentifiable> list = new List<IIdentifiable>();
            List<IBirthtable> birthList = new List<IBirthtable>();
            string cmd = Console.ReadLine();
            
            while (cmd != "End")
            {
                string[] input = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Robot")
                {
                    var robot = new Robot(input[0], input[1]);
                    list.Add(robot);
                }
                else if (input[0] == "Citizen")
                {
                    var citizen = new Citizen(input[1], int.Parse(input[2]), input[3], input[4]);
                    list.Add(citizen);
                    birthList.Add(citizen);
                }
                else if (input[0] == "Pet")
                {
                    var pet = new Pet(input[1], input[2]);
                    birthList.Add(pet);
                }

                cmd = Console.ReadLine();
            }

            string filter = Console.ReadLine();
            *//*foreach (var unit in list.FindAll(x=>x.Id.EndsWith(filter)))
            {
                Console.WriteLine(unit.Id);
            }*//*
            foreach (var unit in birthList.FindAll(x => x.Birthdate.EndsWith(filter)))
            {
                Console.WriteLine(unit.Birthdate);
            }*/

            List<IBuyer> buyerList = new List<IBuyer>();

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 4)
                {
                    var citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    buyerList.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    var rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    buyerList.Add(rebel);
                }
            }

            string cmd = Console.ReadLine();
            while (cmd!= "End")
            {
                var unit = buyerList.FirstOrDefault(x => x.Name == cmd);
                if (unit != null)
                {
                    unit.BuyFood();
                }

                cmd = Console.ReadLine();
            }
            Console.WriteLine(buyerList.Sum(x=>x.Food));
        }
    }
}
