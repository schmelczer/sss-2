/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_Environment_divide_41.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: divide
 *    GoodSink: Check for zero before dividing
 *    BadSink : Dividing by a value that may be zero
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_Environment_divide_41 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    private static void GoodG2BSink(float data )
    {
        /* POTENTIAL FLAW: Possibly divide by zero */
        int result = (int)(100.0 / data);
        IO.WriteLine(result);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        float data;
        /* FIX: Use a hardcoded number that won't a divide by zero */
        data = 2.0f;
        GoodG2BSink(data  );
    }

    private static void GoodB2GSink(float data )
    {
        /* FIX: Check for value of or near zero before dividing */
        if (Math.Abs(data) > 0.000001)
        {
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
        }
        else
        {
            IO.WriteLine("This would result in a divide by zero");
        }
    }

    /* goodB2G() - use badsource and goodsink */
    private static void GoodB2G()
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
        GoodB2GSink(data  );
    }
#endif //omitgood
}
}
