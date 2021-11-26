/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__NetClient_52b.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-52b.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__NetClient_52b
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE606_Unchecked_Loop_Condition__NetClient_52c.BadSink(data );
    }
#endif


}
}
