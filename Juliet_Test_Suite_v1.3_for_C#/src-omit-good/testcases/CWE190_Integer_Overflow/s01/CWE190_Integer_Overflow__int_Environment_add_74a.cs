/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Environment_add_74a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Environment_add_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        data = int.MinValue; /* Initialize data */
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
        Dictionary<int,int> dataDictionary = new Dictionary<int,int>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE190_Integer_Overflow__int_Environment_add_74b.BadSink(dataDictionary  );
    }
#endif //omitbad

}
}
