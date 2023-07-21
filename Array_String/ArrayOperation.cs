using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Array_String
{
    internal class ArrayOperation
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(args[i]);
            }
            
            Console.WriteLine("Given Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            
            Console.WriteLine("Sum:"+sum);
            Console.WriteLine();
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                else if(max < arr[i])
                {
                    max= arr[i];
                }
            }
            
            Console.WriteLine("Minimum:" + min);
            Console.WriteLine("Maximum:" + max);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                int s = 0;
                for (int j = 1; j < arr[i]; j++)
                {
                    if (arr[i]%j==0)
                    {
                        s=s+j;
                    }
                }
                if (s == arr[i])
                {
                    Console.WriteLine(arr[i]+" is a perfect number.");
                }
                else
                {
                    Console.WriteLine(arr[i] + " is not a perfect number.");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Boolean flag = true;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        flag =false;
                        break;
                    }
                }
                if(flag==true)
                {
                    Console.WriteLine(arr[i]+" is a Prime Number.");
                }
                else
                {
                    Console.WriteLine(arr[i] + " is not a Prime Number.");
                }
            }

            Console.WriteLine();
            Boolean[] visited = new Boolean[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int c = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if ((arr[i] == arr[j]) && (visited[j]==false))
                    {
                        c++;
                        visited[j] = true;
                    }
                }
                if (c > 1)
                {
                    Console.WriteLine(arr[i] + " occurs " + c + " times");
                }
            }

            Console.WriteLine();
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Second Largest number is:" + (arr[arr.Length-2]));
            Console.WriteLine("Second Smallest number is:" + (arr[1]));

            Console.WriteLine();
            Console.WriteLine("Array In Ascending order:-");
            int temp1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;
                    }
                }
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array In Descending order:-");
            int temp2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp2 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp2;
                    }
                }
                Console.Write(arr[i] + " ");
            }


            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Array.Reverse(arr);
            Console.WriteLine();
            Console.WriteLine("Reverse Above Array:-");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }
}
