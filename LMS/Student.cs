using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    [Serializable]
    public class Student
    {
        public string StID { get; set; }
        public string StName { get; set; }
        public bool issued = false;

        public Student(string _stid, string _stname)
        {
            StID = _stid;
            StName = _stname;
        }
    }
}
