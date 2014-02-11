using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetelinaReport
{
    class Bon
    {
        public Bon(int id, string date)
        {
            ID = id;
            Date = date;
        }

        public int ID
        {
            set;
            get;
        }

        public string Date
        {
            set;
            get;
        }
    }
}
