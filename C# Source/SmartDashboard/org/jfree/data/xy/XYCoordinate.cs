// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYCoordinate
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

namespace org.jfree.data.xy
{
  [Implements(new string[] {"java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public class XYCoordinate : Object, Comparable, Serializable.__Interface, ISerializable
  {
    private double x;
    private double y;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYCoordinate(double x, double y)
    {
      base.\u002Ector();
      XYCoordinate xyCoordinate = this;
      this.x = x;
      this.y = y;
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYCoordinate()
      : this(0.0, 0.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYCoordinate([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYCoordinate obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getX()
    {
      return this.x;
    }

    public virtual double getY()
    {
      return this.y;
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYCoordinate))
        return false;
      XYCoordinate xyCoordinate = (XYCoordinate) obj;
      return this.x == xyCoordinate.x && this.y == xyCoordinate.y;
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.x);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.y);
      return 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
    }

    [LineNumberTable((ushort) 140)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("(").append(this.x).append(", ").append(this.y).append(")").toString();
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 104, (byte) 144, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 162, (byte) 110, (byte) 130, (byte) 110, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object obj)
    {
      if (!(obj is XYCoordinate))
      {
        string str = "Incomparable object.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        XYCoordinate xyCoordinate = (XYCoordinate) obj;
        if (this.x > xyCoordinate.x)
          return 1;
        if (this.x < xyCoordinate.x)
          return -1;
        if (this.y > xyCoordinate.y)
          return 1;
        return this.y < xyCoordinate.y ? -1 : 0;
      }
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
