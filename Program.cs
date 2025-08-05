namespace Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach(var arg in args)
                {
                    if(int.TryParse(arg, out int num))
                    {
                        EnumerateNums(num);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                EnumerateNums(10);
                Console.WriteLine();
            }
        }

        static void EnumerateNums(int num)
        {
            Console.Write(num + " ");
            if (num > 1)
                EnumerateNums(num - 1);
        }
    }
}
