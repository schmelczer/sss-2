/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__String_12.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 476 Null Pointer Dereference
* BadSource:  Set data to null
* GoodSource: Set data to a non-null value
* Sinks:
*    GoodSink: add check to prevent possibility of null dereference
*    BadSink : possibility of null dereference
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__String_12 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by changing the first "if" so that
     * both branches use the GoodSource */
    private void GoodG2B()
    {
        string data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: hardcode data to non-null */
            data = "This is not null";
        }
        else
        {
            /* FIX: hardcode data to non-null */
            data = "This is not null";
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.Length);
        }
        else
        {
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.Length);
        }
    }

    /* goodB2G() - use badsource and goodsink by changing the second "if" so that
     * both branches use the GoodSink */
    private void GoodB2G()
    {
        string data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: data is null */
            data = null;
        }
        else
        {
            /* POTENTIAL FLAW: data is null */
            data = null;
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: validate that data is non-null */
            if (data != null)
            {
                IO.WriteLine("" + data.Length);
            }
            else
            {
                IO.WriteLine("data is null");
            }
        }
        else
        {
            /* FIX: validate that data is non-null */
            if (data != null)
            {
                IO.WriteLine("" + data.Length);
            }
            else
            {
                IO.WriteLine("data is null");
            }
        }
    }

    public override void Good()

    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}
