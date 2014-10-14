// Decompiled with JetBrains decompiler
// Type: org.jfree.date.RelativeDayOfWeekRule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.date
{
  public class RelativeDayOfWeekRule : AnnualDateRule
  {
    private AnnualDateRule subrule;
    private int dayOfWeek;
    private int relative;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RelativeDayOfWeekRule(AnnualDateRule subrule, int dayOfWeek, int relative)
    {
      RelativeDayOfWeekRule relativeDayOfWeekRule = this;
      this.subrule = subrule;
      this.dayOfWeek = dayOfWeek;
      this.relative = relative;
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RelativeDayOfWeekRule()
      : this((AnnualDateRule) new DayAndMonthRule(), 2, 1)
    {
    }

    public virtual AnnualDateRule getSubrule()
    {
      return this.subrule;
    }

    public virtual void setSubrule(AnnualDateRule subrule)
    {
      this.subrule = subrule;
    }

    public virtual int getDayOfWeek()
    {
      return this.dayOfWeek;
    }

    public virtual void setDayOfWeek(int dayOfWeek)
    {
      this.dayOfWeek = dayOfWeek;
    }

    public virtual int getRelative()
    {
      return this.relative;
    }

    public virtual void setRelative(int relative)
    {
      this.relative = relative;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 110, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      RelativeDayOfWeekRule relativeDayOfWeekRule = (RelativeDayOfWeekRule) base.clone();
      relativeDayOfWeekRule.subrule = (AnnualDateRule) relativeDayOfWeekRule.getSubrule().clone();
      return (object) relativeDayOfWeekRule;
    }

    [LineNumberTable(new byte[] {(byte) 127, (byte) 144, (byte) 240, (byte) 69, (byte) 98, (byte) 141, (byte) 99, (byte) 155, (byte) 141, (byte) 130, (byte) 141, (byte) 130, (byte) 141, (byte) 226, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override SerialDate getDate(int year)
    {
      if (year < 1900 || year > 9999)
      {
        string str = "RelativeDayOfWeekRule.getDate(): year outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        SerialDate serialDate = (SerialDate) null;
        SerialDate date = this.subrule.getDate(year);
        if (date != null)
        {
          switch (this.relative)
          {
            case -1:
              serialDate = SerialDate.getPreviousDayOfWeek(this.dayOfWeek, date);
              break;
            case 0:
              serialDate = SerialDate.getNearestDayOfWeek(this.dayOfWeek, date);
              break;
            case 1:
              serialDate = SerialDate.getFollowingDayOfWeek(this.dayOfWeek, date);
              break;
          }
        }
        return serialDate;
      }
    }
  }
}
