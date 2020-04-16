using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] B = { 7, 1, 2, 8, 2 };


            Console.WriteLine(solution(B));

            Console.ReadKey();

            int solution(int[] A)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                Array.Sort(A);
                Array.Reverse(A);
                int count=default;
                int number;
                int i,j= A[0];

                do
                {
                    count = 0;
                    number = j;
                    for(i=0;i<A.Length;i++)
                    {
                        if(A[i]==j)
                        { 
                            count++;
                        }
                    }
                    j--;
                    if (j == A[0] && count == 0)
                        return 0;
                } while (count != number && j > 0);
                
                return number;
            }
            
        }
    }
}
