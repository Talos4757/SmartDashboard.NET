// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Year
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
  public class Year : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    public const int MINIMUM_YEAR = -9999;
    public const int MAXIMUM_YEAR = 9999;
    private const long serialVersionUID = -7659990929736074836L;
    private short year;
    private long firstMillisecond;
    private long lastMillisecond;

    [HideFromJava]
    static Year()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 104, (byte) 104, (byte) 103, (byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Year(Date time, TimeZone zone, Locale locale)
    {
      Year year = this;
      Calendar instance = Calendar.getInstance(zone, locale);
      instance.setTime(time);
      this.year = (short) instance.get(1);
      this.peg(instance);
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 104, (byte) 112, (byte) 191, (byte) 16, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Year(int year)
    {
      Year year1 = this;
      if (year < -9999 || year > 9999)
      {
        string str = new StringBuffer().append("Year constructor: year (").append(year).append(") outside valid range.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.year = (short) year;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Year(Date time)
      : this(time, TimeZone.getDefault())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 95, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Year(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Year()
      : this(new Date())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Year([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Year obj0)
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

    public virtual int getYear()
    {
      return (int) this.year;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 215, (byte) 2, (byte) 97, (byte) 240, (byte) 69, (byte) 149, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Year parseYear(string s)
    {
      int year1;
      try
      {
        year1 = Integer.parseInt(String.instancehelper_trim(s));
        goto label_3;
      }
      catch (NumberFormatException ex)
      {
      }
      string message1 = "Cannot parse string.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new TimePeriodFormatException(message1);
label_3:
      Year year2;
      try
      {
        year2 = new Year(year1);
      }
      catch (IllegalArgumentException ex)
      {
        goto label_6;
      }
      return year2;
label_6:
      string message2 = "Year outside valid range.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new TimePeriodFormatException(message2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
      this.lastMillisecond = this.getLastMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 113, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      calendar.set((int) this.year, 0, 1, 0, 0, 0);
      calendar.set(14, 0);
      return calendar.getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 173, (byte) 118, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      calendar.set((int) this.year, 11, 31, 23, 59, 59);
      calendar.set(14, 999);
      return calendar.getTime().getTime();
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.lastMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 109, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      if ((int) this.year <= -9999)
        return (RegularTimePeriod) null;
      return (RegularTimePeriod) new Year((int) this.year - 1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 123, (byte) 109, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      if ((int) this.year >= 9999)
        return (RegularTimePeriod) null;
      return (RegularTimePeriod) new Year((int) this.year + 1);
    }

    public override long getSerialIndex()
    {
      return (long) this.year;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 192, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Year))
        return false;
      else
        return (int) this.year == (int) ((Year) obj).year;
    }

    public virtual int hashCode()
    {
      return 37 * 17 + (int) this.year;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 234, (byte) 104, (byte) 103, (byte) 110, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object o1)
    {
      return !(o1 is Year) ? (!(o1 is RegularTimePeriod) ? 1 : 0) : (int) this.year - ((Year) o1).getYear();
    }

    [LineNumberTable((ushort) 377)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return Integer.toString((int) this.year);
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
