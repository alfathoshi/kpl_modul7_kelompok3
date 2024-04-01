using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    internal class TeamMembers1302223099
    {
        public class anggota
        {
            public string firstName {  get; set; }
            public string lastName { get; set; }
            public string gender {  get; set; }
            public int age { get; set; }
            public string nim {  get; set; }
        }
        public anggota[] members { get; set; }
        public void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_2_1302223099.json");
            var dataMembers = JsonSerializer.Deserialize<TeamMembers1302223099>(json);

            if (dataMembers != null)
            {
                Console.WriteLine("Team member list:");
                int i = 0;
                foreach (var item in dataMembers.members)
                {
                    i++;
                    Console.WriteLine($"{item.nim} - {item.firstName} {item.lastName} ({item.age} {item.gender})");
                }
            }
            else
            {
                Console.WriteLine("Data tidak ada");
            }
        }
        

    }
}
