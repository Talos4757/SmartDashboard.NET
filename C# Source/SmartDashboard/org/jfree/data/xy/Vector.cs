// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.Vector
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
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class Vector : Object, Serializable.__Interface, ISerializable
  {
    private double x;
    private double y;

    [LineNumberTable(new byte[] {(byte) 17, (byte) 104, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector(double x, double y)
    {
      base.\u002Ector();
      Vector vector = this;
      this.x = x;
      this.y = y;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Vector([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Vector obj0)
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

    [LineNumberTable((ushort) 96)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLength()
    {
      return Math.sqrt(this.x * this.x + this.y * this.y);
    }

    [LineNumberTable((ushort) 105)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getAngle()
    {
      return Math.atan2(this.y, this.x);
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Vector))
        return false;
      Vector vector = (Vector) obj;
      return this.x == vector.x && this.y == vector.y;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.x);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.y);
      return 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
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
