/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__Environment_Format_53b.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-53b.tmpl.cs
*/
/*
 * @description
 * CWE: 134 Externally Controlled Format String
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks: Format
 *    GoodSink: console write formatted using string.Format
 *    BadSink : console write formatted without validation
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__Environment_Format_53b
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE134_Externally_Controlled_Format_String__Environment_Format_53c.BadSink(data );
    }
#endif


}
}
