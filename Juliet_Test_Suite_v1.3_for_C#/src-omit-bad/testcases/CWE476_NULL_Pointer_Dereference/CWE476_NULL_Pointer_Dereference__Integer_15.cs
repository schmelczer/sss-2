/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__Integer_15.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 476 Null Pointer Dereference
* BadSource:  Set data to null
* GoodSource: Set data to a non-null value
* Sinks:
*    GoodSink: add check to prevent possibility of null dereference
*    BadSink : possibility of null dereference
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__Integer_15 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing the first switch to switch(5) */
    private void GoodG2B1()
    {
        int? data;
        switch (5)
        {
        case 6:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        default:
            /* FIX: hardcode data to non-null */
            data = Int32.Parse("5");
            break;
        }
        switch (7)
        {
        case 7:
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.ToString());
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }

    /* GoodG2B2() - use goodsource and badsink by reversing the blocks in the first switch  */
    private void GoodG2B2()
    {
        int? data;
        switch (6)
        {
        case 6:
            /* FIX: hardcode data to non-null */
            data = Int32.Parse("5");
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        switch (7)
        {
        case 7:
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.ToString());
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }

    /* goodB2G1() - use badsource and goodsink by changing the second switch to switch(8) */
    private void GoodB2G1()
    {
        int? data;
        switch (6)
        {
        case 6:
            /* POTENTIAL FLAW: data is null */
            data = null;
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        switch (8)
        {
        case 7:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        default:
            /* FIX: validate that data is non-null */
            if (data != null)
            {
                IO.WriteLine("" + data.ToString());
            }
            else
            {
                IO.WriteLine("data is null");
            }
            break;
        }
    }

    /* goodB2G2() - use badsource and goodsink by reversing the blocks in the second switch  */
    private void GoodB2G2()
    {
        int? data;
        switch (6)
        {
        case 6:
            /* POTENTIAL FLAW: data is null */
            data = null;
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        switch (7)
        {
        case 7:
            /* FIX: validate that data is non-null */
            if (data != null)
            {
                IO.WriteLine("" + data.ToString());
            }
            else
            {
                IO.WriteLine("data is null");
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
        GoodB2G1();
        GoodB2G2();
    }
#endif //omitgood
}
}
