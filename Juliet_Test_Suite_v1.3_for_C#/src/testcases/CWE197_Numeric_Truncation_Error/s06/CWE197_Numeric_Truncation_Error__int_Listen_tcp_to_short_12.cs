/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_Listen_tcp_to_short_12.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-12.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: Listen_tcp Read data using a listening tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_short Convert data to a short
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__int_Listen_tcp_to_short_12 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink - see how tools report flaws that don't always occur */
    public override void Bad()
    {
        int data;
        if (IO.StaticReturnsTrueOrFalse())
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
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        {
            /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
            IO.WriteLine((short)data);
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by changing the "if" so that
     * both branches use the GoodSource */
    private void GoodG2B()
    {
        int data;
        if (IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        else
        {
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
        }
        {
            /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
            IO.WriteLine((short)data);
        }
    }

    public override void Good()
    {
        GoodG2B();
    }
#endif //omitgood
}
}
