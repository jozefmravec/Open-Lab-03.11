using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string first = str.Substring(0, str.Length / 2);
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        } 
    }
}
