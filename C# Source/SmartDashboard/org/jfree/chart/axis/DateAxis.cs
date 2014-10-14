// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.DateAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.font;
using java.awt.geom;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart.@event;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.time;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class DateAxis : ValueAxis, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -1013460999649007604L;
    internal static DateRange __\u003C\u003EDEFAULT_DATE_RANGE;
    public const double DEFAULT_AUTO_RANGE_MINIMUM_SIZE_IN_MILLISECONDS = 2.0;
    internal static DateTickUnit __\u003C\u003EDEFAULT_DATE_TICK_UNIT;
    internal static Date __\u003C\u003EDEFAULT_ANCHOR_DATE;
    private DateTickUnit tickUnit;
    private DateFormat dateFormatOverride;
    private DateTickMarkPosition tickMarkPosition;
    [Modifiers]
    private static Timeline DEFAULT_TIMELINE;
    private TimeZone timeZone;
    private Locale locale;
    private Timeline timeline;

    [Modifiers]
    public static DateRange DEFAULT_DATE_RANGE
    {
      [HideFromJava] get
      {
        return DateAxis.__\u003C\u003EDEFAULT_DATE_RANGE;
      }
    }

    [Modifiers]
    public static DateTickUnit DEFAULT_DATE_TICK_UNIT
    {
      [HideFromJava] get
      {
        return DateAxis.__\u003C\u003EDEFAULT_DATE_TICK_UNIT;
      }
    }

    [Modifiers]
    public static Date DEFAULT_ANCHOR_DATE
    {
      [HideFromJava] get
      {
        return DateAxis.__\u003C\u003EDEFAULT_ANCHOR_DATE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 101, (byte) 234, (byte) 71, (byte) 213, (byte) 234, (byte) 160, (byte) 126})]
    static DateAxis()
    {
      ValueAxis.__\u003Cclinit\u003E();
      DateAxis.__\u003C\u003EDEFAULT_DATE_RANGE = new DateRange();
      DateAxis.__\u003C\u003EDEFAULT_DATE_TICK_UNIT = new DateTickUnit(DateTickUnitType.__\u003C\u003EDAY, 1, (DateFormat) new SimpleDateFormat());
      DateAxis.__\u003C\u003EDEFAULT_ANCHOR_DATE = new Date();
      DateAxis.DEFAULT_TIMELINE = (Timeline) new DateAxis.DefaultTimeline((DateAxis.\u0031) null);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 232, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateAxis(string label)
      : this(label, TimeZone.getDefault())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 249, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateAxis(string label, TimeZone zone)
      : this(label, zone, Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 240, (byte) 159, (byte) 80, (byte) 235, (byte) 160, (byte) 177, (byte) 109, (byte) 143, (byte) 109, (byte) 103, (byte) 103, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateAxis(string label, TimeZone zone, Locale locale)
      : base(label, DateAxis.createStandardDateTickUnits(zone, locale))
    {
      DateAxis dateAxis = this;
      this.tickMarkPosition = DateTickMarkPosition.__\u003C\u003ESTART;
      this.setTickUnit(DateAxis.__\u003C\u003EDEFAULT_DATE_TICK_UNIT, false, false);
      this.setAutoRangeMinimumSize(2.0);
      this.setRange((Range) DateAxis.__\u003C\u003EDEFAULT_DATE_RANGE, false, false);
      this.dateFormatOverride = (DateFormat) null;
      this.timeZone = zone;
      this.locale = locale;
      this.timeline = DateAxis.DEFAULT_TIMELINE;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateAxis()
      : this((string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DateAxis obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DateAxis obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 74, (byte) 105, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTimeline(Timeline timeline)
    {
      if (this.timeline == timeline)
        return;
      this.timeline = timeline;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 10, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 166, (byte) 108, (byte) 108, (byte) 108, (byte) 109, (byte) 109, (byte) 109, (byte) 141, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 168, (byte) 114, (byte) 152, (byte) 153, (byte) 153, (byte) 154, (byte) 154, (byte) 157, (byte) 221, (byte) 153, (byte) 152, (byte) 153, (byte) 217, (byte) 152, (byte) 153, (byte) 152, (byte) 153, (byte) 153, (byte) 153, (byte) 217, (byte) 152, (byte) 153, (byte) 153, (byte) 152, (byte) 218, (byte) 153, (byte) 153, (byte) 153, (byte) 218, (byte) 153, (byte) 153, (byte) 153, (byte) 153, (byte) 217, (byte) 153, (byte) 153, (byte) 153, (byte) 154, (byte) 154, (byte) 155, (byte) 187})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createStandardDateTickUnits(TimeZone zone, Locale locale)
    {
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
        TickUnits tickUnits = new TickUnits();
        SimpleDateFormat simpleDateFormat1 = new SimpleDateFormat("HH:mm:ss.SSS", locale);
        SimpleDateFormat simpleDateFormat2 = new SimpleDateFormat("HH:mm:ss", locale);
        SimpleDateFormat simpleDateFormat3 = new SimpleDateFormat("HH:mm", locale);
        SimpleDateFormat simpleDateFormat4 = new SimpleDateFormat("d-MMM, HH:mm", locale);
        SimpleDateFormat simpleDateFormat5 = new SimpleDateFormat("d-MMM", locale);
        SimpleDateFormat simpleDateFormat6 = new SimpleDateFormat("MMM-yyyy", locale);
        SimpleDateFormat simpleDateFormat7 = new SimpleDateFormat("yyyy", locale);
        ((DateFormat) simpleDateFormat1).setTimeZone(zone);
        ((DateFormat) simpleDateFormat2).setTimeZone(zone);
        ((DateFormat) simpleDateFormat3).setTimeZone(zone);
        ((DateFormat) simpleDateFormat4).setTimeZone(zone);
        ((DateFormat) simpleDateFormat5).setTimeZone(zone);
        ((DateFormat) simpleDateFormat6).setTimeZone(zone);
        ((DateFormat) simpleDateFormat7).setTimeZone(zone);
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 1, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 5, DateTickUnitType.__\u003C\u003EMILLISECOND, 1, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 10, DateTickUnitType.__\u003C\u003EMILLISECOND, 1, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 25, DateTickUnitType.__\u003C\u003EMILLISECOND, 5, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 50, DateTickUnitType.__\u003C\u003EMILLISECOND, 10, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 100, DateTickUnitType.__\u003C\u003EMILLISECOND, 10, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 250, DateTickUnitType.__\u003C\u003EMILLISECOND, 10, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMILLISECOND, 500, DateTickUnitType.__\u003C\u003EMILLISECOND, 50, (DateFormat) simpleDateFormat1));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003ESECOND, 1, DateTickUnitType.__\u003C\u003EMILLISECOND, 50, (DateFormat) simpleDateFormat2));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003ESECOND, 5, DateTickUnitType.__\u003C\u003ESECOND, 1, (DateFormat) simpleDateFormat2));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003ESECOND, 10, DateTickUnitType.__\u003C\u003ESECOND, 1, (DateFormat) simpleDateFormat2));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003ESECOND, 30, DateTickUnitType.__\u003C\u003ESECOND, 5, (DateFormat) simpleDateFormat2));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMINUTE, 1, DateTickUnitType.__\u003C\u003ESECOND, 5, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMINUTE, 2, DateTickUnitType.__\u003C\u003ESECOND, 10, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMINUTE, 5, DateTickUnitType.__\u003C\u003EMINUTE, 1, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMINUTE, 10, DateTickUnitType.__\u003C\u003EMINUTE, 1, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMINUTE, 15, DateTickUnitType.__\u003C\u003EMINUTE, 5, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMINUTE, 20, DateTickUnitType.__\u003C\u003EMINUTE, 5, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMINUTE, 30, DateTickUnitType.__\u003C\u003EMINUTE, 5, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EHOUR, 1, DateTickUnitType.__\u003C\u003EMINUTE, 5, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EHOUR, 2, DateTickUnitType.__\u003C\u003EMINUTE, 10, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EHOUR, 4, DateTickUnitType.__\u003C\u003EMINUTE, 30, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EHOUR, 6, DateTickUnitType.__\u003C\u003EHOUR, 1, (DateFormat) simpleDateFormat3));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EHOUR, 12, DateTickUnitType.__\u003C\u003EHOUR, 1, (DateFormat) simpleDateFormat4));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EDAY, 1, DateTickUnitType.__\u003C\u003EHOUR, 1, (DateFormat) simpleDateFormat5));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EDAY, 2, DateTickUnitType.__\u003C\u003EHOUR, 1, (DateFormat) simpleDateFormat5));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EDAY, 7, DateTickUnitType.__\u003C\u003EDAY, 1, (DateFormat) simpleDateFormat5));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EDAY, 15, DateTickUnitType.__\u003C\u003EDAY, 1, (DateFormat) simpleDateFormat5));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMONTH, 1, DateTickUnitType.__\u003C\u003EDAY, 1, (DateFormat) simpleDateFormat6));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMONTH, 2, DateTickUnitType.__\u003C\u003EDAY, 1, (DateFormat) simpleDateFormat6));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMONTH, 3, DateTickUnitType.__\u003C\u003EMONTH, 1, (DateFormat) simpleDateFormat6));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMONTH, 4, DateTickUnitType.__\u003C\u003EMONTH, 1, (DateFormat) simpleDateFormat6));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EMONTH, 6, DateTickUnitType.__\u003C\u003EMONTH, 1, (DateFormat) simpleDateFormat6));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EYEAR, 1, DateTickUnitType.__\u003C\u003EMONTH, 1, (DateFormat) simpleDateFormat7));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EYEAR, 2, DateTickUnitType.__\u003C\u003EMONTH, 3, (DateFormat) simpleDateFormat7));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EYEAR, 5, DateTickUnitType.__\u003C\u003EYEAR, 1, (DateFormat) simpleDateFormat7));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EYEAR, 10, DateTickUnitType.__\u003C\u003EYEAR, 1, (DateFormat) simpleDateFormat7));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EYEAR, 25, DateTickUnitType.__\u003C\u003EYEAR, 5, (DateFormat) simpleDateFormat7));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EYEAR, 50, DateTickUnitType.__\u003C\u003EYEAR, 10, (DateFormat) simpleDateFormat7));
        tickUnits.add((TickUnit) new DateTickUnit(DateTickUnitType.__\u003C\u003EYEAR, 100, DateTickUnitType.__\u003C\u003EYEAR, 20, (DateFormat) simpleDateFormat7));
        return (TickUnitSource) tickUnits;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 19, (byte) 100, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickUnit(DateTickUnit unit, bool notify, bool turnOffAutoSelection)
    {
      int num1 = turnOffAutoSelection ? 1 : 0;
      int num2 = notify ? 1 : 0;
      this.tickUnit = unit;
      if (num1 != 0)
        this.setAutoTickUnitSelection(false, false);
      if (num2 == 0)
        return;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 5, (byte) 68, (byte) 99, (byte) 208, (byte) 104, (byte) 136, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setRange(Range range, bool turnOffAutoRange, bool notify)
    {
      int num1 = turnOffAutoRange ? 1 : 0;
      int num2 = notify ? 1 : 0;
      if (range == null)
      {
        string str = "Null 'range' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!(range is DateRange))
          range = (Range) new DateRange(range);
        base.setRange(range, num1 != 0, num2 != 0);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 162, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setRange(Range range)
    {
      this.setRange(range, true, true);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 20, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 130, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getMaximumDate()
    {
      Range range = this.getRange();
      Date date;
      if (range is DateRange)
      {
        date = ((DateRange) range).getUpperDate();
      }
      else
      {
        Date.__\u003Cclinit\u003E();
        date = new Date(ByteCodeHelper.d2l(range.getUpperBound()));
      }
      return date;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 226, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 130, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getMinimumDate()
    {
      Range range = this.getRange();
      Date date;
      if (range is DateRange)
      {
        date = ((DateRange) range).getLowerDate();
      }
      else
      {
        Date.__\u003Cclinit\u003E();
        date = new Date(ByteCodeHelper.d2l(range.getLowerBound()));
      }
      return date;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 137, (byte) 135, (byte) 99, (byte) 161, (byte) 107, (byte) 135, (byte) 104, (byte) 99, (byte) 141, (byte) 255, (byte) 14, (byte) 70, (byte) 198, (byte) 183, (byte) 109, (byte) 106, (byte) 171, (byte) 120, (byte) 103, (byte) 109, (byte) 103, (byte) 112, (byte) 101, (byte) 135, (byte) 113, (byte) 179, (byte) 109, (byte) 111, (byte) 116, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void autoAdjustRange()
    {
      Plot plot = this.getPlot();
      if (plot == null || !(plot is ValueAxisPlot))
        return;
      Range range = ((ValueAxisPlot) plot).getDataRange((ValueAxis) this) ?? (!(this.timeline is SegmentedTimeline) ? (Range) new DateRange() : (Range) new DateRange((double) ((SegmentedTimeline) this.timeline).getStartTime(), (double) (((SegmentedTimeline) this.timeline).getStartTime() + 1L)));
      long l1 = this.timeline.toTimelineValue(ByteCodeHelper.d2l(range.getUpperBound()));
      long num1 = ByteCodeHelper.d2l(this.getFixedAutoRange());
      long l2;
      if ((double) num1 > 0.0)
      {
        l2 = l1 - num1;
      }
      else
      {
        long num2 = this.timeline.toTimelineValue(ByteCodeHelper.d2l(range.getLowerBound()));
        double num3 = (double) (l1 - num2);
        long num4 = ByteCodeHelper.d2l(this.getAutoRangeMinimumSize());
        if (num3 < (double) num4)
        {
          long num5 = ByteCodeHelper.d2l((double) num4 - num3) / 2L;
          l1 += num5;
          num2 -= num5;
        }
        l1 += ByteCodeHelper.d2l(num3 * this.getUpperMargin());
        l2 = num2 - ByteCodeHelper.d2l(num3 * this.getLowerMargin());
      }
      long num6 = this.timeline.toMillisecond(l1);
      this.setRange((Range) new DateRange(new Date(this.timeline.toMillisecond(l2)), new Date(num6)), false, false);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 120, (byte) 149, (byte) 108, (byte) 115, (byte) 115, (byte) 102, (byte) 104, (byte) 105, (byte) 105, (byte) 104, (byte) 213, (byte) 179, (byte) 98, (byte) 104, (byte) 105, (byte) 105, (byte) 104, (byte) 213, (byte) 211})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double valueToJava2D(double value, Rectangle2D area, RectangleEdge edge)
    {
      value = (double) this.timeline.toTimelineValue(ByteCodeHelper.d2l(value));
      DateRange dateRange = (DateRange) this.getRange();
      double num1 = (double) this.timeline.toTimelineValue(dateRange.getLowerMillis());
      double num2 = (double) this.timeline.toTimelineValue(dateRange.getUpperMillis());
      double num3 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        double x = ((RectangularShape) area).getX();
        double maxX = ((RectangularShape) area).getMaxX();
        num3 = !this.isInverted() ? x + (value - num1) / (num2 - num1) * (maxX - x) : maxX + (value - num1) / (num2 - num1) * (x - maxX);
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        double minY = ((RectangularShape) area).getMinY();
        double maxY = ((RectangularShape) area).getMaxY();
        num3 = !this.isInverted() ? maxY - (value - num1) / (num2 - num1) * (maxY - minY) : minY + (value - num1) / (num2 - num1) * (maxY - minY);
      }
      return num3;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 209, (byte) 105, (byte) 114, (byte) 103, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Date nextStandardDate(Date date, DateTickUnit unit)
    {
      Date date1 = this.previousStandardDate(date, unit);
      Calendar instance = Calendar.getInstance(this.timeZone, this.locale);
      instance.setTime(date1);
      instance.add(unit.getCalendarField(), unit.getMultiple());
      return instance.getTime();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 254, (byte) 114, (byte) 103, (byte) 103, (byte) 109, (byte) 142, (byte) 191, (byte) 13, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 106, (byte) 114, (byte) 105, (byte) 104, (byte) 111, (byte) 107, (byte) 136, (byte) 163, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 109, (byte) 133, (byte) 109, (byte) 169, (byte) 135, (byte) 106, (byte) 113, (byte) 104, (byte) 111, (byte) 107, (byte) 136, (byte) 163, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 109, (byte) 133, (byte) 109, (byte) 166, (byte) 132, (byte) 104, (byte) 113, (byte) 104, (byte) 111, (byte) 107, (byte) 136, (byte) 163, (byte) 105, (byte) 105, (byte) 105, (byte) 109, (byte) 99, (byte) 133, (byte) 109, (byte) 100, (byte) 165, (byte) 100, (byte) 132, (byte) 104, (byte) 113, (byte) 104, (byte) 111, (byte) 107, (byte) 136, (byte) 163, (byte) 105, (byte) 105, (byte) 109, (byte) 99, (byte) 98, (byte) 132, (byte) 109, (byte) 100, (byte) 98, (byte) 164, (byte) 100, (byte) 99, (byte) 131, (byte) 104, (byte) 175, (byte) 104, (byte) 111, (byte) 106, (byte) 136, (byte) 163, (byte) 105, (byte) 104, (byte) 109, (byte) 158, (byte) 144, (byte) 105, (byte) 106, (byte) 174, (byte) 114, (byte) 176, (byte) 163, (byte) 109, (byte) 99, (byte) 133, (byte) 109, (byte) 99, (byte) 165, (byte) 100, (byte) 132, (byte) 104, (byte) 110, (byte) 104, (byte) 111, (byte) 106, (byte) 136, (byte) 131})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Date previousStandardDate(Date date, DateTickUnit unit)
    {
      Calendar instance = Calendar.getInstance(this.timeZone, this.locale);
      instance.setTime(date);
      int count = unit.getCount();
      int num1 = instance.get(unit.getCalendarField());
      int num2 = count;
      int num3 = num1;
      int num4 = count;
      int num5 = -1;
      int num6 = num4 != num5 ? num3 / num4 : -num3;
      int num7 = num2 * num6;
      switch (unit.getUnit())
      {
        case 0:
          int num8;
          int num9;
          if (this.tickMarkPosition == DateTickMarkPosition.__\u003C\u003ESTART)
          {
            num8 = 0;
            num9 = 1;
          }
          else if (this.tickMarkPosition == DateTickMarkPosition.__\u003C\u003EMIDDLE)
          {
            num8 = 6;
            num9 = 1;
          }
          else
          {
            num8 = 11;
            num9 = 31;
          }
          instance.clear(14);
          instance.set(num7, num8, num9, 0, 0, 0);
          Date time1 = instance.getTime();
          if (time1.getTime() >= date.getTime())
          {
            instance.set(1, num7 - 1);
            time1 = instance.getTime();
          }
          return time1;
        case 1:
          int num10 = instance.get(1);
          instance.clear(14);
          instance.set(num10, num7, 1, 0, 0, 0);
          Month.__\u003Cclinit\u003E();
          Month month1 = new Month(instance.getTime(), this.timeZone, this.locale);
          Date date1 = this.calculateDateForPosition((RegularTimePeriod) month1, this.tickMarkPosition);
          if (date1.getTime() >= date.getTime())
          {
            Month month2 = (Month) month1.previous();
            month2.peg(Calendar.getInstance(this.timeZone));
            date1 = this.calculateDateForPosition((RegularTimePeriod) month2, this.tickMarkPosition);
          }
          return date1;
        case 2:
          int num11 = instance.get(1);
          int num12 = instance.get(2);
          int num13;
          if (this.tickMarkPosition == DateTickMarkPosition.__\u003C\u003ESTART)
            num13 = 0;
          else if (this.tickMarkPosition == DateTickMarkPosition.__\u003C\u003EMIDDLE)
            num13 = 12;
          else
            num13 = 23;
          instance.clear(14);
          instance.set(num11, num12, num7, num13, 0, 0);
          Date time2 = instance.getTime();
          if (time2.getTime() >= date.getTime())
          {
            instance.set(5, num7 - 1);
            time2 = instance.getTime();
          }
          return time2;
        case 3:
          int num14 = instance.get(1);
          int num15 = instance.get(2);
          int num16 = instance.get(5);
          int num17;
          int num18;
          if (this.tickMarkPosition == DateTickMarkPosition.__\u003C\u003ESTART)
          {
            num17 = 0;
            num18 = 0;
          }
          else if (this.tickMarkPosition == DateTickMarkPosition.__\u003C\u003EMIDDLE)
          {
            num17 = 30;
            num18 = 0;
          }
          else
          {
            num17 = 59;
            num18 = 59;
          }
          instance.clear(14);
          instance.set(num14, num15, num16, num7, num17, num18);
          Date time3 = instance.getTime();
          if (time3.getTime() >= date.getTime())
          {
            instance.set(11, num7 - 1);
            time3 = instance.getTime();
          }
          return time3;
        case 4:
          int num19 = instance.get(1);
          int num20 = instance.get(2);
          int num21 = instance.get(5);
          int num22 = instance.get(11);
          int num23 = this.tickMarkPosition != DateTickMarkPosition.__\u003C\u003ESTART ? (this.tickMarkPosition != DateTickMarkPosition.__\u003C\u003EMIDDLE ? 59 : 30) : 0;
          instance.clear(14);
          instance.set(num19, num20, num21, num22, num7, num23);
          Date time4 = instance.getTime();
          if (time4.getTime() >= date.getTime())
          {
            instance.set(12, num7 - 1);
            time4 = instance.getTime();
          }
          return time4;
        case 5:
          int num24 = instance.get(1);
          int num25 = instance.get(2);
          int num26 = instance.get(5);
          int num27 = instance.get(11);
          int num28 = instance.get(12);
          int num29 = this.tickMarkPosition != DateTickMarkPosition.__\u003C\u003ESTART ? (this.tickMarkPosition != DateTickMarkPosition.__\u003C\u003EMIDDLE ? 999 : 500) : 0;
          instance.set(14, num29);
          instance.set(num24, num25, num26, num27, num28, num7);
          Date time5 = instance.getTime();
          if (time5.getTime() >= date.getTime())
          {
            instance.set(13, num7 - 1);
            time5 = instance.getTime();
          }
          return time5;
        case 6:
          int num30 = instance.get(1);
          int num31 = instance.get(2);
          int num32 = instance.get(5);
          int num33 = instance.get(11);
          int num34 = instance.get(12);
          int num35 = instance.get(13);
          instance.set(num30, num31, num32, num33, num34, num35);
          instance.set(14, num7);
          Date time6 = instance.getTime();
          if (time6.getTime() >= date.getTime())
          {
            instance.set(14, num7 - 1);
            time6 = instance.getTime();
          }
          return time6;
        default:
          return (Date) null;
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 182, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 147, (byte) 104, (byte) 147, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Date calculateDateForPosition([In] RegularTimePeriod obj0, [In] DateTickMarkPosition obj1)
    {
      if (obj1 == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Date date = (Date) null;
        if (obj1 == DateTickMarkPosition.__\u003C\u003ESTART)
        {
          Date.__\u003Cclinit\u003E();
          date = new Date(obj0.getFirstMillisecond());
        }
        else if (obj1 == DateTickMarkPosition.__\u003C\u003EMIDDLE)
        {
          Date.__\u003Cclinit\u003E();
          date = new Date(obj0.getMiddleMillisecond());
        }
        else if (obj1 == DateTickMarkPosition.__\u003C\u003EEND)
        {
          Date.__\u003Cclinit\u003E();
          date = new Date(obj0.getLastMillisecond());
        }
        return date;
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 222, (byte) 99, (byte) 109, (byte) 145, (byte) 114, (byte) 207, (byte) 103, (byte) 110, (byte) 117, (byte) 172, (byte) 111, (byte) 111, (byte) 117, (byte) 108, (byte) 107, (byte) 101, (byte) 143, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectHorizontalAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      long num1 = 0L;
      if (this.timeline is SegmentedTimeline)
        num1 = ((SegmentedTimeline) this.timeline).getStartTime();
      double num2 = this.valueToJava2D((double) num1 + 0.0, dataArea, edge);
      double num3 = this.estimateMaximumTickLabelWidth(g2, this.getTickUnit());
      TickUnitSource standardTickUnits = this.getStandardTickUnits();
      TickUnit ceilingTickUnit = standardTickUnits.getCeilingTickUnit((TickUnit) this.getTickUnit());
      double num4 = Math.abs(this.valueToJava2D((double) num1 + ceilingTickUnit.getSize(), dataArea, edge) - num2);
      double d = num3 / num4 * ceilingTickUnit.getSize();
      DateTickUnit unit = (DateTickUnit) standardTickUnits.getCeilingTickUnit(d);
      double num5 = Math.abs(this.valueToJava2D((double) num1 + unit.getSize(), dataArea, edge) - num2);
      if (this.estimateMaximumTickLabelWidth(g2, unit) > num5)
        unit = (DateTickUnit) standardTickUnits.getLargerTickUnit((TickUnit) unit);
      this.setTickUnit(unit, false, false);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 6, (byte) 103, (byte) 175, (byte) 119, (byte) 141, (byte) 107, (byte) 113, (byte) 172, (byte) 143, (byte) 143, (byte) 108, (byte) 114, (byte) 204, (byte) 102, (byte) 166, (byte) 143, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectVerticalAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      TickUnitSource standardTickUnits = this.getStandardTickUnits();
      double num = this.valueToJava2D(0.0, dataArea, edge);
      double d1 = this.getRange().getLength() / 10.0;
      DateTickUnit dateTickUnit1 = (DateTickUnit) standardTickUnits.getCeilingTickUnit(d1);
      double d2 = this.estimateMaximumTickLabelHeight(g2, dateTickUnit1) / Math.abs(this.valueToJava2D(dateTickUnit1.getSize(), dataArea, edge) - num) * dateTickUnit1.getSize();
      DateTickUnit dateTickUnit2 = (DateTickUnit) standardTickUnits.getCeilingTickUnit(d2);
      this.setTickUnit(this.estimateMaximumTickLabelHeight(g2, dateTickUnit2) >= Math.abs(this.valueToJava2D(dateTickUnit2.getSize(), dataArea, edge) - num) ? (DateTickUnit) standardTickUnits.getLargerTickUnit((TickUnit) dateTickUnit2) : dateTickUnit2, false, false);
    }

    public virtual DateTickUnit getTickUnit()
    {
      return this.tickUnit;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 54, (byte) 103, (byte) 143, (byte) 103, (byte) 103, (byte) 110, (byte) 168, (byte) 209, (byte) 109, (byte) 105, (byte) 105, (byte) 98, (byte) 98, (byte) 104, (byte) 100, (byte) 107, (byte) 173, (byte) 106, (byte) 138, (byte) 105, (byte) 108, (byte) 108, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double estimateMaximumTickLabelWidth([In] Graphics2D obj0, [In] DateTickUnit obj1)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      double num1 = tickLabelInsets.getLeft() + tickLabelInsets.getRight();
      Font tickLabelFont = this.getTickLabelFont();
      FontRenderContext fontRenderContext = obj0.getFontRenderContext();
      LineMetrics lineMetrics = tickLabelFont.getLineMetrics("ABCxyz", fontRenderContext);
      double num2;
      if (this.isVerticalTickLabels())
      {
        num2 = num1 + (double) lineMetrics.getHeight();
      }
      else
      {
        DateRange dateRange = (DateRange) this.getRange();
        Date lowerDate = dateRange.getLowerDate();
        Date upperDate = dateRange.getUpperDate();
        DateFormat dateFormatOverride = this.getDateFormatOverride();
        string str1;
        string str2;
        if (dateFormatOverride != null)
        {
          str1 = dateFormatOverride.format(lowerDate);
          str2 = dateFormatOverride.format(upperDate);
        }
        else
        {
          str1 = obj1.dateToString(lowerDate);
          str2 = obj1.dateToString(upperDate);
        }
        FontMetrics fontMetrics = ((Graphics) obj0).getFontMetrics(tickLabelFont);
        double num3 = (double) fontMetrics.stringWidth(str1);
        double num4 = (double) fontMetrics.stringWidth(str2);
        num2 = num1 + Math.max(num3, num4);
      }
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 107, (byte) 103, (byte) 143, (byte) 103, (byte) 103, (byte) 110, (byte) 168, (byte) 209, (byte) 109, (byte) 105, (byte) 105, (byte) 98, (byte) 98, (byte) 104, (byte) 100, (byte) 107, (byte) 173, (byte) 106, (byte) 138, (byte) 105, (byte) 108, (byte) 108, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double estimateMaximumTickLabelHeight([In] Graphics2D obj0, [In] DateTickUnit obj1)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      double num1 = tickLabelInsets.getTop() + tickLabelInsets.getBottom();
      Font tickLabelFont = this.getTickLabelFont();
      FontRenderContext fontRenderContext = obj0.getFontRenderContext();
      LineMetrics lineMetrics = tickLabelFont.getLineMetrics("ABCxyz", fontRenderContext);
      double num2;
      if (!this.isVerticalTickLabels())
      {
        num2 = num1 + (double) lineMetrics.getHeight();
      }
      else
      {
        DateRange dateRange = (DateRange) this.getRange();
        Date lowerDate = dateRange.getLowerDate();
        Date upperDate = dateRange.getUpperDate();
        DateFormat dateFormatOverride = this.getDateFormatOverride();
        string str1;
        string str2;
        if (dateFormatOverride != null)
        {
          str1 = dateFormatOverride.format(lowerDate);
          str2 = dateFormatOverride.format(upperDate);
        }
        else
        {
          str1 = obj1.dateToString(lowerDate);
          str2 = obj1.dateToString(upperDate);
        }
        FontMetrics fontMetrics = ((Graphics) obj0).getFontMetrics(tickLabelFont);
        double num3 = (double) fontMetrics.stringWidth(str1);
        double num4 = (double) fontMetrics.stringWidth(str2);
        num2 = num1 + Math.max(num3, num4);
      }
      return num2;
    }

    public virtual DateFormat getDateFormatOverride()
    {
      return this.dateFormatOverride;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 216, (byte) 134, (byte) 103, (byte) 135, (byte) 104, (byte) 169, (byte) 103, (byte) 104, (byte) 136, (byte) 141, (byte) 175, (byte) 104, (byte) 151, (byte) 104, (byte) 101, (byte) 136, (byte) 108, (byte) 152, (byte) 159, (byte) 1, (byte) 255, (byte) 13, (byte) 59, (byte) 235, (byte) 75, (byte) 177, (byte) 104, (byte) 100, (byte) 172, (byte) 142, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 173, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 199, (byte) 144, (byte) 137, (byte) 104, (byte) 110, (byte) 104, (byte) 140, (byte) 187, (byte) 154, (byte) 255, (byte) 13, (byte) 58, (byte) 235, (byte) 77, (byte) 130, (byte) 110, (byte) 165, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshTicksHorizontal(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      DateTickUnit tickUnit = this.getTickUnit();
      Date date1 = this.calculateLowestVisibleTickValue(tickUnit);
      Date maximumDate = this.getMaximumDate();
label_3:
      while (date1.before(maximumDate))
      {
        Date date2 = this.correctTickDateForPosition(date1, tickUnit, this.tickMarkPosition);
        long time1 = date2.getTime();
        long num1 = tickUnit.addToDate(date2, this.timeZone).getTime() - time1;
        int minorTickCount = this.getMinorTickCount();
        if (minorTickCount <= 0)
          minorTickCount = tickUnit.getMinorTickCount();
        for (int index = 1; index < minorTickCount; ++index)
        {
          long num2 = time1;
          long num3 = num1 * (long) index;
          long num4 = (long) minorTickCount;
          long num5 = -1L;
          long num6 = num4 != num5 ? num3 / num4 : -num3;
          long millis = num2 - num6;
          if (millis > 0L && this.getRange().contains((double) millis) && !this.isHiddenValue(millis))
            ((List) arrayList).add((object) new DateTick(TickType.__\u003C\u003EMINOR, new Date(millis), "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
        }
        if (!this.isHiddenValue(date2.getTime()))
        {
          DateFormat dateFormatOverride = this.getDateFormatOverride();
          string label = dateFormatOverride == null ? this.tickUnit.dateToString(date2) : dateFormatOverride.format(date2);
          double angle = 0.0;
          TextAnchor textAnchor;
          TextAnchor rotationAnchor;
          if (this.isVerticalTickLabels())
          {
            textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
            rotationAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
            angle = edge != RectangleEdge.__\u003C\u003ETOP ? -1.0 * Math.PI / 2.0 : Math.PI / 2.0;
          }
          else if (edge == RectangleEdge.__\u003C\u003ETOP)
          {
            textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
          }
          else
          {
            textAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
            rotationAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
          }
          DateTick dateTick = new DateTick(date2, label, textAnchor, rotationAnchor, angle);
          ((List) arrayList).add((object) dateTick);
          long time2 = date2.getTime();
          date1 = tickUnit.addToDate(date2, this.timeZone);
          long time3 = date1.getTime();
          int num2 = 1;
          while (true)
          {
            if (num2 < minorTickCount)
            {
              long num3 = time2;
              long num4 = (time3 - time2) * (long) num2;
              long num5 = (long) minorTickCount;
              long num6 = -1L;
              long num7 = num5 != num6 ? num4 / num5 : -num4;
              long millis = num3 + num7;
              if (this.getRange().contains((double) millis) && !this.isHiddenValue(millis))
                ((List) arrayList).add((object) new DateTick(TickType.__\u003C\u003EMINOR, new Date(millis), "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
              ++num2;
            }
            else
              goto label_3;
          }
        }
        else
          date1 = tickUnit.rollDate(date2, this.timeZone);
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 74, (byte) 134, (byte) 103, (byte) 135, (byte) 104, (byte) 137, (byte) 103, (byte) 104, (byte) 136, (byte) 173, (byte) 175, (byte) 104, (byte) 151, (byte) 104, (byte) 101, (byte) 136, (byte) 108, (byte) 152, (byte) 159, (byte) 1, (byte) 255, (byte) 13, (byte) 59, (byte) 235, (byte) 74, (byte) 177, (byte) 104, (byte) 100, (byte) 172, (byte) 142, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 173, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 199, (byte) 144, (byte) 105, (byte) 104, (byte) 110, (byte) 104, (byte) 140, (byte) 187, (byte) 154, (byte) 255, (byte) 13, (byte) 58, (byte) 235, (byte) 76, (byte) 130, (byte) 142, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshTicksVertical(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      DateTickUnit tickUnit = this.getTickUnit();
      Date date1 = this.calculateLowestVisibleTickValue(tickUnit);
      Date maximumDate = this.getMaximumDate();
label_3:
      while (date1.before(maximumDate))
      {
        Date date2 = this.correctTickDateForPosition(date1, tickUnit, this.tickMarkPosition);
        long time1 = date2.getTime();
        long num1 = tickUnit.addToDate(date2, this.timeZone).getTime() - time1;
        int minorTickCount = this.getMinorTickCount();
        if (minorTickCount <= 0)
          minorTickCount = tickUnit.getMinorTickCount();
        for (int index = 1; index < minorTickCount; ++index)
        {
          long num2 = time1;
          long num3 = num1 * (long) index;
          long num4 = (long) minorTickCount;
          long num5 = -1L;
          long num6 = num4 != num5 ? num3 / num4 : -num3;
          long millis = num2 - num6;
          if (millis > 0L && this.getRange().contains((double) millis) && !this.isHiddenValue(millis))
            ((List) arrayList).add((object) new DateTick(TickType.__\u003C\u003EMINOR, new Date(millis), "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
        }
        if (!this.isHiddenValue(date2.getTime()))
        {
          DateFormat dateFormatOverride = this.getDateFormatOverride();
          string label = dateFormatOverride == null ? this.tickUnit.dateToString(date2) : dateFormatOverride.format(date2);
          double angle = 0.0;
          TextAnchor textAnchor;
          TextAnchor rotationAnchor;
          if (this.isVerticalTickLabels())
          {
            textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            angle = edge != RectangleEdge.__\u003C\u003ELEFT ? Math.PI / 2.0 : -1.0 * Math.PI / 2.0;
          }
          else if (edge == RectangleEdge.__\u003C\u003ELEFT)
          {
            textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
            rotationAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
          }
          else
          {
            textAnchor = TextAnchor.__\u003C\u003ECENTER_LEFT;
            rotationAnchor = TextAnchor.__\u003C\u003ECENTER_LEFT;
          }
          DateTick dateTick = new DateTick(date2, label, textAnchor, rotationAnchor, angle);
          ((List) arrayList).add((object) dateTick);
          long time2 = date2.getTime();
          date1 = tickUnit.addToDate(date2, this.timeZone);
          long time3 = date1.getTime();
          int num2 = 1;
          while (true)
          {
            if (num2 < minorTickCount)
            {
              long num3 = time2;
              long num4 = (time3 - time2) * (long) num2;
              long num5 = (long) minorTickCount;
              long num6 = -1L;
              long num7 = num5 != num6 ? num4 / num5 : -num4;
              long millis = num3 + num7;
              if (this.getRange().contains((double) millis) && !this.isHiddenValue(millis))
                ((List) arrayList).add((object) new DateTick(TickType.__\u003C\u003EMINOR, new Date(millis), "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
              ++num2;
            }
            else
              goto label_3;
          }
        }
        else
          date1 = tickUnit.rollDate(date2, this.timeZone);
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 201, (byte) 104, (byte) 139, (byte) 104, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      if (RectangleEdge.isTopOrBottom(edge))
      {
        this.selectHorizontalAutoTickUnit(g2, dataArea, edge);
      }
      else
      {
        if (!RectangleEdge.isLeftOrRight(edge))
          return;
        this.selectVerticalAutoTickUnit(g2, dataArea, edge);
      }
    }

    [LineNumberTable((ushort) 848)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date calculateLowestVisibleTickValue(DateTickUnit unit)
    {
      return this.nextStandardDate(this.getMinimumDate(), unit);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 182, (byte) 98, (byte) 255, (byte) 10, (byte) 70, (byte) 130, (byte) 159, (byte) 0, (byte) 130, (byte) 159, (byte) 0, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Date correctTickDateForPosition([In] Date obj0, [In] DateTickUnit obj1, [In] DateTickMarkPosition obj2)
    {
      Date date = obj0;
      switch (obj1.getUnit())
      {
        case 0:
          Year.__\u003Cclinit\u003E();
          date = this.calculateDateForPosition((RegularTimePeriod) new Year(obj0, this.timeZone, this.locale), obj2);
          break;
        case 1:
          Month.__\u003Cclinit\u003E();
          date = this.calculateDateForPosition((RegularTimePeriod) new Month(obj0, this.timeZone, this.locale), obj2);
          break;
      }
      return date;
    }

    [LineNumberTable((ushort) 729)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isHiddenValue(long millis)
    {
      return !this.timeline.containsDomainValue(new Date(millis));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 160, (byte) 98, (byte) 105, (byte) 141, (byte) 105, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override List refreshTicks(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      List list = (List) null;
      if (RectangleEdge.isTopOrBottom(edge))
        list = this.refreshTicksHorizontal(g2, dataArea, edge);
      else if (RectangleEdge.isLeftOrRight(edge))
        list = this.refreshTicksVertical(g2, dataArea, edge);
      return list;
    }

    public virtual TimeZone getTimeZone()
    {
      return this.timeZone;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 45, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 146, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTimeZone(TimeZone zone)
    {
      if (zone == null)
      {
        string str = "Null 'zone' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (Object.instancehelper_equals((object) this.timeZone, (object) zone))
          return;
        this.timeZone = zone;
        this.setStandardTickUnits(DateAxis.createStandardDateTickUnits(zone, this.locale));
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Timeline getTimeline()
    {
      return this.timeline;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 108, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickUnit(DateTickUnit unit)
    {
      this.setTickUnit(unit, true, true);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 150, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDateFormatOverride(DateFormat formatter)
    {
      this.dateFormatOverride = formatter;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 197, (byte) 110, (byte) 144, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRange(Date lower, Date upper)
    {
      if (lower.getTime() >= upper.getTime())
      {
        string str = "Requires 'lower' < 'upper'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.setRange((Range) new DateRange(lower, upper));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 211, (byte) 102, (byte) 144, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setRange(double lower, double upper)
    {
      if (lower >= upper)
      {
        string str = "Requires 'lower' < 'upper'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.setRange((Range) new DateRange(lower, upper));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 251, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 100, (byte) 103, (byte) 106, (byte) 138, (byte) 111, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinimumDate(Date date)
    {
      if (date == null)
      {
        string str = "Null 'date' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Date upper = this.getMaximumDate();
        long time1 = upper.getTime();
        long time2 = date.getTime();
        if (time1 <= time2)
        {
          Date minimumDate = this.getMinimumDate();
          long num = time1 - minimumDate.getTime();
          upper = new Date(time2 + num);
        }
        this.setRange((Range) new DateRange(date, upper), true, false);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 45, (byte) 99, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 100, (byte) 103, (byte) 106, (byte) 138, (byte) 111, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumDate(Date maximumDate)
    {
      if (maximumDate == null)
      {
        string str = "Null 'maximumDate' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Date lower = this.getMinimumDate();
        long time1 = lower.getTime();
        long time2 = maximumDate.getTime();
        if (time1 >= time2)
        {
          long num = this.getMaximumDate().getTime() - time1;
          lower = new Date(time2 - num);
        }
        this.setRange((Range) new DateRange(lower, maximumDate), true, false);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual DateTickMarkPosition getTickMarkPosition()
    {
      return this.tickMarkPosition;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 77, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickMarkPosition(DateTickMarkPosition position)
    {
      if (position == null)
      {
        string str = "Null 'position' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickMarkPosition = position;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 89, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void configure()
    {
      if (!this.isAutoRange())
        return;
      this.autoAdjustRange();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 167, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double dateToJava2D(Date date, Rectangle2D area, RectangleEdge edge)
    {
      return this.valueToJava2D((double) date.getTime(), area, edge);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 186, (byte) 108, (byte) 115, (byte) 147, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 104, (byte) 201, (byte) 104, (byte) 212, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double java2DToValue(double java2DValue, Rectangle2D area, RectangleEdge edge)
    {
      DateRange dateRange = (DateRange) this.getRange();
      double num1 = (double) this.timeline.toTimelineValue(dateRange.getLowerMillis());
      double num2 = (double) this.timeline.toTimelineValue(dateRange.getUpperMillis());
      double num3 = 0.0;
      double num4 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num3 = ((RectangularShape) area).getX();
        num4 = ((RectangularShape) area).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num3 = ((RectangularShape) area).getMaxY();
        num4 = ((RectangularShape) area).getY();
      }
      return (double) this.timeline.toMillisecond(ByteCodeHelper.d2l(!this.isInverted() ? num1 + (java2DValue - num3) / (num4 - num3) * (num2 - num1) : num2 - (java2DValue - num3) / (num4 - num3) * (num2 - num1)));
    }

    [LineNumberTable((ushort) 859)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date calculateHighestVisibleTickValue(DateTickUnit unit)
    {
      return this.previousStandardDate(this.getMaximumDate(), unit);
    }

    [LineNumberTable((ushort) 1108)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createStandardDateTickUnits()
    {
      return DateAxis.createStandardDateTickUnits(TimeZone.getDefault(), Locale.getDefault());
    }

    [Obsolete]
    [LineNumberTable((ushort) 1128)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createStandardDateTickUnits(TimeZone zone)
    {
      return DateAxis.createStandardDateTickUnits(zone, Locale.getDefault());
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 191, (byte) 104, (byte) 168, (byte) 109, (byte) 103, (byte) 194, (byte) 239, (byte) 69, (byte) 116, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      if (!this.isVisible())
      {
        AxisState state = new AxisState(cursor);
        List ticks = this.refreshTicks(g2, state, dataArea, edge);
        state.setTicks(ticks);
        return state;
      }
      else
      {
        AxisState state1 = this.drawTickMarksAndLabels(g2, cursor, plotArea, dataArea, edge);
        AxisState state2 = this.drawLabel(this.getLabel(), g2, plotArea, dataArea, edge, state1);
        this.createAndAddEntity(cursor, state2, dataArea, edge, plotState);
        return state2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 219, (byte) 189, (byte) 223, (byte) 26, (byte) 98, (byte) 104, (byte) 255, (byte) 35, (byte) 70, (byte) 255, (byte) 21, (byte) 69, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoomRange(double lowerPercent, double upperPercent)
    {
      double num1 = (double) this.timeline.toTimelineValue(ByteCodeHelper.d2l(this.getRange().getLowerBound()));
      double num2 = (double) (this.timeline.toTimelineValue(ByteCodeHelper.d2l(this.getRange().getUpperBound())) - this.timeline.toTimelineValue(ByteCodeHelper.d2l(this.getRange().getLowerBound())));
      this.setRange(!this.isInverted() ? (Range) new DateRange((double) this.timeline.toMillisecond(ByteCodeHelper.d2l(num1 + num2 * lowerPercent)), (double) this.timeline.toMillisecond(ByteCodeHelper.d2l(num1 + num2 * upperPercent))) : (Range) new DateRange((double) this.timeline.toMillisecond(ByteCodeHelper.d2l(num1 + num2 * (1.0 - upperPercent))), (double) this.timeline.toMillisecond(ByteCodeHelper.d2l(num1 + num2 * (1.0 - lowerPercent)))));
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 250, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DateAxis))
        return false;
      DateAxis dateAxis = (DateAxis) obj;
      if (!ObjectUtilities.equal((object) this.tickUnit, (object) dateAxis.tickUnit) || !ObjectUtilities.equal((object) this.dateFormatOverride, (object) dateAxis.dateFormatOverride) || (!ObjectUtilities.equal((object) this.tickMarkPosition, (object) dateAxis.tickMarkPosition) || !ObjectUtilities.equal((object) this.timeline, (object) dateAxis.timeline)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 24, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.getLabel() == null)
        return 0;
      return String.instancehelper_hashCode(this.getLabel());
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 167, (byte) 41, (byte) 140, (byte) 104, (byte) 214})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DateAxis dateAxis = (DateAxis) base.clone();
      if (this.dateFormatOverride != null)
        dateAxis.dateFormatOverride = (DateFormat) this.dateFormatOverride.clone();
      return (object) dateAxis;
    }

    [InnerClass]
    [SourceFile("DateAxis.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [Implements(new string[] {"org.jfree.chart.axis.Timeline", "java.io.Serializable"})]
    [SourceFile("DateAxis.java")]
    [Modifiers]
    [Serializable]
    internal sealed class DefaultTimeline : Object, Timeline, Serializable.__Interface, ISerializable
    {
      [LineNumberTable((ushort) 210)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal DefaultTimeline([In] DateAxis.\u0031 obj0)
        : this()
      {
      }

      [LineNumberTable((ushort) 210)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private DefaultTimeline()
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected DefaultTimeline([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector();
        Serialization.readObject((object) this, obj0);
      }

      public virtual long toTimelineValue([In] long obj0)
      {
        return obj0;
      }

      [LineNumberTable((ushort) 231)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual long toTimelineValue([In] Date obj0)
      {
        return obj0.getTime();
      }

      public virtual long toMillisecond([In] long obj0)
      {
        return obj0;
      }

      public virtual bool containsDomainValue([In] long obj0)
      {
        return true;
      }

      public virtual bool containsDomainValue([In] Date obj0)
      {
        return true;
      }

      public virtual bool containsDomainRange([In] long obj0, [In] long obj1)
      {
        return true;
      }

      public virtual bool containsDomainRange([In] Date obj0, [In] Date obj1)
      {
        return true;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 99, (byte) 130, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
      public virtual bool equals([In] object obj0)
      {
        return obj0 != null && (obj0 == this || obj0 is DateAxis.DefaultTimeline);
      }

      [SecurityCritical]
      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        Serialization.writeObject((object) this, obj0);
      }
    }
  }
}
