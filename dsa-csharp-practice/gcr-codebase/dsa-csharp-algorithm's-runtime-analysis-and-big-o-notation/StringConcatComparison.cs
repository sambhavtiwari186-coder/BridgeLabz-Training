using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabz_2.algorithm_s_runtime_analysis_and_big_o_notation
{
     class StringConcatComparison
    {
        static void Main()
        {
            int n = 100000;

            Stopwatch stopWatch = new Stopwatch();

            // string concatenation
            string result = "";
            stopWatch.Start();
            for (int i = 0; i < n; i++)
            {
                result += "x";
            }
            stopWatch.Stop();
            Console.WriteLine($"string Time --> {stopWatch.ElapsedMilliseconds} ms");

            stopWatch.Reset();

            // StringBuilder concatenation
            StringBuilder sb = new StringBuilder();
            stopWatch.Start();
            for (int i = 0; i < n; i++)
            {
                sb.Append("x");
            }
            stopWatch.Stop();
            Console.WriteLine($"StringBuilder Time --> {stopWatch.ElapsedMilliseconds} ms");
        }

    }
}
