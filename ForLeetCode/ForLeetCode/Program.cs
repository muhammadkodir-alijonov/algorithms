namespace HelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

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