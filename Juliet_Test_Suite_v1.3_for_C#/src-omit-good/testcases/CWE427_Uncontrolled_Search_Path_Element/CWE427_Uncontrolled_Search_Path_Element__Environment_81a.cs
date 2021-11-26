/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__Environment_81a.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: Environment Read data from an environment variable
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__Environment_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        CWE427_Uncontrolled_Search_Path_Element__Environment_81_base baseObject = new CWE427_Uncontrolled_Search_Path_Element__Environment_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
