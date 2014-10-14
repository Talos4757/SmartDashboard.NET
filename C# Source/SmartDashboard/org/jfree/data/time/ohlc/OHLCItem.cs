// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.ohlc.OHLCItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.data;
using org.jfree.data.time;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time.ohlc
{
  [Serializable]
  public class OHLCItem : ComparableObjectItem
  {
    [LineNumberTable(new byte[] {(byte) 14, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OHLCItem(RegularTimePeriod period, double open, double high, double low, double close)
      : base((IComparable) period, (object) new OHLC(open, high, low, close))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected OHLCItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCloseValue()
    {
      OHLC ohlc = (OHLC) this.getObject();
      if (ohlc == null)
        return double.NaN;
      return ohlc.getClose();
    }

    [LineNumberTable((ushort) 73)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RegularTimePeriod getPeriod()
    {
      return (RegularTimePeriod) this.getComparable();
    }

    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue()
    {
      return this.getCloseValue();
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getOpenValue()
    {
      OHLC ohlc = (OHLC) this.getObject();
      if (ohlc == null)
        return double.NaN;
      return ohlc.getOpen();
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHighValue()
    {
      OHLC ohlc = (OHLC) this.getObject();
      if (ohlc == null)
        return double.NaN;
      return ohlc.getHigh();
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 108, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLowValue()
    {
      OHLC ohlc = (OHLC) this.getObject();
      if (ohlc == null)
        return double.NaN;
      return ohlc.getLow();
    }
  }
}
