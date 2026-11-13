using System;
using System.Text;

namespace BTTH1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n BAI TAP:");
                Console.WriteLine(" 1. Bai 1 Chuong 1:");
                Console.WriteLine(" 2. Bai 2 Chuong 1:");
                Console.WriteLine(" 3. Bai 3 Chuong 1:");
                Console.WriteLine(" 4. Bai 4 Chuong 1:");
                Console.WriteLine(" 5. Bai 5 Chuong 1+2:");
                Console.WriteLine(" 6. Bai 1 Chuong 2:");
                Console.WriteLine(" 7. Bai 2 Chuong 2:");
                Console.WriteLine(" 8. Bai 3 Chuong 2:");
                Console.WriteLine(" 9. Bai 4 Chuong 2:");
                Console.WriteLine("10. Bai 6 Chuong 2:");
                Console.WriteLine("11. Bai 1 Chuong 3:");
                Console.WriteLine("12. Bai 2 Chuong 3:");
                Console.WriteLine("13. Bai 3 Chuong 3:");
                Console.WriteLine("14. Bai 4 Chuong 3:");
                Console.WriteLine("15. Bai 5 Chuong 3:");
                Console.WriteLine("16. Bai 6 Chuong 3:");
                Console.WriteLine("17. Bai 7 Chuong 3:");
                Console.WriteLine("18. Bai 8 Chuong 3:");
                Console.WriteLine(" 0. Thoat");
                Console.Write("Chon: ");

                string chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1": B1C1.Run(); break;
                    case "2": B2C1.Run(); break;
                    case "3": B3C1.Run(); break;
                    case "4": B4C1.Run(); break;
                    case "5": B5_Fibonacci.Run(); break;
                    case "6": B1C2.Run(); break;
                    case "7": B2C2.Run(); break;
                    case "8": B3C2.Run(); break;
                    case "9": B4C2.Run(); break;
                    case "10": B6C2.Run(); break;
                    case "11": B1C3.Run(); break;
                    case "12": B2C3.Run(); break;
                    case "13": B3C3.Run(); break;
                    case "14": B4C3.Run(); break;
                    case "15": B5C3.Run(); break;
                    case "16": B6C3.Run(); break;
                    case "17": B7C3.Run(); break;
                    case "18": B8C3.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Lua chon khong hop le."); break;
                }
                Console.Write("\nNhan phim bat ky de quay lai menu...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
