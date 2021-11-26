/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_45.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: NetworkCredential
 *    BadSink : data used as password in NetworkCredential()
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Net;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_45 : AbstractTestCase
{

    private string dataBad;
    private string dataGoodG2B;
#if (!OMITBAD)
    private void BadSink()
    {
        string data = dataBad;
        if (data != null)
        {
            /* POTENTIAL FLAW: data used as password in NetworkCredential() */
            NetworkCredential credentials = new NetworkCredential("user", data, "domain");
            IO.WriteLine(credentials.ToString());
        }
    }

    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        /* FLAW: Set data to a hardcoded string */
        data = "7e5tc4s3";
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
