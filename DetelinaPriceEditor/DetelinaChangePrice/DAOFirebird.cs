using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace DetelinaChangePrice
{
    public class DAOFirebird
    {
        private static readonly DAOFirebird instance = new DAOFirebird();
        private string connectionString = null;

        private DAOFirebird() { }

        public static DAOFirebird getInstance()
        {
            return instance;
        }

        public FbConnection getConnection()
        {
            if (connectionString == null)
            {
                this.connectionString = DetelinaChangePrice.Properties.Settings.Default.connectionString;
            }

            return new FbConnection(this.connectionString);
        }
    }
}
