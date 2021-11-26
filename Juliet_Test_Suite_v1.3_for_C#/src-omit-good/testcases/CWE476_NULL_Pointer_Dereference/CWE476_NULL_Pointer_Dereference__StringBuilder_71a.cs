/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__StringBuilder_71a.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 476 Null Pointer Dereference
 * BadSource:  Set data to null
 * GoodSource: Set data to a non-null value
 * Sinks:
 *    GoodSink: add check to prevent possibility of null dereference
 *    BadSink : possibility of null dereference
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__StringBuilder_71a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: data is null */
        data = null;
        CWE476_NULL_Pointer_Dereference__StringBuilder_71b.BadSink((Object)data  );
    }
#endif //omitbad

}
}
