// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYSeriesCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.DomainInfo", "org.jfree.data.RangeInfo", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYSeriesCollection : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, DomainInfo, RangeInfo, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -7590013825931496766L;
    private List data;
    private IntervalXYDelegate intervalDelegate;

    [LineNumberTable(new byte[] {(byte) 58, (byte) 104, (byte) 107, (byte) 109, (byte) 108, (byte) 99, (byte) 109, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYSeriesCollection(XYSeries series)
    {
      XYSeriesCollection seriesCollection = this;
      this.data = (List) new ArrayList();
      this.intervalDelegate = new IntervalXYDelegate((XYDataset) this, false);
      this.addChangeListener((DatasetChangeListener) this.intervalDelegate);
      if (series == null)
        return;
      this.data.add((object) series);
      series.addChangeListener((SeriesChangeListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYSeriesCollection()
      : this((XYSeries) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYSeriesCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(XYSeries series)
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

    [LineNumberTable((ushort) 207)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (XYSeries) this.data.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int index)
    {
      return ((XYSeries) this.data.get(series)).getDataItem(index).getY();
    }

    [LineNumberTable(new byte[] {(byte) 74, (byte) 103, (byte) 102, (byte) 104, (byte) 104, (byte) 230, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DomainOrder getDomainOrder()
    {
      int seriesCount = this.getSeriesCount();
      for (int series = 0; series < seriesCount; ++series)
      {
        if (!this.getSeries(series).getAutoSort())
          return DomainOrder.__\u003C\u003ENONE;
      }
      return DomainOrder.__\u003C\u003EASCENDING;
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 109, (byte) 208, (byte) 114, (byte) 103, (byte) 109, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 124, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(XYSeries series)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 112, (byte) 114, (byte) 7, (byte) 230, (byte) 70, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllSeries()
    {
      for (int index = 0; index < this.data.size(); ++index)
        ((Series) this.data.get(index)).removeChangeListener((SeriesChangeListener) this);
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 216)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getSeries()
    {
      return Collections.unmodifiableList(this.data);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(XYSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.data.indexOf((object) series);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 99, (byte) 144, (byte) 108, (byte) 104, (byte) 108, (byte) 110, (byte) 130, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYSeries getSeries(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Iterator iterator = this.data.iterator();
        while (iterator.hasNext())
        {
          XYSeries xySeries = (XYSeries) iterator.next();
          if (Object.instancehelper_equals((object) key, (object) xySeries.getKey()))
            return xySeries;
        }
        string message = new StringBuffer().append("Key not found: ").append((object) key).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable((ushort) 292)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable((ushort) 307)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 205, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return ((XYSeries) this.data.get(series)).getDataItem(item).getX();
    }

    [LineNumberTable((ushort) 333)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      return this.intervalDelegate.getStartX(series, item);
    }

    [LineNumberTable((ushort) 345)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      return this.intervalDelegate.getEndX(series, item);
    }

    [LineNumberTable((ushort) 371)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 383)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 24, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYSeriesCollection))
        return false;
      XYSeriesCollection seriesCollection = (XYSeriesCollection) obj;
      if (!this.intervalDelegate.equals((object) seriesCollection.intervalDelegate))
        return false;
      return (ObjectUtilities.equal((object) this.data, (object) seriesCollection.data) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 45, (byte) 108, (byte) 118, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYSeriesCollection seriesCollection = (XYSeriesCollection) base.clone();
      seriesCollection.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      seriesCollection.intervalDelegate = (IntervalXYDelegate) this.intervalDelegate.clone();
      return (object) seriesCollection;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 98, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(5, (object) this.intervalDelegate), (object) this.data);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 32, (byte) 162, (byte) 99, (byte) 175, (byte) 106, (byte) 103, (byte) 102, (byte) 105, (byte) 106, (byte) 104, (byte) 165, (byte) 105, (byte) 234, (byte) 56, (byte) 230, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainLowerBound(bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      if (num1 != 0)
      {
        return this.intervalDelegate.getDomainLowerBound(num1 != 0);
      }
      else
      {
        double num2 = double.NaN;
        int seriesCount = this.getSeriesCount();
        for (int series = 0; series < seriesCount; ++series)
        {
          double minX = this.getSeries(series).getMinX();
          if (Double.isNaN(num2))
            num2 = minX;
          else if (!Double.isNaN(minX))
            num2 = Math.min(num2, minX);
        }
        return num2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 24, (byte) 130, (byte) 99, (byte) 175, (byte) 106, (byte) 103, (byte) 102, (byte) 105, (byte) 106, (byte) 104, (byte) 165, (byte) 105, (byte) 234, (byte) 56, (byte) 230, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainUpperBound(bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      if (num1 != 0)
      {
        return this.intervalDelegate.getDomainUpperBound(num1 != 0);
      }
      else
      {
        double num2 = double.NaN;
        int seriesCount = this.getSeriesCount();
        for (int series = 0; series < seriesCount; ++series)
        {
          double maxX = this.getSeries(series).getMaxX();
          if (Double.isNaN(num2))
            num2 = maxX;
          else if (!Double.isNaN(maxX))
            num2 = Math.max(num2, maxX);
        }
        return num2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 16, (byte) 130, (byte) 99, (byte) 175, (byte) 106, (byte) 106, (byte) 103, (byte) 104, (byte) 106, (byte) 106, (byte) 105, (byte) 138, (byte) 106, (byte) 105, (byte) 234, (byte) 56, (byte) 235, (byte) 75, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (num != 0)
      {
        return this.intervalDelegate.getDomainBounds(num != 0);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        int seriesCount = this.getSeriesCount();
        for (int series1 = 0; series1 < seriesCount; ++series1)
        {
          XYSeries series2 = this.getSeries(series1);
          double minX = series2.getMinX();
          if (!Double.isNaN(minX))
            lower = Math.min(lower, minX);
          double maxX = series2.getMaxX();
          if (!Double.isNaN(maxX))
            upper = Math.max(upper, maxX);
        }
        if (lower > upper)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable((ushort) 540)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getIntervalWidth()
    {
      return this.intervalDelegate.getIntervalWidth();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 180, (byte) 105, (byte) 144, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIntervalWidth(double width)
    {
      if (width < 0.0)
      {
        string str = "Negative 'width' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.intervalDelegate.setFixedIntervalWidth(width);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable((ushort) 563)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getIntervalPositionFactor()
    {
      return this.intervalDelegate.getIntervalPositionFactor();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 204, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIntervalPositionFactor(double factor)
    {
      this.intervalDelegate.setIntervalPositionFactor(factor);
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 584)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isAutoWidth()
    {
      return (this.intervalDelegate.isAutoWidth() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 250, (byte) 130, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoWidth(bool b)
    {
      this.intervalDelegate.setAutoWidth(b);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 237, (byte) 106, (byte) 106, (byte) 103, (byte) 102, (byte) 105, (byte) 106, (byte) 105, (byte) 138, (byte) 106, (byte) 105, (byte) 234, (byte) 56, (byte) 233, (byte) 75, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getRangeBounds(bool includeInterval)
    {
      double lower = double.PositiveInfinity;
      double upper = double.NegativeInfinity;
      int seriesCount = this.getSeriesCount();
      for (int series1 = 0; series1 < seriesCount; ++series1)
      {
        XYSeries series2 = this.getSeries(series1);
        double minY = series2.getMinY();
        if (!Double.isNaN(minY))
          lower = Math.min(lower, minY);
        double maxY = series2.getMaxY();
        if (!Double.isNaN(maxY))
          upper = Math.max(upper, maxY);
      }
      if (lower > upper)
        return (Range) null;
      return new Range(lower, upper);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 12, (byte) 106, (byte) 103, (byte) 102, (byte) 104, (byte) 105, (byte) 104, (byte) 165, (byte) 105, (byte) 234, (byte) 56, (byte) 230, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeLowerBound(bool includeInterval)
    {
      double num = double.NaN;
      int seriesCount = this.getSeriesCount();
      for (int series = 0; series < seriesCount; ++series)
      {
        double minY = this.getSeries(series).getMinY();
        if (Double.isNaN(num))
          num = minY;
        else if (!Double.isNaN(minY))
          num = Math.min(num, minY);
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 38, (byte) 106, (byte) 103, (byte) 102, (byte) 104, (byte) 105, (byte) 104, (byte) 165, (byte) 105, (byte) 234, (byte) 56, (byte) 230, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeUpperBound(bool includeInterval)
    {
      double num = double.NaN;
      int seriesCount = this.getSeriesCount();
      for (int series = 0; series < seriesCount; ++series)
      {
        double maxY = this.getSeries(series).getMaxY();
        if (Double.isNaN(num))
          num = maxY;
        else if (!Double.isNaN(maxY))
          num = Math.max(num, maxY);
      }
      return num;
    }
  }
}
