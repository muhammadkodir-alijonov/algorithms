using System.Globalization;
using System.Text;

namespace HelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.CapitalizeTitle("First leTTeR oF EACH Word"));
    }

}


/*public class Solution //2129
{
    public static string CapitalizeTitle(string title)
    {
        string[] words = title.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 2)
            {
                words[i] = words[i].ToLower();
            }
            else
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }

        return string.Join(" ", words);
    }
}*/

/*public class Solution //125
{
    public static bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
        }
        var left = 0;
        var right = sb.Length - 1;
        while (left < right)
        {
            if (sb[left] != sb[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}*/

/*public class Solution //263
{
    public static bool IsUgly(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        while (n % 2 == 0)
        {
            n /= 2;
        }
        while (n % 3 == 0)
        {
            n /= 3;
        }
        while (n % 5 == 0)
        {
            n /= 5;
        }
        return n==1;
    }
}*/

/*public class Solution //434
{
    //s = "Hello World, My name is Mukhammadkodir"
    public static int CountSegments(string s)
    {
        var count = 0;
        var flag = false;
        foreach (var c in s)
        {
            if (c == ' ')
            {
                flag = false;
            }
            else if (!flag)
            {
                flag = true;
                count++;
            }
        }
        return count;
        if (s == null || s.Length == 0)
        {
            return 0;
        }
        return s.Trim().Split(' ').Count();
        //return s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
    }
}*/

/*public class Solution //268
{
    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        return n * (n + 1) / 2 - sum;
    }
}*/

/*public static class Solution //136
{
    public static int SingleNumber(int[] nums)
    {
        var list = new List<int>();
        foreach (var item in nums)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
            }
            else
            {
                list.Add(item);
            }
        }
        return list.First();
    }
    public static int SingleNumber2(int[] nums)
    {
        int res = 0;
        foreach (int x in nums)
        {
            res ^= x;
        }
        return res;
    }
}*/

/*public class Solution //345
{
    public string ReverseVowels(string s)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        var chars = s.ToCharArray();
        var i = 0;
        var j = s.Length - 1;
        while (i < j)
        {
            if (!vowels.Contains(char.ToLower(chars[i])))
            {
                i++;
                continue;
            }
            if (!vowels.Contains(char.ToLower(chars[j])))
            {
                j--;
                continue;
            }
            (chars[i], chars[j]) = (chars[j], chars[i]);
            i++;
            j--;
        }
        return new string(chars);
    }
}*/

//public class Solution //344
//{
//    public void ReverseString(char[] s)
//    {
//        int length = s.Length;
//        for (int i = 0; i < length / 2; i++)
//        {
//            (s[i], s[length - 1 - i]) = (s[length - 1 - i], s[i]);
//        }
//    }
//}

/*public class Solution //412
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();
        for (var i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
            {
                list.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                list.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                list.Add("Buzz");
            }
            else
            {
                list.Add(i.ToString());
            }
        }
        return list;
    }
}*/

/*public class Solution //709
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split("").Last().Length;
    }
}*/

/*public class Solution //169
{
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length / 2];
        //int majorityElement = 0;
        //int count = 0;

        //foreach (int num in nums)
        //{
        //    if (count == 0)
        //    {
        //        majorityElement = num;
        //        count++;
        //    }
        //    else if (num == majorityElement)
        //    {
        //        count++;
        //    }
        //    else
        //    {
        //        count--;
        //    }
        //}

        //return majorityElement;
    }
}*/