/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Listen_tcp_write_74a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Listen_tcp Read count using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Listen_tcp_write_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        count = int.MinValue; /* Initialize count */
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
                        /* POTENTIAL FLAW: Read count using a listening tcp connection */
                        string stringNumber = sr.ReadLine();
                        if (stringNumber != null) // avoid NPD incidental warnings
                        {
                            try
                            {
                                count = int.Parse(stringNumber.Trim());
                            }
                            catch(FormatException exceptNumberFormat)
                            {
                                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing count from string");
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
        Dictionary<int,int> countDictionary = new Dictionary<int,int>();
        countDictionary.Add(0, count);
        countDictionary.Add(1, count);
        countDictionary.Add(2, count);
        CWE400_Uncontrolled_Resource_Consumption__Listen_tcp_write_74b.BadSink(countDictionary  );
    }
#endif //omitbad

}
}
