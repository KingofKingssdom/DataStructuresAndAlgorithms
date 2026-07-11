namespace Bai02
{
    internal class Program
    {
        /*Bài 02: Điều kiện*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [3, 4, 6, 8, 9, 10, 1, 2, 1, 4, 1] Tìm số chẵn, lẻ đầu tiên trong mảng*/
            int[] array = { 3, 4, 6, 8, 9, 10, 1, 2, 1, 4, 1 };
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"So chan dau tien trong mang co gia tri {array[i]}");
                    break;
                }
                else if (array[i] %2 != 0)
                {
                    Console.WriteLine($"So le dau tien trong mang co gia tri {array[i]}");
                }
            }

           
        }
    }
}
