namespace Lab_5_BT02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = {    { 9,2,3,4},
                            { 14,5,6,9},
                            { 5,6,7,1},
                            { 6,7,8,2}};
            //duyệt mảng
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //tìm chỉ số hàng == cột
            Console.WriteLine("Phan tu bang nhau:");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
            //ptu nhỏ nhất trên hàng
            Console.WriteLine("Phan tu lon nhat tren hang");
            for(int i = 0;i < a.GetLength(1); i++)
            {
                int min = a[i, 0];
                for(int j = 0; j < a.GetLength(0); j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                    }
                }
                Console.WriteLine("Hang {0}: {1}",i, min);
            }
            // liệt kê các phàn tử chia hết cho 7
            Console.WriteLine("So chia het cho 7");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] % 7 == 0)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                }
            }
            Console.WriteLine();
            // chuyển thàng mảng một chiều
            int index = 0;
            int[] ch = new int[a.GetLength(0) * a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    ch[index++] = a[i, j];
                }
            }
            Console.WriteLine("Mang 1 chieu:");
            foreach (var item in ch)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //tính tổng ptu nằm ở viền của mảng
            //i == 0: Kiểm tra xem phần tử nằm ở hàng đầu tiên của mảng không.
            //i == rows - 1: Kiểm tra xem phần tử nằm ở hàng cuối cùng của mảng không.
            //j == 0: Kiểm tra xem phần tử nằm ở cột đầu tiên của mảng không.
            //j == cols - 1: Kiểm tra xem phần tử nằm ở cột cuối cùng của mảng không.
            int sum = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || i == a.GetLength(0) - 1 || j == 0 || j == a.GetLength(1) - 1)
                    {
                        sum += a[i, j];
                    }
                }
            }
            Console.WriteLine("Tong la: {0}", sum);
        }
    }
}
