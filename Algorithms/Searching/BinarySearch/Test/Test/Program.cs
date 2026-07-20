namespace Test
{
    internal class Program
    {
        /*Lý thuyết
         Tìm kiếm nhị phân là tìm kiếm bằng cách chia nửa đoạn tìm kiếm ra thành 2 phần
        - Độ phức tạp về thgian O(log N)
        - Điều kiện để dùng được thuật toán tìm kiếm nhị phân là cấu trúc dữ liệu phải được sắp xếp
        - Cách hoạt động
            + Chia không gian tìm kiếm thành hai phần bằng cách tìm chỉ mục ở giữa "mid" .
            + So sánh phần giữa của không gian tìm kiếm với khóa
            + Nếu tìm thấy khóa ở giữa, quá trình sẽ bị chấm dứt.
            + Nếu không tìm thấy khóa ở giữa, hãy chọn một nửa sẽ được sử dụng làm không gian tìm kiếm tiếp theo.
              => Nếu khóa nhỏ hơn giữa, thì phía bên trái sẽ được sử dụng cho lần tìm kiếm tiếp theo.
              => Nếu khóa lớn hơn giữa, thì phía bên phải sẽ được sử dụng cho lần tìm kiếm tiếp theo.
            + Quá trình này được tiếp tục cho đến khi tìm thấy khóa hoặc toàn bộ không gian tìm kiếm đã được sử dụng hết.
        - Có 2 cách triển khai
            + Thuật toán tìm kiếm nhị phân lặp
            + Thuật toán tìm kiếm nhị phân đệ quy
         */

        /*Triển khai tìm kiếm bằng nhị phân lặp*/
        public static int binarySearch1(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }
                else if (array[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
        /*Triển khai bằng cách tìm kiếm đệ quy */
        public static int binarySearch2(int[] array, int low, int high, int key)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }
                else if (array[mid] > key)
                {
                    return binarySearch2(array, low, mid - 1, key);
                }
                else
                {
                    return binarySearch2(array, mid + 1, high, key);
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 10, 40 };
            int key = 10;
            int result = binarySearch2(array, 0, array.Length - 1, key);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at "
                                  + "index " + result);

        }
    }
}
