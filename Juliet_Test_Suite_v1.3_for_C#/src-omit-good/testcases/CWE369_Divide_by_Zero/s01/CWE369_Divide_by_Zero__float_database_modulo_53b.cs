/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_database_modulo_53b.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-53b.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: database Read data from a database
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_database_modulo_53b
{
#if (!OMITBAD)
    public static void BadSink(float data )
    {
        CWE369_Divide_by_Zero__float_database_modulo_53c.BadSink(data );
    }
#endif


}
}
