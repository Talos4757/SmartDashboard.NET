// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Hour
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
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
  public class Hour : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -835471579831937652L;
    public const int FIRST_HOUR_IN_DAY = 0;
    public const int LAST_HOUR_IN_DAY = 23;
    private Day day;
    private byte hour;
    private long firstMillisecond;
    private long lastMillisecond;

    [HideFromJava]
    static Hour()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hour(Date time)
      : this(time, TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 104, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hour(int hour, Day day)
    {
      Hour hour1 = this;
      if (day == null)
      {
        string str = "Null 'day' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.hour = (byte) hour;
        this.day = day;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 111, (byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hour(Date time, TimeZone zone, Locale locale)
    {
      Hour hour = this;
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
        this.hour = (byte) instance.get(11);
        this.day = new Day(time, zone, locale);
        this.peg(instance);
      }
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hour()
      : this(new Date())
    {
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hour(int hour, int day, int month, int year)
      : this(hour, new Day(day, month, year))
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 108, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hour(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Hour([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Hour obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
      this.lastMillisecond = this.getLastMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 108, (byte) 110, (byte) 108, (byte) 114, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      int year = this.day.getYear();
      int num = this.day.getMonth() - 1;
      int dayOfMonth = this.day.getDayOfMonth();
      calendar.set(year, num, dayOfMonth, (int) (sbyte) this.hour, 0, 0);
      calendar.set(14, 0);
      return calendar.getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 244, (byte) 108, (byte) 110, (byte) 108, (byte) 116, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      int year = this.day.getYear();
      int num = this.day.getMonth() - 1;
      int dayOfMonth = this.day.getDayOfMonth();
      calendar.set(year, num, dayOfMonth, (int) (sbyte) this.hour, 59, 59);
      calendar.set(14, 999);
      return calendar.getTime().getTime();
    }

    [LineNumberTable((ushort) 230)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getDayOfMonth()
    {
      return this.day.getDayOfMonth();
    }

    [LineNumberTable((ushort) 221)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getMonth()
    {
      return this.day.getMonth();
    }

    [LineNumberTable((ushort) 212)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getYear()
    {
      return this.day.getYear();
    }

    public virtual Day getDay()
    {
      return this.day;
    }

    public virtual int getHour()
    {
      return (int) (sbyte) this.hour;
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.lastMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 167, (byte) 105, (byte) 183, (byte) 113, (byte) 99, (byte) 171, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      Hour hour;
      if ((int) (sbyte) this.hour != 0)
      {
        hour = new Hour((int) (sbyte) this.hour - 1, this.day);
      }
      else
      {
        Day day = (Day) this.day.previous();
        hour = day == null ? (Hour) null : new Hour(23, day);
      }
      return (RegularTimePeriod) hour;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 107, (byte) 183, (byte) 113, (byte) 99, (byte) 170, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      Hour hour;
      if ((int) (sbyte) this.hour != 23)
      {
        hour = new Hour((int) (sbyte) this.hour + 1, this.day);
      }
      else
      {
        Day day = (Day) this.day.next();
        hour = day == null ? (Hour) null : new Hour(0, day);
      }
      return (RegularTimePeriod) hour;
    }

    [LineNumberTable((ushort) 324)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getSerialIndex()
    {
      return this.day.getSerialIndex() * 24L + (long) (sbyte) this.hour;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 112, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Hour))
        return false;
      Hour hour = (Hour) obj;
      return (int) (sbyte) this.hour == (int) (sbyte) hour.hour && this.day.equals((object) hour.day);
    }

    [LineNumberTable((ushort) 402)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append("[").append((int) (sbyte) this.hour).append(",").append(this.getDayOfMonth()).append("/").append(this.getMonth()).append("/").append(this.getYear()).append("]").toString();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 99, (byte) 109, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * 17 + (int) (sbyte) this.hour) + this.day.hashCode();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 67, (byte) 104, (byte) 103, (byte) 114, (byte) 99, (byte) 143, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object o1)
    {
      int num;
      if (o1 is Hour)
      {
        Hour hour = (Hour) o1;
        num = this.getDay().compareTo((object) hour.getDay());
        if (num == 0)
          num = (int) (sbyte) this.hour - hour.getHour();
      }
      else
        num = !(o1 is RegularTimePeriod) ? 1 : 0;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 103, (byte) 98, (byte) 136, (byte) 117, (byte) 103, (byte) 99, (byte) 191, (byte) 1, (byte) 103, (byte) 136, (byte) 107, (byte) 201})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Hour parseHour(string s)
    {
      Hour hour1 = (Hour) null;
      s = String.instancehelper_trim(s);
      string s1 = String.instancehelper_substring(s, 0, Math.min(10, String.instancehelper_length(s)));
      Day day = Day.parseDay(s1);
      if (day != null)
      {
        int hour2 = Integer.parseInt(String.instancehelper_trim(String.instancehelper_substring(s, Math.min(String.instancehelper_length(s1) + 1, String.instancehelper_length(s)), String.instancehelper_length(s))));
        if (hour2 >= 0 && hour2 <= 23)
          hour1 = new Hour(hour2, day);
      }
      return hour1;
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
