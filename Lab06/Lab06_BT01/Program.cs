namespace Lab06_BT01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>()
            {
                new Book(1, "Book1", "Author1", "Publisher1", 2022, 29.99),
                new Book(2, "Book2", "Author5", "Publisher2", 2021, 15.99),
                new Book(3, "Book3", "Author3", "Publisher3", 2027, 24.99),
                new Book(4, "Book4", "Author9", "Publisher5", 2012, 21.99),
                new Book(5, "Book5", "Author7", "Publisher7", 2003, 31.99),
                new Book(6, "Book6", "Author6", "Publisher9", 2002, 41.99),
            };
            // in danh sách
            Console.WriteLine("Book List:");
            foreach (var st in list)
            {
                Console.WriteLine(st.ToString());
            }

            //tăng
            //list.Sort(double(a,b) => { return doublre(a.Price - b.Price); });
            //list.Sort((x, y) => { return doublre(y.Price - x.Price); });
            list.Sort((x, y) => { return y.Price.CompareTo(x.Price); });
            Console.WriteLine("====DS===");
            foreach (var item in list)
            {
                Console.WriteLine("{0,5}", item.ToString());
            }
            Console.WriteLine();

            //tìm sách NXB 2012
            Console.WriteLine("Danh sach nam xuat ban 2012");
            foreach (var key in list)
            {
                if (list.Year == 2012 )
                    Console.WriteLine(key + ": " + list);
            }
        }
    }
}
