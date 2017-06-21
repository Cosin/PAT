using System;

/***************************

1002. 写出这个数 (20)

读入一个自然数n，计算其各位数字之和，用汉语拼音写出和的每一位数字。

输入格式：每个测试输入包含1个测试用例，即给出自然数n的值。这里保证n小于10100。

输出格式：在一行内输出n的各位数字之和的每一位，拼音数字间有1 空格，但一行中最后一个拼音数字后没有空格。

输入样例：
1234567890987654321123456789
输出样例：
yi san wu

 ***************************/

namespace PAT
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] p = { "ling", "yi", "er", "san", "si", "wu", "liu", "qi", "ba", "jiu" };
            int sum = 0;
            foreach (char item in num)
            {
                sum += int.Parse(item.ToString());
            }
            string re = string.Empty;
            foreach (char item in sum.ToString())
            {
                re += (p[int.Parse(item.ToString())] + " ");
            }
            Console.WriteLine(re.Substring(0, re.Length - 1));
        }
    }
}
