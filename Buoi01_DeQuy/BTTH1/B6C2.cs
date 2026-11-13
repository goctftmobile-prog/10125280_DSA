using System;
using System.Diagnostics;

namespace BTTH1
{
    static class B6C2
    {
        public static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool daDoi = false;
                for (int j = 0; j < n - 1 - i; j++)
                    if (a[j] > a[j + 1]) { hamhotro.Swap(a, j, j + 1); daDoi = true; }
                if (!daDoi) break;
            }
        }

        public static void SelectionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                    if (a[j] < a[minIdx]) minIdx = j;
                if (minIdx != i) hamhotro.Swap(a, i, minIdx);
            }
        }

        public static void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }

        public static void QuickSort(int[] a) { QuickSort(a, 0, a.Length - 1); }

        static void QuickSort(int[] a, int l, int r)
        {
            if (l >= r) return;
            int mid = l + (r - l) / 2;
            hamhotro.Swap(a, mid, r);
            int pivot = a[r];
            int i = l;
            for (int j = l; j < r; j++)
                if (a[j] < pivot) { hamhotro.Swap(a, i, j); i++; }
            hamhotro.Swap(a, i, r);
            QuickSort(a, l, i - 1);
            QuickSort(a, i + 1, r);
        }

        public static void MergeSort(int[] a)
        {
            int[] tmp = new int[a.Length];
            MergeSort(a, tmp, 0, a.Length - 1);
        }

        static void MergeSort(int[] a, int[] tmp, int l, int r)
        {
            if (l >= r) return;
            int mid = l + (r - l) / 2;
            MergeSort(a, tmp, l, mid);
            MergeSort(a, tmp, mid + 1, r);

            int i = l, j = mid + 1, k = l;
            while (i <= mid && j <= r)
                tmp[k++] = (a[i] <= a[j]) ? a[i++] : a[j++];
            while (i <= mid) tmp[k++] = a[i++];
            while (j <= r) tmp[k++] = a[j++];
            for (k = l; k <= r; k++) a[k] = tmp[k];
        }

        static double DoThoiGian(Action<int[]> sortFn, int[] goc)
        {
            int[] b = (int[])goc.Clone();
            Stopwatch sw = Stopwatch.StartNew();
            sortFn(b);
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public static void Run()
        {
            int[] kichThuoc = { 1000, 5000, 10000, 20000 };
            Console.WriteLine($"{"n",8}{"Bubble",12}{"Selection",12}{"Insertion",12}{"Quick",12}{"Merge",12}   (ms)");
            foreach (int n in kichThuoc)
            {
                int[] a = hamhotro.TaoMangNgauNhien(n, 1000000);
                Console.WriteLine(
                    $"{n,8}" +
                    $"{DoThoiGian(BubbleSort, a),12:F2}" +
                    $"{DoThoiGian(SelectionSort, a),12:F2}" +
                    $"{DoThoiGian(InsertionSort, a),12:F2}" +
                    $"{DoThoiGian(QuickSort, a),12:F2}" +
                    $"{DoThoiGian(MergeSort, a),12:F2}");
            }
        }
    }
}
