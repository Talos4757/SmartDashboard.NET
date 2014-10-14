// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.MonthDateFormat
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.text;
using java.util;
using org.jfree.data.time;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class MonthDateFormat : DateFormat
  {
    private string[] months;
    private bool[] showYear;
    private DateFormat yearFormatter;

    [LineNumberTable(new byte[] {(byte) 36, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonthDateFormat(TimeZone zone)
      : this(zone, Locale.getDefault(), 1, true, false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 106, (byte) 70, (byte) 191, (byte) 53})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonthDateFormat(TimeZone zone, Locale locale, int chars, bool showYearForJan, bool showYearForDec)
    {
      int num1 = showYearForJan ? 1 : 0;
      int num2 = showYearForDec ? 1 : 0;
      TimeZone zone1 = zone;
      Locale locale1 = locale;
      int chars1 = chars;
      bool[] showYear = new bool[13];
      int index1 = 0;
      int num3 = num1;
      showYear[index1] = num3 != 0;
      int index2 = 1;
      int num4 = 0;
      showYear[index2] = num4 != 0;
      int index3 = 2;
      int num5 = 0;
      showYear[index3] = num5 != 0;
      int index4 = 3;
      int num6 = 0;
      showYear[index4] = num6 != 0;
      int index5 = 4;
      int num7 = 0;
      showYear[index5] = num7 != 0;
      int index6 = 5;
      int num8 = 0;
      showYear[index6] = num8 != 0;
      int index7 = 6;
      int num9 = 0;
      showYear[index7] = num9 != 0;
      int index8 = 7;
      int num10 = 0;
      showYear[index8] = num10 != 0;
      int index9 = 8;
      int num11 = 0;
      showYear[index9] = num11 != 0;
      int index10 = 9;
      int num12 = 0;
      showYear[index10] = num12 != 0;
      int index11 = 10;
      int num13 = 0;
      showYear[index11] = num13 != 0;
      int index12 = 11;
      int num14 = 0;
      showYear[index12] = num14 != 0;
      int index13 = 12;
      int num15 = num2;
      showYear[index13] = num15 != 0;
      SimpleDateFormat simpleDateFormat = new SimpleDateFormat("yy");
      // ISSUE: explicit constructor call
      this.\u002Ector(zone1, locale1, chars1, showYear, (DateFormat) simpleDateFormat);
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 109, (byte) 103, (byte) 100, (byte) 223, (byte) 2, (byte) 235, (byte) 58, (byte) 230, (byte) 73, (byte) 108, (byte) 104, (byte) 232, (byte) 69, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonthDateFormat(TimeZone zone, Locale locale, int chars, bool[] showYear, DateFormat yearFormatter)
    {
      base.\u002Ector();
      MonthDateFormat monthDateFormat = this;
      if (locale == null)
      {
        string str = "Null 'locale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        string[] months = new DateFormatSymbols(locale).getMonths();
        this.months = new string[12];
        for (int index = 0; index < 12; ++index)
          this.months[index] = chars <= 0 ? months[index] : String.instancehelper_substring(months[index], 0, Math.min(chars, String.instancehelper_length(months[index])));
        this.calendar = (__Null) new GregorianCalendar(zone);
        this.showYear = showYear;
        this.yearFormatter = yearFormatter;
        this.numberFormat = (__Null) NumberFormat.getNumberInstance();
      }
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonthDateFormat(Locale locale, int chars)
      : this(TimeZone.getDefault(), locale, chars, true, false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonthDateFormat()
      : this(TimeZone.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonthDateFormat(Locale locale)
      : this(TimeZone.getDefault(), locale, 1, true, false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonthDateFormat(TimeZone zone, int chars)
      : this(zone, Locale.getDefault(), chars, true, false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MonthDateFormat([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 108, (byte) 109, (byte) 111, (byte) 106, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(Date date, StringBuffer toAppendTo, FieldPosition fieldPosition)
    {
      ((Calendar) this.calendar).setTime(date);
      int index = ((Calendar) this.calendar).get(2);
      toAppendTo.append(this.months[index]);
      if (this.showYear[index])
        toAppendTo.append(this.yearFormatter.format(date));
      return toAppendTo;
    }

    public virtual Date parse(string source, ParsePosition pos)
    {
      return (Date) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MonthDateFormat) || !base.equals(obj))
        return false;
      MonthDateFormat monthDateFormat = (MonthDateFormat) obj;
      return Arrays.equals((object[]) this.months, (object[]) monthDateFormat.months) && Arrays.equals(this.showYear, monthDateFormat.showYear) && this.yearFormatter.equals((object) monthDateFormat.yearFormatter);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 144, (byte) 108, (byte) 111, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 138, (byte) 108, (byte) 111, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 138, (byte) 108, (byte) 111, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 138, (byte) 107, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      MonthDateFormat monthDateFormat1 = new MonthDateFormat((Locale) Locale.UK, 2);
      System.get_out().println("UK:");
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(1, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(2, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(3, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(4, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(5, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(6, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(7, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(8, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(9, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(10, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(11, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat1).format(new Month(12, 2005).getStart()));
      System.get_out().println();
      MonthDateFormat monthDateFormat2 = new MonthDateFormat((Locale) Locale.GERMANY, 2);
      System.get_out().println("GERMANY:");
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(1, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(2, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(3, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(4, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(5, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(6, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(7, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(8, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(9, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(10, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(11, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat2).format(new Month(12, 2005).getStart()));
      System.get_out().println();
      MonthDateFormat monthDateFormat3 = new MonthDateFormat((Locale) Locale.FRANCE, 2);
      System.get_out().println("FRANCE:");
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(1, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(2, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(3, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(4, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(5, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(6, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(7, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(8, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(9, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(10, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(11, 2005).getStart()));
      System.get_out().println(((DateFormat) monthDateFormat3).format(new Month(12, 2005).getStart()));
      System.get_out().println();
      ((DateFormat) new SimpleDateFormat("yyyy")).setNumberFormat((NumberFormat) null);
    }
  }
}
