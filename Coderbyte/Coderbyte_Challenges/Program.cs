// See https://aka.ms/new-console-template for more information
using Coderbyte_Challenges;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // doing doing = new doing();
       /* Console.WriteLine(doing.FindIntersection(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" }));  // Output: "1,4,13"
        Console.WriteLine(doing.FindIntersection(new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }));  // Output: "1,9,10"
        Console.WriteLine(doing.FindIntersection(new string[] { "5, 6, 7", "8, 9, 10" }));  // Output: "false"*/

        // Test case cho hàm FindIntersection từ class doing
       /* Console.WriteLine(doing.FindIntersection(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" }));  // Output: "1,4,13"
        Console.WriteLine(doing.FindIntersection(new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }));  // Output: "1,9,10"
        Console.WriteLine(doing.FindIntersection(new string[] { "1, 2, 3", "4, 5, 6" }));  // Output: "false"*/
        

        // Test case cho hàm CodelandUsernameValidation từ class doing
        Console.WriteLine(doing.CodelandUsernameValidation("aa_"));  // Output: false
        Console.WriteLine(doing.CodelandUsernameValidation("u__hello_world123"));  // Output: true
        Console.WriteLine(doing.CodelandUsernameValidation("username123_"));  // Output: false
        Console.WriteLine(doing.CodelandUsernameValidation("UsernameValid123"));  // Output: true
        Console.WriteLine(doing.CodelandUsernameValidation("user_name_"));  // Output: false

        // Tìm đoạn con nhỏ nhất trong chuỗi N chứa tất cả ký tự của chuỗi K
        Console.WriteLine(doing.MinWindowSubstring(new string[] { "aaabaaddae", "aed" }));  // Output: "dae"
        Console.WriteLine(doing.MinWindowSubstring(new string[] { "aabdccdbcacd", "aad" }));  // Output: "aabd"
        Console.WriteLine(doing.MinWindowSubstring(new string[] { "ahffaksfajeeubsne", "jefaa" }));  // Output: "aksfaje"
        Console.WriteLine(doing.MinWindowSubstring(new string[] { "aaffhkksemckelloe", "fhea" }));  // Output: "affhkkse"


        Console.ReadLine();
    }
}