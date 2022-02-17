using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibManagementExam
{
    public enum Category { 
        Novels, Academic, Sports, GK
    }
    public class Book
    {
        public int serialNo;
        public string title;
        public string description;
        public string author;
        Category category;

        public Book(int serialNo, string title, string description, string author,Category category) {
            this.serialNo = serialNo;
            this.category = category;
            this.title = title;
            this.description = description;
            this.author = author;    
        }

        public override string ToString()
        {
            return "Title : " + this.title + "Description : " +this.description + "Author : " + this.author + "Category : " + this.category;
        }
    }
}
