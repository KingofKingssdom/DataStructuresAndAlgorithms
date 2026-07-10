namespace Test
{
    internal class Program
    {
        /*Lý thuyết 
         - Matrix là mảng hai chiều
         - Có hàng và cột
         - 
         */

        static void Main(string[] args)
        {
            /*1. Khai báo một ma trận có 3 hàng và 3 cột*/
            int[,] matrix = new int[3, 3];
            matrix[0,0] = 1;
            matrix[0,1] = 2;
            matrix[0,2] = 3;
            matrix[1,0] = 4;
            matrix[1,1] = 5;
            matrix[1,2] = 6;
            matrix[2,0] = 7;
            matrix[2,1] = 8;
            matrix[2,2] = 9;

            int[,] matrix1 =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            /*2. Lấy số hàng và số cột*/
            int rows = matrix.GetLength(0);
            Console.WriteLine(rows);
            int columns = matrix.GetLength(1);
            Console.WriteLine(columns);

            /*3. Duyệt từng phần tử  ma trận*/
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            /*4. Đường chèo chính với điều kiện là i == j*/

        }
    }
}
