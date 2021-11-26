/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__ReadLine_72a.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__ReadLine_72a : AbstractTestCase
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
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE117_Improper_Output_Neutralization_for_Logs__ReadLine_72b.BadSink(dataHashtable  );
    }
#endif //omitbad

}
}
