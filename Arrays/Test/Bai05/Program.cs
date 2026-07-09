namespace Bai05
{
    internal class Program
    {
        /*Bài 05: Tìm phần tử nhỏ nhất trong mảng*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [4, 7, 2, 9, 1]. Tìm phần tử nhỏ nhất trong mảng*/
            int[] array = { 4, 7, 2, 9, 1 };
            int min = array[0];
            for(int i = 0;i< array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Phan tu nho nhat trong mang " + min);

        }
    }
}
