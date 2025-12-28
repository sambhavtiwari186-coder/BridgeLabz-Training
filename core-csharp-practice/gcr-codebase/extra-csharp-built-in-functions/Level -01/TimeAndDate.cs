using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_01
{
    internal class TimeAndDate
    {
            public  void TandD()
            {
                DateTimeOffset utc = DateTimeOffset.UtcNow;
                Console.WriteLine("UTC/GMT Time: " + utc);
                TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTimeOffset ist = TimeZoneInfo.ConvertTime(utc, istZone);
                Console.WriteLine("IST Time: " + ist);
                TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
                DateTimeOffset pst = TimeZoneInfo.ConvertTime(utc, pstZone);
                Console.WriteLine("PST Time: " + pst);
            }
        }
    }
