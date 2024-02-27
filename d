[33mcommit 10cdf7265ac02784378d1ac17b6b15cf33ad809a[m[33m ([m[1;36mHEAD[m[33m -> [m[1;32mmain[m[33m, [m[1;31morigin/main[m[33m, [m[1;31morigin/HEAD[m[33m)[m
Author: Muhammadqodir Alijonov <alijonov0608@gmail.com>
Date:   Sat Feb 10 15:46:10 2024 +0500

    20

[1mdiff --git a/ForLeetCode/ForLeetCode/Program.cs b/ForLeetCode/ForLeetCode/Program.cs[m
[1mindex 20352e4..4b60d09 100644[m
[1m--- a/ForLeetCode/ForLeetCode/Program.cs[m
[1m+++ b/ForLeetCode/ForLeetCode/Program.cs[m
[36m@@ -9,13 +9,8 @@[m [minternal class Program[m
 {[m
     static void Main(string[] args)[m
     {[m
[31m-        int[] arr = { 2, 7, 11, 15 };[m
[31m-        Console.WriteLine(MaxProduct(arr));[m
[31m-    }[m
[31m-    static int MaxProduct(int[] nums)[m
[31m-    {[m
[31m-        Array.Sort(nums);[m
[31m-        return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);[m
[32m+[m[32m        string s = "[{}]";[m
[32m+[m[32m        Console.WriteLine(IsValid(s));[m
     }[m
 }[m
 /*public class Solution //41[m
[36m@@ -504,4 +499,35 @@[m [minternal class Program[m
         Array.Sort(nums);[m
         return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);[m
     }[m
[32m+[m[32m}*/[m
[32m+[m[32m/*public class Solution //20[m
[32m+[m[32m{[m
[32m+[m[32m    public bool IsValid(string s)[m
[32m+[m[32m    {[m
[32m+[m[32m        var StackChars = new Stack<char>();[m
[32m+[m[32m        foreach (var item in s)[m
[32m+[m[32m        {[m
[32m+[m[32m            if (item == '(' || item == '{' || item == '[')[m
[32m+[m[32m            {[m
[32m+[m[32m                StackChars.Push(item);[m
[32m+[m[32m            }[m
[32m+[m[32m            else if (item == ')' && StackChars.Count != 0 && StackChars.Peek() == '(')[m
[32m+[m[32m            {[m
[32m+[m[32m                StackChars.Pop();[m
[32m+[m[32m            }[m
[32m+[m[32m            else if (item == '}' && StackChars.Count != 0 && StackChars.Peek() == '{')[m
[32m+[m[32m            {[m
[32m+[m[32m                StackChars.Pop();[m
[32m+[m[32m            }[m
[32m+[m[32m            else if (item == ']' && StackChars.Count != 0 && StackChars.Peek() == '[')[m
[32m+[m[32m            {[m
[32m+[m[32m                StackChars.Pop();[m
[32m+[m[32m            }[m
[32m+[m[32m            else[m
[32m+[m[32m            {[m
[32m+[m[32m                return false;[m
[32m+[m[32m            }[m
[32m+[m[32m        }[m
[32m+[m[32m        return StackChars.Count == 0;[m
[32m+[m[32m    }[m
 }*/[m
\ No newline at end of file[m
