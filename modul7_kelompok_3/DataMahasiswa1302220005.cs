using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa1302220005
{
    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
    }

    public class Alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public Mahasiswa mahasiswa { get; set; }
    public  Alamat alamat{ get; set; }
    public MataKuliah[] courses { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_1_1302220005.json");

        var dataMhs = JsonSerializer.Deserialize<DataMahasiswa1302220005>(json);
        if (dataMhs != null)
        {
            Console.WriteLine($"Nama          : {dataMhs.mahasiswa.firstName} {dataMhs.mahasiswa.lastName}");
                Console.WriteLine($"Jenis kelamin : {dataMhs.mahasiswa.gender}");
                Console.WriteLine($"Umur          : {dataMhs.mahasiswa.age}");
                Console.WriteLine($"Alamat        : {dataMhs.alamat.streetAddress}, {dataMhs.alamat.city}, {dataMhs.alamat.state}");
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