/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Params_Get_Web_75a.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-75a.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 75 Data flow: data passed in a serialized object from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

using System.Web;


namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__Params_Get_Web_75a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        /* serialize data to a byte array */
        byte[] dataSerialized = null;
        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, data);
                dataSerialized = ms.ToArray();
            }
            CWE643_Xpath_Injection__Params_Get_Web_75b.BadSink(dataSerialized , req, resp );
        }
        catch (SerializationException exceptSerialize)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Serialization exception in serialization", exceptSerialize);
        }
    }
#endif //omitbad

}
}