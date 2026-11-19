namespace Matrixok
{
    internal class Program
    {
        static int sorokszáma = 10;
        static int oszlopokszáma = 6;
        static int[,] szamokMatrix = new int[sorokszáma,oszlopokszáma];
        static Random r = new Random();

        static void f01()
        {
            for (int i = 0; i < sorokszáma; i++)
            {

                for (int j = 0; j < oszlopokszáma; j++)
                {
                    szamokMatrix[i, j] = r.Next(10, 100);
                }
            }
        }
        static void f02()
        {
            for (int i = 0; i < sorokszáma; i++)
            {

                for (int j = 0; j < oszlopokszáma; j++)
                {
                    Console.Write($"{szamokMatrix[i,j]} ");
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
        static void Main(string[] args)
        {
            f01();
            f02();
            f03();


        }
    }
}
