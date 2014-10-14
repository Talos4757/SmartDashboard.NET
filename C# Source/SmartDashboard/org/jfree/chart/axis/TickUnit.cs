// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.TickUnit
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public abstract class TickUnit : Object, Comparable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 510179855057013974L;
    private double size;
    private int minorTickCount;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TickUnit(double size)
    {
      base.\u002Ector();
      TickUnit tickUnit = this;
      this.size = size;
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 104, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TickUnit(double size, int minorTickCount)
    {
      base.\u002Ector();
      TickUnit tickUnit = this;
      this.size = size;
      this.minorTickCount = minorTickCount;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TickUnit([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TickUnit obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getSize()
    {
      return this.size;
    }

    [LineNumberTable((ushort) 130)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string valueToString(double value)
    {
      return String.valueOf(value);
    }

    public virtual int getMinorTickCount()
    {
      return this.minorTickCount;
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 104, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 162, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object @object)
    {
      if (!(@object is TickUnit))
        return -1;
      TickUnit tickUnit = (TickUnit) @object;
      if (this.size > tickUnit.getSize())
        return 1;
      return this.size < tickUnit.getSize() ? -1 : 0;
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TickUnit))
        return false;
      TickUnit tickUnit = (TickUnit) obj;
      return this.size == tickUnit.size && this.minorTickCount == tickUnit.minorTickCount;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      long num = this.size == 0.0 ? 0L : Double.doubleToLongBits(this.size);
      return (int) (num ^ (long) ((ulong) num >> 32));
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
