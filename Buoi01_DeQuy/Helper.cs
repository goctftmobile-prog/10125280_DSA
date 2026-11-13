using System;

namespace BTTH1
{
    static class hamhotro
    {
        public static Random Rnd = new Random();

        public static int[] TaoMangNgauNhien(int n, int max = 10000)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = Rnd.Next(0, max);
            return a;
        }

        public static void InMang(int[] a, int toiDa = 20)
        {
            int n = Math.Min(a.Length, toiDa);
            for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
            if (a.Length > n) Console.Write("... (" + a.Length + " phan tu)");
            Console.WriteLine();
        }

        public static void Swap(int[] a, int i, int j)
        {
            int t = a[i]; a[i] = a[j]; a[j] = t;
        }

        public static int DocSo(string loiNhac, int macDinh)
        {
            Console.Write($"{loiNhac} (Enter = {macDinh}): ");
            string s = Console.ReadLine();
            return int.TryParse(s, out int v) ? v : macDinh;
        }
    }
}
