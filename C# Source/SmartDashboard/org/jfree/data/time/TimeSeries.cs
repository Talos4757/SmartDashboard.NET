// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimeSeries
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class TimeSeries : Series, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -5032960206869675528L;
    protected internal const string DEFAULT_DOMAIN_DESCRIPTION = "Time";
    protected internal const string DEFAULT_RANGE_DESCRIPTION = "Value";
    private string domain;
    private string range;
    protected internal Class timePeriodClass;
    protected internal List data;
    private int maximumItemCount;
    private long maximumItemAge;
    internal static Class class\u0024java\u0024lang\u0024Class;
    internal static Class class\u0024java\u0024util\u0024Date;
    internal static Class class\u0024java\u0024util\u0024TimeZone;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024RegularTimePeriod;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 95, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeries(IComparable name)
      : this(name, "Time", "Value")
    {
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 105, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeries(IComparable name, string domain, string range)
      : base(name)
    {
      TimeSeries timeSeries = this;
      this.domain = domain;
      this.range = range;
      this.timePeriodClass = (Class) null;
      this.data = (List) new ArrayList();
      this.maximumItemCount = int.MaxValue;
      this.maximumItemAge = long.MaxValue;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 187, (byte) 105, (byte) 103, (byte) 103, (byte) 104, (byte) 107, (byte) 107, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeries(IComparable name, string domain, string range, Class timePeriodClass)
      : base(name)
    {
      TimeSeries timeSeries = this;
      this.domain = domain;
      this.range = range;
      this.timePeriodClass = timePeriodClass;
      this.data = (List) new ArrayList();
      this.maximumItemCount = int.MaxValue;
      this.maximumItemAge = long.MaxValue;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 164, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeries(IComparable name, Class timePeriodClass)
      : this(name, "Time", "Value", timePeriodClass)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimeSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] TimeSeries obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimeSeries obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 178, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(RegularTimePeriod period, double value)
    {
      this.add(period, value, true);
    }

    [LineNumberTable((ushort) 361)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RegularTimePeriod getTimePeriod(int index)
    {
      return this.getDataItem(index).getPeriod();
    }

    [LineNumberTable((ushort) 228)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount()
    {
      return this.data.size();
    }

    [LineNumberTable((ushort) 330)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeriesDataItem getDataItem(int index)
    {
      return (TimeSeriesDataItem) this.data.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 205, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(RegularTimePeriod period, Number value)
    {
      this.add(period, value, true);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 203, (byte) 100, (byte) 144, (byte) 104, (byte) 45, (byte) 166, (byte) 109, (byte) 135, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void delete(int start, int end)
    {
      if (end < start)
      {
        string str = "Requires start <= end.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        for (int index = 0; index <= end - start; ++index)
          this.data.remove(start);
        if (this.data.isEmpty())
          this.timePeriodClass = (Class) null;
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 216, (byte) 98, (byte) 105, (byte) 116, (byte) 130, (byte) 118, (byte) 109, (byte) 132, (byte) 102, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAgedItems(bool notify)
    {
      int num1 = notify ? 1 : 0;
      if (this.getItemCount() <= 1)
        return;
      long serialIndex = this.getTimePeriod(this.getItemCount() - 1).getSerialIndex();
      int num2 = 0;
      while (serialIndex - this.getTimePeriod(0).getSerialIndex() > this.maximumItemAge)
      {
        this.data.remove(0);
        num2 = 1;
      }
      if (num2 == 0 || num1 == 0)
        return;
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 47, (byte) 99, (byte) 144, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIndex(RegularTimePeriod period)
    {
      if (period == null)
      {
        string str = "Null 'period' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return Collections.binarySearch(this.data, (object) new TimeSeriesDataItem(period, (double) int.MinValue));
    }

    [LineNumberTable((ushort) 433)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int index)
    {
      return this.getDataItem(index).getValue();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 24, (byte) 130, (byte) 99, (byte) 144, (byte) 108, (byte) 104, (byte) 140, (byte) 113, (byte) 102, (byte) 108, (byte) 108, (byte) 119, (byte) 108, (byte) 114, (byte) 108, (byte) 209, (byte) 98, (byte) 103, (byte) 99, (byte) 109, (byte) 168, (byte) 112, (byte) 112, (byte) 109, (byte) 168, (byte) 110, (byte) 101, (byte) 113, (byte) 168, (byte) 103, (byte) 109, (byte) 109, (byte) 115, (byte) 109, (byte) 109, (byte) 109, (byte) 210, (byte) 132, (byte) 110, (byte) 173, (byte) 167, (byte) 99, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TimeSeriesDataItem item, bool notify)
    {
      int num1 = notify ? 1 : 0;
      if (item == null)
      {
        string str = "Null 'item' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Class @class = Object.instancehelper_getClass((object) item.getPeriod());
        if (this.timePeriodClass == null)
          this.timePeriodClass = @class;
        else if (!Object.instancehelper_equals((object) this.timePeriodClass, (object) @class))
        {
          StringBuffer stringBuffer = new StringBuffer();
          stringBuffer.append("You are trying to add data where the time period class ");
          stringBuffer.append("is ");
          stringBuffer.append(Object.instancehelper_getClass((object) item.getPeriod()).getName());
          stringBuffer.append(", but the TimeSeries is expecting an instance of ");
          stringBuffer.append(this.timePeriodClass.getName());
          stringBuffer.append(".");
          string message = stringBuffer.toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new SeriesException(message);
        }
        int num2;
        if (this.getItemCount() == 0)
        {
          this.data.add((object) item);
          num2 = 1;
        }
        else
        {
          RegularTimePeriod timePeriod = this.getTimePeriod(this.getItemCount() - 1);
          if (item.getPeriod().compareTo((object) timePeriod) > 0)
          {
            this.data.add((object) item);
            num2 = 1;
          }
          else
          {
            int num3 = Collections.binarySearch(this.data, (object) item);
            if (num3 < 0)
            {
              this.data.add(-num3 - 1, (object) item);
              num2 = 1;
            }
            else
            {
              StringBuffer stringBuffer = new StringBuffer();
              stringBuffer.append("You are attempting to add an observation for ");
              stringBuffer.append("the time period ");
              stringBuffer.append(item.getPeriod().toString());
              stringBuffer.append(" but the series already contains an observation");
              stringBuffer.append(" for that time period. Duplicates are not ");
              stringBuffer.append("permitted.  Try using the addOrUpdate() method.");
              string message = stringBuffer.toString();
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new SeriesException(message);
            }
          }
        }
        if (num2 == 0)
          return;
        if (this.getItemCount() > this.maximumItemCount)
          this.data.remove(0);
        this.removeAgedItems(false);
        if (num1 == 0)
          return;
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 2, (byte) 98, (byte) 105, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(RegularTimePeriod period, double value, bool notify)
    {
      int num = notify ? 1 : 0;
      this.add(new TimeSeriesDataItem(period, value), num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 251, (byte) 66, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(RegularTimePeriod period, Number value, bool notify)
    {
      int num = notify ? 1 : 0;
      this.add(new TimeSeriesDataItem(period, value), num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 54, (byte) 99, (byte) 144, (byte) 130, (byte) 104, (byte) 109, (byte) 100, (byte) 146, (byte) 108, (byte) 103, (byte) 167, (byte) 102, (byte) 130, (byte) 118, (byte) 172, (byte) 110, (byte) 109, (byte) 109, (byte) 199, (byte) 167, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeriesDataItem addOrUpdate(RegularTimePeriod period, Number value)
    {
      if (period == null)
      {
        string str = "Null 'period' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        TimeSeriesDataItem timeSeriesDataItem1 = (TimeSeriesDataItem) null;
        int num = Collections.binarySearch(this.data, (object) new TimeSeriesDataItem(period, value));
        if (num >= 0)
        {
          TimeSeriesDataItem timeSeriesDataItem2 = (TimeSeriesDataItem) this.data.get(num);
          timeSeriesDataItem1 = (TimeSeriesDataItem) timeSeriesDataItem2.clone();
          timeSeriesDataItem2.setValue(value);
          this.removeAgedItems(false);
          this.fireSeriesChanged();
        }
        else
        {
          this.data.add(-num - 1, (object) new TimeSeriesDataItem(period, value));
          this.timePeriodClass = Object.instancehelper_getClass((object) period);
          if (this.getItemCount() > this.maximumItemCount)
          {
            this.data.remove(0);
            if (this.data.isEmpty())
              this.timePeriodClass = (Class) null;
          }
          this.removeAgedItems(false);
          this.fireSeriesChanged();
        }
        return timeSeriesDataItem1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TimeSeriesDataItem item)
    {
      this.add(item, true);
    }

    [LineNumberTable((ushort) 761)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal new static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, TimeSeries.__\u003CGetCallerID\u003E());
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

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 251, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 140, (byte) 107, (byte) 113, (byte) 105, (byte) 146, (byte) 140, (byte) 219, (byte) 2, (byte) 98, (byte) 231, (byte) 56, (byte) 233, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries createCopy(int start, int end)
    {
      if (start < 0)
      {
        string str = "Requires start >= 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (end < start)
      {
        string str = "Requires start <= end.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        TimeSeries timeSeries = (TimeSeries) base.clone();
        timeSeries.data = (List) new ArrayList();
        if (this.data.size() > 0)
        {
          for (int index = start; index <= end; ++index)
          {
            TimeSeriesDataItem timeSeriesDataItem = (TimeSeriesDataItem) ((TimeSeriesDataItem) this.data.get(index)).clone();
            SeriesException seriesException;
            try
            {
              timeSeries.add(timeSeriesDataItem);
              continue;
            }
            catch (SeriesException ex)
            {
              int num = 1;
              seriesException = (SeriesException) ByteCodeHelper.MapException<SeriesException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
            }
            Throwable.instancehelper_printStackTrace((Exception) seriesException);
          }
        }
        return timeSeries;
      }
    }

    public virtual string getDomainDescription()
    {
      return this.domain;
    }

    public virtual string getRangeDescription()
    {
      return this.range;
    }

    public virtual long getMaximumItemAge()
    {
      return this.maximumItemAge;
    }

    public virtual int getMaximumItemCount()
    {
      return this.maximumItemCount;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 103, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainDescription(string description)
    {
      string str = this.domain;
      this.domain = description;
      this.firePropertyChange("Domain", (object) str, (object) description);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 103, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeDescription(string description)
    {
      string str = this.range;
      this.range = description;
      this.firePropertyChange("Range", (object) str, (object) description);
    }

    [LineNumberTable((ushort) 238)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getItems()
    {
      return Collections.unmodifiableList(this.data);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 100, (byte) 144, (byte) 103, (byte) 108, (byte) 100, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumItemCount(int maximum)
    {
      if (maximum < 0)
      {
        string str = "Negative 'maximum' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.maximumItemCount = maximum;
        int num = this.data.size();
        if (num <= maximum)
          return;
        this.delete(0, num - maximum - 1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 101, (byte) 144, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumItemAge(long periods)
    {
      if (periods < 0L)
      {
        string str = "Negative 'periods' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.maximumItemAge = periods;
        this.removeAgedItems(true);
      }
    }

    public virtual Class getTimePeriodClass()
    {
      return this.timePeriodClass;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 104, (byte) 100, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeriesDataItem getDataItem(RegularTimePeriod period)
    {
      int index = this.getIndex(period);
      if (index >= 0)
        return (TimeSeriesDataItem) this.data.get(index);
      else
        return (TimeSeriesDataItem) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 1, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RegularTimePeriod getNextTimePeriod()
    {
      return this.getTimePeriod(this.getItemCount() - 1).next();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 11, (byte) 102, (byte) 107, (byte) 46, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getTimePeriods()
    {
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < this.getItemCount(); ++index)
        ((Collection) arrayList).add((object) this.getTimePeriod(index));
      return (Collection) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 102, (byte) 107, (byte) 104, (byte) 104, (byte) 100, (byte) 232, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getTimePeriodsUniqueToOtherSeries(TimeSeries series)
    {
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < series.getItemCount(); ++index)
      {
        RegularTimePeriod timePeriod = series.getTimePeriod(index);
        if (this.getIndex(timePeriod) < 0)
          ((Collection) arrayList).add((object) timePeriod);
      }
      return (Collection) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 75, (byte) 104, (byte) 100, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(RegularTimePeriod period)
    {
      int index = this.getIndex(period);
      if (index < 0)
        return (Number) null;
      return this.getValue(index);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 230, (byte) 104, (byte) 109, (byte) 100, (byte) 114, (byte) 103, (byte) 102, (byte) 130, (byte) 208})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update(RegularTimePeriod period, Number value)
    {
      int num = Collections.binarySearch(this.data, (object) new TimeSeriesDataItem(period, value));
      if (num >= 0)
      {
        ((TimeSeriesDataItem) this.data.get(num)).setValue(value);
        this.fireSeriesChanged();
      }
      else
      {
        string message = "There is no existing value for the specified 'period'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SeriesException(message);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 251, (byte) 104, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update(int index, Number value)
    {
      this.getDataItem(index).setValue(value);
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 9, (byte) 159, (byte) 6, (byte) 107, (byte) 104, (byte) 147, (byte) 99, (byte) 231, (byte) 59, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries addAndOrUpdate(TimeSeries series)
    {
      TimeSeries timeSeries = new TimeSeries((IComparable) new StringBuffer().append("Overwritten values from: ").append((object) this.getKey()).toString());
      for (int index = 0; index < series.getItemCount(); ++index)
      {
        TimeSeriesDataItem dataItem = series.getDataItem(index);
        TimeSeriesDataItem timeSeriesDataItem = this.addOrUpdate(dataItem.getPeriod(), dataItem.getValue());
        if (timeSeriesDataItem != null)
          timeSeries.add(timeSeriesDataItem);
      }
      return timeSeries;
    }

    [LineNumberTable((ushort) 662)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeriesDataItem addOrUpdate(RegularTimePeriod period, double value)
    {
      return this.addOrUpdate(period, (Number) new Double(value));
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 210, (byte) 130, (byte) 109, (byte) 161, (byte) 138, (byte) 191, (byte) 120, (byte) 191, (byte) 24, (byte) 255, (byte) 24, (byte) 74, (byte) 226, (byte) 56, (byte) 98, (byte) 231, (byte) 71, (byte) 226, (byte) 59, (byte) 98, (byte) 199, (byte) 2, (byte) 98, (byte) 231, (byte) 69, (byte) 131, (byte) 127, (byte) 0, (byte) 109, (byte) 133, (byte) 103, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAgedItems(long latest, bool notify)
    {
      int num1 = notify ? 1 : 0;
      if (this.data.isEmpty())
        return;
      long num2 = long.MaxValue;
      NoSuchMethodException suchMethodException;
      IllegalAccessException illegalAccessException;
      InvocationTargetException invocationTargetException;
      try
      {
        try
        {
          try
          {
            Class class1 = TimeSeries.class\u0024org\u0024jfree\u0024data\u0024time\u0024RegularTimePeriod != null ? TimeSeries.class\u0024org\u0024jfree\u0024data\u0024time\u0024RegularTimePeriod : (TimeSeries.class\u0024org\u0024jfree\u0024data\u0024time\u0024RegularTimePeriod = TimeSeries.class\u0024("org.jfree.data.time.RegularTimePeriod"));
            string str = "createInstance";
            Class[] classArray = new Class[3];
            int index1 = 0;
            Class class2 = TimeSeries.class\u0024java\u0024lang\u0024Class != null ? TimeSeries.class\u0024java\u0024lang\u0024Class : (TimeSeries.class\u0024java\u0024lang\u0024Class = TimeSeries.class\u0024("java.lang.Class"));
            classArray[index1] = class2;
            int index2 = 1;
            Class class3 = TimeSeries.class\u0024java\u0024util\u0024Date != null ? TimeSeries.class\u0024java\u0024util\u0024Date : (TimeSeries.class\u0024java\u0024util\u0024Date = TimeSeries.class\u0024("java.util.Date"));
            classArray[index2] = class3;
            int index3 = 2;
            Class class4 = TimeSeries.class\u0024java\u0024util\u0024TimeZone != null ? TimeSeries.class\u0024java\u0024util\u0024TimeZone : (TimeSeries.class\u0024java\u0024util\u0024TimeZone = TimeSeries.class\u0024("java.util.TimeZone"));
            classArray[index3] = class4;
            CallerID callerId1 = TimeSeries.__\u003CGetCallerID\u003E();
            Method declaredMethod = class1.getDeclaredMethod(str, classArray, callerId1);
            Class class5 = this.timePeriodClass;
            object[] objArray = new object[3];
            int index4 = 0;
            Class class6 = this.timePeriodClass;
            objArray[index4] = (object) class6;
            int index5 = 1;
            Date date = new Date(latest);
            objArray[index5] = (object) date;
            int index6 = 2;
            TimeZone @default = TimeZone.getDefault();
            objArray[index6] = (object) @default;
            CallerID callerId2 = TimeSeries.__\u003CGetCallerID\u003E();
            num2 = ((RegularTimePeriod) declaredMethod.invoke((object) class5, objArray, callerId2)).getSerialIndex();
            goto label_11;
          }
          catch (NoSuchMethodException ex)
          {
            int num3 = 1;
            suchMethodException = (NoSuchMethodException) ByteCodeHelper.MapException<NoSuchMethodException>((Exception) ex, (ByteCodeHelper.MapFlags) num3);
          }
        }
        catch (IllegalAccessException ex)
        {
          int num3 = 1;
          illegalAccessException = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num3);
          goto label_8;
        }
      }
      catch (InvocationTargetException ex)
      {
        int num3 = 1;
        invocationTargetException = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num3);
        goto label_9;
      }
      Throwable.instancehelper_printStackTrace((Exception) suchMethodException);
      goto label_11;
label_8:
      Throwable.instancehelper_printStackTrace((Exception) illegalAccessException);
      goto label_11;
label_9:
      Throwable.instancehelper_printStackTrace((Exception) invocationTargetException);
label_11:
      int num4 = 0;
      while (this.getItemCount() > 0 && num2 - this.getTimePeriod(0).getSerialIndex() > this.maximumItemAge)
      {
        this.data.remove(0);
        num4 = 1;
      }
      if (num4 == 0 || num1 == 0)
        return;
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 170, (byte) 110, (byte) 107, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      if (this.data.size() <= 0)
        return;
      this.data.clear();
      this.timePeriodClass = (Class) null;
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 186, (byte) 104, (byte) 100, (byte) 109, (byte) 109, (byte) 135, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void delete(RegularTimePeriod period)
    {
      int index = this.getIndex(period);
      if (index < 0)
        return;
      this.data.remove(index);
      if (this.data.isEmpty())
        this.timePeriodClass = (Class) null;
      this.fireSeriesChanged();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 231, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      TimeSeries timeSeries = (TimeSeries) base.clone();
      timeSeries.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      return (object) timeSeries;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 37, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 106, (byte) 176, (byte) 98, (byte) 104, (byte) 100, (byte) 101, (byte) 110, (byte) 162, (byte) 104, (byte) 100, (byte) 101, (byte) 132, (byte) 104, (byte) 130, (byte) 99, (byte) 108, (byte) 107, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimeSeries createCopy(RegularTimePeriod start, RegularTimePeriod end)
    {
      if (start == null)
      {
        string str = "Null 'start' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (end == null)
      {
        string str = "Null 'end' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (start.compareTo((object) end) > 0)
      {
        string str = "Requires start on or before end.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = 0;
        int start1 = this.getIndex(start);
        if (start1 < 0)
        {
          start1 = -(start1 + 1);
          if (start1 == this.data.size())
            num = 1;
        }
        int end1 = this.getIndex(end);
        if (end1 < 0)
          end1 = -(end1 + 1) - 1;
        if (end1 < 0 || end1 < start1)
          num = 1;
        if (num != 0)
        {
          TimeSeries timeSeries = (TimeSeries) base.clone();
          timeSeries.data = (List) new ArrayList();
          return timeSeries;
        }
        else
          return this.createCopy(start1, end1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 82, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 103, (byte) 105, (byte) 130, (byte) 102, (byte) 117, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object @object)
    {
      if (@object == this)
        return true;
      if (!(@object is TimeSeries))
        return false;
      TimeSeries timeSeries = (TimeSeries) @object;
      if (!ObjectUtilities.equal((object) this.getDomainDescription(), (object) timeSeries.getDomainDescription()) || !ObjectUtilities.equal((object) this.getRangeDescription(), (object) timeSeries.getRangeDescription()) || (!ObjectUtilities.equal((object) this.timePeriodClass, (object) timeSeries.timePeriodClass) || this.getMaximumItemAge() != timeSeries.getMaximumItemAge()) || this.getMaximumItemCount() != timeSeries.getMaximumItemCount())
        return false;
      int itemCount = this.getItemCount();
      if (itemCount != timeSeries.getItemCount())
        return false;
      for (int index = 0; index < itemCount; ++index)
      {
        if (!this.getDataItem(index).equals((object) timeSeries.getDataItem(index)))
          return false;
      }
      return (base.equals(@object) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 125, (byte) 103, (byte) 156, (byte) 124, (byte) 220, (byte) 103, (byte) 100, (byte) 104, (byte) 140, (byte) 100, (byte) 106, (byte) 140, (byte) 100, (byte) 106, (byte) 140, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num = 29 * (29 * (29 * base.hashCode() + (this.domain == null ? 0 : String.instancehelper_hashCode(this.domain))) + (this.range == null ? 0 : String.instancehelper_hashCode(this.range))) + (this.timePeriodClass == null ? 0 : Object.instancehelper_hashCode((object) this.timePeriodClass));
      int itemCount = this.getItemCount();
      if (itemCount > 0)
      {
        TimeSeriesDataItem dataItem = this.getDataItem(0);
        num = 29 * num + dataItem.hashCode();
      }
      if (itemCount > 1)
      {
        TimeSeriesDataItem dataItem = this.getDataItem(itemCount - 1);
        num = 29 * num + dataItem.hashCode();
      }
      if (itemCount > 2)
      {
        TimeSeriesDataItem dataItem = this.getDataItem(itemCount / 2);
        num = 29 * num + dataItem.hashCode();
      }
      return 29 * (29 * num + this.maximumItemCount) + (int) this.maximumItemAge;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TimeSeries.__\u003CcallerID\u003E == null)
        TimeSeries.__\u003CcallerID\u003E = (CallerID) new TimeSeries.__\u003CCallerID\u003E();
      return TimeSeries.__\u003CcallerID\u003E;
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
