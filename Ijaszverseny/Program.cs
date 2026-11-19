using System.ComponentModel.DataAnnotations;

namespace Ijaszverseny
{
    internal class Program
    {
        static int[,] jatekosokpontjai;
        static Random r = new Random();
        
        
        static string[] jatekosoknevei(int jatekosokszama)
        {
            string[] nevek = { "Anna", "Bence", "Csaba", "Dóra", "Eszter", "Ferenc", "Gábor", "Hanna", "István", "Judit", "Katalin", "László", "Márk", "Nóra", "Orsolya", "Péter", "Réka", "Sándor", "Tamás", "Viktória", "Zoltán", "Ádám", "Balázs", "Cecília", "Dávid", "Emese", "Flóra", "György", "Levente", "Mihály" };
            string[] jatekosok = new string[jatekosokszama];
            for (int i = 0; i < jatekosokszama; i++)
            {
                int index = r.Next(0, nevek.Length);
                jatekosok[i] = nevek[index];
            }
            return jatekosok;
        }


        private static int[,] Feltolt(int jatekosokszama)
        {
            int[,] matrix = new int[jatekosokszama, 5];
            for (int i = 0; i < jatekosokszama; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = r.Next(0,26);
                }
            }
            return matrix;

        }
        static int gyoztes(string[] jatekosok)
        {
            int max = -1;
            int maxnumber = 0;
            int sum;
            for (int i = 0; i < jatekosokpontjai.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < jatekosokpontjai.GetLength(1); j++)
                {
                    sum += jatekosokpontjai[i, j];
                }
                if (sum > max)
                {
                    maxnumber = i;
                    max = sum;
                    //Console.WriteLine(max);
                }

            }
            Console.WriteLine($"{maxnumber+1}. a Győztes: {jatekosok[maxnumber]} - pontjainak összege: {max}");
            return maxnumber;
        }    

        
        
        static void Main(string[] args)
        {

            Console.Write("Játékosok száma: ");
            int jatekosok_szama = Convert.ToInt32(Console.ReadLine());
            jatekosokpontjai = Feltolt(jatekosok_szama);
            string[] jatekosok = jatekosoknevei(jatekosok_szama);
            foreach (var item in jatekosok)
            {
                Console.WriteLine(item);
            }
            
            
            for (int i = 0; i < jatekosokpontjai.GetLength(0); i++)
            {
                Console.Write($"Az {i+1,2}. játékos: {jatekosok[i],-8} pontjai: ");
                for (int j = 0; j < jatekosokpontjai.GetLength(1); j++)
                {
                    Console.Write($"{jatekosokpontjai[i, j],-4}");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            gyoztes(jatekosok);
        }
    }
}
