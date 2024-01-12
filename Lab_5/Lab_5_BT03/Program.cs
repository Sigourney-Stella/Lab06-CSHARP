using System.Text;

namespace Lab_5_BT03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Khai báo mảng CAN và CHI
            string[] CAN = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] CHI = { "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

            // Nhập năm từ người dùng
            Console.Write("Nhập vào một năm: ");
            int inputYear = int.Parse(Console.ReadLine());

            // Tính năm âm tương ứng
            int canIndex = (inputYear - 4) % 10;
            int chiIndex = (inputYear - 4) % 12;

            if (canIndex < 0)
            {
                canIndex += 10;
            }

            if (chiIndex < 0)
            {
                chiIndex += 12;
            }

            // Lấy CAN và CHI tương ứng
            string can = CAN[canIndex];
            string chi = CHI[chiIndex];

            // In ra năm âm tương ứng
            Console.WriteLine($"Năm âm tương ứng với {inputYear} là: {can} {chi}");
        }
    }
}
