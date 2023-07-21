namespace OOP_1
{
    internal static class BoxDemoHelpers
    {
        public static void Main2(string[] args)
        {
            Box box = new Box(12, 12, 12);
            Console.WriteLine(box.Area());
            Box box1 = new Box(box);
            Console.WriteLine(box1.Area());
        }
    }
}