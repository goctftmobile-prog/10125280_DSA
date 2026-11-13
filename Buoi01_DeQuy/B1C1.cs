using System;

namespace BTTH1
{
    static class B1C1
    {
        public static void Run()
        {
            int[] a = hamhotro.TaoMangNgauNhien(1000);
            int max = a[0], min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
            Console.WriteLine("So lon nhat: " + max);
            Console.WriteLine("So nho nhat: " + min);
        }
    }
}
