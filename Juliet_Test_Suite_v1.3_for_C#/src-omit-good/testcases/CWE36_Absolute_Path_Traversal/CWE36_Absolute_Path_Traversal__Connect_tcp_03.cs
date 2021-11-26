/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__Connect_tcp_03.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 36 Absolute Path Traversal
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded string
* BadSink: readFile read line from file from disk
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

using System.Net.Sockets;

namespace testcases.CWE36_Absolute_Path_Traversal
{

class CWE36_Absolute_Path_Traversal__Connect_tcp_03 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        if (5 == 5)
        {
            data = ""; /* Initialize data */
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
                            /* POTENTIAL FLAW: Read data using an outbound tcp connection */
                            data = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        /* POTENTIAL FLAW: unvalidated or sandboxed value */
        if (data != null)
        {
            if (File.Exists(data))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(data))
                    {
                        IO.WriteLine(sr.ReadLine());
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
    }
#endif //omitbad

}
}
