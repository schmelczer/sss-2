/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Params_Get_Web_73a.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;


namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_Params_Get_Web_73a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        LinkedList<string> dataLinkedList = new LinkedList<string>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE601_Open_Redirect__Web_Params_Get_Web_73b.BadSink(dataLinkedList , req, resp );
    }
#endif //omitbad

}
}
