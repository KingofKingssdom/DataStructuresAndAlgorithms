namespace Bai02
{
    internal class Program
    {
        /*Bài 2: Luyện tập hàng và cột*/
        static void Main(string[] args)
        {
            /*1. Cho ma trận tìm tổng các phần tử theo từng hàng */
            int[,] matrix = {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine($"Tong phan tu hang {i} la: {sum}");
                sum = 0;
            }

            /*2. Cho ma trận tìm tổng các phần tử theo từng cột */
            int sumc = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
               for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumc += matrix[j, i];
                }
                Console.WriteLine($"Tong phan tu cot {i} la: {sumc}");
                sumc = 0;
            }

            /*3. Tìm và in hàng có tổng lớn nhất*/
            int maxSumH = 0;
            int sumH = 0;
            int indexH = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumH += matrix[i, j];
                }
                if(maxSumH < sumH){
                    indexH = i;
                    maxSumH = sumH;
                }
                sumH = 0;
                
            }
            Console.WriteLine($"Hang {indexH} co tong lon nhat " + maxSumH);

            /*4.Tìm và in cột có tổng lớn nhất */
            int maxSumC = 0;
            int indexC = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumc += matrix[j, i];
                }
                if (maxSumC < sumc)
                {
                    indexC = i;
                    maxSumC = sumc;

                }
                sumc = 0;
            }
            Console.WriteLine($"Cot {indexC} co tong lon nhat " + maxSumC);

            /*5. Tìm phần tử lớn nhất trong từng hàng của ma trận*/
            int maxRow = matrix[0,0];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] > maxRow)
                    {
                        maxRow = matrix[i, j];
                    }
                }
                Console.WriteLine($"Hang {i} co phan tu lon nhat {maxRow}");
            }
            /*6. Tìm phần tử nhỏ nhất trong từng cột của ma trận*/
            int minColumn = matrix[0,0];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j,i]< minColumn)
                    {
                        minColumn = matrix[j, i];
                    }
                }
                Console.WriteLine($"Cot {i} co phan tu nho nhat {minColumn}");

            }
        }
    }
}
