using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public class StoreHours
        {
            public DayOfWeek Day { get; set; }
            public bool Closed { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public string Hours
            {
                get
                {
                    if (Closed)
                        return string.Format(@"{0}   Closed", Day);
                    else
                        return string.Format(@"{0}   {1} - {2}",Day ,StartTime, EndTime);
                }
            }

        }
        static void Main(string[] args)
        {
            var storeSchedule = new List<StoreHours>
            {
                { new StoreHours {Day=DayOfWeek.Monday, Closed=false,StartTime="10:00a",EndTime="6:00p" } },
                { new StoreHours {Day=DayOfWeek.Tuesday, Closed=false,StartTime="10:00a",EndTime="6:00p" } },
                { new StoreHours {Day=DayOfWeek.Wednesday, Closed=false,StartTime="10:00a",EndTime="6:00p" } },
                { new StoreHours {Day=DayOfWeek.Thursday, Closed=false,StartTime="10:00a",EndTime="7:00p" } },
                { new StoreHours {Day=DayOfWeek.Friday, Closed=false,StartTime="10:00a",EndTime="6:00p" } },
                { new StoreHours {Day=DayOfWeek.Saturday, Closed=false,StartTime="10:00a",EndTime="6:00p" } },
                { new StoreHours {Day=DayOfWeek.Sunday, Closed=true,StartTime="",EndTime="" } }
            };
            
            foreach(var daySchedule in storeSchedule)
                Console.WriteLine(daySchedule.Hours);
            Console.ReadKey();
        }
    }
}
