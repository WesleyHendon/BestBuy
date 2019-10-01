using System;
namespace BestBuy
{
    public class Palindrome
    {
        public bool IsPalindrome(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--) result += str[i].ToString();
            if (result == str) return true; return false;
        }
    }
}
