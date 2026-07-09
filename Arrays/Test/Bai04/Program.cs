namespace Bai04
{
    internal class Program
    {
        /*Bài 04: Tìm phần tử lớn nhất trong mảng*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [4, 7, 2, 9, 1]. Tìm phần tử lớn nhất trong mảng*/
            int[] array = { 4, 7, 2, 9, 1 };
            int max = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Phan tu lon nhat trong mang " + max);
        }
    }
}
