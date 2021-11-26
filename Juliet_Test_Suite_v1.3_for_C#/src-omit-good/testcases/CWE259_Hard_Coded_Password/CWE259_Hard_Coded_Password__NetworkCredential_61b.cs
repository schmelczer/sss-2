/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_61b.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: NetworkCredential
 *    BadSink : data used as password in NetworkCredential()
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_61b
{
#if (!OMITBAD)
    public static string BadSource()
    {
        string data;
        /* FLAW: Set data to a hardcoded string */
        data = "7e5tc4s3";
        return data;
    }
#endif


}
}
