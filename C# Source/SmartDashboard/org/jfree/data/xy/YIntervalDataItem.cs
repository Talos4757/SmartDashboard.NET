// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.YIntervalDataItem
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
  public class YIntervalDataItem : ComparableObjectItem
  {
    [LineNumberTable(new byte[] {(byte) 11, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public YIntervalDataItem(double x, double y, double yLow, double yHigh)
      : base((IComparable) new Double(x), (object) new YInterval(y, yLow, yHigh))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected YIntervalDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 70)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Double getX()
    {
      return (Double) this.getComparable();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue()
    {
      YInterval yinterval = (YInterval) this.getObject();
      if (yinterval == null)
        return double.NaN;
      return yinterval.getY();
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYLowValue()
    {
      YInterval yinterval = (YInterval) this.getObject();
      if (yinterval == null)
        return double.NaN;
      return yinterval.getYLow();
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYHighValue()
    {
      YInterval yinterval = (YInterval) this.getObject();
      if (yinterval == null)
        return double.NaN;
      return yinterval.getYHigh();
    }
  }
}
