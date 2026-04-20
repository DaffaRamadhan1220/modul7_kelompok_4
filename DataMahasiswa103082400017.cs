using System;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok_4
{
    public class DataMahasiswa103082400017
    {
        public string? nim { get; set; }
        public string? nama { get; set; }
        public string? jurusan { get; set; }
        public int angkatan { get; set; }

        public void ReadJSON()
        {
            try
            {
                string fileName = "jurnal7_1_103082400017.json";
                string jsonString = File.ReadAllText(fileName);
                DataMahasiswa103082400017? data = JsonSerializer.Deserialize<DataMahasiswa103082400017>(jsonString);

                Console.WriteLine("\n=== DATA MAHASISWA ===");
                Console.WriteLine($"NIM      : {data?.nim}");
                Console.WriteLine($"Nama     : {data?.nama}");
                Console.WriteLine($"Jurusan  : {data?.jurusan}");
                Console.WriteLine($"Angkatan : {data?.angkatan}");
                Console.WriteLine("========================\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}