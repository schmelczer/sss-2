/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__connect_tcp_SqlConnection_17.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 319 Cleartext Transmission of Sensitive Information
* BadSource: connect_tcp Read password using an outbound tcp connection
* GoodSource: Set password to a hardcoded value (one that was not sent over the network)
* Sinks: SqlConnection
*    GoodSink: Decrypt the password from the source before using it in database connection
*    BadSink : Use password directly from source in database connection
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

using System.Net.Sockets;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__connect_tcp_SqlConnection_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string password;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * password is uninitialized
         */
        password = ""; /* init password */
        /* Read data using an outbound tcp connection */
        {
            try
            {
                /* Read data using an outbound tcp connection */
                using (TcpClient tcpConn = new TcpClient("host.example.org", 39544))
                {
                    /* read input from socket */
                    using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                    {
                        /* POTENTIAL FLAW: Read password using an outbound tcp connection */
                        password = sr.ReadLine();
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
        }
        for (int j = 0; j < 1; j++)
        {
            try
            {
                /* POTENTIAL FLAW: use password directly in SqlConnection() */
                using (SqlConnection connection = new SqlConnection(@"Data Source=(local);Initial Catalog=CWE256;User ID=" + "sa" + ";Password=" + password))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("select * from test_table", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException exceptSql)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with database connection", exceptSql);
            }
        }
    }
#endif //omitbad

}
}
