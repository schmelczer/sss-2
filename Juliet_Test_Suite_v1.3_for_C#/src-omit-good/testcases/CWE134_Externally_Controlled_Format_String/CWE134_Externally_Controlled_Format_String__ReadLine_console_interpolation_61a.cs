/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__ReadLine_console_interpolation_61a.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 134 Externally Controlled Format String
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: console_interpolation
 *    GoodSink: console write with interpolation
 *    BadSink : console write formatted without validation
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__ReadLine_console_interpolation_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data = CWE134_Externally_Controlled_Format_String__ReadLine_console_interpolation_61b.BadSource();
        if (data != null)
        {
            /* POTENTIAL FLAW: uncontrolled string formatting */
            Console.Write(string.Format(data));
        }
    }
#endif //omitbad

}
}
