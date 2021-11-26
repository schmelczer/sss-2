/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_console_ReadLine_multiply_75b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-75b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 75 Data flow: data passed in a serialized object from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_console_ReadLine_multiply_75b
{
#if (!OMITBAD)
    public static void BadSink(byte[] dataSerialized )
    {
        try
        {
            ushort data;
            var binForm = new BinaryFormatter();
            using (var memStream = new MemoryStream())
            {
                memStream.Write(dataSerialized, 0, dataSerialized.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                data = (ushort)binForm.Deserialize(memStream);
            }
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < ushort.MinValue, this will underflow */
                ushort result = (ushort)(data * 2);
                IO.WriteLine("result: " + result);
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
