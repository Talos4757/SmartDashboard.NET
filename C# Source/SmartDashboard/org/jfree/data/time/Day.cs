// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Day
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
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
  public class Day : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -7082667380758962755L;
    internal static DateFormat __\u003C\u003EDATE_FORMAT;
    internal static DateFormat __\u003C\u003EDATE_FORMAT_SHORT;
    internal static DateFormat __\u003C\u003EDATE_FORMAT_MEDIUM;
    internal static DateFormat __\u003C\u003EDATE_FORMAT_LONG;
    private SerialDate serialDate;
    private long firstMillisecond;
    private long lastMillisecond;

    [Modifiers]
    protected internal static DateFormat DATE_FORMAT
    {
      [HideFromJava] get
      {
        return Day.__\u003C\u003EDATE_FORMAT;
      }
    }

    [Modifiers]
    protected internal static DateFormat DATE_FORMAT_SHORT
    {
      [HideFromJava] get
      {
        return Day.__\u003C\u003EDATE_FORMAT_SHORT;
      }
    }

    [Modifiers]
    protected internal static DateFormat DATE_FORMAT_MEDIUM
    {
      [HideFromJava] get
      {
        return Day.__\u003C\u003EDATE_FORMAT_MEDIUM;
      }
    }

    [Modifiers]
    protected internal static DateFormat DATE_FORMAT_LONG
    {
      [HideFromJava] get
      {
        return Day.__\u003C\u003EDATE_FORMAT_LONG;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 120, (byte) 69, (byte) 239, (byte) 69, (byte) 203, (byte) 203})]
    static Day()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
      Day.__\u003C\u003EDATE_FORMAT = (DateFormat) new SimpleDateFormat("yyyy-MM-dd");
      Day.__\u003C\u003EDATE_FORMAT_SHORT = DateFormat.getDateInstance(3);
      Day.__\u003C\u003EDATE_FORMAT_MEDIUM = DateFormat.getDateInstance(2);
      Day.__\u003C\u003EDATE_FORMAT_LONG = DateFormat.getDateInstance(1);
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Day()
      : this(new Date())
    {
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Day(Date time)
      : this(time, TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 104, (byte) 106, (byte) 105, (byte) 111, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Day(Date time, TimeZone zone, Locale locale)
    {
      Day day = this;
      if (time == null)
      {
        string str = "Null 'time' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (zone == null)
      {
        string str = "Null 'zone' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (locale == null)
      {
        string str = "Null 'locale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Calendar instance = Calendar.getInstance(zone, locale);
        instance.setTime(time);
        this.serialDate = SerialDate.createInstance(instance.get(5), instance.get(2) + 1, instance.get(1));
        this.peg(instance);
      }
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Day(SerialDate serialDate)
    {
      Day day = this;
      if (serialDate == null)
      {
        string str = "Null 'serialDate' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.serialDate = serialDate;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 104, (byte) 110, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Day(int day, int month, int year)
    {
      Day day1 = this;
      this.serialDate = SerialDate.createInstance(day, month, year);
      this.peg(Calendar.getInstance());
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 118, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Day(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Day([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Day obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
      this.lastMillisecond = this.getLastMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 108, (byte) 108, (byte) 108, (byte) 102, (byte) 110, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      int yyyy = this.serialDate.getYYYY();
      int month = this.serialDate.getMonth();
      int dayOfMonth = this.serialDate.getDayOfMonth();
      calendar.clear();
      calendar.set(yyyy, month - 1, dayOfMonth, 0, 0, 0);
      calendar.set(14, 0);
      return calendar.getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 245, (byte) 108, (byte) 108, (byte) 108, (byte) 102, (byte) 113, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      int yyyy = this.serialDate.getYYYY();
      int month = this.serialDate.getMonth();
      int dayOfMonth = this.serialDate.getDayOfMonth();
      calendar.clear();
      calendar.set(yyyy, month - 1, dayOfMonth, 23, 59, 59);
      calendar.set(14, 999);
      return calendar.getTime().getTime();
    }

    public virtual SerialDate getSerialDate()
    {
      return this.serialDate;
    }

    [LineNumberTable((ushort) 216)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getYear()
    {
      return this.serialDate.getYYYY();
    }

    [LineNumberTable((ushort) 225)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getMonth()
    {
      return this.serialDate.getMonth();
    }

    [LineNumberTable((ushort) 234)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDayOfMonth()
    {
      return this.serialDate.getDayOfMonth();
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.lastMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 108, (byte) 100, (byte) 105, (byte) 169, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      int num = this.serialDate.toSerial();
      if (num > 2)
        return (RegularTimePeriod) new Day(SerialDate.createInstance(num - 1));
      else
        return (RegularTimePeriod) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 108, (byte) 104, (byte) 105, (byte) 169, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      int num = this.serialDate.toSerial();
      if (num < 2958465)
        return (RegularTimePeriod) new Day(SerialDate.createInstance(num + 1));
      else
        return (RegularTimePeriod) null;
    }

    [LineNumberTable((ushort) 322)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getSerialIndex()
    {
      return (long) this.serialDate.toSerial();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is Day && Object.instancehelper_equals((object) this.serialDate, (object) ((Day) obj).getSerialDate());
    }

    [LineNumberTable((ushort) 403)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return Object.instancehelper_hashCode((object) this.serialDate);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 51, (byte) 104, (byte) 103, (byte) 115, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object o1)
    {
      return !(o1 is Day) ? (!(o1 is RegularTimePeriod) ? 1 : 0) : -((Day) o1).getSerialDate().compare(this.serialDate);
    }

    [LineNumberTable((ushort) 449)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return this.serialDate.toString();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 95, (byte) 159, (byte) 0, (byte) 129, (byte) 159, (byte) 0, (byte) 193})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Day parseDay(string s)
    {
      Day day1;
      try
      {
        day1 = new Day(Day.__\u003C\u003EDATE_FORMAT.parse(s));
      }
      catch (ParseException ex)
      {
        goto label_3;
      }
      return day1;
label_3:
      Day day2;
      try
      {
        day2 = new Day(Day.__\u003C\u003EDATE_FORMAT_SHORT.parse(s));
      }
      catch (ParseException ex)
      {
        goto label_7;
      }
      return day2;
label_7:
      return (Day) null;
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
