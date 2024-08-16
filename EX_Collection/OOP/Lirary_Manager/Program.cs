// See https://aka.ms/new-console-template for more information
using Lirary_Manager;

Console.WriteLine("Hello, World!");
/*
 * Bài tập 1: Quản lý thư viện
    Xây dựng một hệ thống quản lý thư viện đơn giản với các lớp Book, 
    Author, và Library. Mỗi Book có thuộc tính như Title, Author, ISBN, 
    và PublishedYear. Mỗi Author có các thuộc tính như Name, DateOfBirth, 
    và danh sách các Book mà họ đã viết.

    Yêu cầu:
    - Thêm, xóa, tìm kiếm sách trong thư viện.
    - Tìm kiếm sách theo tên tác giả.
    - In ra danh sách các cuốn sách theo thứ tự năm xuất bản.

>> tiến trình: hoàn thành thêm, xoá, sửa sách
 */
Library library = new Library();  // Tạo đối tượng thư viện
LibraryService libraryService = new LibraryService(library);  // Tạo dịch vụ quản lý thư viện
LibraryManager libraryManager = new LibraryManager(libraryService);  // Tạo đối tượng quản lý thư viện

// Bắt đầu chương trình quản lý thư viện
libraryManager.Start();