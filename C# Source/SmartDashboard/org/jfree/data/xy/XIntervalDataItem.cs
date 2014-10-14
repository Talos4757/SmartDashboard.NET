// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XIntervalDataItem
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
  public class XIntervalDataItem : ComparableObjectItem
  {
    [LineNumberTable(new byte[] {(byte) 11, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XIntervalDataItem(double x, double xLow, double xHigh, double y)
      : base((IComparable) new Double(x), (object) new YWithXInterval(y, xLow, xHigh))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XIntervalDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 70)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getX()
    {
      return (Number) this.getComparable();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue()
    {
      YWithXInterval ywithXinterval = (YWithXInterval) this.getObject();
      if (ywithXinterval == null)
        return double.NaN;
      return ywithXinterval.getY();
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXLowValue()
    {
      YWithXInterval ywithXinterval = (YWithXInterval) this.getObject();
      if (ywithXinterval == null)
        return double.NaN;
      return ywithXinterval.getXLow();
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXHighValue()
    {
      YWithXInterval ywithXinterval = (YWithXInterval) this.getObject();
      if (ywithXinterval == null)
        return double.NaN;
      return ywithXinterval.getXHigh();
    }
  }
}
