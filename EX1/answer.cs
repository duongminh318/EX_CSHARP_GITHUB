using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

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
            while(!int.TryParse(Console.ReadLine(),out checkNum) || checkNum==0)
            {
                Console.WriteLine("thím nhập số không hợp lệ, nhập lại nhé");
               
            }

            if (checkNum % 2 == 0 && checkNum % 3 == 0)
            {
                Console.WriteLine($" {checkNum} là số chẵn và chia hết cho 3 ");
            }
            else {
                Console.WriteLine($" {checkNum} là số lẻ và không chia hết cho 3 ");

            }

        }

        #endregion
       





        #region exercise
        #endregion

    }
}
