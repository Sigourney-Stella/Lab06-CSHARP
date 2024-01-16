namespace Lab6_TH02
{
    internal class Program
    {
        /// <summary>
        /// MINH HOẠ việc sủ dụng SortedList của generic
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //tạo SortedList
            SortedList<string,string> listItem = new SortedList<string,string>();
            // đưa dư liệu vào
            listItem.Add("01", "ha");
            listItem.Add("02", "hong");
            listItem.Add("03", "hanh");
            listItem.Add("04", "giang");
            listItem.Add("05", "son");

            //in danh sách
            Console.WriteLine("Danh sach");
            foreach(string key in listItem.Keys) { 
                Console.WriteLine(key + ": " + listItem[key]);
            }
            //tìm tên có chu h
            Console.WriteLine("Danh sach co chu H");
            foreach (string key in listItem.Keys)
            {
                if (listItem[key].StartsWith("h"))
                Console.WriteLine(key + ": " + listItem[key]);
            }
            //kiêm tra xem có mã 06 chưa và thêm vào
            if (!listItem.ContainsKey("06"))
            {
                listItem.Add("06", "Thuong");
            }
            Console.WriteLine("Danh sach sau khi kiem tra");
            foreach (string key in listItem.Keys)
            {
                    Console.WriteLine(key + ": " + listItem[key]);
            }
        }
    }
}
