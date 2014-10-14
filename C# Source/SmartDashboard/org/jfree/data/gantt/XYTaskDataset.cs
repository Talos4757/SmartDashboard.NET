// Decompiled with JetBrains decompiler
// Type: org.jfree.data.gantt.XYTaskDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.data.time;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.gantt
{
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.general.DatasetChangeListener"})]
  [Serializable]
  public class XYTaskDataset : AbstractXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, DatasetChangeListener, EventListener
  {
    private TaskSeriesCollection underlying;
    private double seriesWidth;
    private bool transposed;

    [LineNumberTable(new byte[] {(byte) 30, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 112, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYTaskDataset(TaskSeriesCollection tasks)
    {
      XYTaskDataset xyTaskDataset = this;
      if (tasks == null)
      {
        string str = "Null 'tasks' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.underlying = tasks;
        this.seriesWidth = 0.8;
        this.underlying.addChangeListener((DatasetChangeListener) this);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYTaskDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    private double getSeriesValue([In] int obj0)
    {
      return (double) obj0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 16, (byte) 109, (byte) 104, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getItemValue([In] int obj0, [In] int obj1)
    {
      TimePeriod duration = this.underlying.getSeries(obj0).get(obj1).getDuration();
      return (double) (duration.getStart().getTime() + duration.getEnd().getTime()) / 2.0;
    }

    private double getSeriesStartValue([In] int obj0)
    {
      return (double) obj0 - this.seriesWidth / 2.0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 109, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getItemStartValue([In] int obj0, [In] int obj1)
    {
      return (double) this.underlying.getSeries(obj0).get(obj1).getDuration().getStart().getTime();
    }

    private double getSeriesEndValue([In] int obj0)
    {
      return (double) obj0 + this.seriesWidth / 2.0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 33, (byte) 109, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getItemEndValue([In] int obj0, [In] int obj1)
    {
      return (double) this.underlying.getSeries(obj0).get(obj1).getDuration().getEnd().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      if (!this.transposed)
        return this.getSeriesValue(series);
      else
        return this.getItemValue(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getStartXValue(int series, int item)
    {
      if (!this.transposed)
        return this.getSeriesStartValue(series);
      else
        return this.getItemStartValue(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getEndXValue(int series, int item)
    {
      if (!this.transposed)
        return this.getSeriesEndValue(series);
      else
        return this.getItemEndValue(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 104, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      if (!this.transposed)
        return this.getItemValue(series, item);
      else
        return this.getSeriesValue(series);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 104, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getStartYValue(int series, int item)
    {
      if (!this.transposed)
        return this.getItemStartValue(series, item);
      else
        return this.getSeriesStartValue(series);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 104, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getEndYValue(int series, int item)
    {
      if (!this.transposed)
        return this.getItemEndValue(series, item);
      else
        return this.getSeriesEndValue(series);
    }

    public virtual TaskSeriesCollection getTasks()
    {
      return this.underlying;
    }

    public virtual double getSeriesWidth()
    {
      return this.seriesWidth;
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 105, (byte) 144, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesWidth(double w)
    {
      if (w <= 0.0)
      {
        string str = "Requires 'w' > 0.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesWidth = w;
        this.fireDatasetChanged();
      }
    }

    public virtual bool isTransposed()
    {
      return this.transposed;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 105, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTransposed(bool transposed)
    {
      this.transposed = transposed;
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 160)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.underlying.getSeriesCount();
    }

    [LineNumberTable((ushort) 171)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.underlying.getSeriesKey(series);
    }

    [LineNumberTable((ushort) 182)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.underlying.getSeries(series).getItemCount();
    }

    [LineNumberTable((ushort) 249)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable((ushort) 263)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getStartXValue(series, item));
    }

    [LineNumberTable((ushort) 277)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getEndXValue(series, item));
    }

    [LineNumberTable((ushort) 344)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getYValue(series, item));
    }

    [LineNumberTable((ushort) 357)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getStartYValue(series, item));
    }

    [LineNumberTable((ushort) 370)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getEndYValue(series, item));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void datasetChanged(DatasetChangeEvent @event)
    {
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 59, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYTaskDataset))
        return false;
      XYTaskDataset xyTaskDataset = (XYTaskDataset) obj;
      return this.seriesWidth == xyTaskDataset.seriesWidth && this.transposed == xyTaskDataset.transposed && this.underlying.equals((object) xyTaskDataset.underlying);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 86, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYTaskDataset xyTaskDataset = (XYTaskDataset) base.clone();
      xyTaskDataset.underlying = (TaskSeriesCollection) this.underlying.clone();
      return (object) xyTaskDataset;
    }
  }
}
