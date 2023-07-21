namespace Input_Output
{
    internal class AddmissionCriteria
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter Math Marks:");
            int math=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics Marks:");
            int phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry Marks:");
            int chem = int.Parse(Console.ReadLine());
            int total=math+phy+chem;
            if (math >= 65 && phy >= 55 && chem >= 50 && total >= 180)
            {
                Console.WriteLine("Eligible For Addmission");
            }
            else
            {
                Console.WriteLine("Not Eligible For Addmission");
            }

        }
    }
}