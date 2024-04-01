using System;
using System.IO;
using System.Text.Json;

public class TeamMembers1302223038
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
 
    
    public List<Member> members { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_1302223038.json");

        var tim = JsonSerializer.Deserialize<TeamMembers1302223038>(json);

        Console.WriteLine("Team Member:");
        foreach (var member in tim.members)
        {
            Console.WriteLine($"Nama: {member.firstName} {member.lastName}");
            Console.WriteLine($"Gender: {member.gender}");
            Console.WriteLine($"Age: {member.age} ");
            Console.WriteLine($"NIM: {member.nim}");
        }
    }

}