/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_connect_tcp_to_int_07.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-07.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_int Convert data to a int
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_connect_tcp_to_int_07 : AbstractTestCase
{

    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        long data;
        if (privateFive == 5)
        {
            data = long.MinValue; /* Initialize data */
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
            data = 0L;
        }
        {
            /* POTENTIAL FLAW: Convert data to a int, possibly causing a truncation error */
            IO.WriteLine((int)data);
        }
    }
#endif //omitbad

}
}
