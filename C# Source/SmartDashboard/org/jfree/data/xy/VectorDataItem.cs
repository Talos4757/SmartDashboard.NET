// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.VectorDataItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.data;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Serializable]
  public class VectorDataItem : ComparableObjectItem
  {
    [LineNumberTable(new byte[] {(byte) 15, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VectorDataItem(double x, double y, double deltaX, double deltaY)
      : base((IComparable) new XYCoordinate(x, y), (object) new Vector(deltaX, deltaY))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected VectorDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXValue()
    {
      return ((XYCoordinate) this.getComparable()).getX();
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue()
    {
      return ((XYCoordinate) this.getComparable()).getY();
    }

    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector getVector()
    {
      return (Vector) this.getObject();
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVectorX()
    {
      Vector vector = (Vector) this.getObject();
      if (vector == null)
        return double.NaN;
      return vector.getX();
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVectorY()
    {
      Vector vector = (Vector) this.getObject();
      if (vector == null)
        return double.NaN;
      return vector.getY();
    }
  }
}
