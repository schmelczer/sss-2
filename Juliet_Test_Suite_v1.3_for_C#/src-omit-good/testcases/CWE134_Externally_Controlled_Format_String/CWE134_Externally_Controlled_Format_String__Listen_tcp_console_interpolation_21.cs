/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__Listen_tcp_console_interpolation_21.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 134 Externally Controlled Format String
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks: console_interpolation
 *    GoodSink: console write with interpolation
 *    BadSink : console write formatted without validation
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__Listen_tcp_console_interpolation_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
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
        badPrivate = true;
        BadSink(data );
    }

    private void BadSink(string data )
    {
        if (badPrivate)
        {
            if (data != null)
            {
                /* POTENTIAL FLAW: uncontrolled string formatting */
                Console.Write(string.Format(data));
            }
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}
