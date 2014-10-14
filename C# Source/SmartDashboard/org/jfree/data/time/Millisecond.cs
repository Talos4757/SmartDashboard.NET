// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Millisecond
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
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
  public class Millisecond : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = -5316836467277638485L;
    public const int FIRST_MILLISECOND_IN_SECOND = 0;
    public const int LAST_MILLISECOND_IN_SECOND = 999;
    private Day day;
    private byte hour;
    private byte minute;
    private byte second;
    private int millisecond;
    private long firstMillisecond;

    [HideFromJava]
    static Millisecond()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Millisecond()
      : this(new Date())
    {
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Millisecond(Date time)
      : this(time, TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 104, (byte) 103, (byte) 109, (byte) 114, (byte) 114, (byte) 113, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Millisecond(int millisecond, Second second)
    {
      Millisecond millisecond1 = this;
      this.millisecond = millisecond;
      this.second = (byte) second.getSecond();
      this.minute = (byte) second.getMinute().getMinute();
      this.hour = (byte) second.getMinute().getHourValue();
      this.day = second.getMinute().getDay();
      this.peg(Calendar.getInstance());
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 104, (byte) 104, (byte) 103, (byte) 110, (byte) 111, (byte) 111, (byte) 111, (byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Millisecond(Date time, TimeZone zone, Locale locale)
    {
      Millisecond millisecond = this;
      Calendar instance = Calendar.getInstance(zone, locale);
      instance.setTime(time);
      this.millisecond = instance.get(14);
      this.second = (byte) instance.get(13);
      this.minute = (byte) instance.get(12);
      this.hour = (byte) instance.get(11);
      this.day = new Day(time, zone, locale);
      this.peg(instance);
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Millisecond(int millisecond, int second, int minute, int hour, int day, int month, int year)
      : this(millisecond, new Second(second, minute, hour, day, month, year))
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 114, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Millisecond(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Millisecond([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Millisecond obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 43, (byte) 108, (byte) 110, (byte) 108, (byte) 102, (byte) 126, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      int year = this.day.getYear();
      int num = this.day.getMonth() - 1;
      int dayOfMonth = this.day.getDayOfMonth();
      calendar.clear();
      calendar.set(year, num, dayOfMonth, (int) (sbyte) this.hour, (int) (sbyte) this.minute, (int) (sbyte) this.second);
      calendar.set(14, this.millisecond);
      return calendar.getTime().getTime();
    }

    [LineNumberTable((ushort) 193)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Second getSecond()
    {
      Second.__\u003Cclinit\u003E();
      return new Second((int) (sbyte) this.second, (int) (sbyte) this.minute, (int) (sbyte) this.hour, this.day.getDayOfMonth(), this.day.getMonth(), this.day.getYear());
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public virtual long getMillisecond()
    {
      return (long) this.millisecond;
    }

    public override long getLastMillisecond()
    {
      return this.firstMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 139, (byte) 98, (byte) 104, (byte) 182, (byte) 113, (byte) 99, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      Millisecond millisecond = (Millisecond) null;
      if (this.millisecond != 0)
      {
        millisecond = new Millisecond(this.millisecond - 1, this.getSecond());
      }
      else
      {
        Second second = (Second) this.getSecond().previous();
        if (second != null)
          millisecond = new Millisecond(999, second);
      }
      return (RegularTimePeriod) millisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 158, (byte) 98, (byte) 109, (byte) 182, (byte) 113, (byte) 99, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      Millisecond millisecond = (Millisecond) null;
      if (this.millisecond != 999)
      {
        millisecond = new Millisecond(this.millisecond + 1, this.getSecond());
      }
      else
      {
        Second second = (Second) this.getSecond().next();
        if (second != null)
          millisecond = new Millisecond(0, second);
      }
      return (RegularTimePeriod) millisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 121, (byte) 111, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getSerialIndex()
    {
      return (((this.day.getSerialIndex() * 24L + (long) (sbyte) this.hour) * 60L + (long) (sbyte) this.minute) * 60L + (long) (sbyte) this.second) * 1000L + (long) this.millisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 195, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 112, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Millisecond))
        return false;
      Millisecond millisecond = (Millisecond) obj;
      return this.millisecond == millisecond.millisecond && (int) (sbyte) this.second == (int) (sbyte) millisecond.second && ((int) (sbyte) this.minute == (int) (sbyte) millisecond.minute && (int) (sbyte) this.hour == (int) (sbyte) millisecond.hour) && this.day.equals((object) millisecond.day);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 99, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * 17 + this.millisecond) + this.getSecond().hashCode();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 104, (byte) 103, (byte) 110, (byte) 101, (byte) 164, (byte) 101, (byte) 164, (byte) 162, (byte) 194, (byte) 104, (byte) 103, (byte) 104, (byte) 104, (byte) 148, (byte) 226, (byte) 70, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object obj)
    {
      int num1;
      if (obj is Millisecond)
      {
        long num2 = this.getFirstMillisecond() - ((Millisecond) obj).getFirstMillisecond();
        num1 = num2 <= 0L ? (num2 >= 0L ? 0 : -1) : 1;
      }
      else if (obj is RegularTimePeriod)
      {
        RegularTimePeriod regularTimePeriod = (RegularTimePeriod) obj;
        long firstMillisecond1 = this.getFirstMillisecond();
        long firstMillisecond2 = regularTimePeriod.getFirstMillisecond();
        num1 = firstMillisecond1 >= firstMillisecond2 ? (firstMillisecond1 != firstMillisecond2 ? 1 : 0) : -1;
      }
      else
        num1 = 1;
      return num1;
    }

    [LineNumberTable((ushort) 434)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      return this.getFirstMillisecond(calendar);
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
