namespace Bai01
{
    internal class Program
    {
        /*Bài 1: Làm quen ma trận*/
        static void Main(string[] args)
        {
            /*1. Nhập vào các số từ 1 đến 9 và in ra ma trận 3 hàng 3 cột*/
            //Console.WriteLine("Nhap vao cac so ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //int number4 = Convert.ToInt32(Console.ReadLine());
            //int number5 = Convert.ToInt32(Console.ReadLine());
            //int number6 = Convert.ToInt32(Console.ReadLine());
            //int number7 = Convert.ToInt32(Console.ReadLine());
            //int number8 = Convert.ToInt32(Console.ReadLine());
            //int number9 = Convert.ToInt32(Console.ReadLine());
            //int[,] matrix = {
            //    { number1, number2, number3},
            //    { number4, number5, number6},
            //    { number7, number8, number9}

            //};
            //Console.WriteLine("Ma tran co dang la ");
            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*2. Cho ma trận [[1,2,3], [4,5,6], [7,8,9]] tính tổng các phẩn tử có trong ma trận*/
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;
            for(int i = 0; i < matrix1.GetLength(0); i++)
            {
                for(int j = 0; j < matrix1.GetLength(1); j++)
                {
                    sum += matrix1[i, j];
                }
            }
            Console.WriteLine("Tong phan tu co trong ma tran " + sum);

            /*3. Đếm trong ma trận trên có bao nhiêu phân tử chẵn, bao nhiêu phần tử lẻ*/
            int chan = 0;
            int le = 0;
            for(int i = 0; i < matrix1.GetLength(0); i++)
            {
                for(int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i,j] %2 == 0)
                    {
                        chan++;
                    }
                    else if (matrix1[i, j] %2 != 0)
                    {
                        le++;
                    }
                }
            }
            Console.WriteLine("So phan tu chan trong ma tran " + chan);
            Console.WriteLine("So phan tu le trong ma tran " + le);

            /*4. Tìm phần tử lớn nhất, nhỏ nhất trong ma trận trên*/
            int max = matrix1[2,2];
            int min = matrix1[0, 0];
            for(int i = 0; i < matrix1.GetLength(0); i++)
            {
                for(int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i,j] > max)
                    {
                        max = matrix1[i, j];
                    }
                    if (matrix1[i,j] < min)
                    {
                        min = matrix1[i, j];
                    }
                }
            }
            Console.WriteLine("Phan tu nho nhat trong ma tran " + min);
            Console.WriteLine("Phan tu lon nhat trong ma tran " + max);

            
        }
    }
}
