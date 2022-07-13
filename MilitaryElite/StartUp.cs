using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main()
        {
            string cmd = Console.ReadLine();
            var soldiers = new List<Soldier>();
            while (cmd != "End")
            {
                string[] data = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (data[0] == "Private" && data.Length == 5)
                {
                    var newPrivate = new Private(data[1], data[2], data[3], decimal.Parse(data[4]));
                    soldiers.Add(newPrivate);
                    Console.WriteLine(newPrivate);
                }
                else if (data[0] == "LieutenantGeneral")
                {
                    List<Private> privatesList = new List<Private>();
                    for (int i = 5; i < data.Length; i++)
                    {
                        var newPrivate = soldiers.FirstOrDefault(s => s.Id == data[i] && s is Private);
                        if (newPrivate != null && newPrivate is Private pr)
                        {
                            privatesList.Add(pr);
                        }
                    }
                    var newLeutenant = new LieutenantGeneral(data[1], data[2], data[3], decimal.Parse(data[4]), privatesList);
                    soldiers.Add(newLeutenant);
                    Console.WriteLine(newLeutenant);
                }
                else if (data[0] == "Engineer")
                {
                    try
                    {
                        List<Repair> repList = new List<Repair>();
                        for (int i = 6; i < data.Length; i += 2)
                        {
                            var newRep = new Repair(data[i], int.Parse(data[i + 1]));
                            repList.Add(newRep);
                        }
                        var newEngineer = new Engineer(data[1], data[2], data[3], decimal.Parse(data[4]), data[5], repList);
                        soldiers.Add(newEngineer);
                        Console.WriteLine(newEngineer);

                    }
                    catch (Exception)
                    {
                        cmd = Console.ReadLine();
                        continue;
                    }
                }
                else if (data[0] == "Commando")
                {
                    List<Mission> missionList = new List<Mission>();
                    for (int i = 6; i < data.Length; i += 2)
                    {
                        try
                        {
                            var newMission = new Mission(data[i], data[i + 1]);
                            missionList.Add(newMission);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    try
                    {
                        var newCommando = new Commando(data[1], data[2], data[3], decimal.Parse(data[4]), data[5], missionList);
                        soldiers.Add(newCommando);
                        Console.WriteLine(newCommando);
                    }
                    catch (Exception)
                    {
                        cmd = Console.ReadLine();
                        continue;
                    }
                }
                else if (data[0] == "Spy")
                {
                    var newSpy = new Spy(data[1], data[2], data[3], int.Parse(data[4]));
                    soldiers.Add(newSpy);
                    Console.WriteLine(newSpy);
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
