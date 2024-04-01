using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa1302223137
{
    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class AlamatMahasiswa
	{
		public string alamat { get; set; }
		public string kota { get; set; }
		public string provinsi { get; set; }
	}
 
    public MataKuliah[] courses { get; set; }
    public AlamatMahasiswa address { get; set; }
    public string depan { get; set; }
    public string belakang { get; set; }
    public string jenisKelamin { get; set; }
    public int umur { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_1302223137.json");

        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223137>(json);

        if (dataMahasiswa.address != null)
        {
            Console.WriteLine($"Nama {dataMahasiswa.depan} {dataMahasiswa.belakang} dengan jenis kelamin {dataMahasiswa.jenisKelamin} berumur {dataMahasiswa.umur} beralamat di jalan {dataMahasiswa.address.alamat} kota {dataMahasiswa.address.kota} provinsi {dataMahasiswa.address.provinsi}");
            Console.WriteLine(" ");
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 0;
            foreach (var mk in dataMahasiswa.courses)
            {
                i++;
                Console.WriteLine($"MK {i} {mk.code} - {mk.name}");
            }

        }
        else
        {
            Console.WriteLine("Data mahasiswa tidak tersedia.");
        }

    }
}
