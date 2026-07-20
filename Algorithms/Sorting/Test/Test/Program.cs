namespace Test
{
    internal class Program
    {
        /*Lý thuyết 
        - Sắp xếp là quá trình sắp xếp lại một mảng hoặc danh sách các phần tử đã cho theo một toán tử 
        so sánh trên các phần tử đó. Toán tử so sánh được sử dụng để quyết định thứ tự mới của các phần tử trong cấu trúc dữ liệu tương ứng.
        - Nguyên tắc cơ bản về sorting
            + Sắp xếp tại chỗ (In-place sorting): Thuật toán sắp xếp tại chỗ sử dụng không gian bộ nhớ cố định để tạo ra kết quả (chỉ sửa đổi mảng đã cho). 
                Ví dụ: Sắp xếp chọn, Sắp xếp nổi bọt, Sắp xếp chèn và Sắp xếp đống. 
            + Sắp xếp nội bộ (Internal sorting): Là khi tất cả dữ liệu được lưu trữ trong  bộ nhớ chính  hoặc  bộ nhớ trong . 
              Trong sắp xếp nội bộ, bài toán không thể nhận dữ liệu đầu vào vượt quá kích thước bộ nhớ được cấp phát.
            + Sắp xếp ngoài (External sorting): Sắp xếp ngoài là khi toàn bộ dữ liệu cần được sắp xếp không nhất thiết phải được lưu trữ 
              trong bộ nhớ cùng một lúc. Phương pháp sắp xếp này được gọi là sắp xếp ngoài. Sắp xếp ngoài được sử dụng cho lượng dữ liệu khổng lồ. 
                Ví dụ, thuật toán sắp xếp trộn (Merge sort) có thể được sử dụng trong sắp xếp ngoài vì toàn bộ mảng không cần phải luôn có mặt trong bộ nhớ.
            + Sắp xếp ổn định (Stable sorting): Khi hai phần tử giống nhau xuất hiện theo  cùng thứ tự  trong dữ liệu đã được sắp xếp như trong mảng ban đầu, đó được gọi là sắp xếp ổn định. 
                Ví dụ: Sắp xếp trộn, Sắp xếp chèn, Sắp xếp nổi bọt
            + Sắp xếp lai (Hybird sorting): Một thuật toán sắp xếp được gọi là lai nếu nó sử dụng nhiều hơn một thuật toán sắp xếp tiêu chuẩn để sắp xếp mảng. 
              Ý tưởng là tận dụng ưu điểm của nhiều thuật toán sắp xếp. 
                Ví dụ: IntroSort sử dụng sắp xếp chèn và sắp xếp nhanh.
        - Các kĩ thuật phân loại: Trong cấu trúc dữ liệu, có nhiều thuật toán sắp xếp khác nhau được sử dụng. Có thể phân loại thuật toán sắp xếp thành hai loại chính 
            + Dựa trên so sánh: Trong một thuật toán sắp xếp dựa trên việc so sánh, chúng ta sẽ so sánh các phần tử với nhau 
               => cách vận hành: so sánh lần lượt số đầu tiên với số thứ hai, số thứ hai với số thứ ba
            + Không dưa trên so sánh: Trong một thuật toán sắp xếp không dựa trên việc so sánh, chúng ta hoàn toàn không so sánh các phần tử với nhau
               => cách vận hành: Dựa vào vị trí hoặc giá trị tuyệt đối của phần tử để xếp vào đúng chỗ. Giống như việc có bài kiểm tra từ 1 đến 5, có 5 cái hộp từ 1 đến 5 cứ cầm vào bài
                  kiểm tra thấy điểm giá trị bao nhiêu ném vào hộp đúng giá trị đó. Cuối cùng cầm các bài từ hộp theo thứ tự là sắp xếp xong
         */
        static void Main(string[] args)
        {
            
        }
    }
}
