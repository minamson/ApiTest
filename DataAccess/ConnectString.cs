using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DataAccess
{

    public class ConnectString
    {
        //private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
        //                            (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = system; Password = system123;";

        //string cn = string.Format(@"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = TESTDB))); User ID=MINAMSON; Password=thsalska;");
        public string OracleConnectString { get; set; }

        public ConnectString(string host, uint port, string sid, string id, string pw) {
            string cn = string.Format(@"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)HOST = {1})(PORT = {2}}))(CONNECT_DATA = (SERVICE_NAME = {3}))); User ID={4};Password=thsalska;", host, port.ToString(), sid, id, pw);
            this.OracleConnectString = cn;
        }

    }
}
