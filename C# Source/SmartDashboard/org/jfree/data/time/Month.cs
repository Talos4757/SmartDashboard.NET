// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Month
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.date;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class Month : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -5090216912548722570L;
    private int month;
    private int year;
    private long firstMillisecond;
    private long lastMillisecond;

    [HideFromJava]
    static Month()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 104, (byte) 104, (byte) 103, (byte) 111, (byte) 109, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Month(Date time, TimeZone zone, Locale locale)
    {
      Month month = this;
      Calendar instance = Calendar.getInstance(zone, locale);
      instance.setTime(time);
      this.month = instance.get(2) + 1;
      this.year = instance.get(1);
      this.peg(instance);
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 104, (byte) 105, (byte) 144, (byte) 103, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Month(int month, int year)
    {
      Month month1 = this;
      if (month < 1 || month > 12)
      {
        string str = "Month outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.month = month;
        this.year = year;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Month(Date time)
      : this(time, TimeZone.getDefault())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 109, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Month(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 104, (byte) 105, (byte) 144, (byte) 103, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Month(int month, Year year)
    {
      Month month1 = this;
      if (month < 1 || month > 12)
      {
        string str = "Month outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.month = month;
        this.year = year.getYear();
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Month()
      : this(new Date())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Month([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Month obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 144, (byte) 105, (byte) 182, (byte) 109, (byte) 178, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      return this.month == 1 ? (this.year <= 1900 ? (RegularTimePeriod) null : (RegularTimePeriod) new Month(12, this.year - 1)) : (RegularTimePeriod) new Month(this.month - 1, this.year);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
      this.lastMillisecond = this.getLastMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 120, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      calendar.set(this.year, this.month - 1, 1, 0, 0, 0);
      calendar.set(14, 0);
      return calendar.getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 114, (byte) 123, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      int num = SerialDate.lastDayOfMonth(this.month, this.year);
      calendar.set(this.year, this.month - 1, num, 23, 59, 59);
      calendar.set(14, 999);
      return calendar.getTime().getTime();
    }

    public virtual int getYearValue()
    {
      return this.year;
    }

    public virtual int getMonth()
    {
      return this.month;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 144, (byte) 105, (byte) 100, (byte) 137, (byte) 100, (byte) 137, (byte) 100, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int findSeparator([In] string obj0)
    {
      int num = String.instancehelper_indexOf(obj0, 45);
      if (num == -1)
        num = String.instancehelper_indexOf(obj0, 44);
      if (num == -1)
        num = String.instancehelper_indexOf(obj0, 32);
      if (num == -1)
        num = String.instancehelper_indexOf(obj0, 46);
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 167, (byte) 130, (byte) 210, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Year evaluateAsYear([In] string obj0)
    {
      Year year = (Year) null;
      try
      {
        year = Year.parseYear(obj0);
        goto label_4;
      }
      catch (TimePeriodFormatException ex)
      {
      }
label_4:
      return year;
    }

    [LineNumberTable((ushort) 186)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Year getYear()
    {
      Year.__\u003Cclinit\u003E();
      return new Year(this.year);
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.lastMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 106, (byte) 182, (byte) 109, (byte) 177, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      return this.month == 12 ? (this.year >= 9999 ? (RegularTimePeriod) null : (RegularTimePeriod) new Month(1, this.year + 1)) : (RegularTimePeriod) new Month(this.month + 1, this.year);
    }

    public override long getSerialIndex()
    {
      return (long) this.year * 12L + (long) this.month;
    }

    [LineNumberTable((ushort) 313)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append(SerialDate.monthCodeToString(this.month)).append(" ").append(this.year).toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 213, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Month))
        return false;
      Month month = (Month) obj;
      return this.month == month.month && this.year == month.year;
    }

    public virtual int hashCode()
    {
      return 37 * (37 * 17 + this.month) + this.year;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 4, (byte) 104, (byte) 103, (byte) 110, (byte) 99, (byte) 142, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object o1)
    {
      int num;
      if (o1 is Month)
      {
        Month month = (Month) o1;
        num = this.year - month.getYearValue();
        if (num == 0)
          num = this.month - month.getMonth();
      }
      else
        num = !(o1 is RegularTimePeriod) ? 1 : 0;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 80, (byte) 98, (byte) 99, (byte) 162, (byte) 104, (byte) 231, (byte) 69, (byte) 100, (byte) 98, (byte) 105, (byte) 173, (byte) 110, (byte) 149, (byte) 104, (byte) 100, (byte) 164, (byte) 104, (byte) 100, (byte) 164, (byte) 239, (byte) 70, (byte) 99, (byte) 104, (byte) 170, (byte) 104, (byte) 136, (byte) 101, (byte) 144, (byte) 100, (byte) 144, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Month parseMonth(string s)
    {
      if (s == null)
        return (Month) null;
      s = String.instancehelper_trim(s);
      int separator = Month.findSeparator(s);
      int num;
      string s1;
      string s2;
      if (separator == -1)
      {
        num = 1;
        s1 = String.instancehelper_substring(s, 0, 5);
        s2 = String.instancehelper_substring(s, 5);
      }
      else
      {
        s1 = String.instancehelper_trim(String.instancehelper_substring(s, 0, separator));
        s2 = String.instancehelper_trim(String.instancehelper_substring(s, separator + 1, String.instancehelper_length(s)));
        num = Month.evaluateAsYear(s1) != null ? (Month.evaluateAsYear(s2) != null ? (String.instancehelper_length(s1) > String.instancehelper_length(s2) ? 1 : 0) : 1) : 0;
      }
      Year year;
      int month;
      if (num != 0)
      {
        year = Month.evaluateAsYear(s1);
        month = SerialDate.stringToMonthCode(s2);
      }
      else
      {
        year = Month.evaluateAsYear(s2);
        month = SerialDate.stringToMonthCode(s1);
      }
      if (month == -1)
      {
        string message = "Can't evaluate the month.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TimePeriodFormatException(message);
      }
      else
      {
        if (year != null)
          return new Month(month, year);
        string message = "Can't evaluate the year.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TimePeriodFormatException(message);
      }
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
