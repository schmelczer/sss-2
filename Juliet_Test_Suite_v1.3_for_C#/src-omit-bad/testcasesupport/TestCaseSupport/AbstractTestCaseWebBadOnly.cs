using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseSupport
{
    public abstract class AbstractTestCaseWebBadOnly : AbstractTestCaseWebBase
    {

        override public void RunTest(String webName, HttpRequest req, HttpResponse resp)
        {
            resp.Write("<br><br>Starting tests for Web testcase " + webName);

        }
    }
}
