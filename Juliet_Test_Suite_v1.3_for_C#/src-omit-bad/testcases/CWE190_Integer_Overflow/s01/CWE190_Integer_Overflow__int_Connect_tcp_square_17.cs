/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Connect_tcp_square_17.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: square
*    GoodSink: Ensure there will not be an overflow before squaring data
*    BadSink : Square data, which can lead to overflow
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Connect_tcp_square_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        int data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: if (data*data) > int.MaxValue, this will overflow */
            int result = (int)(data * data);
            IO.WriteLine("result: " + result);
        }
    }

    /* goodB2G() - use badsource and goodsink*/
    private void GoodB2G()
    {
        int data;
        data = int.MinValue; /* Initialize data */
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
                        /* POTENTIAL FLAW: Read data using an outbound tcp connection */
                        stringNumber = sr.ReadLine();
                    }
                }
                if (stringNumber != null) /* avoid NPD incidental warnings */
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
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        for (int k = 0; k < 1; k++)
        {
            /* FIX: Add a check to prevent an overflow from occurring */
            if (Math.Abs((long)data) <= (long)Math.Sqrt(int.MaxValue))
            {
                int result = (int)(data * data);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too large to perform squaring.");
            }
        }
    }

    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}