<<<<<<< HEAD
﻿using System;

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
            TeamMembers103082400047 team = new TeamMembers103082400047();
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
=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> f7d0e7cbd7fbade1f6e7845e74dec93fa6c0c16d
