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

        #region exercise 1.3:
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
            int[] ints = new int[4] {1,2,1,1};
            //nhập liệu
          /*  Console.WriteLine("Find Min Of 4 Number: ");
            for (int i = 0; i < ints.Length; i++) {
                Console.Write($"INPUT FOR NUMBER {i + 1}: ");
                while( !int.TryParse(Console.ReadLine(), out ints[i]))
                {
                    Console.WriteLine("incorrect validat, again");
                }
               
            
            }
*/

            //xử lý
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
                Console.WriteLine(min);

            }

          

        }


        #endregion

        #region exercise
        #endregion

    }
}
