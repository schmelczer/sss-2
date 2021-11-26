/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_Environment_divide_71a.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_Environment_divide_71a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        data = -1.0f; /* Initialize data */
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        {
            string stringNumber = Environment.GetEnvironmentVariable("ADD");
            if (stringNumber != null) // avoid NPD incidental warnings
            {
                try
                {
                    data = int.Parse(stringNumber.Trim());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                }
            }
        }
        CWE369_Divide_by_Zero__float_Environment_divide_71b.BadSink((Object)data  );
    }
#endif //omitbad

}
}
