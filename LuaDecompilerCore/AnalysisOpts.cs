using System;
using System.Collections.Generic;
using System.Text;

namespace luadec
{
    public static class AnalysisOpts
    {
        public static bool AnalyzeReturns = true;

        // If this is true, all values that the decompiler determines to have been assigned to local variables in the original Lua code will still be
        // assigned to local variables in the output. If it's false, those values may be inlined into function calls instead.
        public static bool PreserveOriginalLocals = true;
    }
}
