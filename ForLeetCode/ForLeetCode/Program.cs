using System.Globalization;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        string s = "[{}]";
        Console.WriteLine(IsValid(s));
    }
}
/*public class Solution //41
{
    public int FirstMissingPositive(int[] nums)
    {
        if (nums.Length == 1 && nums[0] == 1) return 2;
        else if (nums.Length == 1 && nums[0] != 1) return 1;

        Array.Sort(nums);
        int i = 0;
        int lowest = int.MaxValue;
        for (; i < nums.Length - 1; i++)
        {
            // ignore negative numbers
            if (nums[i] < 0) continue;

            // save lowest number
            if (nums[i] < lowest) lowest = nums[i];

            // checks for if the numbers are one after the other
            if (nums[i] + 1 == nums[i + 1] || nums[i] == nums[i + 1]) continue;

            // if they aren't return based on the lowest number
            return lowest == 1 || lowest + 1 == 1 ? nums[i] + 1 : 1;
        }

        // return based on the lowest number if nothing 
        // was returned during the loop
        return lowest == 1 || lowest + 1 == 1 || nums[i] == 1 ? nums[i] + 1 : 1;
    }
}*/
/*public class Solution //41
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }
        return n + 1;
    }
}*/
/*public class Solution //171
{
    public static int TitleToNumber(string columnTitle)
    {
        var columnNumber = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            columnNumber *= 26;
            columnNumber += columnTitle[i] - 'A' + 1;
        }
        return columnNumber;
    }
}*/
/*public class Solution //13
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> romanIntegerMap = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        var resalt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (romanIntegerMap[s[i]] < romanIntegerMap[s[i + 1]])
            {
                resalt -= romanIntegerMap[s[i]];
            }
            else
            {
                resalt += romanIntegerMap[s[i]];
            }
        }
        resalt += romanIntegerMap[s.Last()];
        return resalt;
    }
}*/

/*public class Solution //118
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var list = new List<IList<int>>();
        for (var i = 0; i < numRows; i++)
        {
            var row = new List<int>();
            for (var j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    row.Add(1);
                }
                else
                {
                    row.Add(list[i - 1][j - 1] + list[i - 1][j]);
                }
            }
            list.Add(row);
        }
        return list;
    }
}*/

/*public class Solution //14
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        var prefix = strs[0];
        for (var i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                {
                    return "";
                }
            }
        }
        return prefix;
    }
}*/

/*public class Solution //9
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        var s = x.ToString();
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}*/

/*public class Solution //520
{
    public static bool DetectCapitalUse(string word)
    {
        if (word.Length == 1)
        {
            return true;
        }
        var first = word[0];
        var second = word[1];
        if (char.IsUpper(first) && char.IsUpper(second))
        {
            for (var i = 2; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    return false;
                }
            }
        }
        else
        {
            for (var i = 1; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    return false;
                }
            }
        }
        return true; //main idea
    }
}*/

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
/*public class Solution //160
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var a = headA;
        var b = headB;
        while (a != b)
        {
            a = a == null ? headB : a.next;
            b = b == null ? headA : b.next;
        }
        return a;
    }
}*/
/*public class Solution 1046
{
    public int LastStoneWeight(int[] stones)
    {
        Array.Sort(stones);
        for (int i = 0; i < stones.Length; i++)
        {
            if (stones[i] == stones[i + 1])
            {
                stones[i] = 0;
                stones[i + 1] = 0;
            }
            else
            {
                stones[i] = stones[i + 1] - stones[i];
                stones[i + 1] = 0;
            }
        }
        return stones[stones.Length - 1];
    }
}*/
/*public class Solution //1464
{
    public int MaxProduct(int[] nums)
    {
        Array.Sort(nums);
        return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
    }
}*/
/*public class Solution //20
{
    public bool IsValid(string s)
    {
        var StackChars = new Stack<char>();
        foreach (var item in s)
        {
            if (item == '(' || item == '{' || item == '[')
            {
                StackChars.Push(item);
            }
            else if (item == ')' && StackChars.Count != 0 && StackChars.Peek() == '(')
            {
                StackChars.Pop();
            }
            else if (item == '}' && StackChars.Count != 0 && StackChars.Peek() == '{')
            {
                StackChars.Pop();
            }
            else if (item == ']' && StackChars.Count != 0 && StackChars.Peek() == '[')
            {
                StackChars.Pop();
            }
            else
            {
                return false;
            }
        }
        return StackChars.Count == 0;
    }
}*/