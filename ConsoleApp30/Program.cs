namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 78;
            int[] SortInt = new int[100];
            for (int i = 0; i < SortInt.Length; i++)
            {
                SortInt[i] = i;
            }
            int count = 0;
            int n = SortInt.Length;
            for (int i = 0; i < n;)
            {
                if (i == x)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("true");
                    Console.WriteLine(count);
                    break;
                }
                i++;
                if ((i + n) / 2 <= x)
                {
                    i = (n + i) / 2;

                }
                else
                {
                    n = (i + n) / 2;

                }
                count++;
            }
            
            
        }

    }

}