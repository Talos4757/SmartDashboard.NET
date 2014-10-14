// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.DynamicTimeSeriesCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.DomainInfo", "org.jfree.data.RangeInfo"})]
  [Serializable]
  public class DynamicTimeSeriesCollection : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, DomainInfo, RangeInfo
  {
    public const int START = 0;
    public const int MIDDLE = 1;
    public const int END = 2;
    private int maximumItemCount;
    protected internal int historyCount;
    private IComparable[] seriesKeys;
    private Class timePeriodClass;
    protected internal RegularTimePeriod[] pointsInTime;
    private int seriesCount;
    protected internal DynamicTimeSeriesCollection.ValueSequence[] valueHistory;
    protected internal Calendar workingCalendar;
    private int position;
    private bool domainIsPointsInTime;
    private int oldestAt;
    private int newestAt;
    private long deltaTime;
    private Long domainStart;
    private Long domainEnd;
    private Range domainRange;
    private Float minValue;
    private Float maxValue;
    private Range valueRange;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Second;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 232, (byte) 159, (byte) 88, (byte) 235, (byte) 73, (byte) 255, (byte) 5, (byte) 160, (byte) 100, (byte) 176, (byte) 231, (byte) 123, (byte) 103, (byte) 103, (byte) 140, (byte) 102, (byte) 45, (byte) 166, (byte) 105, (byte) 108, (byte) 172, (byte) 127, (byte) 7, (byte) 142, (byte) 127, (byte) 7, (byte) 142, (byte) 127, (byte) 7, (byte) 172, (byte) 109, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicTimeSeriesCollection(int nSeries, int nMoments, RegularTimePeriod timeSample, TimeZone zone)
    {
      DynamicTimeSeriesCollection seriesCollection = this;
      this.maximumItemCount = 2000;
      this.timePeriodClass = DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute != null ? DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute : (DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute = DynamicTimeSeriesCollection.class\u0024("org.jfree.data.time.Minute"));
      this.minValue = new Float(0.0f);
      this.maxValue = (Float) null;
      this.maximumItemCount = nMoments;
      this.historyCount = nMoments;
      this.seriesKeys = new IComparable[nSeries];
      for (int index = 0; index < nSeries; ++index)
        this.seriesKeys[index] = (IComparable) "";
      this.newestAt = nMoments - 1;
      this.valueHistory = new DynamicTimeSeriesCollection.ValueSequence[nSeries];
      this.timePeriodClass = Object.instancehelper_getClass((object) timeSample);
      if (this.timePeriodClass == (DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second != null ? DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second : (DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second = DynamicTimeSeriesCollection.class\u0024("org.jfree.data.time.Second"))))
        this.pointsInTime = (RegularTimePeriod[]) new Second[nMoments];
      else if (this.timePeriodClass == (DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute != null ? DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute : (DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute = DynamicTimeSeriesCollection.class\u0024("org.jfree.data.time.Minute"))))
        this.pointsInTime = (RegularTimePeriod[]) new Minute[nMoments];
      else if (this.timePeriodClass == (DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour != null ? DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour : (DynamicTimeSeriesCollection.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour = DynamicTimeSeriesCollection.class\u0024("org.jfree.data.time.Hour"))))
        this.pointsInTime = (RegularTimePeriod[]) new Hour[nMoments];
      this.workingCalendar = Calendar.getInstance(zone);
      this.position = 0;
      this.domainIsPointsInTime = true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 116, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicTimeSeriesCollection(int nSeries, int nMoments)
      : this(nSeries, nMoments, (RegularTimePeriod) new Millisecond(), TimeZone.getDefault())
    {
      DynamicTimeSeriesCollection seriesCollection = this;
      this.newestAt = nMoments - 1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 112, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicTimeSeriesCollection(int nSeries, int nMoments, TimeZone zone)
      : this(nSeries, nMoments, (RegularTimePeriod) new Millisecond(), zone)
    {
      DynamicTimeSeriesCollection seriesCollection = this;
      this.newestAt = nMoments - 1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicTimeSeriesCollection(int nSeries, int nMoments, RegularTimePeriod timeSample)
      : this(nSeries, nMoments, timeSample, TimeZone.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DynamicTimeSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 84)]
    internal static int access\u0024000([In] DynamicTimeSeriesCollection obj0)
    {
      return obj0.maximumItemCount;
    }

    [LineNumberTable((ushort) 115)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal new static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, DynamicTimeSeriesCollection.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 146, (byte) 104, (byte) 180, (byte) 146, (byte) 108, (byte) 108, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void findDomainLimits()
    {
      long firstMillisecond = this.getOldestTime().getFirstMillisecond(this.workingCalendar);
      long num = !this.domainIsPointsInTime ? this.getNewestTime().getLastMillisecond(this.workingCalendar) : this.getNewestTime().getFirstMillisecond(this.workingCalendar);
      this.domainStart = new Long(firstMillisecond);
      this.domainEnd = new Long(num);
      this.domainRange = new Range((double) firstMillisecond, (double) num);
    }

    [LineNumberTable((ushort) 727)]
    public virtual RegularTimePeriod getOldestTime()
    {
      return this.pointsInTime[this.oldestAt];
    }

    [LineNumberTable((ushort) 718)]
    public virtual RegularTimePeriod getNewestTime()
    {
      return this.pointsInTime[this.newestAt];
    }

    public virtual void invalidateRangeInfo()
    {
      this.maxValue = (Float) null;
      this.valueRange = (Range) null;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 222, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fireSeriesChanged()
    {
      this.seriesChanged(new SeriesChangeEvent((object) this));
    }

    protected internal virtual int wrapOffset(int protoIndex)
    {
      int num = protoIndex;
      if (num >= this.historyCount)
        num -= this.historyCount;
      else if (num < 0)
        num += this.historyCount;
      return num;
    }

    public override int getSeriesCount()
    {
      return this.seriesCount;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 130, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return (double) this.valueHistory[series].getData(this.translateGet(item));
    }

    protected internal virtual int translateGet(int toFetch)
    {
      if (this.oldestAt == 0)
        return toFetch;
      int num = toFetch + this.oldestAt;
      if (num >= this.historyCount)
        num -= this.historyCount;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 23, (byte) 153, (byte) 143, (byte) 143, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private long getX([In] RegularTimePeriod obj0)
    {
      switch (this.position)
      {
        case 0:
          return obj0.getFirstMillisecond(this.workingCalendar);
        case 1:
          return obj0.getMiddleMillisecond(this.workingCalendar);
        case 2:
          return obj0.getLastMillisecond(this.workingCalendar);
        default:
          return obj0.getMiddleMillisecond(this.workingCalendar);
      }
    }

    [LineNumberTable((ushort) 769)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      Float.__\u003Cclinit\u003E();
      return (Number) new Float(this.getYValue(series, item));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 66, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeUpperBound(bool includeInterval)
    {
      double num = double.NaN;
      if (this.maxValue != null)
        num = this.maxValue.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 203, (byte) 106, (byte) 105, (byte) 107, (byte) 55, (byte) 198, (byte) 180, (byte) 180, (byte) 105, (byte) 103, (byte) 110, (byte) 102})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual long setTimeBase(RegularTimePeriod start)
    {
      if (this.pointsInTime[0] == null)
      {
        this.pointsInTime[0] = start;
        for (int index = 1; index < this.historyCount; ++index)
          this.pointsInTime[index] = this.pointsInTime[index - 1].next();
      }
      this.deltaTime = this.pointsInTime[1].getFirstMillisecond(this.workingCalendar) - this.pointsInTime[0].getFirstMillisecond(this.workingCalendar);
      this.oldestAt = 0;
      this.newestAt = this.historyCount - 1;
      this.findDomainLimits();
      return this.deltaTime;
    }

    public virtual int getPosition()
    {
      return this.position;
    }

    public virtual void setPosition(int position)
    {
      this.position = position;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 19, (byte) 134, (byte) 99, (byte) 176, (byte) 106, (byte) 176, (byte) 106, (byte) 148, (byte) 238, (byte) 69, (byte) 99, (byte) 103, (byte) 98, (byte) 105, (byte) 98, (byte) 162, (byte) 134, (byte) 17, (byte) 198, (byte) 99, (byte) 107, (byte) 51, (byte) 230, (byte) 69, (byte) 99, (byte) 137, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(float[] values, int seriesNumber, IComparable seriesKey)
    {
      this.invalidateRangeInfo();
      if (values == null)
      {
        string str = "TimeSeriesDataset.addSeries(): cannot add null array of values.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (seriesNumber >= this.valueHistory.Length)
      {
        string str = "TimeSeriesDataset.addSeries(): cannot add more series than specified in c'tor";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.valueHistory[seriesNumber] == null)
        {
          this.valueHistory[seriesNumber] = new DynamicTimeSeriesCollection.ValueSequence(this, this.historyCount);
          ++this.seriesCount;
        }
        int length = values.Length;
        int num1 = this.historyCount;
        int num2 = 0;
        if (length < this.historyCount)
        {
          num2 = 1;
          num1 = length;
        }
        for (int index = 0; index < num1; ++index)
          this.valueHistory[seriesNumber].enterData(index, values[index]);
        if (num2 != 0)
        {
          for (int index = num1; index < this.historyCount; ++index)
            this.valueHistory[seriesNumber].enterData(index, 0.0f);
        }
        if (seriesKey != null)
          this.seriesKeys[seriesNumber] = seriesKey;
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 69, (byte) 105})]
    public virtual void setSeriesKey(int seriesNumber, IComparable key)
    {
      this.seriesKeys[seriesNumber] = key;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 81, (byte) 102, (byte) 106, (byte) 255, (byte) 16, (byte) 69, (byte) 106, (byte) 148, (byte) 238, (byte) 69, (byte) 144, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(int seriesNumber, int index, float value)
    {
      this.invalidateRangeInfo();
      if (seriesNumber >= this.valueHistory.Length)
      {
        string str = new StringBuffer().append("TimeSeriesDataset.addValue(): series #").append(seriesNumber).append("unspecified in c'tor").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.valueHistory[seriesNumber] == null)
        {
          this.valueHistory[seriesNumber] = new DynamicTimeSeriesCollection.ValueSequence(this, this.historyCount);
          ++this.seriesCount;
        }
        this.valueHistory[seriesNumber].enterData(index, value);
        this.fireSeriesChanged();
      }
    }

    public override int getItemCount(int series)
    {
      return this.historyCount;
    }

    [LineNumberTable((ushort) 523)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int offsetFromNewest(int delta)
    {
      return this.wrapOffset(this.newestAt + delta);
    }

    [LineNumberTable((ushort) 534)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int offsetFromOldest(int delta)
    {
      return this.wrapOffset(this.oldestAt + delta);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 193, (byte) 115, (byte) 236, (byte) 71, (byte) 98, (byte) 102, (byte) 104, (byte) 140, (byte) 107, (byte) 118, (byte) 130, (byte) 99, (byte) 226, (byte) 59, (byte) 230, (byte) 72, (byte) 99, (byte) 166, (byte) 103, (byte) 109, (byte) 54, (byte) 200, (byte) 142, (byte) 110, (byte) 110, (byte) 167, (byte) 109, (byte) 121, (byte) 109, (byte) 121, (byte) 113, (byte) 102})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual RegularTimePeriod advanceTime()
    {
      RegularTimePeriod regularTimePeriod = this.pointsInTime[this.newestAt].next();
      this.newestAt = this.oldestAt;
      int num1 = 0;
      float num2 = 0.0f;
      if (this.maxValue != null)
        num2 = this.maxValue.floatValue();
      for (int index = 0; index < this.getSeriesCount(); ++index)
      {
        if ((double) this.valueHistory[index].getData(this.oldestAt) == (double) num2)
          num1 = 1;
        if (num1 != 0)
          break;
      }
      if (num1 != 0)
        this.invalidateRangeInfo();
      float num3 = 0.0f;
      for (int index = 0; index < this.getSeriesCount(); ++index)
        this.valueHistory[index].enterData(this.newestAt, num3);
      this.pointsInTime[this.newestAt] = regularTimePeriod;
      ++this.oldestAt;
      if (this.oldestAt >= this.historyCount)
        this.oldestAt = 0;
      long num4 = this.domainStart.longValue();
      Long.__\u003Cclinit\u003E();
      this.domainStart = new Long(num4 + this.deltaTime);
      long num5 = this.domainEnd.longValue();
      Long.__\u003Cclinit\u003E();
      this.domainEnd = new Long(num5 + this.deltaTime);
      this.domainRange = new Range((double) num4, (double) num5);
      this.fireSeriesChanged();
      return regularTimePeriod;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 255, (byte) 102, (byte) 107, (byte) 107, (byte) 106, (byte) 100, (byte) 226, (byte) 61, (byte) 38, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double findMaxValue()
    {
      double num = 0.0;
      for (int series = 0; series < this.getSeriesCount(); ++series)
      {
        for (int index = 0; index < this.historyCount; ++index)
        {
          double yvalue = this.getYValue(series, index);
          if (yvalue > num)
            num = yvalue;
        }
      }
      return num;
    }

    public virtual int getOldestIndex()
    {
      return this.oldestAt;
    }

    public virtual int getNewestIndex()
    {
      return this.newestAt;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 39, (byte) 99, (byte) 106, (byte) 240, (byte) 69, (byte) 166, (byte) 106, (byte) 148, (byte) 246, (byte) 58, (byte) 230, (byte) 72, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void appendData(float[] newData)
    {
      int length = newData.Length;
      if (length > this.valueHistory.Length)
      {
        string str = "More data than series to put them in";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        for (int index = 0; index < length; ++index)
        {
          if (this.valueHistory[index] == null)
            this.valueHistory[index] = new DynamicTimeSeriesCollection.ValueSequence(this, this.historyCount);
          this.valueHistory[index].enterData(this.newestAt, newData[index]);
        }
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 66, (byte) 99, (byte) 106, (byte) 208, (byte) 102, (byte) 106, (byte) 148, (byte) 241, (byte) 60, (byte) 230, (byte) 70, (byte) 100, (byte) 101, (byte) 110, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void appendData(float[] newData, int insertionIndex, int refresh)
    {
      int length = newData.Length;
      if (length > this.valueHistory.Length)
      {
        string str = "More data than series to put them in";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        for (int index = 0; index < length; ++index)
        {
          if (this.valueHistory[index] == null)
            this.valueHistory[index] = new DynamicTimeSeriesCollection.ValueSequence(this, this.historyCount);
          this.valueHistory[index].enterData(insertionIndex, newData[index]);
        }
        if (refresh <= 0)
          return;
        ++insertionIndex;
        int num1 = insertionIndex;
        int num2 = refresh;
        int num3 = -1;
        if ((num2 != num3 ? num1 % num2 : 0) != 0)
          return;
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 115, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      RegularTimePeriod regularTimePeriod = this.pointsInTime[this.translateGet(item)];
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(this.getX(regularTimePeriod));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 155, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      RegularTimePeriod regularTimePeriod = this.pointsInTime[this.translateGet(item)];
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(regularTimePeriod.getFirstMillisecond(this.workingCalendar));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 168, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      RegularTimePeriod regularTimePeriod = this.pointsInTime[this.translateGet(item)];
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(regularTimePeriod.getLastMillisecond(this.workingCalendar));
    }

    [LineNumberTable((ushort) 807)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 819)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 841)]
    public override IComparable getSeriesKey(int series)
    {
      return this.seriesKeys[series];
    }

    [LineNumberTable((ushort) 865)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainLowerBound(bool includeInterval)
    {
      return this.domainStart.doubleValue();
    }

    [LineNumberTable((ushort) 878)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainUpperBound(bool includeInterval)
    {
      return this.domainEnd.doubleValue();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 9, (byte) 104, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      if (this.domainRange == null)
        this.findDomainLimits();
      return this.domainRange;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 50, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeLowerBound(bool includeInterval)
    {
      double num = double.NaN;
      if (this.minValue != null)
        num = this.minValue.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 157, (byte) 66, (byte) 104, (byte) 105, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getRangeBounds(bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (this.valueRange == null)
        this.valueRange = new Range(0.0, this.getRangeUpperBound(num != 0));
      return this.valueRange;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (DynamicTimeSeriesCollection.__\u003CcallerID\u003E == null)
        DynamicTimeSeriesCollection.__\u003CcallerID\u003E = (CallerID) new DynamicTimeSeriesCollection.__\u003CCallerID\u003E();
      return DynamicTimeSeriesCollection.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("DynamicTimeSeriesCollection.java")]
    public class ValueSequence : Object
    {
      internal float[] dataPoints;
      [Modifiers]
      private DynamicTimeSeriesCollection this\u00240;

      [LineNumberTable(new byte[] {(byte) 93, (byte) 111, (byte) 108, (byte) 102, (byte) 45, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ValueSequence(DynamicTimeSeriesCollection dtsc, int length)
      {
        base.\u002Ector();
        DynamicTimeSeriesCollection.ValueSequence valueSequence = this;
        this.this\u00240 = dtsc;
        this.dataPoints = new float[length];
        for (int index = 0; index < length; ++index)
          this.dataPoints[index] = 0.0f;
      }

      [LineNumberTable(new byte[] {(byte) 85, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ValueSequence(DynamicTimeSeriesCollection dtsc)
        : this(dtsc, DynamicTimeSeriesCollection.access\u0024000(dtsc))
      {
      }

      [LineNumberTable(new byte[] {(byte) 107, (byte) 106})]
      public virtual void enterData(int index, float value)
      {
        this.dataPoints[index] = value;
      }

      [LineNumberTable((ushort) 168)]
      public virtual float getData(int index)
      {
        return this.dataPoints[index];
      }
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
