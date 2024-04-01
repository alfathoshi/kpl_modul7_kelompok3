using System;
using System.IO;
using System.Text.Json;

public class GlosarryItem1302220005
{
    public class GlossDef
    {
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public Glossary glossary { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_1302220005.json");

        var glosarryItem = JsonSerializer.Deserialize<GlosarryItem1302220005>(json);
        var glossDiv = glosarryItem.glossary.GlossDiv;
        var glossEntry = glossDiv.GlossList.GlossEntry;

        Console.WriteLine($"GlossTerm: {glossEntry.GlossTerm}");
        Console.WriteLine($"Acronym: {glossEntry.Acronym}");
        Console.WriteLine($"Abbrev: {glossEntry.Abbrev} ");
        Console.WriteLine($"Address: {glossEntry.GlossDef.para}");


        Console.WriteLine("See Also:");
        foreach (var isi in glossEntry.GlossDef.GlossSeeAlso)
        {
            Console.WriteLine($" {isi}");
        }
    }

}