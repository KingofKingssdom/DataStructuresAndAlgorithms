namespace Bai12
{
    internal class Program
    {
        /*Bài 12: Liệt kê các số chia hết*/
        static void Main(string[] args)
        {
            /*1. Cho một mảng [10, 230, 3, 1, 9, 27] liệt kê các số chia hết cho 3*/
            int[] array = { 10, 230, 3, 1, 9, 27 };
            Console.WriteLine("Cac so chia het cho 3");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] %3 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            /*2. Tiếp tục sử dụng mảng trên hãy liệt kê các số chia hết cho 2 và 5*/
            Console.WriteLine("Cac so chia het cho 2 va 5");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]% 2 == 0 && array[i] % 5 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
