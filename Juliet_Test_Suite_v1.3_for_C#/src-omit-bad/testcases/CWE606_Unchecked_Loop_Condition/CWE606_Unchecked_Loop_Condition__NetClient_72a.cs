/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__NetClient_72a.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.IO;
using System.Net;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__NetClient_72a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use GoodSource and BadSink */
    private static void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded int as a string */
        data = "5";
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE606_Unchecked_Loop_Condition__NetClient_72b.GoodG2BSink(dataHashtable  );
    }

    /* goodB2G() - use BadSource and GoodSink */
    private static void GoodB2G()
    {
        string data;
        data = ""; /* Initialize data */
        /* read input from WebClient */
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (StreamReader sr = new StreamReader(client.OpenRead("http://www.example.org/")))
                    {
                        /* POTENTIAL FLAW: Read data from a web server with WebClient */
                        /* This will be reading the first "line" of the response body,
                        * which could be very long if there are no newlines in the HTML */
                        data = sr.ReadLine();
                    }
                }
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
        CWE606_Unchecked_Loop_Condition__NetClient_72b.GoodB2GSink(dataHashtable  );
    }
#endif //omitgood
}
}
