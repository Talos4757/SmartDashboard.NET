// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.ohlc.OHLCSeriesCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.data.time;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time.ohlc
{
  [Implements(new string[] {"org.jfree.data.xy.OHLCDataset", "java.io.Serializable"})]
  [Serializable]
  public class OHLCSeriesCollection : AbstractXYDataset, OHLCDataset, XYDataset, SeriesDataset, Dataset, Serializable.__Interface
  {
    private List data;
    private TimePeriodAnchor xPosition;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 232, (byte) 59, (byte) 235, (byte) 70, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OHLCSeriesCollection()
    {
      OHLCSeriesCollection seriesCollection = this;
      this.xPosition = TimePeriodAnchor.__\u003C\u003EMIDDLE;
      this.data = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected OHLCSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] OHLCSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 126)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 90, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual OHLCSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (OHLCSeries) this.data.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 99, (byte) 109, (byte) 137, (byte) 109, (byte) 137, (byte) 109, (byte) 135})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    protected internal virtual long getX(RegularTimePeriod period)
    {
      long num = 0L;
      if (this.xPosition == TimePeriodAnchor.__\u003C\u003ESTART)
        num = period.getFirstMillisecond();
      else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EMIDDLE)
        num = period.getMiddleMillisecond();
      else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EEND)
        num = period.getLastMillisecond();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 114, (byte) 109, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return (double) this.getX(((OHLCItem) ((OHLCSeries) this.data.get(series)).getDataItem(item)).getPeriod());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 134, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getOpenValue(int series, int item)
    {
      return ((OHLCItem) ((OHLCSeries) this.data.get(series)).getDataItem(item)).getOpenValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCloseValue(int series, int item)
    {
      return ((OHLCItem) ((OHLCSeries) this.data.get(series)).getDataItem(item)).getCloseValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 186, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHighValue(int series, int item)
    {
      return ((OHLCItem) ((OHLCSeries) this.data.get(series)).getDataItem(item)).getHighValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 212, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLowValue(int series, int item)
    {
      return ((OHLCItem) ((OHLCSeries) this.data.get(series)).getDataItem(item)).getLowValue();
    }

    public virtual TimePeriodAnchor getXPosition()
    {
      return this.xPosition;
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 99, (byte) 144, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setXPosition(TimePeriodAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.xPosition = anchor;
        this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(OHLCSeries series)
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

    [LineNumberTable((ushort) 159)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable((ushort) 174)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable((ushort) 222)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      OHLCItem ohlcItem = (OHLCItem) ((OHLCSeries) this.data.get(series)).getDataItem(item);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(ohlcItem.getYValue());
    }

    [LineNumberTable((ushort) 262)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getOpen(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getOpenValue(series, item));
    }

    [LineNumberTable((ushort) 288)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getClose(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getCloseValue(series, item));
    }

    [LineNumberTable((ushort) 314)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getHigh(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getHighValue(series, item));
    }

    [LineNumberTable((ushort) 340)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getLow(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getLowValue(series, item));
    }

    public virtual Number getVolume(int series, int item)
    {
      return (Number) null;
    }

    public virtual double getVolumeValue(int series, int item)
    {
      return double.NaN;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 7, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is OHLCSeriesCollection))
        return false;
      OHLCSeriesCollection seriesCollection = (OHLCSeriesCollection) obj;
      if (!this.xPosition.equals((object) seriesCollection.xPosition))
        return false;
      return (ObjectUtilities.equal((object) this.data, (object) seriesCollection.data) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      OHLCSeriesCollection seriesCollection = (OHLCSeriesCollection) base.clone();
      seriesCollection.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      return (object) seriesCollection;
    }
  }
}
