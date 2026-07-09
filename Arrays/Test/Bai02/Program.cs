namespace Bai02
{
    internal class Program
    {
        /*Bài 2: Tính tổng các phần tử trong mảng*/
        static void Main(string[] args)
        {
            /*1. Cho mảng có các phẩn từ [1,2,3,4]*/
            int[] array1 = { 1, 2, 3, 4 };
            int sum1 = 0;
            for(int i = 0; i< array1.Length; i++)
            {
                sum1 += array1[i];
            }
            Console.WriteLine($"Tong phan tu trong mang {sum1}");
        }
    }
}
