/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__StringBuilder_75b.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.label.xml
Template File: sources-sinks-75b.tmpl.cs
*/
/*
 * @description
 * CWE: 476 Null Pointer Dereference
 * BadSource:  Set data to null
 * GoodSource: Set data to a non-null value
 * Sinks:
 *    GoodSink: add check to prevent possibility of null dereference
 *    BadSink : possibility of null dereference
 * Flow Variant: 75 Data flow: data passed in a serialized object from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using System.Text;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__StringBuilder_75b
{
#if (!OMITBAD)
    public static void BadSink(byte[] dataSerialized )
    {
        try
        {
            StringBuilder data;
            var binForm = new BinaryFormatter();
            using (var memStream = new MemoryStream())
            {
                memStream.Write(dataSerialized, 0, dataSerialized.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                data = (StringBuilder)binForm.Deserialize(memStream);
            }
            /* POTENTIAL FLAW: null dereference will occur if data is null */
            IO.WriteLine("" + data.Length);
        }
        catch (SerializationException exceptSerialize)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "SerializationException in deserialization", exceptSerialize);
        }
    }
#endif


}
}
