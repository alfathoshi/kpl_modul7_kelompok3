using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa1302223038
{
    
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public class alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class matKul
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public alamat address { get; set; }
    public matKul[] courses { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_1302223038.json");

        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223038>(json);

        Console.WriteLine($"Name: {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
        Console.WriteLine($"Gender: {dataMahasiswa.gender}");
        Console.WriteLine($"Age: {dataMahasiswa.age} ");
        Console.WriteLine($"Address: {dataMahasiswa.address.streetAddress}, {dataMahasiswa.address.city},{dataMahasiswa.address.state} ");


        Console.WriteLine("Courses:");
        foreach(var crs in dataMahasiswa.courses) {
            Console.WriteLine($"Code: {crs.code}, Name: {crs.name}"); 
        }
    }

}