/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_Connect_tcp_12.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 400 Uncontrolled Resource Consumption
* BadSource: Connect_tcp Read count using an outbound tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks:
*    GoodSink: Validate count before using it as a parameter in sleep function
*    BadSink : Use count as the parameter for sleep withhout checking it's size first
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Threading;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_Connect_tcp_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        if(IO.StaticReturnsTrueOrFalse())
        {
            count = int.MinValue; /* Initialize count */
            /* Read data using an outbound tcp connection */
            {
                try
                {
                    String stringNumber = "";
                    /* Read data using an outbound tcp connection */
                    using (TcpClient tcpConn = new TcpClient("host.example.org", 39544))
                    {
                        /* read input from socket */
                        using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                        {
                            /* POTENTIAL FLAW: Read count using an outbound tcp connection */
                            stringNumber = sr.ReadLine();
                        }
                    }
                    if (stringNumber != null) /* avoid NPD incidental warnings */
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
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
        else
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            count = 2;
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Use count as the input to Thread.Sleep() */
            Thread.Sleep(count);
        }
        else
        {
            /* FIX: Validate count before using it in a call to Thread.Sleep() */
            if (count > 0 && count <= 2000)
            {
                Thread.Sleep(count);
            }
        }
    }
#endif //omitbad

}
}
