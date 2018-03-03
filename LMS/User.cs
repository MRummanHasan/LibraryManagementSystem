using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string ID { get; set; }
        // CONSTRUCTOR
        public User(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }
    }

}
