/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Random_write_67a.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Random Set count to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: write
 *    GoodSink: Write to a file count number of times, but first validate count
 *    BadSink : Write to a file count number of times
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Random_write_67a : AbstractTestCase
{

    public class Container
    {
        public int containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        int count;
        /* POTENTIAL FLAW: Set count to a random value */
        count = (new Random()).Next();
        Container countContainer = new Container();
        countContainer.containerOne = count;
        CWE400_Uncontrolled_Resource_Consumption__Random_write_67b.BadSink(countContainer  );
    }
#endif //omitbad

}
}
