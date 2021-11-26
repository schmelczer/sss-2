/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_connect_tcp_to_byte_21.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_connect_tcp_to_byte_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        double data;
        badPrivate = true;
        data = Bad_source();
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }

    private double Bad_source()
    {
        double data;
        if (badPrivate)
        {
            data = double.MinValue; /* Initialize data */
            /* Read data using an outbound tcp connection */
            {
                TcpClient tcpConn = null;
                StreamReader sr = null;
                try
                {
                    /* Read data using an outbound tcp connection */
                    tcpConn = new TcpClient("host.example.org", 39544);
                    /* read input from socket */
                    sr = new StreamReader(tcpConn.GetStream());
                    /* FLAW: Read data using an outbound tcp connection */
                    string stringNumber = sr.ReadLine();
                    if (stringNumber != null) /* avoid NPD incidental warnings */
                    {
                        try
                        {
                            data = double.Parse(stringNumber.Trim());
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
                    /* clean up stream reading objects */
                    try
                    {
                        if (sr != null)
                        {
                            sr.Close();
                        }
                    }
                    catch (IOException exceptIO)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing InputStreamReader");
                    }

                    /* clean up socket objects */
                    try
                    {
                        if (tcpConn != null)
                        {
                            tcpConn.Close();
                        }
                    }
                    catch (IOException exceptIO)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing Socket");
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0.0d;
        }
        return data;
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;

}
}
