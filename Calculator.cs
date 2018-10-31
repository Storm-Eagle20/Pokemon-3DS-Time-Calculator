using Pokemon_RNG_Time_Calculator;
using System;

public class Calculator
{
    public static string Convert2timestr(double sec)
    {
        if (sec < 60)
            return sec.ToString("F3") + "s";
        int min = (int)Math.Floor(sec) / 60;
        sec -= 60 * min;
        if (min < 60)
            return min.ToString() + "m " + sec.ToString("00.000s");
        int hour = min / 60;
        min -= 60 * hour;
        return hour.ToString() + "h " + min.ToString("D2") + "m " + sec.ToString("00.0s");
    }

    public int realtime = -1;

    public static decimal targetFrame { get; internal set; }

    public static int startingFrame;
    //original
    public string RealTime => framemin == framemax ? "-" : Convert2timestr((framemin + 2 - Startingframe) / 60.0) + " ~ " + Convert2timestr((framemax - Startingframe) / 60.0);
    //edited
    public string gen7Result => Form1.starter == Form1.target ? "-" : Convert2timestr((Form1.starter + 2 - startingFrame) / 60.0) + " ~ " + Convert2timestr((Form1.target - startingFrame) / 60.0);
    public string gen6Result => Form1.starter == Form1.target ? "-" : Convert2timestr(())


}