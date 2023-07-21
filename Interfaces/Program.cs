namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*Account a1 = new RecurringAccount();
            a1.accno = 11;
            a1.name = "Shrikant";
            a1.balance = 20000;
            Console.WriteLine($"{a1.accno}-->{a1.name}-->{a1.balance}");
            a1.withdraw(1000);
            Console.WriteLine(a1.calBalance()); 


            Account a2 = new SavingAccount();
            a2.accno = 11;
            a2.name = "Shrikant";
            a2.balance = 20000;
            Console.WriteLine($"{a2.accno}-->{a2.name}-->{a2.balance}");
            a2.withdraw(1000);
            Console.WriteLine(a2.balance);
            Console.WriteLine(a2.calBalance());*/

            IintOperation op=new MyNumber();
            Console.WriteLine(op.calFactorial(6));
            Console.WriteLine(op.isPrime(6));
            Console.WriteLine(op.isEven(6));
            Console.WriteLine(op.isOdd(6));

        }
    }
}