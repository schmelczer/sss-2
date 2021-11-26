/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Params_Get_Web_multiply_45.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Params_Get_Web_multiply_45 : AbstractTestCaseWeb
{

    private int dataBad;
    private int dataGoodG2B;
    private int dataGoodB2G;
#if (!OMITBAD)
    private void BadSink(HttpRequest req, HttpResponse resp)
    {
        int data = dataBad;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < int.MinValue, this will underflow */
            int result = (int)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        data = int.MinValue; /* Initialize data */
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get() */
        {
            string stringNumber = req.Params.Get("name");
            try
            {
                data = int.Parse(stringNumber.Trim());
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading data from parameter 'name'");
            }
        }
        dataBad = data;
        BadSink(req, resp);
    }
#endif //omitbad

}
}
