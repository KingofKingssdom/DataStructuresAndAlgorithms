namespace Bai01
{
    internal class Program
    {
        /*Bài 01: Nhập n số nguyên và in ra toàn bộ phần tử mảng từ 1 đến n 
         
         */
        static void Main(string[] args)
        {
            /*1. Cho số n = 5*/
            Console.WriteLine("Nhap vao so n = 5");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Phan tu trong mang ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            /*2 Cho số n = 6*/
            Console.WriteLine("Nhap vao n = 6");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Phan tu trong mang");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            /*3. Cho số n = 4 */
            Console.WriteLine("Nhap vo so n = 4");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int[] array3 = new int[n3];
            for (int i = 0; i < n3; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                array3[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Phan tu mang ");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }



        }
    }
}
