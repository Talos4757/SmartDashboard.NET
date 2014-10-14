// Decompiled with JetBrains decompiler
// Type: org.jfree.date.DayAndMonthRule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.date
{
  public class DayAndMonthRule : AnnualDateRule
  {
    private int dayOfMonth;
    private int month;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 168, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DayAndMonthRule(int dayOfMonth, int month)
    {
      DayAndMonthRule dayAndMonthRule = this;
      this.setMonth(month);
      this.setDayOfMonth(dayOfMonth);
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DayAndMonthRule()
      : this(1, 1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 104, (byte) 208, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMonth(int month)
    {
      if (!SerialDate.isValidMonthCode(month))
      {
        string str = "DayAndMonthRule(): month code not valid.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.month = month;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 115, (byte) 240, (byte) 69, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDayOfMonth(int dayOfMonth)
    {
      if (dayOfMonth < 1 || dayOfMonth > SerialDate.LAST_DAY_OF_MONTH[this.month])
      {
        string str = "DayAndMonthRule(): dayOfMonth outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.dayOfMonth = dayOfMonth;
    }

    public virtual int getDayOfMonth()
    {
      return this.dayOfMonth;
    }

    public virtual int getMonth()
    {
      return this.month;
    }

    [LineNumberTable((ushort) 156)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override SerialDate getDate(int yyyy)
    {
      return SerialDate.createInstance(this.dayOfMonth, this.month, yyyy);
    }
  }
}
