namespace Lab_5_TH02
{
    internal class Program
    {
        /// <summary>
        /// Khai báo mảng 2 chiều 4x3
        /// duyệt mảng và in theo ma trận hàng cột
        /// in ra ptu mang có chỉ số hàng bằng chỉ số cột
        /// in ptu lon nhat tren mang
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] a = {    { 9,2,3},
                            { 4,5,6}, 
                            { 5,6,7}, 
                            { 6,7,8}};
            //duyệt mảng
            for(int i = 0;  i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j] + "\t");
                }
                Console.WriteLine();
            }
            //tìm chỉ số hàng == cột
            Console.WriteLine("Phan tu bang nhau:");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if( i == j)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
            //ptu lớn nhất trên hàng
            Console.WriteLine("Phan tu lon nhat tren hang");
            for(int i = 0;i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine("Hang {0}: {1}",i,max);

            }

        }
    }
}
