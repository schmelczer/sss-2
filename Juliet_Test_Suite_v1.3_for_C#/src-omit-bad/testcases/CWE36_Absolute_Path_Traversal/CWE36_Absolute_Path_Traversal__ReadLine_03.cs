/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__ReadLine_03.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 36 Absolute Path Traversal
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: A hardcoded string
* BadSink: readFile read line from file from disk
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;


namespace testcases.CWE36_Absolute_Path_Traversal
{

class CWE36_Absolute_Path_Traversal__ReadLine_03 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing 5==5 to 5!=5 */
    private void GoodG2B1()
    {
        string data;
        if (5 != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        else
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        /* POTENTIAL FLAW: unvalidated or sandboxed value */
        if (data != null)
        {
            if (File.Exists(data))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(data))
                    {
                        IO.WriteLine(sr.ReadLine());
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
    }

    /* GoodG2B2() - use goodsource and badsink by reversing statements in if */
    private void GoodG2B2()
    {
        string data;
        if (5 == 5)
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        /* POTENTIAL FLAW: unvalidated or sandboxed value */
        if (data != null)
        {
            if (File.Exists(data))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(data))
                    {
                        IO.WriteLine(sr.ReadLine());
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
    }

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
    }
#endif //omitgood
}
}
