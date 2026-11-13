using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH1
{
    static class B3C1
    {
        static string DaoNguoc_VongLap(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--) sb.Append(s[i]);
            return sb.ToString();
        }

        static string DaoNguoc_Stack(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in s) st.Push(c);
            StringBuilder sb = new StringBuilder();
            while (st.Count > 0) sb.Append(st.Pop());
            return sb.ToString();
        }

        public static void Run()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine() ?? "";
            Console.WriteLine("Dao (vong lap): " + DaoNguoc_VongLap(s));
            Console.WriteLine("Dao (Stack): " + DaoNguoc_Stack(s));
        }
    }
}
