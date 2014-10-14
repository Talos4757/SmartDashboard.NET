// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Second
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
  public class Second : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -6536564190712383466L;
    public const int FIRST_SECOND_IN_MINUTE = 0;
    public const int LAST_SECOND_IN_MINUTE = 59;
    private Day day;
    private byte hour;
    private byte minute;
    private byte second;
    private long firstMillisecond;

    [HideFromJava]
    static Second()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Second(int second, int minute, int hour, int day, int month, int year)
      : this(second, new Minute(minute, hour, day, month, year))
    {
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Second(Date time)
      : this(time, TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 104, (byte) 99, (byte) 144, (byte) 108, (byte) 109, (byte) 109, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Second(int second, Minute minute)
    {
      Second second1 = this;
      if (minute == null)
      {
        string str = "Null 'minute' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.day = minute.getDay();
        this.hour = (byte) minute.getHourValue();
        this.minute = (byte) minute.getMinute();
        this.second = (byte) second;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 104, (byte) 104, (byte) 103, (byte) 111, (byte) 111, (byte) 111, (byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Second(Date time, TimeZone zone, Locale locale)
    {
      Second second = this;
      Calendar instance = Calendar.getInstance(zone, locale);
      instance.setTime(time);
      this.second = (byte) instance.get(13);
      this.minute = (byte) instance.get(12);
      this.hour = (byte) instance.get(11);
      this.day = new Day(time, zone, locale);
      this.peg(instance);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Second()
      : this(new Date())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 113, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Second(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Second([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Second obj0)
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

    public virtual int getSecond()
    {
      return (int) (sbyte) this.second;
    }

    [LineNumberTable((ushort) 200)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Minute getMinute()
    {
      Minute.__\u003Cclinit\u003E();
      int minute = (int) (sbyte) this.minute;
      Hour.__\u003Cclinit\u003E();
      Hour hour = new Hour((int) (sbyte) this.hour, this.day);
      return new Minute(minute, hour);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 98, (byte) 105, (byte) 183, (byte) 113, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      Second second = (Second) null;
      if ((int) (sbyte) this.second != 0)
      {
        second = new Second((int) (sbyte) this.second - 1, this.getMinute());
      }
      else
      {
        Minute minute = (Minute) this.getMinute().previous();
        if (minute != null)
          second = new Second(59, minute);
      }
      return (RegularTimePeriod) second;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 98, (byte) 107, (byte) 183, (byte) 113, (byte) 99, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      Second second = (Second) null;
      if ((int) (sbyte) this.second != 59)
      {
        second = new Second((int) (sbyte) this.second + 1, this.getMinute());
      }
      else
      {
        Minute minute = (Minute) this.getMinute().next();
        if (minute != null)
          second = new Second(0, minute);
      }
      return (RegularTimePeriod) second;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 1, (byte) 99, (byte) 109, (byte) 109, (byte) 109, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * (37 * (37 * 17 + (int) (sbyte) this.second) + (int) (sbyte) this.minute) + (int) (sbyte) this.hour) + this.day.hashCode();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 108, (byte) 110, (byte) 108, (byte) 102, (byte) 126, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      int year = this.day.getYear();
      int num = this.day.getMonth() - 1;
      int dayOfMonth = this.day.getDayOfMonth();
      calendar.clear();
      calendar.set(year, num, dayOfMonth, (int) (sbyte) this.hour, (int) (sbyte) this.minute, (int) (sbyte) this.second);
      calendar.set(14, 0);
      return calendar.getTime().getTime();
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.firstMillisecond + 999L;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 173, (byte) 121, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getSerialIndex()
    {
      return ((this.day.getSerialIndex() * 24L + (long) (sbyte) this.hour) * 60L + (long) (sbyte) this.minute) * 60L + (long) (sbyte) this.second;
    }

    [LineNumberTable((ushort) 324)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      return this.getFirstMillisecond(calendar) + 999L;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 225, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Second))
        return false;
      Second second = (Second) obj;
      return (int) (sbyte) this.second == (int) (sbyte) second.second && (int) (sbyte) this.minute == (int) (sbyte) second.minute && ((int) (sbyte) this.hour == (int) (sbyte) second.hour && this.day.equals((object) second.day));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 104, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 162, (byte) 226, (byte) 70, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    public override int compareTo(object o1)
    {
      if (!(o1 is Second))
        return !(o1 is RegularTimePeriod) ? 1 : 0;
      Second second = (Second) o1;
      if (this.firstMillisecond < second.firstMillisecond)
        return -1;
      return this.firstMillisecond > second.firstMillisecond ? 1 : 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 63, (byte) 98, (byte) 104, (byte) 117, (byte) 103, (byte) 102, (byte) 159, (byte) 1, (byte) 135, (byte) 104, (byte) 113, (byte) 120, (byte) 120, (byte) 137, (byte) 142, (byte) 105, (byte) 139, (byte) 118, (byte) 105, (byte) 107, (byte) 234, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Second parseSecond(string s)
    {
      Second second1 = (Second) null;
      s = String.instancehelper_trim(s);
      string s1 = String.instancehelper_substring(s, 0, Math.min(10, String.instancehelper_length(s)));
      Day day = Day.parseDay(s1);
      if (day != null)
      {
        string str1 = String.instancehelper_trim(String.instancehelper_substring(s, Math.min(String.instancehelper_length(s1) + 1, String.instancehelper_length(s)), String.instancehelper_length(s)));
        int num = String.instancehelper_length(str1);
        string str2 = String.instancehelper_substring(str1, 0, Math.min(2, num));
        string str3 = String.instancehelper_substring(str1, Math.min(3, num), Math.min(5, num));
        string str4 = String.instancehelper_substring(str1, Math.min(6, num), Math.min(8, num));
        int hour = Integer.parseInt(str2);
        if (hour >= 0 && hour <= 23)
        {
          int minute1 = Integer.parseInt(str3);
          if (minute1 >= 0 && minute1 <= 59)
          {
            Minute.__\u003Cclinit\u003E();
            Minute minute2 = new Minute(minute1, new Hour(hour, day));
            int second2 = Integer.parseInt(str4);
            if (second2 >= 0 && second2 <= 59)
              second1 = new Second(second2, minute2);
          }
        }
      }
      return second1;
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
