using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetelinaReport
{
    class User
    {
        public User(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
