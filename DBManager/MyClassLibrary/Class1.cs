using System;

namespace MyClassLibrary
{
    public class myLib
    {
        public static int count(char deli, string str) 
        {
        string[] Strs = str.Split(deli);
        int n = Strs.Length;
        return n - 1;
        }

        public static string GetToken(int index, char deli, string str)
        {
            string[] Strs = str.Split(deli);
            string ret = Strs[index];
            return ret;
        }
    }   
}

