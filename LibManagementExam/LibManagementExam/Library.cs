using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibManagementExam
{
    public class Library
    {
        List<Book> books;

        public Library(List<Book> books) {
            this.books = books;
        }

        public void ShowBooks() {
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        public List<Book> GetAllBooks() { 
            return books;
        }

        public Book SearchBook(int sNo)
        {
            Book result = null;
            foreach (Book book in books)
            {
                if (book.serialNo == sNo)
                {
                    result = book;
                    break;
                }
            }

            return result;
        }
    }
}
