namespace Bai03
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*Bài 03: Cho mảng [3, 4, 6, 8, 9, 10, 1, 2, 1, 4, 1] tìm tất cả vị trí xuất hiện của x = 1*/
            int[] array1 = { 3, 4, 6, 8, 9, 10, 1, 2, 1, 4, 1 };
            int x1 = 1;
            for(int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == x1)
                {
                    Console.WriteLine($"Vi tri cua {x1} la: {i}");
                }
            }
        }
    }
}
