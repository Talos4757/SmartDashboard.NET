// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.YIntervalSeriesCollection
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
  public class YIntervalSeriesCollection : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    private List data;

    [LineNumberTable(new byte[] {(byte) 21, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public YIntervalSeriesCollection()
    {
      YIntervalSeriesCollection seriesCollection = this;
      this.data = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected YIntervalSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] YIntervalSeriesCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] YIntervalSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 96)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual YIntervalSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (YIntervalSeries) this.data.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return ((YIntervalSeries) this.data.get(series)).getX(item);
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(YIntervalSeries series)
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

    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable((ushort) 144)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return ((YIntervalSeries) this.data.get(series)).getYValue(item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartYValue(int series, int item)
    {
      return ((YIntervalSeries) this.data.get(series)).getYLowValue(item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndYValue(int series, int item)
    {
      return ((YIntervalSeries) this.data.get(series)).getYHighValue(item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      YIntervalSeries yintervalSeries = (YIntervalSeries) this.data.get(series);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(yintervalSeries.getYValue(item));
    }

    [LineNumberTable((ushort) 225)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      return this.getX(series, item);
    }

    [LineNumberTable((ushort) 238)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      return this.getX(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 136, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      YIntervalSeries yintervalSeries = (YIntervalSeries) this.data.get(series);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(yintervalSeries.getYLowValue(item));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      YIntervalSeries yintervalSeries = (YIntervalSeries) this.data.get(series);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(yintervalSeries.getYHighValue(item));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 109, (byte) 144, (byte) 114, (byte) 103, (byte) 109, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 180, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(YIntervalSeries series)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 112, (byte) 114, (byte) 7, (byte) 198, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllSeries()
    {
      for (int index = 0; index < this.data.size(); ++index)
        ((Series) this.data.get(index)).removeChangeListener((SeriesChangeListener) this);
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is YIntervalSeriesCollection))
        return false;
      return (ObjectUtilities.equal((object) this.data, (object) ((YIntervalSeriesCollection) obj).data) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 233, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      YIntervalSeriesCollection seriesCollection = (YIntervalSeriesCollection) base.clone();
      seriesCollection.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      return (object) seriesCollection;
    }
  }
}
