/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE15_External_Control_of_System_or_Configuration_Setting__ReadLine_54a.cs
Label Definition File: CWE15_External_Control_of_System_or_Configuration_Setting.label.xml
Template File: sources-sink-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 15 External Control of System or Configuration Setting
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : Set the catalog name with the value of data
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE15_External_Control_of_System_or_Configuration_Setting
{

class CWE15_External_Control_of_System_or_Configuration_Setting__ReadLine_54a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        data = ""; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        CWE15_External_Control_of_System_or_Configuration_Setting__ReadLine_54b.BadSink(data );
    }
#endif //omitbad

}
}
