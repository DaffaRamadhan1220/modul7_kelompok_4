using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok_4
{
    
    public class Member103082400047
    {
        public string? nim { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int age { get; set; }
        public string? gender { get; set; }
    }

   
    public class TeamMembers103082400047
    {
        public void ReadJSON()
        {
            try
            {
                string fileName = "jurnal7_2_103082400047.json";
                string jsonString = File.ReadAllText(fileName);
                List<Member103082400047>? members = JsonSerializer.Deserialize<List<Member103082400047>>(jsonString);

                Console.WriteLine("\nTeam member list:");

                if (members != null)
                {
                    foreach (var m in members)
                    {
                        Console.WriteLine($"{m.nim} {m.firstname} {m.lastname} ({m.age} {m.gender})");
                    }
                }
                else
                {
                    Console.WriteLine("Tidak ada data member.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: File JSON tidak ditemukan!");
                Console.WriteLine($"Pastikan file 'jurnal7_2_103082400047.json' ada di folder project.");
            }
            catch (JsonException)
            {
                Console.WriteLine($"Error: Format JSON tidak valid!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}