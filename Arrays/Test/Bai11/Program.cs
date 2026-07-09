namespace Bai11
{
    internal class Program
    {
        /*Bài 11: Tìm số nguyên tố trong mảng*/
        static void Main(string[] args)
        {
            /*1. Cho mảng [1,2,3,4,5] liệt kê các số nguyên tố trong mảng*/
            int[] array1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Cac so nguyen to");
            for (int i = 0; i < array1.Length; i++)
            {
                int number1 = array1[i];
                bool check1 = true;
                for (int j = 2; j < number1; j++)
                {
                    if (number1 % j == 0)
                    {
                        check1 = false;
                        break;
                    }
                }
                if (check1)
                {
                    Console.WriteLine(number1);
                }
            }

            /*2. Cho mảng [10,3,7,9,11,2] tìm các số nguyên tố trong mảng*/
            int[] array2 = { 10, 3, 7, 9, 11, 2 };
            for (int i = 0; i < array2.Length; i++)
            {
                int number2 = array2[i];
                bool check2 = true;
                for (int j = 2; j < number2; j++)
                {
                    if (number2 % j == 0)
                    {
                        check2 = false;
                        break;
                    }
                }
                if (check2)
                {
                    Console.WriteLine(number2);
                }
            }

            /*3. Cho mảng [10,20,30,4,23,25] tìm các số nguyên tố có trong mảng*/
            int[] array3 = { 10, 20, 30, 4, 23, 25 };
            for(int i = 0; i < array3.Length; i++)
            {
                int number3 = array3[i];
                bool check3 = true;
                for(int j = 2; j < number3; j++)
                {
                    if (array3[j] % j == 0)
                    {
                        check3 = false;
                        break;
                    }
                }
                if (check3)
                {
                    Console.WriteLine(number3);
                }
            }
        }
    }
}
