namespace Lab06_TH03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sử dụng List khai báo và khởi tạo
            List<Student> list = new List<Student>()
            { 
                new Student(01,"ha",16),
                new Student(02,"hong",16),
                new Student(03,"hanh",16),
                new Student(04,"giang",16),
                new Student(05,"son",16),
            };
            
            // in danh sách
            Console.WriteLine("Product List:");
            foreach (var st in list)
            {
                Console.WriteLine(st);
            }
            

        }
    }
}
