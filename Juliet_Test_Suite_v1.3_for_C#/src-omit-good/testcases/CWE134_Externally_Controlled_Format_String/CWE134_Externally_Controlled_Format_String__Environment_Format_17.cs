/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__Environment_Format_17.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 134 Externally Controlled Format String
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded string
* Sinks: Format
*    GoodSink: console write formatted using string.Format
*    BadSink : console write formatted without validation
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__Environment_Format_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        for (int j = 0; j < 1; j++)
        {
            if (data != null)
            {
                /* POTENTIAL FLAW: uncontrolled string formatting */
                Console.Write(string.Format(data));
            }
        }
    }
#endif //omitbad

}
}
