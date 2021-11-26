/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE129_Improper_Validation_of_Array_Index__Connect_tcp_array_size_52a.cs
Label Definition File: CWE129_Improper_Validation_of_Array_Index.label.xml
Template File: sources-sinks-52a.tmpl.cs
*/
/*
 * @description
 * CWE: 129 Improper Validation of Array Index
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: array_size
 *    GoodSink: data is used to set the size of the array and it must be greater than 0
 *    BadSink : data is used to set the size of the array, but it could be set to 0
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE129_Improper_Validation_of_Array_Index
{
class CWE129_Improper_Validation_of_Array_Index__Connect_tcp_array_size_52a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
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
        CWE129_Improper_Validation_of_Array_Index__Connect_tcp_array_size_52b.BadSink(data );
    }
#endif //omitbad

}
}
