// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimePeriodValuesCollection
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
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.DomainInfo", "java.io.Serializable"})]
  [Serializable]
  public class TimePeriodValuesCollection : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, DomainInfo, Serializable.__Interface
  {
    private const long serialVersionUID = -3077934065236454199L;
    private List data;
    private TimePeriodAnchor xPosition;
    private bool domainIsPointsInTime;

    [LineNumberTable(new byte[] {(byte) 55, (byte) 104, (byte) 107, (byte) 107, (byte) 103, (byte) 99, (byte) 109, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimePeriodValuesCollection(TimePeriodValues series)
    {
      TimePeriodValuesCollection valuesCollection = this;
      this.data = (List) new ArrayList();
      this.xPosition = TimePeriodAnchor.__\u003C\u003EMIDDLE;
      this.domainIsPointsInTime = false;
      if (series == null)
        return;
      this.data.add((object) series);
      series.addChangeListener((SeriesChangeListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimePeriodValuesCollection()
      : this((TimePeriodValues) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimePeriodValuesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimePeriodValuesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 146)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimePeriodValues getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (TimePeriodValues) this.data.get(series);
      string str = "Index 'series' out of range.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(TimePeriodValues series)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 109, (byte) 142, (byte) 109, (byte) 190, (byte) 109, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private long getX([In] TimePeriod obj0)
    {
      if (this.xPosition == TimePeriodAnchor.__\u003C\u003ESTART)
      {
        return obj0.getStart().getTime();
      }
      else
      {
        if (this.xPosition == TimePeriodAnchor.__\u003C\u003EMIDDLE)
          return obj0.getStart().getTime() / 2L + obj0.getEnd().getTime() / 2L;
        if (this.xPosition == TimePeriodAnchor.__\u003C\u003EEND)
        {
          return obj0.getEnd().getTime();
        }
        else
        {
          string str = "TimePeriodAnchor unknown.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalStateException(str);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 198, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return ((TimePeriodValues) this.data.get(series)).getDataItem(item).getValue();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 46, (byte) 66, (byte) 112, (byte) 98, (byte) 98, (byte) 109, (byte) 108, (byte) 110, (byte) 105, (byte) 104, (byte) 144, (byte) 112, (byte) 102, (byte) 109, (byte) 144, (byte) 159, (byte) 1, (byte) 101, (byte) 112, (byte) 144, (byte) 110, (byte) 110, (byte) 144, (byte) 110, (byte) 110, (byte) 158, (byte) 98, (byte) 109, (byte) 144, (byte) 159, (byte) 1, (byte) 162, (byte) 191, (byte) 1, (byte) 136, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      int num = includeInterval || this.domainIsPointsInTime ? 1 : 0;
      Range range1 = (Range) null;
      Range range2 = (Range) null;
      Iterator iterator = this.data.iterator();
      while (iterator.hasNext())
      {
        TimePeriodValues timePeriodValues = (TimePeriodValues) iterator.next();
        if (timePeriodValues.getItemCount() > 0)
        {
          TimePeriod timePeriod1 = timePeriodValues.getTimePeriod(timePeriodValues.getMinStartIndex());
          TimePeriod timePeriod2 = timePeriodValues.getTimePeriod(timePeriodValues.getMaxEndIndex());
          if (num == 0)
          {
            if (this.xPosition == TimePeriodAnchor.__\u003C\u003ESTART)
            {
              TimePeriod timePeriod3 = timePeriodValues.getTimePeriod(timePeriodValues.getMaxStartIndex());
              range2 = new Range((double) timePeriod1.getStart().getTime(), (double) timePeriod3.getStart().getTime());
            }
            else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EMIDDLE)
            {
              TimePeriod timePeriod3 = timePeriodValues.getTimePeriod(timePeriodValues.getMinMiddleIndex());
              long time1 = timePeriod3.getStart().getTime();
              long time2 = timePeriod3.getEnd().getTime();
              TimePeriod timePeriod4 = timePeriodValues.getTimePeriod(timePeriodValues.getMaxMiddleIndex());
              long time3 = timePeriod4.getStart().getTime();
              long time4 = timePeriod4.getEnd().getTime();
              range2 = new Range((double) (time1 + (time2 - time1) / 2L), (double) (time3 + (time4 - time3) / 2L));
            }
            else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EEND)
              range2 = new Range((double) timePeriodValues.getTimePeriod(timePeriodValues.getMinEndIndex()).getEnd().getTime(), (double) timePeriod2.getEnd().getTime());
          }
          else
            range2 = new Range((double) timePeriod1.getStart().getTime(), (double) timePeriod2.getEnd().getTime());
          range1 = Range.combine(range1, range2);
        }
      }
      return range1;
    }

    public virtual TimePeriodAnchor getXPosition()
    {
      return this.xPosition;
    }

    [LineNumberTable(new byte[] {(byte) 84, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setXPosition(TimePeriodAnchor position)
    {
      if (position == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.xPosition = position;
    }

    [LineNumberTable((ushort) 172)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 99, (byte) 176, (byte) 109, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(TimePeriodValues series)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 104, (byte) 99, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(int index)
    {
      TimePeriodValues series = this.getSeries(index);
      if (series == null)
        return;
      this.removeSeries(series);
    }

    [LineNumberTable((ushort) 232)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 114, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      TimePeriod period = ((TimePeriodValues) this.data.get(series)).getDataItem(item).getPeriod();
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(this.getX(period));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 170, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      TimePeriodValue dataItem = ((TimePeriodValues) this.data.get(series)).getDataItem(item);
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(dataItem.getPeriod().getStart().getTime());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      TimePeriodValue dataItem = ((TimePeriodValues) this.data.get(series)).getDataItem(item);
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(dataItem.getPeriod().getEnd().getTime());
    }

    [LineNumberTable((ushort) 326)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 338)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 55, (byte) 130, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 51, (byte) 162, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 69, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TimePeriodValuesCollection))
        return false;
      TimePeriodValuesCollection valuesCollection = (TimePeriodValuesCollection) obj;
      return this.domainIsPointsInTime == valuesCollection.domainIsPointsInTime && this.xPosition == valuesCollection.xPosition && ObjectUtilities.equal((object) this.data, (object) valuesCollection.data);
    }

    [Obsolete]
    public virtual bool getDomainIsPointsInTime()
    {
      return this.domainIsPointsInTime;
    }

    [Obsolete]
    public virtual void setDomainIsPointsInTime(bool flag)
    {
      this.domainIsPointsInTime = flag;
    }
  }
}
