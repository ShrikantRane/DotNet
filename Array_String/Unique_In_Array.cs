namespace Array_String
{
    internal class Unique_In_Array
    {
        static void Main1(string[] args)
        {
            String[] str = { "Tushar", "Shrikant","Shivam","Nikhil", "Shrikant","Tushar" };
            Boolean flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if(str[i].Equals(str[j]))
                     {
                          flag= true;
                          break;
                     }
                     else
                     {
                         flag = false;
                     }
                 }
                 if(flag== false)
                 {
                     Console.WriteLine(str[i]);
                 }
                    
            }
        }
    }
}