using System;
using LongestCommonPrefixConsoleApp.Models;

namespace LongestCommonPrefixConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new [] {"flower", "flow", "flight"};
            string prefix = SuperArray.GetLongestCommonPrefix(strs);

            Console.WriteLine($"The common prefix is: {prefix}");
        }
    }
}
