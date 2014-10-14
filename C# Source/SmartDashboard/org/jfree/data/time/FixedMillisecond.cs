// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.FixedMillisecond
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
  public class FixedMillisecond : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7867521484545646931L;
    private long time;

    [HideFromJava]
    static FixedMillisecond()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 104, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FixedMillisecond(Date time)
    {
      FixedMillisecond fixedMillisecond = this;
      this.time = time.getTime();
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FixedMillisecond(long millisecond)
      : this(new Date(millisecond))
    {
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FixedMillisecond()
      : this(new Date())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FixedMillisecond([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] FixedMillisecond obj0)
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

    public override long getFirstMillisecond()
    {
      return this.time;
    }

    [LineNumberTable((ushort) 101)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getTime()
    {
      Date.__\u003Cclinit\u003E();
      return new Date(this.time);
    }

    public override void peg(Calendar calendar)
    {
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 98, (byte) 103, (byte) 108, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      FixedMillisecond fixedMillisecond = (FixedMillisecond) null;
      long num = this.time;
      if (num != long.MinValue)
        fixedMillisecond = new FixedMillisecond(num - 1L);
      return (RegularTimePeriod) fixedMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 98, (byte) 103, (byte) 108, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      FixedMillisecond fixedMillisecond = (FixedMillisecond) null;
      long num = this.time;
      if (num != long.MaxValue)
        fixedMillisecond = new FixedMillisecond(num + 1L);
      return (RegularTimePeriod) fixedMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 104, (byte) 103, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object @object)
    {
      if (@object is FixedMillisecond)
        return this.time == ((FixedMillisecond) @object).getFirstMillisecond();
      else
        return false;
    }

    public virtual int hashCode()
    {
      return (int) this.time;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 72, (byte) 104, (byte) 103, (byte) 110, (byte) 101, (byte) 164, (byte) 101, (byte) 164, (byte) 162, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    public override int compareTo(object o1)
    {
      int num1;
      if (o1 is FixedMillisecond)
      {
        long num2 = this.time - ((FixedMillisecond) o1).time;
        num1 = num2 <= 0L ? (num2 >= 0L ? 0 : -1) : 1;
      }
      else
        num1 = !(o1 is RegularTimePeriod) ? 1 : 0;
      return num1;
    }

    public override long getFirstMillisecond(Calendar calendar)
    {
      return this.time;
    }

    public override long getLastMillisecond()
    {
      return this.time;
    }

    public override long getLastMillisecond(Calendar calendar)
    {
      return this.time;
    }

    public override long getMiddleMillisecond()
    {
      return this.time;
    }

    public override long getMiddleMillisecond(Calendar calendar)
    {
      return this.time;
    }

    public override long getSerialIndex()
    {
      return this.time;
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
