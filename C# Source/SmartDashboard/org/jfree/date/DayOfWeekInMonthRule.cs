// Decompiled with JetBrains decompiler
// Type: org.jfree.date.DayOfWeekInMonthRule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace org.jfree.date
{
  public class DayOfWeekInMonthRule : AnnualDateRule
  {
    private int count;
    private int dayOfWeek;
    private int month;

    [LineNumberTable(new byte[] {(byte) 28, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DayOfWeekInMonthRule(int count, int dayOfWeek, int month)
    {
      DayOfWeekInMonthRule ofWeekInMonthRule = this;
      this.count = count;
      this.dayOfWeek = dayOfWeek;
      this.month = month;
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DayOfWeekInMonthRule()
      : this(1, 2, 1)
    {
    }

    public virtual int getCount()
    {
      return this.count;
    }

    public virtual void setCount(int count)
    {
      this.count = count;
    }

    public virtual int getDayOfWeek()
    {
      return this.dayOfWeek;
    }

    public virtual void setDayOfWeek(int dayOfWeek)
    {
      this.dayOfWeek = dayOfWeek;
    }

    public virtual int getMonth()
    {
      return this.month;
    }

    public virtual void setMonth(int month)
    {
      this.month = month;
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 136, (byte) 110, (byte) 110, (byte) 138, (byte) 243, (byte) 69, (byte) 110, (byte) 104, (byte) 110, (byte) 202})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override SerialDate getDate(int year)
    {
      SerialDate base1;
      if (this.count != 0)
      {
        SerialDate base2 = SerialDate.createInstance(1, this.month, year);
        while (base2.getDayOfWeek() != this.dayOfWeek)
          base2 = SerialDate.addDays(1, base2);
        base1 = SerialDate.addDays(7 * (this.count - 1), base2);
      }
      else
      {
        SerialDate instance = SerialDate.createInstance(1, this.month, year);
        base1 = instance.getEndOfCurrentMonth(instance);
        while (base1.getDayOfWeek() != this.dayOfWeek)
          base1 = SerialDate.addDays(-1, base1);
      }
      return base1;
    }
  }
}
