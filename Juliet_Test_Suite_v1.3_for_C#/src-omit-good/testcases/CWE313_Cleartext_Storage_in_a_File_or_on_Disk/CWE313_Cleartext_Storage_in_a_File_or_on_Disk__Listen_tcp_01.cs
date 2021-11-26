/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Listen_tcp_01.cs
Label Definition File: CWE313_Cleartext_Storage_in_a_File_or_on_Disk.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 313 Cleartext storage in a File or on Disk
* BadSource: Listen_tcp Read data using a listening tcp connection
* GoodSource: A hardcoded string
* Sinks:
*    GoodSink: Hash data before storing in registry
*    BadSink : Store data directly in a file
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Web;

using System.Net.Sockets;
using System.Net;

namespace testcases.CWE313_Cleartext_Storage_in_a_File_or_on_Disk
{
class CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Listen_tcp_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        data = ""; /* Initialize data */
        /* Read data using a listening tcp connection */
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                listener.Start();
                using (TcpClient tcpConn = listener.AcceptTcpClient())
                {
                    /* read input from socket */
                    using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                    {
                        /* POTENTIAL FLAW: Read data using a listening tcp connection */
                        data = sr.ReadLine();
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
            finally
            {
                if (listener != null)
                {
                    try
                    {
                        listener.Stop();
                    }
                    catch(SocketException se)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, se, "Error closing TcpListener");
                    }
                }
            }
        }
        using (SecureString secureData = new SecureString())
        {
            for (int i = 0; i < data.Length; i++)
            {
                secureData.AppendChar(data[i]);
            }
            /* POTENTIAL FLAW: Store data directly in a file */
            File.WriteAllText(@"C:\Users\Public\WriteText.txt", secureData.ToString());
        }
    }
#endif //omitbad

}
}
