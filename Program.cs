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

            // ==========================================
            // JSON DESERIALIZATION 2 - Team Members
            // ==========================================
            Console.WriteLine(">>> 2. TEAM MEMBERS <<<");
            TeamMembers103082400017 team = new TeamMembers103082400017();
            team.ReadJSON();
            Console.WriteLine();

            Console.WriteLine("=====================================");
            Console.WriteLine("     PROGRAM SELESAI");
            Console.WriteLine("=====================================");

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
