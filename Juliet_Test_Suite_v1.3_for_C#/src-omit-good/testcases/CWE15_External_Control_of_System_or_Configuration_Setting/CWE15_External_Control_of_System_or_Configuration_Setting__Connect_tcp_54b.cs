/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE15_External_Control_of_System_or_Configuration_Setting__Connect_tcp_54b.cs
Label Definition File: CWE15_External_Control_of_System_or_Configuration_Setting.label.xml
Template File: sources-sink-54b.tmpl.cs
*/
/*
 * @description
 * CWE: 15 External Control of System or Configuration Setting
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : Set the catalog name with the value of data
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE15_External_Control_of_System_or_Configuration_Setting
{
class CWE15_External_Control_of_System_or_Configuration_Setting__Connect_tcp_54b
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE15_External_Control_of_System_or_Configuration_Setting__Connect_tcp_54c.BadSink(data );
    }
#endif


}
}
