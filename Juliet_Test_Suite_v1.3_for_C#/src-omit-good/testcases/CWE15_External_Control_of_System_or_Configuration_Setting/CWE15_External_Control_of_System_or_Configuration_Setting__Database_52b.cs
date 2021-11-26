/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE15_External_Control_of_System_or_Configuration_Setting__Database_52b.cs
Label Definition File: CWE15_External_Control_of_System_or_Configuration_Setting.label.xml
Template File: sources-sink-52b.tmpl.cs
*/
/*
 * @description
 * CWE: 15 External Control of System or Configuration Setting
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : Set the catalog name with the value of data
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE15_External_Control_of_System_or_Configuration_Setting
{
class CWE15_External_Control_of_System_or_Configuration_Setting__Database_52b
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE15_External_Control_of_System_or_Configuration_Setting__Database_52c.BadSink(data );
    }
#endif


}
}