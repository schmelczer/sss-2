/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Environment_22b.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : no validation
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__Environment_22b
{


#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by setting the static variable to false instead of true */
    public static string GoodG2B1Source()
    {
        string data;
        if (CWE23_Relative_Path_Traversal__Environment_22a.goodG2B1PublicStatic)
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
        return data;
    }

    /* GoodG2B2() - use goodsource and badsink by reversing the blocks in the if in the sink function */
    public static string GoodG2B2Source()
    {
        string data;
        if (CWE23_Relative_Path_Traversal__Environment_22a.GoodG2B2PublicStatic)
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
        return data;
    }
#endif
}
}