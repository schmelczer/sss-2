/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_listen_tcp_to_short_67a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_listen_tcp_to_short_67a : AbstractTestCase
{

    public class Container
    {
        public long containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        data = long.MinValue; /* Initialize data */
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
                        data = long.Parse(stringNumber.Trim());
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
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE197_Numeric_Truncation_Error__long_listen_tcp_to_short_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
