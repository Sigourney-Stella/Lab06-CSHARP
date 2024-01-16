using System.Collections;

namespace Lab06_TH01
{
    class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public bool OnHand { get; set; }

        public Product(string name, double cost, bool onHand)
        {
            Name = name;
            Cost = cost;
            OnHand = onHand;
        }
        //ghi đè phương th
        public override string ToString()
        {
            return $"Name: {Name}, Cost: {Cost}, OnHand: {OnHand}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một ArrayList để lưu trữ danh sách sản phẩm
            ArrayList productList = new ArrayList();

            // Thêm 5 sản phẩm vào ArrayList
            productList.Add(new Product("Product1", 10.99, true));
            productList.Add(new Product("Product2", 15.49, false));
            productList.Add(new Product("Product3", 5.99, true));
            productList.Add(new Product("Product4", 8.79, false));
            productList.Add(new Product("Product5", 12.29, true));

            // Hiển thị thông tin sản phẩm ra màn hình
            Console.WriteLine("Product List:");
            foreach (Product product in productList)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
