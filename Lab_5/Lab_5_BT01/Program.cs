using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_5_BT01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 1,2, 3, 9, 6, 4, 5, 11,23,14 };
            // duyệt và in 
            Console.WriteLine("Phan tu mang:");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("{0,5}", m[i]);
            }
            Console.WriteLine();
            // tìm gtri nho nhat
            int min = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (min > m[i])
                {
                    min = m[i];
                }
            }
            Console.WriteLine("Phan tu nho nhat: {0}", min);
            //đảo ngược dãy 
            Array.Reverse(m); 
            Console.WriteLine("Mang dao nguoc:");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("{0,5}", m[i]);
            }
            Console.WriteLine();
            //sắp xếp mảng
            Array.Sort(m);
            Console.WriteLine("Mang sap xep:");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write("{0,5}", m[i]);
            }
            Console.WriteLine();
            // tìm số nguyên tố
            bool check = true;
            for (int i = 2; i <= Math.Sqrt(m[i]); i++)
            {
                if (m[i] % i == 0)
                {
                    check = false;
                }
            }
            Console.WriteLine("Cac so nguyen to trong mang:");
            for (int i = 0; i < m.Length; i++)
            {
                if (check)
                {
                    Console.Write("{0,5}", m[i]);
                }
            }
            Console.WriteLine();

            // tính trung bình cộng các phần tử dương
            int count = 0;
            float tong = 0;
            float tbc;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] >= 0)
                {
                    tong += m[i];
                    count++;
                }
            }
            tbc = tong / count;
            Console.WriteLine("Trung binh cong so duong là: {0} / {1} = {2}",tong, count, tbc);

            // kiểm tra ptu am dương dan xem
            bool ktra = true;
            for (int i = 2; i <= m.Length; i++)
            {
                if (m[i] >= 0 && m[i+1] >= 0 || m[i] < 0 && m[i + 1] < 0)
                {
                    ktra = true;
                    break;
                }
            }
            if (ktra)
            {
                Console.WriteLine("cung dau");
            }
            else
            {
                Console.WriteLine("khac dau");
            }
        }
    }
}
