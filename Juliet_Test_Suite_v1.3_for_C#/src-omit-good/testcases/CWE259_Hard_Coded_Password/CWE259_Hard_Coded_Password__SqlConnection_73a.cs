/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__SqlConnection_73a.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: SqlConnection
 *    BadSink : data used as password in database connection
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{

class CWE259_Hard_Coded_Password__SqlConnection_73a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* FLAW: Set data to a hardcoded string */
        data = "7e5tc4s3";
        LinkedList<string> dataLinkedList = new LinkedList<string>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE259_Hard_Coded_Password__SqlConnection_73b.BadSink(dataLinkedList  );
    }
#endif //omitbad

}
}
