/*
 * @description Use of "Double Checked Locking" which can fail in certain circumstances. 
 * 
 * */

using System;
using System.Threading.Tasks;
using TestCaseSupport;

namespace testcases.CWE609_Double_Checked_Locking
{
    class CWE609_Double_Checked_Locking__Thread_01 : AbstractTestCase
    {
        /* Bad() - Use of Double Checked Locking */
        private static string stringBad = null;
        private static readonly object badLock = new object();
#if (!OMITBAD)
        public static string helperBad()
        {
            if (stringBad == null)
            {
                lock (badLock)
                {
                    if (stringBad == null)
                    {
                        stringBad = "stringBad";
                    }
                }
            }
            return stringBad;
        }

        /* FLAW: Insufficient "Double-Checked Locking" in this method - in certain circumstances, this can lead to stringBad being initialized twice. */
        public override void Bad()
        {
            var task1 = Task.Run(() =>
            {
                IO.WriteLine(helperBad());
            });

            var task2 = Task.Run(() =>
            {
                IO.WriteLine(helperBad());
            });
        }
#endif // OMITBAD
        private volatile static string stringGood1 = null; /* FIX: Added "volatile" here */
        private static readonly object goodLock = new object();

}
}
