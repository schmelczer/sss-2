/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_string_06.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-06.tmpl.cs
*/
/*
* @description
* CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
* BadSource:  Use a custom method which may return null
* GoodSource: Use a custom method that never returns null
* Sinks: trim
*    GoodSink: Check data for null before calling trim()
*    BadSink : Call trim() on possibly null object
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_string_06 : AbstractTestCase
{

    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value. */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        String data;
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: Call getStringBad(), which may return null */
            data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBad();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: data could be null */
            string stringTrimmed = data.Trim();
            IO.WriteLine(stringTrimmed);
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing first PRIVATE_CONST_FIVE==5 to PRIVATE_CONST_FIVE!=5 */
    private void GoodG2B1()
    {
        String data;
        if (PRIVATE_CONST_FIVE!=5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        else
        {
            /* FIX: call getStringGood(), which will never return null */
            data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringGood();
        }
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: data could be null */
            string stringTrimmed = data.Trim();
            IO.WriteLine(stringTrimmed);
        }
    }

    /* GoodG2B2() - use goodsource and badsink by reversing statements in first if */
    private void GoodG2B2()
    {
        String data;
        if (PRIVATE_CONST_FIVE==5)
        {
            /* FIX: call getStringGood(), which will never return null */
            data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringGood();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: data could be null */
            string stringTrimmed = data.Trim();
            IO.WriteLine(stringTrimmed);
        }
    }

    /* goodB2G1() - use badsource and goodsink by changing second PRIVATE_CONST_FIVE==5 to PRIVATE_CONST_FIVE!=5 */
    private void GoodB2G1()
    {
        String data;
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: Call getStringBad(), which may return null */
            data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBad();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (PRIVATE_CONST_FIVE!=5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: explicit check for null */
            if (data != null)
            {
                string stringTrimmed = data.Trim();
                IO.WriteLine(stringTrimmed);
            }
        }
    }

    /* goodB2G2() - use badsource and goodsink by reversing statements in second if  */
    private void GoodB2G2()
    {
        String data;
        if (PRIVATE_CONST_FIVE==5)
        {
            /* POTENTIAL FLAW: Call getStringBad(), which may return null */
            data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBad();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (PRIVATE_CONST_FIVE==5)
        {
            /* FIX: explicit check for null */
            if (data != null)
            {
                string stringTrimmed = data.Trim();
                IO.WriteLine(stringTrimmed);
            }
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
