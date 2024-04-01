using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    internal class DataMahasiswa1302223099
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public class alamat
        {
            public string streetAddress { get; set; }

            public string city { get; set; }

            public string state { get; set; }

        }
        public alamat address { get; set; }
        public class mk
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public mk[] courses { get; set; }

        public void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_1302223099.json");
            var dataMhs = JsonSerializer.Deserialize<DataMahasiswa1302223099>(json);

            if (dataMhs != null)
            {
                Console.WriteLine($"Nama          : {dataMhs.firstName} {dataMhs.lastName}");
                Console.WriteLine($"Jenis kelamin : {dataMhs.gender}");
                Console.WriteLine($"Umur          : {dataMhs.age}");
                Console.WriteLine($"Alamat        : {dataMhs.address.streetAddress}, {dataMhs.address.city}, {dataMhs.address.state}");
                Console.WriteLine();
                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int i = 0;
                foreach ( var item in dataMhs.courses ) 
                {
                    i++;
                    Console.WriteLine($"{i}. {item.code} - {item.name}");
                }
            } else
            {
                Console.WriteLine("Data tidak ada");
            }
        }
    }
}
