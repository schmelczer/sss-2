/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__SqlConnection_54a.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: SqlConnection
 *    BadSink : data used as password in database connection
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__SqlConnection_54a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        string data;
        data = ""; /* init data */
        /* FIX: Read data from the console using ReadLine() */
        try
        {
            /* POTENTIAL FLAW: Read data from the console using ReadLine */
            data = Console.ReadLine();
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
        }
        CWE259_Hard_Coded_Password__SqlConnection_54b.GoodG2BSink(data );
    }
#endif //omitgood
}
}
