/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_NetClient_modulo_74b.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_NetClient_modulo_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,int> dataDictionary )
    {
        int data = dataDictionary[2];
        /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
        result in an exception.  */
        IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use GoodSource and BadSink */
    public static  void GoodG2BSink(Dictionary<int,int> dataDictionary )
    {
        int data = dataDictionary[2];
        /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
        result in an exception.  */
        IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
    }

    /* goodB2G() - use BadSource and GoodSink */
    public static void GoodB2GSink(Dictionary<int,int> dataDictionary )
    {
        int data = dataDictionary[2];
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
