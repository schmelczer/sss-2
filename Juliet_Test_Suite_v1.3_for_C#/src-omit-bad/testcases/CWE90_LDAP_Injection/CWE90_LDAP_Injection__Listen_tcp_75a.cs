/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__Listen_tcp_75a.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-75a.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
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

namespace testcases.CWE90_LDAP_Injection
{
class CWE90_LDAP_Injection__Listen_tcp_75a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
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
            CWE90_LDAP_Injection__Listen_tcp_75b.GoodG2BSink(dataSerialized  );
        }
        catch (SerializationException exceptSerialize)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Serialization exception in serialization", exceptSerialize);
        }
    }
#endif //omitgood
}
}
