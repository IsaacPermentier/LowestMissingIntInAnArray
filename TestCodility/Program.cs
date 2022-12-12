using System;


namespace TestCodility;

class program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] test1 = { -1, -3 };
        int[] test2 = { 6, 1, 3, 4, 2, 7, 8, 12, 13, 17, 115, 13, 14, 138, 205, -3 };
        int[] test3 = { 1, 2, 3 };
        var result1 = solution.solution(test1);
        var result2 = solution.solution(test2);
        var result3 = solution.solution(test3);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}

class Solution
{
    public int solution(int[] A)
    {
        int missing = A.Length + 1;
        for (int index = 1; index <= A.Length; index++)
        {
            if (!A.Contains(index))
            {
                missing = index;
                break;
            }

        }
        return missing;
    }
}
