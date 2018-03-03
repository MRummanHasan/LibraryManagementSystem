using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    [Serializable]
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AccNo { get; set; }
        public bool Available { get; set; }
        
        public Book()
        {

        }

        public Book(string _accNo, string _isbn, string _name, string _author)
        {
            AccNo = _accNo;
            ISBN = _isbn;
            Title = _name;
            Author = _author;
            Available = true;
        }

        public bool checkIfEmpty(string accno, string isbn, string title, string author)
        {
            if(accno == string.Empty && isbn == string.Empty && title == string.Empty && author == string.Empty)
            {
                return false;
            }
            return true;
        }

    }
    

}
