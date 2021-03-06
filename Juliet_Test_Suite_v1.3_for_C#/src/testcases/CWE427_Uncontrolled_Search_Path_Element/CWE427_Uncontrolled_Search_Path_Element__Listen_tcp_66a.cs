/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_66a.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override  void Bad()
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
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_66b.BadSink(dataArray  );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        string data;
        /* FIX: Set the path as the "system" path */
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            data = "/bin";
        }
        else
        {
            data = "%SystemRoot%\\system32";
        }
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_66b.GoodG2BSink(dataArray  );
    }
#endif //omitgood
}
}
