/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__NetClient_75b.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-75b.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 75 Data flow: data passed in a serialized object from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using System.Web;

namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__NetClient_75b
{
#if (!OMITBAD)
    public static void BadSink(byte[] dataSerialized )
    {
        try
        {
            string data;
            var binForm = new BinaryFormatter();
            using (var memStream = new MemoryStream())
            {
                memStream.Write(dataSerialized, 0, dataSerialized.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                data = (string)binForm.Deserialize(memStream);
            }
            try
            {
                int value = int.Parse(data);
            }
            catch (FormatException exceptNumberFormat)
            {
                /* POTENTIAL FLAW: Logging output is not neutralized */
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Failed to parse value = " + data);
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