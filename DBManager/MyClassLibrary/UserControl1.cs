using System;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public class myLib
        {
            public static int count(char deli, string str)    //str 문자열의 deli 구분자의 개수
            {
                string[] Strs = str.Split(deli);
                int n = Strs.Length;
                return n - 1;
            }

            public static string GetToken(int index, char deli, string str)
            {
                string[] Strs = str.Split(deli);
                //           int n = Strs.Length;
                string ret = Strs[index];
                return ret;
            }
        }
    }
}
