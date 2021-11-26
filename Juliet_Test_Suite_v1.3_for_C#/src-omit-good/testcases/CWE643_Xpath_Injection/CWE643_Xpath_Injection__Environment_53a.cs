/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Environment_53a.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__Environment_53a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        CWE643_Xpath_Injection__Environment_53b.BadSink(data );
    }
#endif //omitbad

}
}
