namespace LINQ
{
    internal class ArrayOperation
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            var res = (from s in arr
                      select s).Count();
            Console.WriteLine(res);

            var res1 = from s in arr
                       where s > 40
                       select s;
            foreach (var item in res1)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            var res2 = from s in arr
                       where s >= 10 && s <= 40
                       select s;
            foreach (var item in res2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var res3 = from s in arr
                       orderby s
                       select s;
            foreach (var item in res3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var res4 = from s in arr
                       orderby s descending
                       select s;
            foreach (var item in res4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        

    }
}