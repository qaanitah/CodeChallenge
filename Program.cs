using System;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int commonChild (string s1, string s2);
            int counter = 0;
            for(int i = 0; i < s1.Length; i++)
            {
                for(int k = 0; k < s2.Length; k++)
                {
                    if (s1[i] == s2[k])
                    {
                        s2 = s2.Remove[k, i]
                        counter ++;
                        break;
                    }
                }
            }
        }
        public static int StudentsCandy()
        {
            int n = 0;
            int [] arr = [4, 6, 4, 5, 6, 2];
            int [] minAmount = [1, 2, 1, 2, 3, 1];
            for(int i = 0; i < arr.Length; i++)
        }
    }
}