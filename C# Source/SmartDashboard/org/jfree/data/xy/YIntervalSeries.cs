// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.YIntervalSeries
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
  public class YIntervalSeries : ComparableObjectSeries
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 123, (byte) 164, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public YIntervalSeries(IComparable key, bool autoSort, bool allowDuplicateXValues)
    {
      int num1 = autoSort ? 1 : 0;
      int num2 = allowDuplicateXValues ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(key, num1 != 0, num2 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public YIntervalSeries(IComparable key)
      : this(key, true, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected YIntervalSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 156)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ComparableObjectItem getDataItem(int index)
    {
      return base.getDataItem(index);
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double x, double y, double yLow, double yHigh)
    {
      base.add((ComparableObjectItem) new YIntervalDataItem(x, y, yLow, yHigh), true);
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getX(int index)
    {
      return (Number) ((YIntervalDataItem) this.getDataItem(index)).getX();
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue(int index)
    {
      return ((YIntervalDataItem) this.getDataItem(index)).getYValue();
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYLowValue(int index)
    {
      return ((YIntervalDataItem) this.getDataItem(index)).getYLowValue();
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYHighValue(int index)
    {
      return ((YIntervalDataItem) this.getDataItem(index)).getYHighValue();
    }
  }
}
