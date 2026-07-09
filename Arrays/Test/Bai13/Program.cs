namespace Bai13
{
    internal class Program
    {
        /*Bài 13: Tìm phần tử đầu tiên lớn hơn 100*/
        
        static void Main(string[] args)
        {
            /*1. Cho mảng [10, 20, 30, 110, 100, 220]. Tìm phần tử đầu tiên trong mảng lớn hơn 100, nếu không có in ra -1*/
            int[] array = { 10, 20, 30, 10, 10, 20 };
            Console.WriteLine("Phan tu dau tien trong mang lon nho 100");
            bool check = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 100)
                {
                    check = true;
                    Console.WriteLine(array[i]);
                    break;
                }   
            }
            if (!check)
            {
                Console.WriteLine(-1);
            }
            
           
            
        }
    }
}
