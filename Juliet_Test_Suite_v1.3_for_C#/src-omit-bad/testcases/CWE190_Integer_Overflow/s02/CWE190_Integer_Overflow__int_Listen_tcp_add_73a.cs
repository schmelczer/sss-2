/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Listen_tcp_add_73a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Listen_tcp_add_73a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use GoodSource and BadSink */
    private static void GoodG2B()
    {
        int data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        LinkedList<int> dataLinkedList = new LinkedList<int>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE190_Integer_Overflow__int_Listen_tcp_add_73b.GoodG2BSink(dataLinkedList  );
    }

    /* goodB2G() - use BadSource and GoodSink */
    private static void GoodB2G()
    {
        int data;
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
        LinkedList<int> dataLinkedList = new LinkedList<int>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE190_Integer_Overflow__int_Listen_tcp_add_73b.GoodB2GSink(dataLinkedList  );
    }
#endif //omitgood
}
}
