// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.util.RelativeDateFormat
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.text;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.util
{
  [Serializable]
  public class RelativeDateFormat : DateFormat
  {
    private static long MILLISECONDS_IN_ONE_HOUR = 3600000L;
    private static long MILLISECONDS_IN_ONE_DAY = 24L * RelativeDateFormat.MILLISECONDS_IN_ONE_HOUR;
    private long baseMillis;
    private bool showZeroDays;
    private bool showZeroHours;
    private NumberFormat dayFormatter;
    private string positivePrefix;
    private string daySuffix;
    private NumberFormat hourFormatter;
    private string hourSuffix;
    private NumberFormat minuteFormatter;
    private string minuteSuffix;
    private NumberFormat secondFormatter;
    private string secondSuffix;

    [LineNumberTable(new byte[] {(byte) 116, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 108, (byte) 108, (byte) 203, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RelativeDateFormat(long baseMillis)
    {
      base.\u002Ector();
      RelativeDateFormat relativeDateFormat = this;
      this.baseMillis = baseMillis;
      this.showZeroDays = false;
      this.showZeroHours = true;
      this.positivePrefix = "";
      this.dayFormatter = NumberFormat.getNumberInstance();
      this.daySuffix = "d";
      this.hourFormatter = NumberFormat.getNumberInstance();
      this.hourSuffix = "h";
      this.minuteFormatter = NumberFormat.getNumberInstance();
      this.minuteSuffix = "m";
      this.secondFormatter = NumberFormat.getNumberInstance();
      this.secondFormatter.setMaximumFractionDigits(3);
      this.secondFormatter.setMinimumFractionDigits(3);
      this.secondSuffix = "s";
      this.calendar = (__Null) new GregorianCalendar();
      this.numberFormat = (__Null) new DecimalFormat("0");
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RelativeDateFormat()
      : this(0L)
    {
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RelativeDateFormat(Date time)
      : this(time.getTime())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RelativeDateFormat([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual string getDaySuffix()
    {
      return this.daySuffix;
    }

    public virtual string getHourSuffix()
    {
      return this.hourSuffix;
    }

    public virtual string getMinuteSuffix()
    {
      return this.minuteSuffix;
    }

    public virtual string getSecondSuffix()
    {
      return this.secondSuffix;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 74, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSecondFormatter(NumberFormat formatter)
    {
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.secondFormatter = formatter;
    }

    public virtual void setShowZeroDays(bool show)
    {
      this.showZeroDays = show;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDaySuffix(string suffix)
    {
      if (suffix == null)
      {
        string str = "Null 'suffix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.daySuffix = suffix;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 254, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setHourSuffix(string suffix)
    {
      if (suffix == null)
      {
        string str = "Null 'suffix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.hourSuffix = suffix;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 37, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinuteSuffix(string suffix)
    {
      if (suffix == null)
      {
        string str = "Null 'suffix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.minuteSuffix = suffix;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 62, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSecondSuffix(string suffix)
    {
      if (suffix == null)
      {
        string str = "Null 'suffix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.secondSuffix = suffix;
    }

    public virtual long getBaseMillis()
    {
      return this.baseMillis;
    }

    public virtual void setBaseMillis(long baseMillis)
    {
      this.baseMillis = baseMillis;
    }

    public virtual bool getShowZeroDays()
    {
      return this.showZeroDays;
    }

    public virtual bool getShowZeroHours()
    {
      return this.showZeroHours;
    }

    public virtual void setShowZeroHours(bool show)
    {
      this.showZeroHours = show;
    }

    public virtual string getPositivePrefix()
    {
      return this.positivePrefix;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositivePrefix(string prefix)
    {
      if (prefix == null)
      {
        string str = "Null 'prefix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.positivePrefix = prefix;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDayFormatter(NumberFormat formatter)
    {
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.dayFormatter = formatter;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setHourFormatter(NumberFormat formatter)
    {
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.hourFormatter = formatter;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 12, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinuteFormatter(NumberFormat formatter)
    {
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.minuteFormatter = formatter;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 103, (byte) 137, (byte) 101, (byte) 101, (byte) 168, (byte) 167, (byte) 113, (byte) 106, (byte) 114, (byte) 107, (byte) 106, (byte) 108, (byte) 143, (byte) 104, (byte) 109, (byte) 159, (byte) 14, (byte) 110, (byte) 191, (byte) 15, (byte) 159, (byte) 15, (byte) 159, (byte) 15})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(Date date, StringBuffer toAppendTo, FieldPosition fieldPosition)
    {
      long num1 = date.getTime() - this.baseMillis;
      string str;
      if (num1 < 0L)
      {
        num1 *= -1L;
        str = "-";
      }
      else
        str = this.positivePrefix;
      long num2 = num1;
      long num3 = RelativeDateFormat.MILLISECONDS_IN_ONE_DAY;
      long num4 = -1L;
      long num5 = num3 != num4 ? num2 / num3 : -num2;
      long num6 = num1 - num5 * RelativeDateFormat.MILLISECONDS_IN_ONE_DAY;
      long num7 = num6;
      long num8 = RelativeDateFormat.MILLISECONDS_IN_ONE_HOUR;
      long num9 = -1L;
      long num10 = num8 != num9 ? num7 / num8 : -num7;
      long num11 = num6 - num10 * RelativeDateFormat.MILLISECONDS_IN_ONE_HOUR;
      long num12 = num11 / 60000L;
      double num13 = (double) (num11 - num12 * 60000L) / 1000.0;
      toAppendTo.append(str);
      if (num5 != 0L || this.showZeroDays)
        toAppendTo.append(new StringBuffer().append(this.dayFormatter.format(num5)).append(this.getDaySuffix()).toString());
      if (num10 != 0L || this.showZeroHours)
        toAppendTo.append(new StringBuffer().append(this.hourFormatter.format(num10)).append(this.getHourSuffix()).toString());
      toAppendTo.append(new StringBuffer().append(this.minuteFormatter.format(num12)).append(this.getMinuteSuffix()).toString());
      toAppendTo.append(new StringBuffer().append(this.secondFormatter.format(num13)).append(this.getSecondSuffix()).toString());
      return toAppendTo;
    }

    public virtual Date parse(string source, ParsePosition pos)
    {
      return (Date) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 146, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is RelativeDateFormat) || !base.equals(obj))
        return false;
      RelativeDateFormat relativeDateFormat = (RelativeDateFormat) obj;
      return this.baseMillis == relativeDateFormat.baseMillis && this.showZeroDays == relativeDateFormat.showZeroDays && (this.showZeroHours == relativeDateFormat.showZeroHours && String.instancehelper_equals(this.positivePrefix, (object) relativeDateFormat.positivePrefix)) && (String.instancehelper_equals(this.daySuffix, (object) relativeDateFormat.daySuffix) && String.instancehelper_equals(this.hourSuffix, (object) relativeDateFormat.hourSuffix) && (String.instancehelper_equals(this.minuteSuffix, (object) relativeDateFormat.minuteSuffix) && String.instancehelper_equals(this.secondSuffix, (object) relativeDateFormat.secondSuffix))) && (this.dayFormatter.equals((object) relativeDateFormat.dayFormatter) && this.hourFormatter.equals((object) relativeDateFormat.hourFormatter) && (this.minuteFormatter.equals((object) relativeDateFormat.minuteFormatter) && this.secondFormatter.equals((object) relativeDateFormat.secondFormatter)));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 201, (byte) 102, (byte) 151, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * (37 * (37 * (37 * (37 * (37 * 193 + (int) (this.baseMillis ^ (long) ((ulong) this.baseMillis >> 32))) + String.instancehelper_hashCode(this.positivePrefix)) + String.instancehelper_hashCode(this.daySuffix)) + String.instancehelper_hashCode(this.hourSuffix)) + String.instancehelper_hashCode(this.minuteSuffix)) + String.instancehelper_hashCode(this.secondSuffix)) + this.secondFormatter.hashCode();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 219, (byte) 108, (byte) 118, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      RelativeDateFormat relativeDateFormat = (RelativeDateFormat) base.clone();
      relativeDateFormat.dayFormatter = (NumberFormat) this.dayFormatter.clone();
      relativeDateFormat.secondFormatter = (NumberFormat) this.secondFormatter.clone();
      return (object) relativeDateFormat;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 231, (byte) 113, (byte) 116, (byte) 138, (byte) 111, (byte) 113, (byte) 118, (byte) 138, (byte) 111, (byte) 112, (byte) 118, (byte) 138, (byte) 111, (byte) 103, (byte) 118, (byte) 138, (byte) 111, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 118, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      GregorianCalendar gregorianCalendar1 = new GregorianCalendar(2006, 10, 1, 0, 0, 0);
      GregorianCalendar gregorianCalendar2 = new GregorianCalendar(2006, 10, 1, 11, 37, 43);
      ((Calendar) gregorianCalendar2).set(14, 123);
      System.get_out().println("Default: ");
      RelativeDateFormat relativeDateFormat = new RelativeDateFormat(((Calendar) gregorianCalendar1).getTime().getTime());
      System.get_out().println(((DateFormat) relativeDateFormat).format(((Calendar) gregorianCalendar2).getTime()));
      System.get_out().println();
      System.get_out().println("Hide milliseconds: ");
      relativeDateFormat.setSecondFormatter((NumberFormat) new DecimalFormat("0"));
      System.get_out().println(((DateFormat) relativeDateFormat).format(((Calendar) gregorianCalendar2).getTime()));
      System.get_out().println();
      System.get_out().println("Show zero day output: ");
      relativeDateFormat.setShowZeroDays(true);
      System.get_out().println(((DateFormat) relativeDateFormat).format(((Calendar) gregorianCalendar2).getTime()));
      System.get_out().println();
      System.get_out().println("Alternative suffixes: ");
      relativeDateFormat.setShowZeroDays(false);
      relativeDateFormat.setDaySuffix(":");
      relativeDateFormat.setHourSuffix(":");
      relativeDateFormat.setMinuteSuffix(":");
      relativeDateFormat.setSecondSuffix("");
      System.get_out().println(((DateFormat) relativeDateFormat).format(((Calendar) gregorianCalendar2).getTime()));
      System.get_out().println();
    }
  }
}
