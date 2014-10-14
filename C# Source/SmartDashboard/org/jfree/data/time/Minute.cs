// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Minute
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
  public class Minute : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 2144572840034842871L;
    public const int FIRST_MINUTE_IN_HOUR = 0;
    public const int LAST_MINUTE_IN_HOUR = 59;
    private Day day;
    private byte hour;
    private byte minute;
    private long firstMillisecond;
    private long lastMillisecond;

    [HideFromJava]
    static Minute()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minute(Date time)
      : this(time, TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 105, (byte) 104, (byte) 111, (byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minute(Date time, TimeZone zone, Locale locale)
    {
      Minute minute = this;
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
        this.minute = (byte) instance.get(12);
        this.hour = (byte) instance.get(11);
        this.day = new Day(time, zone, locale);
        this.peg(instance);
      }
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 104, (byte) 99, (byte) 144, (byte) 104, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minute(int minute, Hour hour)
    {
      Minute minute1 = this;
      if (hour == null)
      {
        string str = "Null 'hour' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minute = (byte) minute;
        this.hour = (byte) hour.getHour();
        this.day = hour.getDay();
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minute()
      : this(new Date())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 100, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minute(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 126})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Minute(int minute, int hour, int day, int month, int year)
    {
      int minute1 = minute;
      Hour.__\u003Cclinit\u003E();
      Hour hour1 = new Hour(hour, new Day(day, month, year));
      // ISSUE: explicit constructor call
      this.\u002Ector(minute1, hour1);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Minute([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Minute obj0)
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

    public virtual int getMinute()
    {
      return (int) (sbyte) this.minute;
    }

    public virtual int getHourValue()
    {
      return (int) (sbyte) this.hour;
    }

    public virtual Day getDay()
    {
      return this.day;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
      this.lastMillisecond = this.getLastMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 227, (byte) 108, (byte) 110, (byte) 140, (byte) 102, (byte) 120, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      int year = this.day.getYear();
      int num = this.day.getMonth() - 1;
      int dayOfMonth = this.day.getDayOfMonth();
      calendar.clear();
      calendar.set(year, num, dayOfMonth, (int) (sbyte) this.hour, (int) (sbyte) this.minute, 0);
      calendar.set(14, 0);
      return calendar.getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 108, (byte) 110, (byte) 140, (byte) 102, (byte) 121, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      int year = this.day.getYear();
      int num = this.day.getMonth() - 1;
      int dayOfMonth = this.day.getDayOfMonth();
      calendar.clear();
      calendar.set(year, num, dayOfMonth, (int) (sbyte) this.hour, (int) (sbyte) this.minute, 59);
      calendar.set(14, 999);
      return calendar.getTime().getTime();
    }

    [LineNumberTable((ushort) 211)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Hour getHour()
    {
      Hour.__\u003Cclinit\u003E();
      return new Hour((int) (sbyte) this.hour, this.day);
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.lastMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 105, (byte) 183, (byte) 113, (byte) 99, (byte) 171, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      Minute minute;
      if ((int) (sbyte) this.minute != 0)
      {
        minute = new Minute((int) (sbyte) this.minute - 1, this.getHour());
      }
      else
      {
        Hour hour = (Hour) this.getHour().previous();
        minute = hour == null ? (Minute) null : new Minute(59, hour);
      }
      return (RegularTimePeriod) minute;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 107, (byte) 183, (byte) 113, (byte) 99, (byte) 170, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      Minute minute;
      if ((int) (sbyte) this.minute != 59)
      {
        minute = new Minute((int) (sbyte) this.minute + 1, this.getHour());
      }
      else
      {
        Hour hour = (Hour) this.getHour().next();
        minute = hour == null ? (Minute) null : new Minute(0, hour);
      }
      return (RegularTimePeriod) minute;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getSerialIndex()
    {
      return (this.day.getSerialIndex() * 24L + (long) (sbyte) this.hour) * 60L + (long) (sbyte) this.minute;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 19, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 112, (byte) 130, (byte) 112, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Minute))
        return false;
      Minute minute = (Minute) obj;
      return (int) (sbyte) this.minute == (int) (sbyte) minute.minute && (int) (sbyte) this.hour == (int) (sbyte) minute.hour;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 45, (byte) 99, (byte) 109, (byte) 109, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * (37 * 17 + (int) (sbyte) this.minute) + (int) (sbyte) this.hour) + this.day.hashCode();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 67, (byte) 104, (byte) 103, (byte) 114, (byte) 99, (byte) 143, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object o1)
    {
      int num;
      if (o1 is Minute)
      {
        Minute minute = (Minute) o1;
        num = this.getHour().compareTo((object) minute.getHour());
        if (num == 0)
          num = (int) (sbyte) this.minute - minute.getMinute();
      }
      else
        num = !(o1 is RegularTimePeriod) ? 1 : 0;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 103, (byte) 98, (byte) 136, (byte) 117, (byte) 103, (byte) 102, (byte) 191, (byte) 1, (byte) 135, (byte) 117, (byte) 137, (byte) 107, (byte) 223, (byte) 3, (byte) 105, (byte) 107, (byte) 208})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Minute parseMinute(string s)
    {
      Minute minute1 = (Minute) null;
      s = String.instancehelper_trim(s);
      string s1 = String.instancehelper_substring(s, 0, Math.min(10, String.instancehelper_length(s)));
      Day day = Day.parseDay(s1);
      if (day != null)
      {
        string str1 = String.instancehelper_trim(String.instancehelper_substring(s, Math.min(String.instancehelper_length(s1) + 1, String.instancehelper_length(s)), String.instancehelper_length(s)));
        string str2 = String.instancehelper_substring(str1, 0, Math.min(2, String.instancehelper_length(str1)));
        int hour = Integer.parseInt(str2);
        if (hour >= 0 && hour <= 23)
        {
          int minute2 = Integer.parseInt(String.instancehelper_substring(str1, Math.min(String.instancehelper_length(str2) + 1, String.instancehelper_length(str1)), String.instancehelper_length(str1)));
          if (minute2 >= 0 && minute2 <= 59)
            minute1 = new Minute(minute2, new Hour(hour, day));
        }
      }
      return minute1;
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
