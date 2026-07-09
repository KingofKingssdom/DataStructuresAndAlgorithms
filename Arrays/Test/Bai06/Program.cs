namespace Bai06
{
    internal class Program
    {
        /*Bài 06: Đếm số chẵn*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [1 2 3 4 5 6] đếm số phần tử chẵn trong mảng*/
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("So phan tu chan co trong mang " + count);
        }
    }
}
