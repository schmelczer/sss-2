/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__Get_Cookies_Web_31.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-31.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : read line from file from disk
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;


namespace testcases.CWE36_Absolute_Path_Traversal
{

class CWE36_Absolute_Path_Traversal__Get_Cookies_Web_31 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string dataCopy;
        {
            string data;
            data = ""; /* initialize data in case there are no cookies */
            /* Read data from cookies */
            {
                HttpCookieCollection cookieSources = req.Cookies;
                if (cookieSources != null)
                {
                    /* POTENTIAL FLAW: Read data from the first cookie value */
                    data = cookieSources[0].Value;
                }
            }
            dataCopy = data;
        }
        {
            string data = dataCopy;
            /* POTENTIAL FLAW: unvalidated or sandboxed value */
            if (data != null)
            {
                if (File.Exists(data))
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(data))
                        {
                            IO.WriteLine(sr.ReadLine());
                        }
                    }
                    catch (IOException exceptIO)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                    }
                }
            }
        }
    }
#endif //omitbad

}
}
