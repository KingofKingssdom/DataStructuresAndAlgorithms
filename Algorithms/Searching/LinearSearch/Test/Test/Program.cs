namespace Test
{
    internal class Program
    {
        /*Lý thuyết
         - Linear Search (Sequential Search) là thuật toán tìm kiếm bằng cách duyệt từng phần tử từ đầu đến cuối cho đến khi tìm thấy phần tử cần tìm hoặc duyệt hết mảng.
         - Dùng khi
            + Mảng chưa sắp xếp
            + Danh sách ngắn
            + Không muốn tốn thời gian sắp xếp
         - Ý tưởng tư duy của thuật toán: 
            + Bắt đầu từ phần tử đầu tiên -> So sánh với giá trị cần tìm -> Nếu bằng trả về
                                                                         -> Nếu không bằng tiếp tục lặp -> Lặp đến cuối mảng
        - Sử dụng break, để nếu tìm thấy phần tử dừng lại không tìm nữa tránh lãng phí tài nguyên
        - Độ phức tạp: 
            Thời gian
            + Best case O(1): tìm thấy ngay đầu mảng
            + Worst Case O(n): Tìm thấy phần từ cuối mảng hoặc không tìm thấy phần tử có trong mảng
            + Average O(n): Tìm thấy phần tử giữa mảng
            Không gian
            + O(1): vì không cần phải thêm tạo mảng nào nữa
        - Nhược điểm duyệt bị chậm với dữ liệu lớn vì phải duyệt nhiều phần tử từ đầu 
        _ Dùng khi mảng ngắn và dữ liệu chưa sắp xếp
         */
        static void Main(string[] args)
        {
            /*Ví dụ: cho một mảng [2, 4, 8, 9, 10, 14, 7] tìm phần tử số 10 ở vị trí thứ mấy trong mảng*/
            int[] array = { 2, 4, 8, 9, 10, 14, 7 };
            int x = 10;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine($"Phan tu {x} o vi tri thu {i} trong mang");
                    break;
                }
            }
        }
    }
}
