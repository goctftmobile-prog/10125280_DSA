using System;

namespace BTTH1
{
    static class B4C1
    {
        public static void Run()
        {
            int[] a = hamhotro.TaoMangNgauNhien(1000);
            Console.Write("Mang ban dau: ");
            hamhotro.InMang(a);
            B6C2.InsertionSort(a);
            Console.Write("Sau khi sort: ");
            hamhotro.InMang(a);
        }
    }
}
