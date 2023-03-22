using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Text;
using FreelanceProject.Core.Common;

namespace FreelanceProject.infra.Common
{
    public class DBContaxt: IDBContaxt
    {
        private DbConnection _Connection;
        private readonly IConfiguration _configuration;
        public DBContaxt(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new OracleConnection(_configuration["ConnectionStrings:DefaultConnection"]);
                    _Connection.Open();
                }
                else if (_Connection.State != ConnectionState.Open)
                {
                    _Connection.Open();
                }
                return _Connection;
            }
        }

        
    }
}
