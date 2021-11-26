/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__StringBuilder_21.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 476 Null Pointer Dereference
 * BadSource:  Set data to null
 * GoodSource: Set data to a non-null value
 * Sinks:
 *    GoodSink: add check to prevent possibility of null dereference
 *    BadSink : possibility of null dereference
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Text;


namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__StringBuilder_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: data is null */
        data = null;
        badPrivate = true;
        BadSink(data );
    }

    private void BadSink(StringBuilder data )
    {
        if (badPrivate)
        {
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.Length);
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}
