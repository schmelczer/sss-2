/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__Listen_tcp_21.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : read line from file from disk
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

using System.Net.Sockets;
using System.Net;

namespace testcases.CWE36_Absolute_Path_Traversal
{

class CWE36_Absolute_Path_Traversal__Listen_tcp_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        badPrivate = true;
        data = Bad_source();
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

    private string Bad_source()
    {
        string data;
        if (badPrivate)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;

}
}
