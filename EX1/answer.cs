using System.Numerics;
using System.Transactions;

namespace EX1
{

    public class answer
    {
        #region exercise 1.1
        /*Bài 1.1: 
        * Viết chương trình in ra nội dung của một chuỗi kí tự 
        * nào đó nhập vào từ
        bàn phím. Ví dụ: “I’m Iron Man”.
       */
        public void InputString()
        {

            Console.WriteLine("Mời thím nhập vào chuỗi bất kỳ");
            var str = Console.ReadLine();
            Console.WriteLine($"chuỗi thím mới nhập vào là {str}");
        }
        #endregion

        #region exercise 1.2 
        /*
         * Bài 1.2: Nhập vào một số nguyên n, hãy cho biết số đó chẵn hay lẻ,
         * chia hết cho 3 không, in kết quả kiểm tra ra màn hình. 
         * Mỗi kết luận trên một dòng
         */
        public void CheckEvenAndDiv3Number()
        {
            Console.WriteLine("Mời thím nhập số muốn nguyên kiểm tra");
            int checkNum;
            while (!int.TryParse(Console.ReadLine(), out checkNum) || checkNum == 0)
            {
                Console.WriteLine("thím nhập số không hợp lệ, nhập lại nhé");

            }

            if (checkNum % 2 == 0 && checkNum % 3 == 0)
            {
                Console.WriteLine($" {checkNum} là số chẵn và chia hết cho 3 ");
            }
            else
            {
                Console.WriteLine($" {checkNum} là số lẻ và không chia hết cho 3 ");

            }

        }

        #endregion

        #region exercise 1.3
        /*Bài 1.3:
         * Nhập vào hai số nguyên a, b. In ra màn hình kết quả các phép 
         * tính +, -, *, /,%. Lưu ý khi xử lý các phép chia sẽ cần ép kiểu, 
         * kiểm tra mẫu khác 0. Xuất kết
         * quả ra màn hình trên từng dòng
         */
        public void Calculator2Number()
        {
            Console.WriteLine("+, -, *, / hai số");
            Console.Write(" mời thím nhập số thứ nhất: ");
            int num1;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("thím nhập không đúng định dạng nhập lại nhé");
            }     
            Console.Write(" mời thím nhập số thứ hai: ");
            int num2;
            while (!int.TryParse(Console.ReadLine(), out num2) || num2 == 0)
            {
                Console.WriteLine("thím nhập không đúng định dạng nhập lại nhé");
            }
            //output
            Console.WriteLine($"{num1} +{num2} = {num1+num2}");
            Console.WriteLine($"{num1} -{num2} = {num1 - num2}");
            Console.WriteLine($"{num1} *{num2} = {num1 * num2}");
            double div = num1 / (double)num2;
            Console.WriteLine($"{num1} /{num2} = {Math.Round(div, 2)}");
        }

        #endregion

