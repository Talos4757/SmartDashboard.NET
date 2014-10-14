// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XIntervalSeriesCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XIntervalSeriesCollection : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    private List data;

    [LineNumberTable(new byte[] {(byte) 19, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XIntervalSeriesCollection()
    {
      XIntervalSeriesCollection seriesCollection = this;
      this.data = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XIntervalSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XIntervalSeriesCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XIntervalSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XIntervalSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (XIntervalSeries) this.data.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 96, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      XIntervalDataItem xintervalDataItem = (XIntervalDataItem) ((XIntervalSeries) this.data.get(series)).getDataItem(item);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(xintervalDataItem.getYValue());
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(XIntervalSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data.add((object) series);
        series.addChangeListener((SeriesChangeListener) this);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable((ushort) 127)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable((ushort) 142)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return ((XIntervalDataItem) ((XIntervalSeries) this.data.get(series)).getDataItem(item)).getX();
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartXValue(int series, int item)
    {
      return ((XIntervalSeries) this.data.get(series)).getXLowValue(item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndXValue(int series, int item)
    {
      return ((XIntervalSeries) this.data.get(series)).getXHighValue(item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return ((XIntervalSeries) this.data.get(series)).getYValue(item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      XIntervalDataItem xintervalDataItem = (XIntervalDataItem) ((XIntervalSeries) this.data.get(series)).getDataItem(item);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(xintervalDataItem.getXLowValue());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      XIntervalDataItem xintervalDataItem = (XIntervalDataItem) ((XIntervalSeries) this.data.get(series)).getDataItem(item);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(xintervalDataItem.getXHighValue());
    }

    [LineNumberTable((ushort) 253)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 266)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 109, (byte) 144, (byte) 114, (byte) 103, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(int series)
    {
      if (series < 0 || series >= this.getSeriesCount())
      {
        string str = "Series index out of bounds.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ((Series) this.data.get(series)).removeChangeListener((SeriesChangeListener) this);
        this.data.remove(series);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(XIntervalSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.data.contains((object) series))
          return;
        series.removeChangeListener((SeriesChangeListener) this);
        this.data.remove((object) series);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 112, (byte) 114, (byte) 7, (byte) 198, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllSeries()
    {
      for (int index = 0; index < this.data.size(); ++index)
        ((Series) this.data.get(index)).removeChangeListener((SeriesChangeListener) this);
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 217, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XIntervalSeriesCollection))
        return false;
      return (ObjectUtilities.equal((object) this.data, (object) ((XIntervalSeriesCollection) obj).data) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 235, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XIntervalSeriesCollection seriesCollection = (XIntervalSeriesCollection) base.clone();
      seriesCollection.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      return (object) seriesCollection;
    }
  }
}
