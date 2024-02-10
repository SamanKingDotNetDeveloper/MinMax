namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int a = int.Parse(Console.ReadLine()),b = 0,min = 0,max = 0;
            for(int i = 0; i < a; i++)
            {
                b = int.Parse(Console.ReadLine());
                list.Add(b);
            }
            min = list[0];
            for(int i = 0;i < a-1; i++)
            {
                if(min > list[i+1])min = list[i+1];
            }
            max = list[0];
            for(int i = 0; i < a - 1; i++)
            {
                if(max < list[i+1])max = list[i+1];
            }
            Console.WriteLine($"Min {min}\nMax {max}");
            Console.ReadKey();
        }
    }
}
//{12,34,13,67,98,11 }