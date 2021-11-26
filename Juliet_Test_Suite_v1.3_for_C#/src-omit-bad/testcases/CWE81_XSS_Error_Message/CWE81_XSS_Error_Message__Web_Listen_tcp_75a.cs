/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Listen_tcp_75a.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-75a.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 75 Data flow: data passed in a serialized object from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

using System.Web;

using System.Net.Sockets;
using System.Net;

namespace testcases.CWE81_XSS_Error_Message
{
class CWE81_XSS_Error_Message__Web_Listen_tcp_75a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
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
            CWE81_XSS_Error_Message__Web_Listen_tcp_75b.GoodG2BSink(dataSerialized , req, resp );
        }
        catch (SerializationException exceptSerialize)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Serialization exception in serialization", exceptSerialize);
        }
    }
#endif //omitgood
}
}
