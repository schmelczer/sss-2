/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_71a.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 319 Cleartext Transmission of Sensitive Information
 * BadSource: listen_tcp Read password using a listening tcp connection
 * GoodSource: Set password to a hardcoded value (one that was not sent over the network)
 * Sinks: SqlConnection
 *    GoodSink: Decrypt the password from the source before using it in database connection
 *    BadSink : Use password directly from source in database connection
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_71a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        string password;
        /* FIX: Use a hardcoded password as the password (it was not sent over the network) */
        /* INCIDENTAL FLAW: CWE-259 Hard Coded Password */
        password = "Password1234!";
        CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_71b.GoodG2BSink((Object)password  );
    }

    /* goodB2G() - use badsource and goodsink */
    private static void GoodB2G()
    {
        string password;
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
        CWE319_Cleartext_Tx_Sensitive_Info__listen_tcp_SqlConnection_71b.GoodB2GSink((Object)password  );
    }
#endif //omitgood
}
}
