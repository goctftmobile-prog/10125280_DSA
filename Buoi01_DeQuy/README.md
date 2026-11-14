# Buổi 01 – Đệ quy

Chương trình C# dạng console, gom các bài tập thực hành về **đệ quy**, **thuật toán cơ bản** và **đánh giá độ phức tạp** (Chương 1, 2, 3) vào một menu duy nhất.

## Yêu cầu môi trường

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) trở lên (dự án dùng `net10.0`)
- Hệ điều hành: Windows / Linux / macOS

## Cấu trúc thư mục

```
Buoi01_DeQuy/
└── BTTH1/
    ├── BTTH1.csproj
    ├── Program.cs        # Menu chính, gọi Run() của từng bài
    ├── Helper.cs         # Hàm hỗ trợ: tạo mảng ngẫu nhiên, in mảng, Swap, đọc số
    ├── B1C1.cs ... B4C1.cs   # Chương 1
    ├── B5_Fibonacci.cs       # Chương 1 + 2
    ├── B1C2.cs ... B6C2.cs   # Chương 2
    └── B1C3.cs ... B8C3.cs   # Chương 3 (đệ quy)
```

Quy ước tên file: `B<số bài>C<số chương>.cs`, ví dụ `B1C2.cs` = Bài 1 Chương 2.

## Lệnh chạy

```bash
cd Buoi01_DeQuy/BTTH1

# Biên dịch + chạy
dotnet run

# Hoặc build bản Release rồi chạy
dotnet build -c Release
dotnet bin/Release/net10.0/BTTH1.dll
```

Chương trình hiện menu, nhập số thứ tự bài (`1`–`18`) để chạy, `0` để thoát. Các bài có nhập liệu đều có **giá trị mặc định**: nhấn `Enter` để dùng giá trị trong ngoặc `(Enter = ...)`. Sau mỗi bài, nhấn phím bất kỳ để quay lại menu.

## Danh sách bài đã làm

| Menu | File | Bài | Nội dung |
|:---:|---|---|---|
| 1 | `B1C1.cs` | Bài 1 – Chương 1 | Tìm số lớn nhất, nhỏ nhất trong mảng 1000 số ngẫu nhiên |
| 2 | `B2C1.cs` | Bài 2 – Chương 1 | FizzBuzz từ 1 đến 100, in thành 5 cột |
| 3 | `B3C1.cs` | Bài 3 – Chương 1 | Đảo ngược chuỗi bằng vòng lặp và bằng `Stack` |
| 4 | `B4C1.cs` | Bài 4 – Chương 1 | Sắp xếp mảng 1000 số ngẫu nhiên (Insertion Sort) |
| 5 | `B5_Fibonacci.cs` | Bài 5 – Chương 1+2 | Fibonacci bằng 4 cách: đệ quy trực tiếp, vòng lặp, đệ quy có nhớ, lũy thừa ma trận; so sánh thời gian |
| 6 | `B1C2.cs` | Bài 1 – Chương 2 | Tháp Hà Nội, đếm số bước (đối chiếu 2ⁿ − 1) |
| 7 | `B2C2.cs` | Bài 2 – Chương 2 | Tìm kiếm nhị phân: vòng lặp và đệ quy |
| 8 | `B3C2.cs` | Bài 3 – Chương 2 | Kiểm tra số nguyên tố: O(n) và O(√n) |
| 9 | `B4C2.cs` | Bài 4 – Chương 2 | Tìm số hoàn hảo nhỏ hơn N: O(N²) và O(N√N), có đo thời gian |
| 10 | `B6C2.cs` | Bài 6 – Chương 2 | So sánh thời gian 5 thuật toán sắp xếp: Bubble, Selection, Insertion, Quick, Merge |
| 11 | `B1C3.cs` | Bài 1 – Chương 3 | S(n) = 1 + 2 + … + n (đệ quy) |
| 12 | `B2C3.cs` | Bài 2 – Chương 3 | S(n) = 1 + 2² + … + n² (đệ quy) |
| 13 | `B3C3.cs` | Bài 3 – Chương 3 | S(n) = 1 + 1/2 + … + 1/n (đệ quy) |
| 14 | `B4C3.cs` | Bài 4 – Chương 3 | Lũy thừa xⁿ (đệ quy, hỗ trợ n âm) |
| 15 | `B5C3.cs` | Bài 5 – Chương 3 | Ước lẻ lớn nhất của n (đệ quy) |
| 16 | `B6C3.cs` | Bài 6 – Chương 3 | Ước chung lớn nhất UCLN(a, b) (đệ quy – Euclid) |
| 17 | `B7C3.cs` | Bài 7 – Chương 3 | Đếm số chữ số của n (đệ quy) |
| 18 | `B8C3.cs` | Bài 8 – Chương 3 | S(n) = √(1 + √(2 + … + √n)) (đệ quy) |

