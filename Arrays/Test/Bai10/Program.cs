namespace Bai10
{
    internal class Program
    {
        /*Bài 10: Duyệt mảng và điều kiện*/
        static void Main(string[] args)
        {
            /*1. Liệt kê các số chẵn mảng*/
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Cac phan tu chan trong mang");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] %2== 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            /*2. Liệt kê các số lẻ trong mảng*/
            Console.WriteLine("Cac phan tu le trong mang");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            
        }
    }
}
