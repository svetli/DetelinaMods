using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace DetelinaReport
{
    public class daoFirebird
    {
        private static readonly daoFirebird instance = new daoFirebird();
        
        private daoFirebird(){}

        public static daoFirebird getInstance()
        {
            return instance;
        }

        public FbConnection getConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["FirebirdConnectionString"].ToString();
            return new FbConnection(connection);
        }
    }
}
