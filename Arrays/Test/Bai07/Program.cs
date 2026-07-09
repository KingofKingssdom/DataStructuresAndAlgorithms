namespace Bai07
{
    internal class Program
    {
        /*Bài 07: Đếm số phần tử lẻ trong mảng*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [1 2 3 4 5 6] đếm trong mảng có bao nhiêu phần tử lẻ*/
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int count = 0;
            for(int i =0;i< array.Length; i++)
            {
                if (array[i] %2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("So phan tu le co trong mang " + count);
        }
    }
}
