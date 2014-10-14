// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.VectorSeries
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
  public class VectorSeries : ComparableObjectSeries
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 132, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VectorSeries(IComparable key, bool autoSort, bool allowDuplicateXValues)
    {
      int num1 = autoSort ? 1 : 0;
      int num2 = allowDuplicateXValues ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(key, num1 != 0, num2 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VectorSeries(IComparable key)
      : this(key, false, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected VectorSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 168)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ComparableObjectItem getDataItem(int index)
    {
      return base.getDataItem(index);
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double x, double y, double deltaX, double deltaY)
    {
      base.add((ComparableObjectItem) new VectorDataItem(x, y, deltaX, deltaY), true);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 114, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ComparableObjectItem remove(int index)
    {
      VectorDataItem vectorDataItem = (VectorDataItem) this.data.remove(index);
      this.fireSeriesChanged();
      return (ComparableObjectItem) vectorDataItem;
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXValue(int index)
    {
      return ((VectorDataItem) this.getDataItem(index)).getXValue();
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue(int index)
    {
      return ((VectorDataItem) this.getDataItem(index)).getYValue();
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVectorXValue(int index)
    {
      return ((VectorDataItem) this.getDataItem(index)).getVectorX();
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVectorYValue(int index)
    {
      return ((VectorDataItem) this.getDataItem(index)).getVectorY();
    }
  }
}
