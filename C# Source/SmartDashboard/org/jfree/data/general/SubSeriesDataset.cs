// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.SubSeriesDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.xy.OHLCDataset", "org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.general.CombinationDataset"})]
  [Obsolete]
  [Serializable]
  public class SubSeriesDataset : AbstractIntervalXYDataset, OHLCDataset, XYDataset, SeriesDataset, Dataset, IntervalXYDataset, CombinationDataset
  {
    private SeriesDataset parent;
    private int[] map;

    [LineNumberTable(new byte[] {(byte) 49, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubSeriesDataset(SeriesDataset parent, int series)
    {
      SeriesDataset parent1 = parent;
      int[] map = new int[1];
      int index = 0;
      int num = series;
      map[index] = num;
      // ISSUE: explicit constructor call
      this.\u002Ector(parent1, map);
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 232, (byte) 52, (byte) 231, (byte) 77, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubSeriesDataset(SeriesDataset parent, int[] map)
    {
      SubSeriesDataset subSeriesDataset = this;
      this.parent = (SeriesDataset) null;
      this.parent = parent;
      this.map = map;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SubSeriesDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 118)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getHigh(int series, int item)
    {
      return ((OHLCDataset) this.parent).getHigh(this.map[series], item);
    }

    [LineNumberTable((ushort) 151)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getLow(int series, int item)
    {
      return ((OHLCDataset) this.parent).getLow(this.map[series], item);
    }

    [LineNumberTable((ushort) 184)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getOpen(int series, int item)
    {
      return ((OHLCDataset) this.parent).getOpen(this.map[series], item);
    }

    [LineNumberTable((ushort) 217)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getClose(int series, int item)
    {
      return ((OHLCDataset) this.parent).getClose(this.map[series], item);
    }

    [LineNumberTable((ushort) 250)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getVolume(int series, int item)
    {
      return ((OHLCDataset) this.parent).getVolume(this.map[series], item);
    }

    [LineNumberTable((ushort) 287)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return ((XYDataset) this.parent).getX(this.map[series], item);
    }

    [LineNumberTable((ushort) 302)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return ((XYDataset) this.parent).getY(this.map[series], item);
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHighValue(int series, int item)
    {
      double num = double.NaN;
      Number high = this.getHigh(series, item);
      if (high != null)
        num = high.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLowValue(int series, int item)
    {
      double num = double.NaN;
      Number low = this.getLow(series, item);
      if (low != null)
        num = low.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getOpenValue(int series, int item)
    {
      double num = double.NaN;
      Number open = this.getOpen(series, item);
      if (open != null)
        num = open.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCloseValue(int series, int item)
    {
      double num = double.NaN;
      Number close = this.getClose(series, item);
      if (close != null)
        num = close.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVolumeValue(int series, int item)
    {
      double num = double.NaN;
      Number volume = this.getVolume(series, item);
      if (volume != null)
        num = volume.doubleValue();
      return num;
    }

    [LineNumberTable((ushort) 316)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return ((XYDataset) this.parent).getItemCount(this.map[series]);
    }

    [LineNumberTable((ushort) 329)]
    public override int getSeriesCount()
    {
      return this.map.Length;
    }

    [LineNumberTable((ushort) 340)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.parent.getSeriesKey(this.map[series]);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 109, (byte) 252, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      if (this.parent is IntervalXYDataset)
        return ((IntervalXYDataset) this.parent).getStartX(this.map[series], item);
      else
        return this.getX(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 5, (byte) 109, (byte) 252, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      if (this.parent is IntervalXYDataset)
        return ((IntervalXYDataset) this.parent).getEndX(this.map[series], item);
      else
        return this.getX(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 24, (byte) 109, (byte) 252, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      if (this.parent is IntervalXYDataset)
        return ((IntervalXYDataset) this.parent).getStartY(this.map[series], item);
      else
        return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 43, (byte) 109, (byte) 252, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      if (this.parent is IntervalXYDataset)
        return ((IntervalXYDataset) this.parent).getEndY(this.map[series], item);
      else
        return this.getY(series, item);
    }

    public virtual SeriesDataset getParent()
    {
      return this.parent;
    }

    [LineNumberTable((ushort) 442)]
    public virtual int[] getMap()
    {
      return (int[]) this.map.Clone();
    }
  }
}
