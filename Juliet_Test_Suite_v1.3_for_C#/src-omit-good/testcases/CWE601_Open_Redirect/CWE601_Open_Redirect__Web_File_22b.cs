/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_File_22b.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_File_22b
{
#if (!OMITBAD)
    public static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE601_Open_Redirect__Web_File_22a.badPublicStatic)
        {
            data = ""; /* Initialize data */
            {
                try
                {
                    /* read string from file into data */
                    using (StreamReader sr = new StreamReader("data.txt"))
                    {
                        /* POTENTIAL FLAW: Read data from a file */
                        /* This will be reading the first "line" of the file, which
                         * could be very long if there are little or no newlines in the file */
                        data = sr.ReadLine();
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
            data = null;
        }
        return data;
    }
#endif


}
}