/*
 * @description Demonstrates use of Monitor.Enter() more times than Monitor.Exit() in multithreaded code that accesses a shared variable.
 * 
 * */

using System;
using System.Threading;
using TestCaseSupport;

namespace testcases.CWE764_Multiple_Locks
{
    class CWE764_Multiple_locks__Monitor_Object_Thread_01 : AbstractTestCase
    {
        /* Bad(): Use Monitor.Enter() twice and Monitor.Exit() once */
        static private readonly object badLock = new object();
        static private int intBad = 1;



        /* Good1(): Use a ReentrantLock properly (use Monitor.Enter() once and Monitor.Exit() once) */
        static private readonly object goodLock = new object();
        static private int intGood1 = 1;

#if (!OMITGOOD)
        public void Good1()
        {
            Monitor.Enter(goodLock); /* FIX: Only use Monitor.Enter() once */
            try
            {
                intGood1 = intGood1 * 2;
            }
            finally
            {
                Monitor.Exit(goodLock);
            }
        }

        public override void Good()
        {
            Good1();
        }
#endif // OMITGOOD

}
}
