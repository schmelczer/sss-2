/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_51a.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * BadSink: NetworkCredential data used as password in NetworkCredential()
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_51a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* FLAW: Set data to a hardcoded string */
        data = "7e5tc4s3";
        CWE259_Hard_Coded_Password__NetworkCredential_51b.BadSink(data  );
    }
#endif //omitbad

}
}
