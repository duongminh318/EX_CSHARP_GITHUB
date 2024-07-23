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
       
      
        /*Bài 1.1: 
         * Viết chương trình in ra nội dung của một chuỗi kí tự 
         * nào đó nhập vào từ
         bàn phím. Ví dụ: “I’m Iron Man”.
        */
        public void InputString()
        {
            
            Console.WriteLine("Mời thím nhập vào chuỗi bất kỳ");
            var str= Console.ReadLine();
            Console.WriteLine($"chuỗi thím mới nhập vào là {str}");
        }

    }
}
