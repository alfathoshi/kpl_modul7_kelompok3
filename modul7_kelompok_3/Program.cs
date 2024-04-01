internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223038 dataArga = new DataMahasiswa1302223038();
        TeamMembers1302223038 timArga = new TeamMembers1302223038();
        dataArga.ReadJSON();
        timArga.ReadJSON();

    }
}