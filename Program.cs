using System;

namespace modul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("     TUGAS JURNAL MODUL 7");
            Console.WriteLine("     KELOMPOK 4");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            
            Console.WriteLine(">>> 1. DATA MAHASISWA <<<");
            DataMahasiswa103082400047 mhs = new DataMahasiswa103082400047();
            mhs.ReadJSON();
            Console.WriteLine();

            
            Console.WriteLine(">>> 2. TEAM MEMBERS <<<");
            TeamMembers103082400047 team = new TeamMembers103082400047();
            team.ReadJSON();
            Console.WriteLine();

            Console.WriteLine(">>> 3. GLOSSARY ENTRY <<<");
            GlossaryItem103082400047 glossary = new GlossaryItem103082400047();
            glossary.ReadJSON();
            Console.WriteLine();

            Console.WriteLine("=====================================");
            Console.WriteLine("     PROGRAM SELESAI");
            Console.WriteLine("=====================================");

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}