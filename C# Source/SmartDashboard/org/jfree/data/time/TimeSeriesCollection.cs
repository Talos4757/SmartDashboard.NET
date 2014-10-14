// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimeSeriesCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset", "org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.DomainInfo", "java.io.Serializable"})]
  [Serializable]
  public class TimeSeriesCollection : AbstractIntervalXYDataset, XYDataset, SeriesDataset, Dataset, IntervalXYDataset, DomainInfo, Serializable.__Interface
  {
    private const long serialVersionUID = 834149929022371137L;
    private List data;
    private Calendar workingCalendar;
    private TimePeriodAnchor xPosition;
    [Obsolete]
    private bool domainIsPointsInTime;

    [LineNumberTable(new byte[] {(byte) 90, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesCollection()
      : this((TimeSeries) null, TimeZone.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 136, (byte) 99, (byte) 135, (byte) 108, (byte) 107, (byte) 99, (byte) 109, (byte) 135, (byte) 107, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesCollection(TimeSeries series, TimeZone zone)
    {
      TimeSeriesCollection seriesCollection = this;
      if (zone == null)
        zone = TimeZone.getDefault();
      this.workingCalendar = Calendar.getInstance(zone);
      this.data = (List) new ArrayList();
      if (series != null)
      {
        this.data.add((object) series);
        series.addChangeListener((SeriesChangeListener) this);
      }
      this.xPosition = TimePeriodAnchor.__\u003C\u003ESTART;
      this.domainIsPointsInTime = true;
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesCollection(TimeZone zone)
      : this((TimeSeries) null, zone)
    {
    }

    [LineNumberTable(new byte[] {(byte) 111, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesCollection(TimeSeries series)
      : this(series, TimeZone.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimeSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimeSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 231, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(TimeSeries series)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 183, (byte) 109, (byte) 191, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (TimeSeries) this.data.get(series);
      string str = new StringBuffer().append("The 'series' argument is out of bounds (").append(series).append(").").toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 269)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 246, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(TimeSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data.remove((object) series);
        series.removeChangeListener((SeriesChangeListener) this);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 79, (byte) 99, (byte) 109, (byte) 143, (byte) 109, (byte) 143, (byte) 109, (byte) 141})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    protected internal virtual long getX(RegularTimePeriod period)
    {
      long num = 0L;
      if (this.xPosition == TimePeriodAnchor.__\u003C\u003ESTART)
        num = period.getFirstMillisecond(this.workingCalendar);
      else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EMIDDLE)
        num = period.getMiddleMillisecond(this.workingCalendar);
      else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EEND)
        num = period.getLastMillisecond(this.workingCalendar);
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 131, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return ((TimeSeries) this.data.get(series)).getDataItem(item).getValue();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 114, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      RegularTimePeriod period = ((TimeSeries) this.data.get(series)).getDataItem(item).getPeriod();
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(this.getX(period));
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 248, (byte) 98, (byte) 98, (byte) 108, (byte) 107, (byte) 108, (byte) 104, (byte) 104, (byte) 105, (byte) 140, (byte) 99, (byte) 187, (byte) 223, (byte) 4, (byte) 137, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      Range range1 = (Range) null;
      Iterator iterator = this.data.iterator();
      while (iterator.hasNext())
      {
        TimeSeries timeSeries = (TimeSeries) iterator.next();
        int itemCount = timeSeries.getItemCount();
        if (itemCount > 0)
        {
          RegularTimePeriod timePeriod1 = timeSeries.getTimePeriod(0);
          RegularTimePeriod timePeriod2 = timeSeries.getTimePeriod(itemCount - 1);
          Range range2 = num != 0 ? new Range((double) timePeriod1.getFirstMillisecond(this.workingCalendar), (double) timePeriod2.getLastMillisecond(this.workingCalendar)) : new Range((double) this.getX(timePeriod1), (double) this.getX(timePeriod2));
          range1 = Range.combine(range1, range2);
        }
      }
      return range1;
    }

    [Obsolete]
    public virtual bool getDomainIsPointsInTime()
    {
      return this.domainIsPointsInTime;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 89, (byte) 162, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainIsPointsInTime(bool flag)
    {
      this.domainIsPointsInTime = flag;
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable((ushort) 225)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DomainOrder getDomainOrder()
    {
      return DomainOrder.__\u003C\u003EASCENDING;
    }

    public virtual TimePeriodAnchor getXPosition()
    {
      return this.xPosition;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 99, (byte) 144, (byte) 103, (byte) 111})]
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

    [LineNumberTable((ushort) 260)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getSeries()
    {
      return Collections.unmodifiableList(this.data);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 169, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(TimeSeries series)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 98, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 108, (byte) 130, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries getSeries(IComparable key)
    {
      TimeSeries timeSeries1 = (TimeSeries) null;
      Iterator iterator = this.data.iterator();
      while (iterator.hasNext())
      {
        TimeSeries timeSeries2 = (TimeSeries) iterator.next();
        IComparable key1 = timeSeries2.getKey();
        if (key1 != null && Object.instancehelper_equals((object) key1, (object) key))
          timeSeries1 = timeSeries2;
      }
      return timeSeries1;
    }

    [LineNumberTable((ushort) 335)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 4, (byte) 104, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(int index)
    {
      TimeSeries series = this.getSeries(index);
      if (series == null)
        return;
      this.removeSeries(series);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 18, (byte) 112, (byte) 114, (byte) 7, (byte) 230, (byte) 70, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllSeries()
    {
      for (int index = 0; index < this.data.size(); ++index)
        ((Series) this.data.get(index)).removeChangeListener((SeriesChangeListener) this);
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 408)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 50, (byte) 114, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return (double) this.getX(((TimeSeries) this.data.get(series)).getDataItem(item).getPeriod());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 101, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      TimeSeriesDataItem dataItem = ((TimeSeries) this.data.get(series)).getDataItem(item);
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(dataItem.getPeriod().getFirstMillisecond(this.workingCalendar));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 116, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      TimeSeriesDataItem dataItem = ((TimeSeries) this.data.get(series)).getDataItem(item);
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(dataItem.getPeriod().getLastMillisecond(this.workingCalendar));
    }

    [LineNumberTable((ushort) 515)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 527)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 172, (byte) 111, (byte) 104, (byte) 107, (byte) 105, (byte) 104, (byte) 101, (byte) 132, (byte) 101, (byte) 100, (byte) 226, (byte) 56, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int[] getSurroundingItems(int series, long milliseconds)
    {
      int[] numArray1 = new int[2];
      int index1 = 0;
      int num1 = -1;
      numArray1[index1] = num1;
      int index2 = 1;
      int num2 = -1;
      numArray1[index2] = num2;
      int[] numArray2 = numArray1;
      TimeSeries series1 = this.getSeries(series);
      for (int index3 = 0; index3 < series1.getItemCount(); ++index3)
      {
        long num3 = this.getX(series, index3).longValue();
        if (num3 <= milliseconds)
          numArray2[0] = index3;
        if (num3 >= milliseconds)
        {
          numArray2[1] = index3;
          break;
        }
      }
      return numArray2;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 1, (byte) 162, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainLowerBound(bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      double num2 = double.NaN;
      Range domainBounds = this.getDomainBounds(num1 != 0);
      if (domainBounds != null)
        num2 = domainBounds.getLowerBound();
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 252, (byte) 66, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainUpperBound(bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      double num2 = double.NaN;
      Range domainBounds = this.getDomainBounds(num1 != 0);
      if (domainBounds != null)
        num2 = domainBounds.getUpperBound();
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 6, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TimeSeriesCollection))
        return false;
      TimeSeriesCollection seriesCollection = (TimeSeriesCollection) obj;
      return this.xPosition == seriesCollection.xPosition && this.domainIsPointsInTime == seriesCollection.domainIsPointsInTime && ObjectUtilities.equal((object) this.data, (object) seriesCollection.data);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 32, (byte) 108, (byte) 156, (byte) 156, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (29 * (29 * Object.instancehelper_hashCode((object) this.data) + (this.workingCalendar == null ? 0 : this.workingCalendar.hashCode())) + (this.xPosition == null ? 0 : this.xPosition.hashCode())) + (!this.domainIsPointsInTime ? 0 : 1);
    }
  }
}
