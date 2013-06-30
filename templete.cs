using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class $CLASSNAME$
{
    public $RC$ $METHODNAME$($METHODPARMS$)
    {
#if DEBUGGER
        Debugger.Launch();
#endif
    }

$TESTCODE$

$BEGINCUT$
    public static void Main()
    {
        $CLASSNAME$ __test = new $CLASSNAME$();
        __test.run_test(-1);
    }
$ENDCUT$
}