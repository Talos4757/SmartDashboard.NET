// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.CombinedDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset", "org.jfree.data.xy.OHLCDataset", "org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.general.CombinationDataset"})]
  [Obsolete]
  [Serializable]
  public class CombinedDataset : AbstractIntervalXYDataset, XYDataset, SeriesDataset, Dataset, OHLCDataset, IntervalXYDataset, CombinationDataset
  {
    private List datasetInfo;

    [LineNumberTable(new byte[] {(byte) 36, (byte) 232, (byte) 58, (byte) 235, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CombinedDataset()
    {
      CombinedDataset combinedDataset = this;
      this.datasetInfo = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 232, (byte) 49, (byte) 235, (byte) 80, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CombinedDataset(SeriesDataset[] data)
    {
      CombinedDataset combinedDataset = this;
      this.datasetInfo = (List) new ArrayList();
      this.add(data);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CombinedDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 103, (byte) 41, (byte) 166, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(SeriesDataset[] data)
    {
      for (int index = 0; index < data.Length; ++index)
        this.fastAdd(data[index]);
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 107, (byte) 52, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fastAdd([In] SeriesDataset obj0)
    {
      for (int index = 0; index < obj0.getSeriesCount(); ++index)
        this.datasetInfo.add((object) new CombinedDataset.DatasetInfo(this, obj0, index));
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 103, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(SeriesDataset data)
    {
      this.fastAdd(data);
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable((ushort) 584)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private CombinedDataset.DatasetInfo getDatasetInfo([In] int obj0)
    {
      return (CombinedDataset.DatasetInfo) this.datasetInfo.get(obj0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getHigh(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((OHLCDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getHigh(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 161, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getLow(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((OHLCDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getLow(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 195, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getOpen(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((OHLCDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getOpen(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getClose(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((OHLCDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getClose(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 7, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getVolume(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((OHLCDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getVolume(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((XYDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getX(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((XYDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getY(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 226, (byte) 99, (byte) 130, (byte) 99, (byte) 130, (byte) 107, (byte) 107, (byte) 108})]
    private int[] joinMap([In] int[] obj0, [In] int[] obj1)
    {
      if (obj0 == null)
        return obj1;
      if (obj1 == null)
        return obj0;
      int[] numArray = new int[obj0.Length + obj1.Length];
      ByteCodeHelper.arraycopy_primitive_4((Array) obj0, 0, (Array) numArray, 0, obj0.Length);
      ByteCodeHelper.arraycopy_primitive_4((Array) obj1, 0, (Array) numArray, obj0.Length, obj1.Length);
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 181, (byte) 98, (byte) 115, (byte) 109, (byte) 104, (byte) 141, (byte) 100, (byte) 132, (byte) 100, (byte) 130, (byte) 100, (byte) 130, (byte) 228, (byte) 50, (byte) 233, (byte) 81})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getChildPosition(Dataset child)
    {
      int num = 0;
      for (int index = 0; index < this.datasetInfo.size(); ++index)
      {
        SeriesDataset seriesDataset = CombinedDataset.DatasetInfo.access\u0024100(this.getDatasetInfo(index));
        if (seriesDataset is CombinedDataset)
        {
          int childPosition = ((CombinedDataset) seriesDataset).getChildPosition(child);
          if (childPosition >= 0)
            return num + childPosition;
          ++num;
        }
        else
        {
          if (child == seriesDataset)
            return num;
          ++num;
        }
      }
      return -1;
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(SeriesDataset data, int series)
    {
      this.add((SeriesDataset) new SubSeriesDataset(data, series));
    }

    [LineNumberTable((ushort) 159)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.datasetInfo.size();
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return CombinedDataset.DatasetInfo.access\u0024100(datasetInfo).getSeriesKey(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      return ((XYDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getItemCount(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHighValue(int series, int item)
    {
      double num = double.NaN;
      Number high = this.getHigh(series, item);
      if (high != null)
        num = high.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLowValue(int series, int item)
    {
      double num = double.NaN;
      Number low = this.getLow(series, item);
      if (low != null)
        num = low.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 209, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getOpenValue(int series, int item)
    {
      double num = double.NaN;
      Number open = this.getOpen(series, item);
      if (open != null)
        num = open.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCloseValue(int series, int item)
    {
      double num = double.NaN;
      Number close = this.getClose(series, item);
      if (close != null)
        num = close.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 21, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVolumeValue(int series, int item)
    {
      double num = double.NaN;
      Number volume = this.getVolume(series, item);
      if (volume != null)
        num = volume.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 104, (byte) 109, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      if (CombinedDataset.DatasetInfo.access\u0024100(datasetInfo) is IntervalXYDataset)
        return ((IntervalXYDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getStartX(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
      else
        return this.getX(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 60, (byte) 104, (byte) 109, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      if (CombinedDataset.DatasetInfo.access\u0024100(datasetInfo) is IntervalXYDataset)
        return ((IntervalXYDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getEndX(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
      else
        return this.getX(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 78, (byte) 104, (byte) 109, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      if (CombinedDataset.DatasetInfo.access\u0024100(datasetInfo) is IntervalXYDataset)
        return ((IntervalXYDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getStartY(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
      else
        return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 96, (byte) 104, (byte) 109, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      CombinedDataset.DatasetInfo datasetInfo = this.getDatasetInfo(series);
      if (CombinedDataset.DatasetInfo.access\u0024100(datasetInfo) is IntervalXYDataset)
        return ((IntervalXYDataset) CombinedDataset.DatasetInfo.access\u0024100(datasetInfo)).getEndY(CombinedDataset.DatasetInfo.access\u0024000(datasetInfo), item);
      else
        return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 118, (byte) 98, (byte) 112, (byte) 109, (byte) 104, (byte) 140, (byte) 99, (byte) 132, (byte) 100, (byte) 130, (byte) 130, (byte) 226, (byte) 51, (byte) 230, (byte) 80})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SeriesDataset getParent()
    {
      SeriesDataset seriesDataset1 = (SeriesDataset) null;
      for (int index = 0; index < this.datasetInfo.size(); ++index)
      {
        SeriesDataset seriesDataset2 = CombinedDataset.DatasetInfo.access\u0024100(this.getDatasetInfo(index));
        if (!(seriesDataset2 is CombinationDataset))
          return (SeriesDataset) null;
        SeriesDataset parent = ((CombinationDataset) seriesDataset2).getParent();
        if (seriesDataset1 == null)
          seriesDataset1 = parent;
        else if (seriesDataset1 != parent)
          return (SeriesDataset) null;
      }
      return seriesDataset1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 151, (byte) 98, (byte) 112, (byte) 109, (byte) 104, (byte) 108, (byte) 99, (byte) 130, (byte) 105, (byte) 130, (byte) 226, (byte) 54, (byte) 230, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int[] getMap()
    {
      int[] numArray = (int[]) null;
      for (int index = 0; index < this.datasetInfo.size(); ++index)
      {
        SeriesDataset seriesDataset = CombinedDataset.DatasetInfo.access\u0024100(this.getDatasetInfo(index));
        if (!(seriesDataset is CombinationDataset))
          return (int[]) null;
        int[] map = ((CombinationDataset) seriesDataset).getMap();
        if (map == null)
          return (int[]) null;
        numArray = this.joinMap(numArray, map);
      }
      return numArray;
    }

    [InnerClass]
    [SourceFile("CombinedDataset.java")]
    [Modifiers]
    internal sealed class DatasetInfo : Object
    {
      private SeriesDataset data;
      private int series;
      [Modifiers]
      private CombinedDataset this\u00240;

      [LineNumberTable(new byte[] {(byte) 162, (byte) 0, (byte) 111, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal DatasetInfo([In] CombinedDataset obj0, [In] SeriesDataset obj1, [In] int obj2)
      {
        base.\u002Ector();
        CombinedDataset.DatasetInfo datasetInfo = this;
        this.this\u00240 = obj0;
        this.data = obj1;
        this.series = obj2;
      }

      [LineNumberTable((ushort) 612)]
      internal static int access\u0024000([In] CombinedDataset.DatasetInfo obj0)
      {
        return obj0.series;
      }

      [LineNumberTable((ushort) 612)]
      internal static SeriesDataset access\u0024100([In] CombinedDataset.DatasetInfo obj0)
      {
        return obj0.data;
      }
    }
  }
}
