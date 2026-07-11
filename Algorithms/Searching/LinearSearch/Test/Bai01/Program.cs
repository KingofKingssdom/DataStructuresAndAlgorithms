namespace Bai01
{
    internal class Program
    {
        /*Bài 1: Cơ bản*/
        static void Main(string[] args)
        {
            /*1. Cho một mảng [3, 4, 6, 8, 9, 10] tìm vị trí một số x = 9 có trong mảng*/
            int[] array = { 3, 4, 6, 8, 9, 10, 1, 2, 1, 4, 1 };
            int x = 9;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine($"Vi tri cua {x} trong mang o vi tri {i}");
                    break;
                }
            }

            /*2. Từ mảng trên kiểm tra số x = 6 có tồn tại trong mảng không*/
            int x1 = 6;
            bool check = false;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == x1)
                {
                    check = true;
                }
                
            }
            Console.WriteLine($"Phan tu {x1} {check} trong mang");

            /*3. Đếm số lần phần tử x  = 1 có xuất hiện trong mảng*/
            int count = 0;
            int x2 = 1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == x2)
                {
                    count++;
                }
            }
            Console.WriteLine($"Phan tu {x2} xuat hien {count} lan trong mang");

            /*4. Tìm vị trí đâu tiên x = 1 trong mảng*/
            int x3 = 1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == x3)
                {
                    Console.WriteLine($"Phan tu {x3} ton tai vi tri {i} dau tien trong mang");
                    break;
                }
            }
            /*5. Tìm vị trí cuối cùng x = 1 trong mảng*/
            int x4 = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x4)
                {
                    Console.WriteLine($"Phan tu {x4} ton tai vi tri {i} cuoi cung trong mang");
                }
            }
        }
    }
}
