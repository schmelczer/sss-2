/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_File_07.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-07.tmpl.cs
*/
/*
* @description
* CWE: 80 Cross Site Scripting (XSS)
* BadSource: File Read data from file (named data.txt)
* GoodSource: A hardcoded string
* BadSink: Web Display of data in web page without any encoding or validation
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE80_XSS
{

class CWE80_XSS__Web_File_07 : AbstractTestCaseWeb
{

    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (privateFive == 5)
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
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
            resp.Write("<br>Bad(): data = " + data);
        }
    }
#endif //omitbad

}
}
