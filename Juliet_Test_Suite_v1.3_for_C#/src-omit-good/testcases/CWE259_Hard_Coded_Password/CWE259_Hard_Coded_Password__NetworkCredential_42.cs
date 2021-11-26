/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_42.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-42.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * BadSink: NetworkCredential data used as password in NetworkCredential()
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Net;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static string BadSource()
    {
        string data;
        /* FLAW: Set data to a hardcoded string */
        data = "7e5tc4s3";
        return data;
    }

    /* use badsource and badsink */
    public override void Bad()
    {
        string data = BadSource();
        if (data != null)
        {
            /* POTENTIAL FLAW: data used as password in NetworkCredential() */
            NetworkCredential credentials = new NetworkCredential("user", data, "domain");
            IO.WriteLine(credentials.ToString());
        }
    }
#endif //omitbad

}
}
