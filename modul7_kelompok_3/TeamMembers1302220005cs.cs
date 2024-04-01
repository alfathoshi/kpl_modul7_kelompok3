using System;
using System.IO;
using System.Text.Json;

public class TeamMember1302220005
{
    public class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public Members[] member { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_2_1302220005.json");

        var members = JsonSerializer.Deserialize<TeamMember1302220005>(json);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 0;
        foreach (var anggota in member)
        {
            i++;
            Console.WriteLine($"Nama : {i} {anggota.firstName} {anggota.lastName} umur {anggota.age} jenis kelamin {anggota.gender} ");
            Console.WriteLine($"umur : {anggota.age} jenis kelamin {anggota.gender} ");
            Console.WriteLine($"jenis kelamin : {anggota.gender} ");
        }
    }
}