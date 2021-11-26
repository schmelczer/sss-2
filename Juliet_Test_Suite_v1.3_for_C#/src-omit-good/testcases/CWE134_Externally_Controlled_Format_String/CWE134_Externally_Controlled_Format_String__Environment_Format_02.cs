/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__Environment_Format_02.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 134 Externally Controlled Format String
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded string
* Sinks: Format
*    GoodSink: console write formatted using string.Format
*    BadSink : console write formatted without validation
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__Environment_Format_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (true)
        {
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (true)
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
