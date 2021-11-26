/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__NetworkCredential_22b.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: NetworkCredential
 *    BadSink : data used as password in NetworkCredential()
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__NetworkCredential_22b
{
#if (!OMITBAD)
    public static string BadSource()
    {
        string data;
        if (CWE259_Hard_Coded_Password__NetworkCredential_22a.badPublicStatic)
        {
            /* FLAW: Set data to a hardcoded string */
            data = "7e5tc4s3";
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
