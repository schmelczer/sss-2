/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE789_Uncontrolled_Mem_Alloc__Params_Get_Web_ArrayList_21.cs
Label Definition File: CWE789_Uncontrolled_Mem_Alloc.int.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 789 Uncontrolled Memory Allocation
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: ArrayList
 *    BadSink : Create an ArrayList using data as the initial size
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Collections;

using System.Web;


namespace testcases.CWE789_Uncontrolled_Mem_Alloc
{

class CWE789_Uncontrolled_Mem_Alloc__Params_Get_Web_ArrayList_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        badPrivate = true;
        data = Bad_source(req, resp);
        /* POTENTIAL FLAW: Create an ArrayList using data as the initial size.  data may be very large, creating memory issues */
        ArrayList intArrayList = new ArrayList(data);
    }

    private int Bad_source(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (badPrivate)
        {
            data = int.MinValue; /* Initialize data */
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get() */
            {
                string stringNumber = req.Params.Get("name");
                try
                {
                    data = int.Parse(stringNumber.Trim());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading data from parameter 'name'");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        return data;
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;

}
}
