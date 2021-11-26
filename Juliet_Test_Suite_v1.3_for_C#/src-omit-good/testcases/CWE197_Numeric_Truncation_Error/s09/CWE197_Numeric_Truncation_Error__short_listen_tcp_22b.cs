/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_listen_tcp_22b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__short_listen_tcp_22b
{
#if (!OMITBAD)
    public static short BadSource()
    {
        short data;
        if (CWE197_Numeric_Truncation_Error__short_listen_tcp_22a.badPublicStatic)
        {
            data = short.MinValue; /* Initialize data */
            /* Read data using a listening tcp connection */
            {
                TcpListener listener = null;
                TcpClient tcpConn = null;
                StreamReader sr = null;
                /* Read data using a listening tcp connection */
                try
                {
                    listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                    tcpConn = listener.AcceptTcpClient();
                    /* read input from socket */
                    sr = new StreamReader(tcpConn.GetStream());
                    /* FLAW: Read data using a listening tcp connection */
                    string stringNumber = sr.ReadLine();
                    if (stringNumber != null) // avoid NPD incidental warnings
                    {
                        try
                        {
                            data = short.Parse(stringNumber.Trim());
                        }
                        catch(FormatException exceptNumberFormat)
                        {
                            IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
                finally
                {
                    /* Close stream reading objects */
                    try
                    {
                        if (sr != null)
                        {
                            sr.Close();
                        }
                    }
                    catch (IOException exceptIO)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing StreamReader");
                    }

                    /* Close socket objects */
                    try
                    {
                        if (tcpConn != null)
                        {
                            tcpConn.Close();
                        }
                    }
                    catch (IOException exceptIO)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing TcpClient");
                    }

                    try
                    {
                        if (listener != null)
                        {
                            listener.Stop();
                        }
                    }
                    catch (IOException exceptIO)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing TcpListener");
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
        return data;
    }
#endif


}
}