## Kết quả chạy

Kết quả dưới đây được chạy thật trên .NET SDK 10.0 (Linux). Các bài dùng số ngẫu nhiên (menu 1, 4, 10) và các con số thời gian (ms) sẽ **khác nhau giữa các lần chạy và giữa các máy**.

### 1. Bài 1 – Chương 1: Max / Min

```
So lon nhat: 9985
So nho nhat: 7
```

### 2. Bài 2 – Chương 1: FizzBuzz (1 → 100, 5 cột)

```
  1           Fizz        41          61          Fizz        
  2           22          Fizz        62          82          
  Fizz        23          43          Fizz        83          
  4           Fizz        44          64          Fizz        
  Buzz        Buzz        FizzBuzz    Buzz        Buzz        
  Fizz        26          46          Fizz        86          
  7           Fizz        47          67          Fizz        
  8           28          Fizz        68          88          
  Fizz        29          49          Fizz        89          
  Buzz        FizzBuzz    Buzz        Buzz        FizzBuzz    
  11          31          Fizz        71          91          
  Fizz        32          52          Fizz        92          
  13          Fizz        53          73          Fizz        
  14          34          Fizz        74          94          
  FizzBuzz    Buzz        Buzz        FizzBuzz    Buzz        
  16          Fizz        56          76          Fizz        
  17          37          Fizz        77          97          
  Fizz        38          58          Fizz        98          
  19          Fizz        59          79          Fizz        
  Buzz        Buzz        FizzBuzz    Buzz        Buzz        
```

### 3. Bài 3 – Chương 1: Đảo ngược chuỗi

Nhập `Hello World`:

```
Dao (vong lap): dlroW olleH
Dao (Stack): dlroW olleH
```

### 4. Bài 4 – Chương 1: Sắp xếp mảng

```
Mang ban dau: 2557 3620 7789 168 7335 2487 9511 6400 3553 891 3217 1184 3228 3285 8697 1853 5740 7161 3619 3728 ... (1000 phan tu)
Sau khi sort: 9 26 29 46 46 72 80 89 99 102 105 125 132 133 140 167 168 179 182 184 ... (1000 phan tu)
```

### 5. Bài 5 – Chương 1+2: Fibonacci (n = 30)

```
De quy truc tiep: 832040  (5.091 ms)
Vong lap: 832040  (0.146 ms)
De quy co nho: 832040  (1.844 ms)
Luy thua ma tran: 832040  (0.881 ms)
```

> Đệ quy trực tiếp có độ phức tạp O(2ⁿ) nên chậm nhất khi n lớn; vòng lặp O(n), đệ quy có nhớ O(n), lũy thừa ma trận O(log n). Chương trình giới hạn n trong khoảng 0..90 để không tràn `long`.

### 6. Bài 1 – Chương 2: Tháp Hà Nội

Với n = 3 (mặc định):

```
Chuyen dia 1: A -> C
Chuyen dia 2: A -> B
Chuyen dia 1: C -> B
Chuyen dia 3: A -> C
Chuyen dia 1: B -> A
Chuyen dia 2: B -> C
Chuyen dia 1: A -> C
Tong so buoc: 7(ly thuyet 2^n - 1 = 7)
```

