/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_connect_tcp_to_float_45.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_float
 *    BadSink : Convert data to a float
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_connect_tcp_to_float_45 : AbstractTestCase
{

    private double dataBad;
    private double dataGoodG2B;
#if (!OMITBAD)
    private void BadSink()
    {
        double data = dataBad;
        {
            /* POTENTIAL FLAW: Convert data to a float, possibly causing a truncation error */
            IO.WriteLine((float)data);
        }
    }

    /* uses badsource and badsink */
    public override void Bad()
    {
        double data;
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
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}