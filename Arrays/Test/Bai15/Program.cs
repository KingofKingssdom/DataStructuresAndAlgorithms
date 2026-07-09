namespace Bai15
{
    internal class Program
    {
        /*Bài 15: Thao tác với mảng*/
        static void Main(string[] args)
        {
            /*1. Cho một mảng [12 4 6 8 ] thêm phần tử số 5 vào đầu mảng*/
            //int[] array = { 12, 4, 6, 8 };
            //int first = 5;
            //int [] newArray = new int[array.Length + 1];
            //newArray[0] = first;
            //for(int i = 1; i < newArray.Length; i++)
            //{
            //    newArray[i] = array[i -1];
            //}
            //Console.WriteLine("Phan tu sau khi them vao dau mang");
            //for(int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i]);
            //}

            /*2. Từ mảng trên hãy tiếp thêm phần tử số 1 vào cuối mảng*/
            //int last = 1;
            //int [] arrayLast = new int[array.Length + 1];
            //arrayLast[array.Length] = last;
            //for(int i = 0; i < array.Length -1; i++)
            //{
            //    arrayLast[i] = array[i];
            //}
            //Console.WriteLine("Phan tu cua mang sau khi them vào cuoi mang");
            //for(int i  = 0; i < arrayLast.Length; i++)
            //{
            //    Console.WriteLine(arrayLast[i]);
            //}

            /*3. Từ mảng trên hãy tiếp chèn thêm một phần tử 3 vào vị trí số 2 trong mảng*/
            //int[] arrayIndex = new int[array.Length + 1];
            //int value = 3;
            //int index = 2;
            //for(int i = 0; i < arrayIndex.Length; i++)
            //{
            //    if(i < index)
            //    {
            //        arrayIndex[i] = array[i];
            //    }
            //    else if(i == index)
            //    {
            //        arrayIndex[i] = value;
            //    }
            //    else
            //    {
            //        arrayIndex[i] = array[i - 1];
            //    }
            //}
            //Console.WriteLine("Phan tu mang ");
            //for(int i = 0; i < arrayIndex.Length; i++)
            //{
            //    Console.WriteLine(arrayIndex[i]);
            //}

            /*4.Từ mảng trên hãy Xóa phần tử đầu mảng*/
            //int[] deleteFirstArray = new int[array.Length - 1];
            //for(int i = 0; i < array.Length -1; i++)
            //{
            //    deleteFirstArray[i] = array[i + 1];
            //}
            //Console.WriteLine("Mang sau khi xoa phan tu dau mang ");
            //for(int i = 0; i < deleteFirstArray.Length; i++)
            //{
            //    Console.WriteLine(deleteFirstArray[i]);
            //}

            /*5.Từ mảng trên hãy xóa phần tử ở cuối mảng*/
            //int[] deleteLastArray = new int[array.Length - 1];
            //for(int i  = 0; i < array.Length -1; i++)
            //{
            //    deleteLastArray[i] = array[i];
            //}
            //Console.WriteLine("Mang sau khi xoa phan tu cuoi mang ");
            //for (int i = 0; i < deleteLastArray.Length; i++)
            //{
            //    Console.WriteLine(deleteLastArray[i]);
            //}

            /*6. Từ mảng trên hãy xóa phần tử tại vị trí số 2*/
            //int[] deleteIndexArray = new int[array.Length - 1];
            //int index2 = 1;
            //for(int i = 0; i < deleteIndexArray.Length; i++)
            //{
            //    if(i < index2)
            //    {
            //        deleteIndexArray[i] = array[i];
            //    }
            //    else if( i >= index2)
            //    {
            //        deleteIndexArray[i] = array[i + 1];
            //    }
            //}
            //Console.WriteLine("Mang sau khi xoa phan tu o vi tri chi dinh ");
            //for(int i = 0;i < deleteIndexArray.Length; i++)
            //{
            //    Console.WriteLine(deleteIndexArray[i]);
            //}
            /*7. Cho một mảng [10, 2, 4, 5, 6, 7, 2, 3, 2] xóa phần tử số 2 đầu tiên ra khỏi mảng*/
            //int[] array7 = { 10, 2, 4, 5, 6, 7, 2, 3, 2 };
            //int[] newArray7 = new int[array7.Length - 1];
            //int valueDelete7 = 2;
            //int indexArray7 = 0;
            //for(int i = 0; i < array7.Length; i++)
            //{
            //    if (array7[i] == valueDelete7)
            //    {
            //        indexArray7 = i;
            //        break;
            //    }
            //}
            //for(int i = 0; i < newArray7.Length; i++)
            //{
            //    if(i < indexArray7)
            //    {
            //        newArray7[i] = array7[i];
            //    }
            //    else if(i >= indexArray7)
            //    {
            //        newArray7[i] = array7[i + 1];
            //    }
            //}
            //Console.WriteLine("Mang sau khi xoa so 2 dau tien ");
            //for(int i = 0; i < newArray7.Length; i++)
            //{
            //    Console.WriteLine(newArray7[i]);
            //}

            /*Bài 8: Cho một mảng [10, 2, 4, 5, 6, 7, 2, 3, 2] hãy xóa toàn bộ phần tử số 2 ra khỏi mảng*/
            //int[] array8 = { 10, 2, 4, 5, 6, 7, 2, 3, 2 };
            //int deleteValue = 2;
            //int count8 = 0;
            //for(int i = 0; i < array8.Length; i++)
            //{
            //    if (array8[i] == deleteValue)
            //    {
            //        count8++;
            //    }
            //}
            //int j = 0;
            //int [] newArray8 = new int[array8.Length - count8];
            //for(int i = 0; i < array8.Length; i++)
            //{
            //    if (array8[i] != deleteValue)
            //    {
            //        newArray8[j] = array8[i];
            //        j++;
            //    }
            //}
            //Console.WriteLine($"Mang sau khi xoa toan bo phan tu {deleteValue}");
            //for(int i = 0; i < newArray8.Length; i++)
            //{
            //    Console.WriteLine(newArray8[i]);
            //}
            /*Bài 9:Cho mảng [1,-3,4 -2 1 2] Thay đổi toàn bộ số âm thành số 0*/
            //int[] array9 = { 1, -3, 4, -2, 1, 2 };
            //for(int i = 0; i < array9.Length; i++)
            //{
            //    if (array9[i] < 0)
            //    {
            //        array9[i] = 0;
            //    }
            //}
            //Console.WriteLine("Thay the toan bo so am trong mang thanh so 0");
            //for(int i = 0;i < array9.Length; i++)
            //{
            //    Console.WriteLine(array9[i]); 
            //}

            /*Bài 10: Cho mảng [1, 3, 4, 9, 20] hay đổi chỗ số lớn nhất với số nhỏ nhất*/
            int[] array10 = { 3, 1, 4, 20, 9 };
            int maxValue = array10[array10.Length -1];
            int minValue = array10[0];
            int maxIndex = 0;
            int minIndex = 0;
            for(int i = 0; i< array10.Length; i++)
            {
                if (array10[i] > maxValue)
                {
                    maxValue = array10[i];
                    maxIndex = i;
                }
                if (array10[i] < minValue)
                {
                    minValue = array10[i];
                    minIndex = i;
                }
            }
            array10[maxIndex] = minValue;
            array10[minIndex] = maxValue;
            Console.WriteLine("Mang sau khi doi cho ");
            for(int i = 0; i < array10.Length; i++)
            {
                Console.WriteLine(array10[i]);
            }
        }
    }
}
