/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__Environment_console_interpolation_15.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 134 Externally Controlled Format String
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded string
* Sinks: console_interpolation
*    GoodSink: console write with interpolation
*    BadSink : console write formatted without validation
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__Environment_console_interpolation_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        switch (6)
        {
        case 6:
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        switch (7)
        {
        case 7:
            if (data != null)
            {
                /* POTENTIAL FLAW: uncontrolled string formatting */
                Console.Write(string.Format(data));
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
