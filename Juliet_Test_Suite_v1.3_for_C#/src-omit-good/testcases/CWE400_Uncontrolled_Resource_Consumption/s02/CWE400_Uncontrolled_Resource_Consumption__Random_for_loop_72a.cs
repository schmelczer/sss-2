/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Random_for_loop_72a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Random Set count to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: for_loop
 *    GoodSink: Validate count before using it as the loop variant in a for loop
 *    BadSink : Use count as the loop variant in a for loop
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Random_for_loop_72a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        /* POTENTIAL FLAW: Set count to a random value */
        count = (new Random()).Next();
        Hashtable countHashtable = new Hashtable(5);
        countHashtable.Add(0, count);
        countHashtable.Add(1, count);
        countHashtable.Add(2, count);
        CWE400_Uncontrolled_Resource_Consumption__Random_for_loop_72b.BadSink(countHashtable  );
    }
#endif //omitbad

}
}
