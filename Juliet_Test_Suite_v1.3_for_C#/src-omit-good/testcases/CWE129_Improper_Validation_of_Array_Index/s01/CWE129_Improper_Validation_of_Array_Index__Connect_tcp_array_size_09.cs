/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Connect_tcp_array_size_09.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-09.tmpl.cs
*/
/*
* @description
* CWE: 129 Improper Validation of Array Index
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: array_size
*    GoodSink: data is used to set the size of the array and it must be greater than 0
*    BadSink : data is used to set the size of the array, but it could be set to 0
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Connect_tcp_array_size_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        if (IO.STATIC_READONLY_TRUE)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (IO.STATIC_READONLY_TRUE)
        {
            int[] array = null;
            /* POTENTIAL FLAW: Verify that data is non-negative, but still allow it to be 0 */
            if (data >= 0)
            {
                array = new int[data];
            }
            else
            {
                IO.WriteLine("Array size is negative");
            }
            /* do something with the array */
            array[0] = 5;
            IO.WriteLine(array[0]);
        }
    }
#endif //omitbad

}
}
