using modul7_kelompok_3;

internal class Program
{
    private static void Main(string[] args)
    {

        DataMahasiswa1302223099 dataMhs = new DataMahasiswa1302223099();
        dataMhs.ReadJSON();
        Console.WriteLine();
        TeamMembers1302223099 dataTeam = new TeamMembers1302223099();
        dataTeam.ReadJSON();

        DataMahasiswa1302223038 dataArga = new DataMahasiswa1302223038();
        TeamMembers1302223038 timArga = new TeamMembers1302223038();
        GlosarryItem1302223038 gloss = new GlosarryItem1302223038();
        dataArga.ReadJSON();
        timArga.ReadJSON();
        gloss.ReadJSON();


    }
}