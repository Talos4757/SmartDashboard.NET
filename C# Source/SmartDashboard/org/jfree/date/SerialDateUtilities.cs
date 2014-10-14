// Decompiled with JetBrains decompiler
// Type: org.jfree.date.SerialDateUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.text;
using System.Runtime.CompilerServices;

namespace org.jfree.date
{
  public class SerialDateUtilities : Object
  {
    private DateFormatSymbols dateFormatSymbols;
    private string[] weekdays;
    private string[] months;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 107, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerialDateUtilities()
    {
      base.\u002Ector();
      SerialDateUtilities serialDateUtilities = this;
      this.dateFormatSymbols = new DateFormatSymbols();
      this.weekdays = this.dateFormatSymbols.getWeekdays();
      this.months = this.dateFormatSymbols.getMonths();
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 105, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int dayCount30(SerialDate start, SerialDate end)
    {
      if (!start.isBefore(end))
        return -SerialDateUtilities.dayCount30(end, start);
      int dayOfMonth1 = start.getDayOfMonth();
      int month1 = start.getMonth();
      int yyyy = start.getYYYY();
      int dayOfMonth2 = end.getDayOfMonth();
      int month2 = end.getMonth();
      return 360 * (end.getYYYY() - yyyy) + 30 * (month2 - month1) + (dayOfMonth2 - dayOfMonth1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 101, (byte) 131, (byte) 103, (byte) 104, (byte) 104, (byte) 106, (byte) 131, (byte) 151, (byte) 105, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int dayCount30ISDA(SerialDate start, SerialDate end)
    {
      if (start.isBefore(end))
      {
        int num1 = start.getDayOfMonth();
        int month1 = start.getMonth();
        int yyyy1 = start.getYYYY();
        if (num1 == 31)
          num1 = 30;
        int num2 = end.getDayOfMonth();
        int month2 = end.getMonth();
        int yyyy2 = end.getYYYY();
        if (num2 == 31 && num1 == 30)
          num2 = 30;
        return 360 * (yyyy2 - yyyy1) + 30 * (month2 - month1) + (num2 - num1);
      }
      else if (start.isAfter(end))
        return -SerialDateUtilities.dayCount30ISDA(end, start);
      else
        return 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 105, (byte) 103, (byte) 109, (byte) 166, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isLastDayOfFebruary(SerialDate d)
    {
      if (d.getMonth() != 2)
        return false;
      int dayOfMonth = d.getDayOfMonth();
      if (SerialDate.isLeapYear(d.getYYYY()))
        return dayOfMonth == 29;
      else
        return dayOfMonth == 28;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 108, (byte) 103, (byte) 103, (byte) 135, (byte) 104, (byte) 131, (byte) 141, (byte) 131, (byte) 103, (byte) 104, (byte) 104, (byte) 106, (byte) 131, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int dayCount30PSA(SerialDate start, SerialDate end)
    {
      if (!start.isOnOrBefore(end))
        return -SerialDateUtilities.dayCount30PSA(end, start);
      int num1 = start.getDayOfMonth();
      int month1 = start.getMonth();
      int yyyy1 = start.getYYYY();
      if (SerialDateUtilities.isLastDayOfFebruary(start))
        num1 = 30;
      if (num1 == 31 || SerialDateUtilities.isLastDayOfFebruary(start))
        num1 = 30;
      int num2 = end.getDayOfMonth();
      int month2 = end.getMonth();
      int yyyy2 = end.getYYYY();
      if (num2 == 31 && num1 == 30)
        num2 = 30;
      return 360 * (yyyy2 - yyyy1) + 30 * (month2 - month1) + (num2 - num1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 101, (byte) 131, (byte) 103, (byte) 104, (byte) 104, (byte) 101, (byte) 131, (byte) 151, (byte) 105, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int dayCount30E(SerialDate start, SerialDate end)
    {
      if (start.isBefore(end))
      {
        int num1 = start.getDayOfMonth();
        int month1 = start.getMonth();
        int yyyy1 = start.getYYYY();
        if (num1 == 31)
          num1 = 30;
        int num2 = end.getDayOfMonth();
        int month2 = end.getMonth();
        int yyyy2 = end.getYYYY();
        if (num2 == 31)
          num2 = 30;
        return 360 * (yyyy2 - yyyy1) + 30 * (month2 - month1) + (num2 - num1);
      }
      else if (start.isAfter(end))
        return -SerialDateUtilities.dayCount30E(end, start);
      else
        return 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 248, (byte) 226, (byte) 71, (byte) 137, (byte) 103, (byte) 103, (byte) 102, (byte) 104, (byte) 107, (byte) 108, (byte) 228, (byte) 60, (byte) 230, (byte) 72, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int countFeb29s(SerialDate start, SerialDate end)
    {
      int num = 0;
      if (start.isBefore(end))
      {
        int yyyy1 = start.getYYYY();
        int yyyy2 = end.getYYYY();
        for (int yyyy3 = yyyy1; yyyy3 == yyyy2; ++yyyy3)
        {
          if (SerialDate.isLeapYear(yyyy3) && SerialDate.createInstance(29, 2, yyyy3).isInRange(start, end, 2))
            ++num;
        }
        return num;
      }
      else
        return SerialDateUtilities.countFeb29s(end, start);
    }

    public virtual string[] getWeekdays()
    {
      return this.weekdays;
    }

    public virtual string[] getMonths()
    {
      return this.months;
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 112, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int stringToWeekday(string s)
    {
      if (String.instancehelper_equals(s, (object) this.weekdays[7]))
        return 7;
      if (String.instancehelper_equals(s, (object) this.weekdays[1]))
        return 1;
      if (String.instancehelper_equals(s, (object) this.weekdays[2]))
        return 2;
      if (String.instancehelper_equals(s, (object) this.weekdays[3]))
        return 3;
      if (String.instancehelper_equals(s, (object) this.weekdays[4]))
        return 4;
      return String.instancehelper_equals(s, (object) this.weekdays[5]) ? 5 : 6;
    }

    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int dayCountActual(SerialDate start, SerialDate end)
    {
      return end.compare(start);
    }
  }
}
