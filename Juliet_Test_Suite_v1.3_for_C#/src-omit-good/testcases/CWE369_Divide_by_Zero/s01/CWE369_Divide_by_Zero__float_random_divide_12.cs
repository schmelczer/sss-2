/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_random_divide_12.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: random Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive)
* GoodSource: A hardcoded non-zero number (two)
* Sinks: divide
*    GoodSink: Check for zero before dividing
*    BadSink : Dividing by a value that may be zero
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_random_divide_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Set data to a random value between 0.0f (inclusive) and 1.0f (exclusive) */
            Random rand = new Random();
            data = (float)rand.NextDouble();
        }
        else
        {
            /* FIX: Use a hardcoded number that won't a divide by zero */
            data = 2.0f;
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Possibly divide by zero */
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
        }
        else
        {
            /* FIX: Check for value of or near zero before dividing */
            if (Math.Abs(data) > 0.000001)
            {
                int result = (int)(100.0 / data);
                IO.WriteLine(result);
            }
            else
            {
                IO.WriteLine("This would result in a divide by zero");
            }
        }
    }
#endif //omitbad

}
}
