﻿internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223123 dataMhs = new DataMahasiswa1302223123();
        TeamMembers1302223123 Anggota = new TeamMembers1302223123();
        dataMhs.ReadJSON();
        Console.WriteLine();
        Anggota.ReadJSON();
    }
}