// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYIntervalDataItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Serializable]
  public class XYIntervalDataItem : ComparableObjectItem
  {
    [LineNumberTable(new byte[] {(byte) 14, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYIntervalDataItem(double x, double xLow, double xHigh, double y, double yLow, double yHigh)
      : base((IComparable) new Double(x), (object) new XYInterval(xLow, xHigh, y, yLow, yHigh))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYIntervalDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 73)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Double getX()
    {
      return (Double) this.getComparable();
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue()
    {
      XYInterval xyInterval = (XYInterval) this.getObject();
      if (xyInterval == null)
        return double.NaN;
      return xyInterval.getY();
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXLowValue()
    {
      XYInterval xyInterval = (XYInterval) this.getObject();
      if (xyInterval == null)
        return double.NaN;
      return xyInterval.getXLow();
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXHighValue()
    {
      XYInterval xyInterval = (XYInterval) this.getObject();
      if (xyInterval == null)
        return double.NaN;
      return xyInterval.getXHigh();
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYLowValue()
    {
      XYInterval xyInterval = (XYInterval) this.getObject();
      if (xyInterval == null)
        return double.NaN;
      return xyInterval.getYLow();
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYHighValue()
    {
      XYInterval xyInterval = (XYInterval) this.getObject();
      if (xyInterval == null)
        return double.NaN;
      return xyInterval.getYHigh();
    }
  }
}