        #region exercise 1.4
        /*Bài 1.4: Nhập vào hai số nguyên a, b. So sánh xem số nào lớn hơn, 
         * số nào nhỏ hơn hay hai số bằng nhau. In kết quả ra màn hình.*/
        public void CompareNumber()
        {
            Console.WriteLine("Chương trình so sánh 2 số ");
            Console.Write("Please enter the first number: ");
            int num1;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("thím nhập không đúng định dạng nhập lại nhé: ");
            }
            Console.Write("Please enter the second number: ");
            int num2;
            while (!int.TryParse(Console.ReadLine(), out num2) || num2 == 0)
            {
                Console.Write("thím nhập không đúng định dạng nhập lại nhé: ");
            }
            if (num1 > num2)
            {
                Console.WriteLine($"{num1}>{num2}");
            }
            else if (num1 == num2) { Console.WriteLine($"{num1}={num2}"); }
            else { Console.WriteLine($"{num1}<{num2}"); }

        }

        #endregion

        #region exercise 1.5
        /*Bài 1.5: Hãy nhập 4 số nguyên a, b, c, d. 
         * Tìm giá trị nhỏ nhất trong đó và in ra màn
        hình. Trong trường hợp 4 số bằng nhau thì in ra: không có số nhỏ nhất.*/
        public void FindMinOf4Number()
        {
            // khai báo
            int[] ints = new int[4];
            //nhập liệu
            Console.WriteLine("Find Min Of 4 Number: ");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write($"INPUT FOR NUMBER {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out ints[i]))
                {
                    Console.WriteLine("incorrect validat, again");
                }
            }

            //progess
            // 1. kiểm tra xem các phần tử trong mảng có băng nhau
            bool allEqual = true;
            for (int i = 1; i < ints.Length; i++)
            {
                // nếu có bất kỳ element nào khác nhau sẽ bật cơ allEqual=flase, thoát luôn vòng lặp
                if (ints[i] != ints[0]) 
                {
                    allEqual = false;
                    break;
                }
            }
            if (allEqual)
            {  //output
                Console.WriteLine("Tất cả các phần tử trong mảng đều bằng nhau.");
            }
                //2. find min
            else
            {
                //output
                var min = ints.Min();
                Console.WriteLine("Min of 4 number is: "+min);

            }
        }
        #endregion

        #region exercise 1.6
        /*Bài 1.6: Hãy nhập 4 số nguyên bất kì sau đó lưu vào 4 biến a, b, c, d. 
         * Tìm giá trị lớn thứ hai trong số chúng, in kết quả ra màn hình. 
        Trường hợp tất cả cùng giá trị thì không có số lớn thứ hai.*/

        public void FindSecordMaxOf4Number() {
            // khai báo
            int[] ints2 = new int[4];
            //nhập liệu
            Console.WriteLine("Find Min Of 4 Number: ");
            for (int i = 0; i < ints2.Length; i++)
            {
                Console.Write($"INPUT FOR NUMBER {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out ints2[i]))
                {
                    Console.WriteLine("incorrect validat, again");
                }
            }

            //progess
            // 1. kiểm tra xem các phần tử trong mảng có băng nhau
            bool allEqual = true;
            for (int i = 1; i < ints2.Length; i++)
            {
                // nếu có bất kỳ element nào khác nhau sẽ bật cơ allEqual=flase, thoát luôn vòng lặp
                if (ints2[i] != ints2[0])
                {
                    allEqual = false;
                    break;
                }
            }
            if (allEqual)
            {  //output
                Console.WriteLine("Tất cả các phần tử trong mảng đều bằng nhau.");
            }
            //2. find second max
            else
            {
                //output
                Array.Sort(ints2); //sắp xếp mảng tăng dần
                 // vị trị kê trót của mảng đã sx --> element lớn thứ 2
                Console.WriteLine(ints2[ints2.Length-2]); 

            }

        }

        #endregion

        #region exercise 1.7
        /*Bài 1.7: Viết chương trình nhập vào hai cạnh của hình chữ nhật và tính chu vi và
        diện tích của hình chữ nhật đó. Hiển thị kết quả lên màn hình.*/

        public void CalRecangle()
        {
            // Nhập chiều rộng của hình chữ nhật
            int width = GetPositiveInteger("Mời thím Nhập chiều rộng của hình chữ nhật: ");

            // Nhập chiều cao của hình chữ nhật
            int height = GetPositiveInteger("Mời thím Nhập chiều cao của hình chữ nhật: ");

            // Tính chu vi và diện tích của hình chữ nhật
            int chuVi = 2 * (width + height);
            int dienTich = width * height;

            // Hiển thị kết quả
            Console.WriteLine("Chu vi = " + chuVi);
            Console.WriteLine("Diện tích = " + dienTich);
        }

        // Phương thức để nhập một số nguyên dương
        static int GetPositiveInteger(string prompt)
        {
            int value;
            Console.WriteLine(prompt);
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Giá trị nhập vào phải là số nguyên dương. Vui lòng nhập lại.");
            }
            return value;
        }
        #endregion

        #region exercise 1.8
        /*Bài 1.8: Viết chương trình nhập bán kính của hình tròn và tính chu vi, 
         * diện tích hình  tròn đó.*/

        public void CalCircle()
        {
            // Nhập chiều cao của hình chữ nhật
            double round = GetPositiveDouble("Mời thím Nhập bán kính hình tròn: ");

            // Tính chu vi và diện tích của hình tròn
            double chuVi = (2 * Math.PI*round);
            double dienTich = Math.PI*Math.Pow(round,2);

            // Hiển thị kết quả
            Console.WriteLine($"Hình Tròn bán kính {round} có");
            Console.WriteLine("Chu vi = " + chuVi);
            Console.WriteLine("Diện tích = " + dienTich);
        }

        // Phương thức để nhập một số nguyên dương
        static double GetPositiveDouble(string prompt)
        {
            int value;
            Console.WriteLine(prompt);
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Giá trị nhập vào phải là số thực dương. Vui lòng nhập lại.");
            }
            return value;
        }
        #endregion

        #region exercise 1.9
        /*Bài 1.9: Giải và biện luận phương trình bậc nhất a𝑥 + b = 𝟎*/
        /**/
        // output
        public void EquationFirst()
        {
            double a = GetDouble("Mời thím nhập vào a= ");
            double b = GetDouble("Mời thím nhập vào b= ");
          
            if (a == 0)
            {
                Console.WriteLine("phương trình vô nghiệm= ");
            }
            else
            {
                Console.WriteLine("phương trình có nghiệm x= "+Math.Round((-b/a),2));
            }
            //progess
        }
        static double GetDouble(string prompt)
        {
            double value;
            Console.WriteLine(prompt);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Giá trị nhập vào phải là số . Vui lòng nhập lại.");
            }
            return value;
        }

        #endregion

        #region exercise 1.10
        /*Bài 1.10: Giải và biện luận phương trình bậc 2 a𝑥2 + b𝑥1 + c = 𝟎*/
        public void EquationSercord()
        {
            double a = GetDouble("Mời thím nhập vào a= ");
            double b = GetDouble("Mời thím nhập vào b= ");
            double c = GetDouble("Mời thím nhập vào c= ");
            double x1, x2;
            if (a == 0)
            {
                Console.WriteLine("phương trình có nghiệm x= " + Math.Round((-c / b), 2));
            }
            else
            {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2* a );
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a );
                    Console.WriteLine($"PT có 2 nghiệp phân biệt x1= {x1} ; x2={x2}");
                }else if (delta == 0)
                {
                    x1 = x2 = (-b) / (2 * a);
                    Console.WriteLine("PT có 1 nghiệm kép x1 = x2 = "+x1);
                }
                else
                {
                    Console.WriteLine("PT không có nghiệm thực ");
                }
            }

            //progess
        }
     
        #endregion

        #region exercise
        #endregion

    }
}
