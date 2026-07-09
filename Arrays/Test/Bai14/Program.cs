namespace Bai14
{
    internal class Program
    {
        /*Bài 14: Kiểm tra x có tồn tại trong mảng, và đếm xem có bao nhiêu số x xuất hiện trong mảng*/
        static void Main(string[] args)
        {
            /*1.Cho mảng [10,2, 4, 8, 9, 20, 3, 2, 7, 2] Kiểm tra xem số 2 có tồn tại trong mảng không*/
            int[] array = { 10, 2, 4, 8, 9, 20, 3, 2, 7, 2 };
            int x = 2;
            bool check = false;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    check = true;
                    Console.WriteLine($"So {x} co ton tai trong mang");
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine($"So {x} khong ton tai trong mang");
            }

            /*2. Với mảng trên kiểm tra xem số 2 xuất hiện bao nhiêu lần trong mảng*/
            int count = 0;
            for(int i = 0;i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    count++;
                }
            }
            Console.WriteLine($"So {x} xuat hien {count} lan trong mang");

        }
    }
}
