/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_ReadLine_modulo_68b.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_ReadLine_modulo_68b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink()
    {
        int data = CWE369_Divide_by_Zero__int_ReadLine_modulo_68a.data;
        /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
        result in an exception.  */
        IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink()
    {
        int data = CWE369_Divide_by_Zero__int_ReadLine_modulo_68a.data;
        /* FIX: test for a zero modulus */
        if (data != 0)
        {
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
        }
        else
        {
            IO.WriteLine("This would result in a modulo by zero");
        }
    }
#endif
}
}
