// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimeTableXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
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
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.DomainInfo", "org.jfree.data.xy.TableXYDataset"})]
  [Serializable]
  public class TimeTableXYDataset : AbstractIntervalXYDataset, Cloneable.__Interface, PublicCloneable, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, DomainInfo, TableXYDataset
  {
    private DefaultKeyedValues2D values;
    private bool domainIsPointsInTime;
    private TimePeriodAnchor xPosition;
    private Calendar workingCalendar;

    [LineNumberTable(new byte[] {(byte) 85, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 108, (byte) 109, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeTableXYDataset(TimeZone zone, Locale locale)
    {
      TimeTableXYDataset timeTableXyDataset = this;
      if (zone == null)
      {
        string str = "Null 'zone' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (locale == null)
      {
        string str = "Null 'locale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.values = new DefaultKeyedValues2D(true);
        this.workingCalendar = Calendar.getInstance(zone, locale);
        this.xPosition = TimePeriodAnchor.__\u003C\u003ESTART;
      }
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeTableXYDataset()
      : this(TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeTableXYDataset(TimeZone zone)
      : this(zone, Locale.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimeTableXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] TimeTableXYDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 84, (byte) 131, (byte) 110, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TimePeriod period, Number y, string seriesName, bool notify)
    {
      int num = notify ? 1 : 0;
      this.values.addValue(y, (IComparable) period, (IComparable) seriesName);
      if (num == 0)
        return;
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 76, (byte) 162, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(TimePeriod period, string seriesName, bool notify)
    {
      int num = notify ? 1 : 0;
      this.values.removeValue((IComparable) period, (IComparable) seriesName);
      if (num == 0)
        return;
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 304)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.values.getRowCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 249, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return (double) this.getXValue((TimePeriod) this.values.getRowKey(item));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 97, (byte) 99, (byte) 109, (byte) 142, (byte) 109, (byte) 108, (byte) 108, (byte) 105, (byte) 98, (byte) 109, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private long getXValue([In] TimePeriod obj0)
    {
      long num = 0L;
      if (this.xPosition == TimePeriodAnchor.__\u003C\u003ESTART)
        num = obj0.getStart().getTime();
      else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EMIDDLE)
      {
        long time1 = obj0.getStart().getTime();
        long time2 = obj0.getEnd().getTime();
        num = time1 + (time2 - time1) / 2L;
      }
      else if (this.xPosition == TimePeriodAnchor.__\u003C\u003EEND)
        num = obj0.getEnd().getTime();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 21, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartXValue(int series, int item)
    {
      return (double) ((TimePeriod) this.values.getRowKey(item)).getStart().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndXValue(int series, int item)
    {
      return (double) ((TimePeriod) this.values.getRowKey(item)).getEnd().getTime();
    }

    [LineNumberTable((ushort) 432)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return this.values.getValue(item, series);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 11, (byte) 98, (byte) 108, (byte) 104, (byte) 162, (byte) 109, (byte) 148, (byte) 107, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      List rowKeys = this.values.getRowKeys();
      if (rowKeys.isEmpty())
        return (Range) null;
      TimePeriod timePeriod1 = (TimePeriod) rowKeys.get(0);
      TimePeriod timePeriod2 = (TimePeriod) rowKeys.get(rowKeys.size() - 1);
      if (num == 0 || this.domainIsPointsInTime)
        return new Range((double) this.getXValue(timePeriod1), (double) this.getXValue(timePeriod2));
      else
        return new Range((double) timePeriod1.getStart().getTime(), (double) timePeriod2.getEnd().getTime());
    }

    public virtual bool getDomainIsPointsInTime()
    {
      return this.domainIsPointsInTime;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 99, (byte) 130, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainIsPointsInTime(bool flag)
    {
      this.domainIsPointsInTime = flag;
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    public virtual TimePeriodAnchor getXPosition()
    {
      return this.xPosition;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 99, (byte) 144, (byte) 103, (byte) 111})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TimePeriod period, double y, string seriesName)
    {
      this.add(period, (Number) new Double(y), seriesName, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(TimePeriod period, string seriesName)
    {
      this.remove(period, seriesName, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 166, (byte) 110, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      if (this.values.getRowCount() <= 0)
        return;
      this.values.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 295)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimePeriod getTimePeriod(int item)
    {
      return (TimePeriod) this.values.getRowKey(item);
    }

    [LineNumberTable((ushort) 317)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getItemCount();
    }

    [LineNumberTable((ushort) 326)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.values.getColumnCount();
    }

    [LineNumberTable((ushort) 337)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.values.getColumnKey(series);
    }

    [LineNumberTable((ushort) 351)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable((ushort) 378)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getStartXValue(series, item));
    }

    [LineNumberTable((ushort) 406)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getEndXValue(series, item));
    }

    [LineNumberTable((ushort) 444)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 456)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 20, (byte) 162, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 15, (byte) 66, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 180, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 189, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TimeTableXYDataset))
        return false;
      TimeTableXYDataset timeTableXyDataset = (TimeTableXYDataset) obj;
      return this.domainIsPointsInTime == timeTableXyDataset.domainIsPointsInTime && this.xPosition == timeTableXyDataset.xPosition && (Object.instancehelper_equals((object) this.workingCalendar.getTimeZone(), (object) timeTableXyDataset.workingCalendar.getTimeZone()) && this.values.equals((object) timeTableXyDataset.values));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 212, (byte) 108, (byte) 118, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      TimeTableXYDataset timeTableXyDataset = (TimeTableXYDataset) base.clone();
      timeTableXyDataset.values = (DefaultKeyedValues2D) this.values.clone();
      timeTableXyDataset.workingCalendar = (Calendar) this.workingCalendar.clone();
      return (object) timeTableXyDataset;
    }
  }
}
