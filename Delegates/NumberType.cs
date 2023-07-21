namespace Delegates
{
    internal class NumberType
    {
        public bool IsPositive(int a)
        {
            if (a < 0)
                return false;
            else
                return true;
        }
        public bool IsNegative(int a)
        {
            if (a > 0)
                return false;
            else
                return true;
        }
        public bool IsPrime(int a)
        {
            bool flag = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public bool IsPerfect(int a)
        {
            int c = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                    c = c + i;
            }
            if (c == a)
                return true;
            else
                return false;
        }

        public bool IsPallindrome(int a)
        {
            int n = a;
            int rem = 0;
            int rev = 0;
            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            if (rev == a)
                return true;
            else
                return false;
        }
        public delegate bool NDel(int a);
    }
   
    class MyNDemo
    {
        static void Main(string[] args)
        {
            NumberType nt = new NumberType();
            Predicate<int> p1 = nt.IsNegative;
            p1 += nt.IsPositive;
            p1 += nt.IsPerfect;
            p1 += nt.IsPallindrome;
            p1 += delegate (int a)
            {
                if (a == 0)
                    return true;
                else
                    return false;
            };
            Console.WriteLine(p1(0));
        }

    }
}
