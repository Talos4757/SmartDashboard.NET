// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.SimpleTimePeriod
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
  [Implements(new string[] {"org.jfree.data.time.TimePeriod", "java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public class SimpleTimePeriod : Object, TimePeriod, Comparable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 8684672361131829554L;
    private long start;
    private long end;

    [LineNumberTable(new byte[] {(byte) 41, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleTimePeriod(Date start, Date end)
      : this(start.getTime(), end.getTime())
    {
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 104, (byte) 100, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleTimePeriod(long start, long end)
    {
      base.\u002Ector();
      SimpleTimePeriod simpleTimePeriod = this;
      if (start > end)
      {
        string str = "Requires start <= end.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.start = start;
        this.end = end;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SimpleTimePeriod([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SimpleTimePeriod obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 100)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getStart()
    {
      Date.__\u003Cclinit\u003E();
      return new Date(this.start);
    }

    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getEnd()
    {
      Date.__\u003Cclinit\u003E();
      return new Date(this.end);
    }

    public virtual long getStartMillis()
    {
      return this.start;
    }

    public virtual long getEndMillis()
    {
      return this.end;
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TimePeriod))
        return false;
      TimePeriod timePeriod = (TimePeriod) obj;
      return this.getStart().equals((object) timePeriod.getStart()) && this.getEnd().equals((object) timePeriod.getEnd());
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 103, (byte) 108, (byte) 108, (byte) 105, (byte) 109, (byte) 109, (byte) 109, (byte) 101, (byte) 130, (byte) 101, (byte) 162, (byte) 101, (byte) 130, (byte) 101, (byte) 162, (byte) 101, (byte) 130, (byte) 101, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object obj)
    {
      TimePeriod timePeriod = (TimePeriod) obj;
      long time1 = this.getStart().getTime();
      long time2 = this.getEnd().getTime();
      long num1 = time1 + (time2 - time1) / 2L;
      long time3 = timePeriod.getStart().getTime();
      long time4 = timePeriod.getEnd().getTime();
      long num2 = time3 + (time4 - time3) / 2L;
      if (num1 < num2)
        return -1;
      if (num1 > num2)
        return 1;
      if (time1 < time3)
        return -1;
      if (time1 > time3)
        return 1;
      if (time2 < time4)
        return -1;
      return time2 > time4 ? 1 : 0;
    }

    public virtual int hashCode()
    {
      return 37 * (37 * 17 + (int) this.start) + (int) this.end;
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
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
