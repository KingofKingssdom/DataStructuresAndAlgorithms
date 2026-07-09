namespace Bai09
{
    internal class Program
    {
        /*Bài 09: In mảng theo thứ tự đảo ngược*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [1 2 3 4]. Hãy in ra mảng theo thứ tự ngược lại*/
            int[] array = { 1, 2, 3, 4 };
            for(int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
