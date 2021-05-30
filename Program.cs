using System;
using System.Linq;

namespace _3LineCardMgtLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[6] { 1, 5, 7, 4, 1, 2};
           
            Solution s = new Solution();
            Console.WriteLine(s.Thesmallest(N));
        }
    }
    class Solution
    {
        public int Thesmallest(int[] A) {
            if (!A.Contains(1))
            {
                return 1;
            }
            int result = A.Max();
            foreach (var num in A)
            {
                if (num > 0 && num <=  result)
                {
                    if (!A.Contains(num +1))
                    {
                        result = (num + 1);
                    }
                }
            }
            return result;

        }
      
    }
}
