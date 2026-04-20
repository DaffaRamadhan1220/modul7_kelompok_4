using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class GlossDef
    {
        public string? para { get; set; }
        public List<string>? GlossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string? ID { get; set; }
        public string? SortAs { get; set; }
        public string? GlossTerm { get; set; }
        public string? Acronym { get; set; }
        public string? Abbrev { get; set; }
        public GlossDef? GlossDef { get; set; }
        public string? GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry? GlossEntry { get; set; }
    }

    public class GlossDiv
    {
        public string? title { get; set; }
        public GlossList? GlossList { get; set; }
    }

    public class Glossary
    {
        public string? title { get; set; }
        public GlossDiv? GlossDiv { get; set; }
    }

    public class RootGlossary
    {
        public Glossary? glossary { get; set; }
    }

    public class GlossaryItem103082400017
    {
        public void ReadJSON()
        {
            try
            {
                string fileName = "jurnal7_3_103082400017.json";
                string jsonString = File.ReadAllText(fileName);
                RootGlossary? data = JsonSerializer.Deserialize<RootGlossary>(jsonString);

                var entry = data?.glossary?.GlossDiv?.GlossList?.GlossEntry;

                Console.WriteLine("\n=== GLOSSARY ENTRY ===");
                Console.WriteLine($"ID         : {entry?.ID}");
                Console.WriteLine($"Sort As    : {entry?.SortAs}");
                Console.WriteLine($"Term       : {entry?.GlossTerm}");
                Console.WriteLine($"Acronym    : {entry?.Acronym}");
                Console.WriteLine($"Abbrev     : {entry?.Abbrev}");
                Console.WriteLine($"Definition : {entry?.GlossDef?.para}");
                Console.WriteLine($"See Also   : {string.Join(", ", entry?.GlossDef?.GlossSeeAlso ?? new List<string>())}");
                Console.WriteLine($"See        : {entry?.GlossSee}");
                Console.WriteLine("========================\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}