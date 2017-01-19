using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheckerApp
{
    public class Program
    {
        public static bool IsPalindrome(string s)
        {
            char[] CharArray;
            int MidPoint;
            bool IsPalindromeMatch;
            if (s == null) { return false; } // Otherwise we end up with an exception
            CharArray = s.Replace(@" ",string.Empty).ToLowerInvariant().ToCharArray();
            if (CharArray.Length == 0) { return false; } // Edge case - no idea if an empty string should be considered a Palindrome
            MidPoint = CharArray.Length / 2; // Note that by default dot net truncates integer division results.
            IsPalindromeMatch = true;
            for (int I = 0; I < MidPoint; I++)
            {
                if (CharArray[I] != CharArray[CharArray.Length - (I+1)])
                {
                    IsPalindromeMatch = false;
                    break; // Early exit
                }
            }
            return IsPalindromeMatch;
        }

        public static bool IsPalindromeConvolutedHorrorCode(string s)
        {
            // Horror code example for question 4 (code review nightmare)
            return s == null ? false : s == "" ? false :  ((Func<bool>)(() =>{ bool r = true; int n=0;char[] c = s.Replace(@" ", @"").ToLowerInvariant().ToCharArray();c.ToList().ForEach(delegate (char v) { if (v != c[c.Length - (n + 1)]) { r = false; return; } n++; });return r;  }))(); ;
        }

        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }


        static void Main(string[] args)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

            // Additional test cases
            Check(null, false);
            Check(string.Empty, false);
            Check("Nev#er Odd Or E#ven", true);
            Check("Nev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#ven", true);
            Check("Nev#er O\r\ndd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd \n\rOr E#ven", true);

            Console.ReadLine(); // Pause
        }
    }
}
