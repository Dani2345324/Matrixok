namespace Matrixok
{
    internal class Program
    {
        static int sorokszáma = 10;
        static int oszlopokszáma = 6;
        static int[,] szamokMatrix = new int[sorokszáma,oszlopokszáma];
        static int[,] negyzetesmatrix = new int[5,5];
        static Random r = new Random();

        static void f01(int[,]matrix, int min,int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(min, max+1);
                }
            }
        }
        static void f02(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j], 4} ");
                }
                Console.WriteLine();
            }
        }
        static void f03()
        {
            int sum = 0;
            for (int i = 0; i < sorokszáma; i++)
            {

                for (int j = 0; j < oszlopokszáma; j++)
                {
                    sum += szamokMatrix[i, j];
                }
                
            }
            Console.WriteLine($"A mátrixban lévő elemek összege: {sum}");
        }
        static void f04()
        {
            
            for (int i = 0; i < sorokszáma; i++)
            {

                int sum = 0;
                for (int j = 0; j < oszlopokszáma; j++)
                {
                    sum += szamokMatrix[i, j];
                }
                Console.WriteLine($"{i+1}. sor összege: {sum}");
            }
        }
        static void f05()
        {
            for (int j = 0; j < oszlopokszáma; j++)
            {
                int sum = 0;
                for (int i = 0; i < sorokszáma; i++)
                {
                    sum += szamokMatrix[i, j];
                }
                Console.WriteLine($"{j + 1}. oszlop összege: {sum}");
            }
        }

        static void Balatlosszeg(int[,]matrix)
        {
            int sum = 0;
            Console.Write("Az átló: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i,i],5}");
                sum += matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix bal átlójának összege: {sum}");
        }
        static void Jobbatlooszzeg(int[,] matrix)
        {
            int sum = 0;
            int i = matrix.GetLength(0)-1;
            
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write($"{matrix[i, j],5}");
                sum += matrix[i, j];
                i--;

            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix jobb átlójának összege: {sum}");


        }
        static void Main(string[] args)
        {
            f01(szamokMatrix,10,99);
            f02(szamokMatrix);
            f03();
            f04();
            f05();
            Console.WriteLine("------------------------------------------------");
            f01(negyzetesmatrix, -100, 100);
            f02(negyzetesmatrix);
            Balatlosszeg(negyzetesmatrix);
            Jobbatlooszzeg(negyzetesmatrix);
            int[,] masolat = negyzetesmatrix;
            masolat[0, 0] = 100;
            Console.WriteLine("A másolat elemei: ");
            f02(masolat);
            Console.WriteLine("A négyzetesmátrix: ");
            f02(negyzetesmatrix);
        }
    }
}
