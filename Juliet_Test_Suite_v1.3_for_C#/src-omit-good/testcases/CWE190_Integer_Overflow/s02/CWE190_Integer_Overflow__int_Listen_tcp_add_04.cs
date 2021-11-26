/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Listen_tcp_add_04.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: Listen_tcp Read data using a listening tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Listen_tcp_add_04 : AbstractTestCase
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (PRIVATE_CONST_TRUE)
        {
            data = int.MinValue; /* Initialize data */
            /* Read data using a listening tcp connection */
            {
                TcpListener listener = null;
                /* Read data using a listening tcp connection */
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
                            string stringNumber = sr.ReadLine();
                            if (stringNumber != null) // avoid NPD incidental warnings
                            {
                                try
                                {
                                    data = int.Parse(stringNumber.Trim());
                                }
                                catch(FormatException exceptNumberFormat)
                                {
                                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                                }
                            }
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
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
                    catch(SocketException se)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, se, "Error closing TcpListener");
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (PRIVATE_CONST_TRUE)
        {
            /* POTENTIAL FLAW: if data == int.MaxValue, this will overflow */
            int result = (int)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