Với n = 4:

```
Chuyen dia 1: A -> B
Chuyen dia 2: A -> C
Chuyen dia 1: B -> C
Chuyen dia 3: A -> B
Chuyen dia 1: C -> A
Chuyen dia 2: C -> B
Chuyen dia 1: A -> B
Chuyen dia 4: A -> C
Chuyen dia 1: B -> C
Chuyen dia 2: B -> A
Chuyen dia 1: C -> A
Chuyen dia 3: B -> C
Chuyen dia 1: A -> B
Chuyen dia 2: A -> C
Chuyen dia 1: B -> C
Tong so buoc: 15(ly thuyet 2^n - 1 = 15)
```

> Chỉ in chi tiết từng bước khi n ≤ 5; với n lớn hơn chỉ in tổng số bước. n tối đa là 30.

### 7. Bài 2 – Chương 2: Tìm kiếm nhị phân

Nhập `23`:

```
Mang (da sap xep): 2 5 8 12 16 23 38 56 72 91 
Cach lap: vi tri 5
Cach de quy: vi tri 5
```

### 8. Bài 3 – Chương 2: Số nguyên tố

Nhập `97`:

```
Co ban O(n): la so nguyen to
Cai tien O(sqrt n): la so nguyen to
```

### 9. Bài 4 – Chương 2: Số hoàn hảo nhỏ hơn N

Nhập `10000`:

```
Co ban: 6, 28, 496, 8128 (151.36 ms)
Cai tien: 6, 28, 496, 8128 (5.41 ms)
```

### 10. Bài 6 – Chương 2: So sánh các thuật toán sắp xếp

```
       n      Bubble   Selection   Insertion       Quick       Merge   (ms)
    1000        1.47        1.10        0.76        0.40        0.64
    5000       13.37        9.01        4.24        1.72        2.89
   10000       53.23       34.36       16.84        2.10        3.04
   20000      439.04      141.07       83.84        3.97        5.72
```

> Bubble / Selection / Insertion tăng nhanh theo O(n²); Quick Sort và Merge Sort (O(n log n)) tăng chậm hơn nhiều.

### 11. Bài 1 – Chương 3: S(n) = 1 + 2 + … + n

Nhập `10`:

```
S(10) = 1 + 2 + ... + 10 = 55
```

### 12. Bài 2 – Chương 3: S(n) = 1 + 2² + … + n²

Nhập `10`:

```
S(10) = 1 + 2^2 + ... + 10^2 = 385
```

### 13. Bài 3 – Chương 3: S(n) = 1 + 1/2 + … + 1/n

Nhập `10`:

```
S(10) = 1 + 1/2 + ... + 1/10 = 2.928968
```

### 14. Bài 4 – Chương 3: Lũy thừa xⁿ

Nhập `x = 2`, `n = 10`:

```
S(2, 10) = 2^10 = 1024
```

### 15. Bài 5 – Chương 3: Ước lẻ lớn nhất

Nhập `100`:

```
Uoc le lon nhat cua 100 la 25
```

### 16. Bài 6 – Chương 3: UCLN

Nhập `a = 48`, `b = 18`:

```
UCLN(48, 18) = 6
```

### 17. Bài 7 – Chương 3: Đếm số chữ số

Nhập `12345`:

```
So chu so cua 12345 la 5
```

### 18. Bài 8 – Chương 3: S(n) = √(1 + √(2 + … + √n))

Nhập `10`:

```
S(10) = 1.757933
```

## Ghi chú

- Dữ liệu đầu vào không hợp lệ (không phải số) sẽ tự động dùng giá trị mặc định.
- Các bài có kiểm tra điều kiện đầu vào (n > 0, n ≤ 30 với Hà Nội, n ≤ 90 với Fibonacci, ...) và báo lỗi nếu nhập sai.
- `B4C1.cs` tái sử dụng `InsertionSort` từ `B6C2.cs`; các hàm dùng chung nằm trong `Helper.cs` (lớp `hamhotro`).
