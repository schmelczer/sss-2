/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_NetClient_to_long_45.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_long
 *    BadSink : Convert data to a long
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_NetClient_to_long_45 : AbstractTestCase
{

    private float dataBad;
    private float dataGoodG2B;
#if (!OMITBAD)
    private void BadSink()
    {
        float data = dataBad;
        {
            /* POTENTIAL FLAW: Convert data to a long, possibly causing a truncation error */
            IO.WriteLine((long)data);
        }
    }

    /* uses badsource and badsink */
    public override void Bad()
    {
        float data;
        data = float.MinValue; /* Initialize data */
        /* read input from WebClient */
        {
            WebClient client = new WebClient();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(client.OpenRead("http://www.example.org/"));
                /* FLAW: Read data from a web server with WebClient */
                /* This will be reading the first "line" of the response body,
                 * which could be very long if there are no newlines in the HTML */
                string stringNumber = sr.ReadLine();
                if (stringNumber != null) // avoid NPD incidental warnings
                {
                    try
                    {
                        data = float.Parse(stringNumber.Trim());
                    }
                    catch (FormatException exceptNumberFormat)
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
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing StreamReader");
                }
            }
        }
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
