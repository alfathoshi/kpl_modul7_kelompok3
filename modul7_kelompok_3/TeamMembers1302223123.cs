using System;
using System.Text.Json;

public class TeamMembers1302223123
{
    public class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim {  get; set; }
    }

    public Members[] members { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_1302223123.json");

        var TeamMembers = JsonSerializer.Deserialize<TeamMembers1302223123>(json);

        Console.WriteLine("Anggota Team:");
        int i = 0;
        foreach (var tm in TeamMembers.members)
        {
            i++;
            Console.WriteLine($"Anggota KE {i}-{tm.firstName}{tm.lastName} - {tm.gender}-{tm.age}-{tm.nim}");
        }
    }
}
