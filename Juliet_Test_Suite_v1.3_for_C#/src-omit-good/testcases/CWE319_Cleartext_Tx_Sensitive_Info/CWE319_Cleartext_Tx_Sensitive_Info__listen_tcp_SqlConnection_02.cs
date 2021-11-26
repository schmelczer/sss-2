/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_02.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 319 Cleartext Transmission of Sensitive Information
* BadSource: listen_tcp Read password using a listening tcp connection
* GoodSource: Set password to a hardcoded value (one that was not sent over the network)
* Sinks: SqlConnection
*    GoodSink: Decrypt the password from the source before using it in database connection
*    BadSink : Use password directly from source in database connection
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

using System.Net.Sockets;
using System.Net;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string password;
        if (true)
        {
            password = ""; /* init password */
            /* Read data using a listening tcp connection */
            {
                TcpListener listener = null;
                try
                {
                    /* read input from socket */
                    listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                    listener.Start();
                    using (TcpClient tcpConn = listener.AcceptTcpClient())
                    {
                        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
                        {
                            /* POTENTIAL FLAW: Read password using a listening tcp connection */
                            password = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
                }
                finally
                {
                    try
                    {
                        if (listener != null)
                        {
                            listener.Stop();
                        }
                    }
                    catch (IOException exceptIO)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, "Error closing TcpListener", exceptIO);
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure password is inititialized before the Sink to avoid compiler errors */
            password = null;
        }
        if (true)
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
