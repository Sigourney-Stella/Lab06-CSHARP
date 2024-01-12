namespace Lab_5_TH01
{
    internal class Program
    {
        /// <summary>
        /// tạo mảng 10 ptu
        /// in ra ptu
        /// tìm ptu nhỏ nhất
        /// ktra xem đối xứng không
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] m = { 2,3,4,5,4,3,2 };
            // duyệt và in 
            Console.WriteLine("Phan tu mang:");
            for(int i = 0; i < m.Length; i++)
            {
                Console.Write("{0,5}", m[i]);
            }
            Console.WriteLine();
            // tìm gtri nho nhat
            int min = m[0];
            for(int i = 0; i < m.Length;i++)
            {
                if (min > m[i])
                {
                    min = m[i];
                }
            }
            Console.WriteLine("Phan tu nho nhat: {0}", min);
            //kiểm tra đối xứng
            bool kt = true;
            for(int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if(kt )
            {
                Console.WriteLine("Mang doi xung");
            }
            else
            {
                Console.WriteLine("Mang khong doi xung");

            }
        }
    }
}
