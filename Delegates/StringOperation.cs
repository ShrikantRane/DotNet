namespace Delegates
{
    class StrOperation
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public void Upper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public void Lower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
    public delegate void MyDel(string str);
     class StringOperation
    {
        static void Main1(string[] args)
        {
            StrOperation c =new StrOperation();
            /*MyDel d=new MyDel(c.Print);
             MyDel d1=new MyDel(c.Upper);
            d += c.Upper;
            d += c.Lower;
            d("ShrIKant");
            //d.Invoke("sHriKant");*/
            Action<string> act=c.Print;
            act += c.Lower;
            act+=c.Upper;
            act += delegate (string s)
            {
                Console.WriteLine(s.Length);
            };
            act += s1 => Console.WriteLine(s1.GetHashCode());
            act("ShriKant");
        }
    }
}