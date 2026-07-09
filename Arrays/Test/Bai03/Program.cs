namespace Bai03
{
    internal class Program
    {
        /*Bài 03: Tính trung bình cộng phần tử trong mảng*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [1,2,3,4] tính trung bình cộng phần tử trong mảng*/
            double sum = 0;
            double count = 0;
            int[] array = { 1, 2, 3, 4 };

            for(int i = 0; i< array.Length; i++)
            {
                sum += array[i];
                count++;
            }
            double tbc = sum / count;
            Console.WriteLine("Trung binh cong phan tu trong mang " + tbc);
        }
    }
}
