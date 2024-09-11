using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_Challenges
{
    public class doing
    {
        /*Have the function FindIntersection(strArr) read the array of strings 
         * stored in strArr which will contain 2 elements: the first element
         * will represent a list of comma-separated numbers sorted in ascending 
         * order, the second element will represent a second list of 
         * comma-separated numbers (also sorted). Your goal is to return a 
         * comma-separated string containing the numbers that occur in elements 
         * of strArr in sorted order. If there is no intersection, return the 
         * string false.
            Examples
            Input: new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}
            Output: 1,4,13
            Input: new string[] {"1, 3, 9, 10, 17, 18", "1, 4, 9, 10"}
            Output: 1,9,10*/
        public static string FindIntersection(string[] strArr)
        {
            //  { [1,2,3,4,5], [6,7,8,9,10] }]}
            // code goes here  
            // tách mảng thành 2 mảng chuỗi
            string[] strArr1 = strArr[0].Split(',');
            string[] strArr2 = strArr[1].Split(',');

            // chuyển mảng chuỗi thành mảng số
            int[] intArr1 = Array.ConvertAll(strArr1, int.Parse);
            int[] intArr2 = Array.ConvertAll(strArr2, int.Parse);

            // tìm giao giữa hai mảng sô nguyên 
            var intersection = intArr1.Intersect(intArr2);

            // kiểm tra xem kết quả giao thế nào
            if (intersection.Any())
            {
                // chuyển mảng số thành mảng chuỗi
                string[] result = Array.ConvertAll(intersection.ToArray(), x => x.ToString());
                // trả về kết quả
                return string.Join(",", result);
            }

            return "false";

        }

        /*Questions Marks
        Have the function QuestionsMarks(str) take the str string parameter, 
        which will contain single digit numbers, letters, and question marks, 
        and check if there are exactly 3 question marks between every pair of 
        two numbers that add up to 10. If so, then your program should return
        the string true, otherwise it should return the string false. If there 
        aren't any two numbers that add up to 10 in the string, then your
        program should return false as well.

        For example: if str is "arrb6???4xxbl5???eee5" then your program should 
        return true because there are exactly 3 question marks between 6 and 4, 
        and 3 question marks between 5 and 5 at the end of the string.
        Examples
        Input: "aa6?9"
        Output: false
        Input: "acc?7??sss?3rr1??????5"
        Output: true*/

        public static string QuestionsMarks(string str)
        {
            int prevNum = -1;  // Biến lưu số trước đó, khởi tạo bằng -1 (giá trị không hợp lệ)
            int questionMarkCount = 0;  // Biến đếm số lượng dấu chấm hỏi giữa các số
            bool validPairFound = false;  // Biến kiểm tra xem có cặp số nào thỏa điều kiện không

            // Duyệt qua từng ký tự trong chuỗi
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                // Nếu ký tự là một chữ số
                if (Char.IsDigit(c))
                {
                    int currentNum = (int)Char.GetNumericValue(c);

                    // Nếu đã có số trước đó và tổng của chúng bằng 10
                    if (prevNum != -1 && (prevNum + currentNum == 10))
                    {
                        // Kiểm tra số lượng dấu chấm hỏi
                        if (questionMarkCount == 3)
                        {
                            validPairFound = true;  // Tìm thấy cặp hợp lệ
                        }
                        else
                        {
                            return "false";  // Nếu không có đúng 3 dấu chấm hỏi, trả về false
                        }
                    }

                    // Cập nhật số hiện tại là số trước cho vòng lặp tiếp theo
                    prevNum = currentNum;
                    questionMarkCount = 0;  // Reset bộ đếm dấu chấm hỏi
                }
                // Nếu ký tự là dấu chấm hỏi
                else if (c == '?')
                {
                    questionMarkCount++;  // Tăng bộ đếm dấu chấm hỏi
                }
            }

            // Nếu tìm thấy ít nhất một cặp hợp lệ, trả về "true"
            if (validPairFound)
            {
                return "true";
            }
            else
            {
                return "false";  // Nếu không có cặp nào hợp lệ, trả về false
            }
        }

        /*Codeland Username Validation
        Have the function CodelandUsernameValidation(str) take the str parameter
        being passed and determine if the string is a valid username according 
        to the following rules:

        1. The username is between 4 and 25 characters.
        2. It must start with a letter.
        3. It can only contain letters, numbers, and the underscore character.
        4. It cannot end with an underscore character.

        If the username is valid then your program should return the string true, otherwise return the string false.
        Examples
        Input: "aa_"
        Output: false
        Input: "u__hello_world123"
        Output: true*/

        // Hàm kiểm tra tính hợp lệ của username
        public static string CodelandUsernameValidation(string str)
        {
            // Kiểm tra chiều dài của username
            if (str.Length < 4 || str.Length > 25)
            {
                return "false"; // Trả về false nếu chiều dài không hợp lệ
            }

            // Kiểm tra nếu ký tự đầu tiên không phải là chữ cái
            if (!char.IsLetter(str[0]))
            {
                return "false"; // Trả về false nếu ký tự đầu không phải là chữ cái
            }

            // Kiểm tra nếu username kết thúc bằng dấu gạch dưới
            if (str[str.Length - 1] == '_')
            {
                return "false"; // Trả về false nếu kết thúc bằng "_"
            }

            // Duyệt qua từng ký tự, kiểm tra nếu có ký tự không hợp lệ
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    return "false"; // Trả về false nếu có ký tự không hợp lệ
                }
            }

            // Nếu qua tất cả các kiểm tra, username hợp lệ
            return "true";
        }


        public static string MinWindowSubstring(string[] strArr)
        {
            string N = strArr[0]; // Chuỗi N
            string K = strArr[1]; // Chuỗi K

            // Bước 1: Tạo một bảng đếm tần suất ký tự của K
            Dictionary<char, int> targetCharCount = new Dictionary<char, int>();
            foreach (char c in K)
            {
                if (targetCharCount.ContainsKey(c))
                    targetCharCount[c]++;
                else
                    targetCharCount[c] = 1;
            }

            // Bước 2: Biến để theo dõi cửa sổ trượt và tần suất ký tự
            Dictionary<char, int> windowCharCount = new Dictionary<char, int>();
            int start = 0, minLength = int.MaxValue, matched = 0;
            string minSubstring = "";

            // Bước 3: Duyệt qua từng ký tự trong chuỗi N
            for (int end = 0; end < N.Length; end++)
            {
                char endChar = N[end];

                // Nếu ký tự hiện tại là một phần của chuỗi K, cập nhật đếm của nó
                if (targetCharCount.ContainsKey(endChar))
                {
                    if (windowCharCount.ContainsKey(endChar))
                        windowCharCount[endChar]++;
                    else
                        windowCharCount[endChar] = 1;

                    // Kiểm tra nếu số lượng ký tự trong cửa sổ đã đạt yêu cầu của K
                    if (windowCharCount[endChar] <= targetCharCount[endChar])
                        matched++;
                }

                // Khi tất cả các ký tự trong K đã có mặt trong cửa sổ
                while (matched == K.Length)
                {
                    // Cập nhật độ dài nhỏ nhất và substring nhỏ nhất nếu tìm thấy
                    int windowLength = end - start + 1;
                    if (windowLength < minLength)
                    {
                        minLength = windowLength;
                        minSubstring = N.Substring(start, windowLength);
                    }

                    // Thu nhỏ cửa sổ bằng cách di chuyển con trỏ start
                    char startChar = N[start];
                    if (targetCharCount.ContainsKey(startChar))
                    {
                        if (windowCharCount[startChar] == targetCharCount[startChar])
                            matched--;
                        windowCharCount[startChar]--;
                    }
                    start++;
                }
            }

            // Nếu không tìm thấy đoạn con, trả về "false"
            return minSubstring == "" ? "false" : minSubstring;
        }
    }

}
