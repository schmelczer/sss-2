/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Listen_tcp_multiply_09.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: Listen_tcp Read data using a listening tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an underflow before multiplying data by 2
*    BadSink : If data is negative, multiply by 2, which can cause an underflow
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Listen_tcp_multiply_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (IO.STATIC_READONLY_TRUE)
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
        if (IO.STATIC_READONLY_TRUE)
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < int.MinValue, this will underflow */
                int result = (int)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
