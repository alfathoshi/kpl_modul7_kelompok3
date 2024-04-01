using System;
using System.Text.Json;

public class DataMahasiswa1302223123
{
	public class NamaMahasiswa
	{
		public string firstName {  get; set; }
		public string lastName { get; set; }
	}
	
	public class Address
	{
		public string streetAddress { get; set; }
		public string city { get; set; }
		public string state { get; set; }
	}

	public class mataKuliah
	{
		public string name { get; set; }
	}

	public	NamaMahasiswa nama { get; set; }
	public string gender { get; set; }
	public int age {  get; set; }
	public Address address {  get; set; }
	public mataKuliah [] courses { get; set; }

	public void ReadJSON()
	{
		string json = File.ReadAllText("jurnal7_1_1302223123.json");

		var DataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223123>(json);

		if (DataMahasiswa != null )
		{
			Console.WriteLine($"Nama   : {DataMahasiswa.nama.firstName}{DataMahasiswa.nama.lastName}");
            Console.WriteLine($"gender : {DataMahasiswa.gender}");
			Console.WriteLine($"Umur   : {DataMahasiswa.age}");
            Console.WriteLine($"Alamat : {DataMahasiswa.address.streetAddress}{DataMahasiswa.address.city}{DataMahasiswa.address.state}");

			Console.WriteLine("Daftar Mata Kuliahh yang diambil :");
			int i = 0;
			foreach( var dm in DataMahasiswa.courses )
			{ 
				i++;
				Console.WriteLine($"MK {i}{dm.name}");
			}
		}
		else
		{
			Console.WriteLine("tidak ada data");
		}
	}
}
