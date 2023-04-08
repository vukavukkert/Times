using System;
using Times;

Time time2 = new Time(1, 59, 59);
Time time = new Time(1,59,60);
Time time3 = time2 + time;
Console.WriteLine(time2.ToString());
Console.WriteLine(time.ToString());
Console.WriteLine(time3.ToString());
