/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_QueryString_Web_addCookie_81_goodG2B.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-81_goodG2B.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: addCookie
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AppendCookie()
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */
