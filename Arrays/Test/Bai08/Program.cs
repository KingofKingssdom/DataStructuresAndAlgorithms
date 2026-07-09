namespace Bai08
{
    internal class Program
    {
        /*Tính tổng số chẵn*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [1,2,3,4,5,6] tính tổng số chẵn trong mảng*/
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            for(int i = 0; i< array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Tong cac so chan trong mang {sum}");
        }
    }
}
