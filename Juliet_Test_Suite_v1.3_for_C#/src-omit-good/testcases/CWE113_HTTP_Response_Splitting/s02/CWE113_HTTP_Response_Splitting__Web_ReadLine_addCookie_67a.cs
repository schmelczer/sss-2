/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_ReadLine_addCookie_67a.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: addCookie
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AppendCookie()
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

using System.IO;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_ReadLine_addCookie_67a : AbstractTestCaseWeb
{

    public class Container
    {
        public string containerOne;
    }
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE113_HTTP_Response_Splitting__Web_ReadLine_addCookie_67b.BadSink(dataContainer , req, resp );
    }
#endif //omitbad

}
}