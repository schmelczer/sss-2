/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_53a.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: NetworkCredential
 *    BadSink : data used as password in NetworkCredential()
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_53a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* FLAW: Set data to a hardcoded string */
        data = "7e5tc4s3";
        CWE259_Hard_Coded_Password__NetworkCredential_53b.BadSink(data );
    }
#endif //omitbad

}
}
