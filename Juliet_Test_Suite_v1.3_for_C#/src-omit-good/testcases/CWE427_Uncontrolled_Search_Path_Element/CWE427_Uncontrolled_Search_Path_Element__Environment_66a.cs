/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__Environment_66a.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: Environment Read data from an environment variable
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__Environment_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override  void Bad()
    {
        string data;
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE427_Uncontrolled_Search_Path_Element__Environment_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
