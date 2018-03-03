using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    [Serializable]
    public class Library
    {
        public static Book[] collection = new Book[10];
        public static Student[] bookworm = new Student[5];



        //FileStream fs = new FileStream("file.dat", FileMode.Open);
        //BinaryFormatter frmttr = new BinaryFormatter();

        //collection[0] = (Book[])frmttr.Deserialize(fs);

        //     //Library.collection[0] = (Book)frmttr.Deserialize(fs);
        //    fs.Close();



        public string SearchBook(string a)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == null)
                    break;
                if (collection[i].ISBN == a && collection[i].Available == true)
                {
                    return i.ToString();
                }
            }
            return "-1";
        }



        public string IssueBook(Book a)
        {
            if (a.Available != false)
            {
                a.Available = false;
                return "issued";
            }
            return "not available to issue";
        }

        public void AddBook(Book a)
        {
            for (int i = 0; i < Library.collection.Length; i++)
            {
                if (Library.collection[i] != null)
                {
                    Library.collection[i] = a;
                }
            }
        }
        public static void ReturnBook(Book a)
        {
            if (a.Available == false)
            {
                a.Available = true;
                Library.bookworm[0] = null;
            }
        }

        public Book DeleteBook(string a)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == null)
                {
                    break;
                }
                if (collection[i].ISBN == a && collection[i].Available == true)
                {
                    return (collection[i] = null);
                }

            }
            return (new Book(null, null, null, null));
        }

        public void AddStdnt(Student a)
        {
            for (int i = 0; i < bookworm.Length; i++)
            {
                if (bookworm[i] != null)
                {
                    bookworm[i] = a;
                }
            }
        }

        public Student DeleteStdnt(string a)
        {
            for (int i = 0; i < bookworm.Length; i++)
            {
                if (bookworm[i] == null)
                {
                    break;
                }
                else if (bookworm[i].StID == a)
                {
                    return (bookworm[i] = null);
                }
            }
            return (new Student(null, null));
        }


        public bool StdntIssueBook(string a, string b)
        {
            for (int j = 0; j < bookworm.Length; j++)
            {
                if (bookworm[j].issued == false)
                {
                    for (int i = 0; i < collection.Length; i++)
                    {
                        if (collection[i].ISBN == b)
                        {
                            collection[i].Available = false;
                            bookworm[j].issued = true;
                            return true;
                        }

                    }

                }
            }
            return false;


        }
    }
}