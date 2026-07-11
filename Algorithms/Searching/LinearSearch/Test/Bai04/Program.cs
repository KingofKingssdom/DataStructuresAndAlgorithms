namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bài 04: Cho mảng [3, 4, 6, 8, 9, 10, 1, 2, 1, 4, 1] tìm phần tử lớn nhất và nhỏ nhất trong mảng in ra vi trí của nó*/
            int[] array = { 3, 4, 6, 8, 9, 10, 1, 2, 1, 4, 1 };
            int max = array[array.Length - 1];
            int idxMax = 0;
            int min = array[0];
            int idxMin = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    idxMax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    idxMin = i;
                }
            }
            Console.WriteLine($"Vi tri phan tu lon nhat trong mang: {idxMax}");
            Console.WriteLine($"Vi tri phan tu nho nhat trong mang: {idxMin}");

            /*2.Cho mảng [4, 4, 6, 6, 9, 1, 1, 2, 3, 4, 2] Tìm phần tử đầu tiên trong mảng xuất hiện đúng 1 lần*/
            int[] array2 = { 4, 4, 6, 6, 9, 1, 1, 2, 3, 5, 2 };
           
            for(int i = 0; i < array2.Length; i++)
            {
                int count2 = 0;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[i] == array2[j])
                    {
                        count2++;
                    }
                }
                
               if(count2 == 1)
                {
                    Console.WriteLine($"Phan tu dau tien trong mang xuat hien dung 1 lan {array2[i]}");
                    break;
                }
            }

        }
    }
}
