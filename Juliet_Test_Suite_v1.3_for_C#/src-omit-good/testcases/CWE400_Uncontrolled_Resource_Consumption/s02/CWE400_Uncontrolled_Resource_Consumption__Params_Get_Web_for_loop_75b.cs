/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Params_Get_Web_for_loop_75b.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-75b.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Params_Get_Web Read count from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: for_loop
 *    GoodSink: Validate count before using it as the loop variant in a for loop
 *    BadSink : Use count as the loop variant in a for loop
 * Flow Variant: 75 Data flow: data passed in a serialized object from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Params_Get_Web_for_loop_75b
{
#if (!OMITBAD)
    public static void BadSink(byte[] countSerialized , HttpRequest req, HttpResponse resp)
    {
        try
        {
            int count;
            var binForm = new BinaryFormatter();
            using (var memStream = new MemoryStream())
            {
                memStream.Write(countSerialized, 0, countSerialized.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                count = (int)binForm.Deserialize(memStream);
            }
            int i = 0;
            /* POTENTIAL FLAW: For loop using count as the loop variant and no validation */
            for (i = 0; i < count; i++)
            {
                IO.WriteLine("Hello");
            }
        }
        catch (SerializationException exceptSerialize)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "SerializationException in deserialization", exceptSerialize);
        }
    }
#endif


}
}
