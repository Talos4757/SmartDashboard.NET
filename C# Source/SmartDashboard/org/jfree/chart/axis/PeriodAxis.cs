// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.PeriodAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.lang.reflect;
using java.text;
using java.util;
using org.jfree.chart.@event;
using org.jfree.chart.plot;
using org.jfree.data;
using org.jfree.data.time;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class PeriodAxis : ValueAxis, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 8353295532075872069L;
    private RegularTimePeriod first;
    private RegularTimePeriod last;
    private TimeZone timeZone;
    private Locale locale;
    private Calendar calendar;
    private Class autoRangeTimePeriodClass;
    private Class majorTickTimePeriodClass;
    private bool minorTickMarksVisible;
    private Class minorTickTimePeriodClass;
    private float minorTickMarkInsideLength;
    private float minorTickMarkOutsideLength;
    [NonSerialized]
    private Stroke minorTickMarkStroke;
    [NonSerialized]
    private Paint minorTickMarkPaint;
    private PeriodAxisLabelInfo[] labelInfo;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Month;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Year;
    internal static Class class\u0024java\u0024util\u0024Date;
    internal static Class class\u0024java\u0024util\u0024TimeZone;
    internal static Class class\u0024java\u0024util\u0024Locale;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [HideFromJava]
    static PeriodAxis()
    {
      ValueAxis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PeriodAxis(string label, RegularTimePeriod first, RegularTimePeriod last)
      : this(label, first, last, TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 234, (byte) 159, (byte) 185, (byte) 171, (byte) 171, (byte) 176, (byte) 235, (byte) 127, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 111, (byte) 113, (byte) 113, (byte) 108, (byte) 108, (byte) 103, (byte) 145, (byte) 103, (byte) 108, (byte) 159, (byte) 29, (byte) 159, (byte) 29})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PeriodAxis(string label, RegularTimePeriod first, RegularTimePeriod last, TimeZone timeZone, Locale locale)
      : base(label, (TickUnitSource) null)
    {
      PeriodAxis periodAxis = this;
      this.minorTickMarkInsideLength = 0.0f;
      this.minorTickMarkOutsideLength = 2f;
      this.minorTickMarkStroke = (Stroke) new BasicStroke(0.5f);
      this.minorTickMarkPaint = (Paint) Color.black;
      if (timeZone == null)
      {
        string str = "Null 'timeZone' argument.";
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
        this.first = first;
        this.last = last;
        this.timeZone = timeZone;
        this.locale = locale;
        this.calendar = Calendar.getInstance(timeZone, locale);
        this.first.peg(this.calendar);
        this.last.peg(this.calendar);
        this.autoRangeTimePeriodClass = Object.instancehelper_getClass((object) first);
        this.majorTickTimePeriodClass = Object.instancehelper_getClass((object) first);
        this.minorTickMarksVisible = false;
        this.minorTickTimePeriodClass = RegularTimePeriod.downsize(this.majorTickTimePeriodClass);
        this.setAutoRange(true);
        this.labelInfo = new PeriodAxisLabelInfo[2];
        PeriodAxisLabelInfo[] periodAxisLabelInfoArray1 = this.labelInfo;
        int index1 = 0;
        PeriodAxisLabelInfo.__\u003Cclinit\u003E();
        PeriodAxisLabelInfo periodAxisLabelInfo1 = new PeriodAxisLabelInfo(PeriodAxis.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month != null ? PeriodAxis.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month : (PeriodAxis.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month = PeriodAxis.class\u0024("org.jfree.data.time.Month")), (DateFormat) new SimpleDateFormat("MMM", locale));
        periodAxisLabelInfoArray1[index1] = periodAxisLabelInfo1;
        PeriodAxisLabelInfo[] periodAxisLabelInfoArray2 = this.labelInfo;
        int index2 = 1;
        PeriodAxisLabelInfo.__\u003Cclinit\u003E();
        PeriodAxisLabelInfo periodAxisLabelInfo2 = new PeriodAxisLabelInfo(PeriodAxis.class\u0024org\u0024jfree\u0024data\u0024time\u0024Year != null ? PeriodAxis.class\u0024org\u0024jfree\u0024data\u0024time\u0024Year : (PeriodAxis.class\u0024org\u0024jfree\u0024data\u0024time\u0024Year = PeriodAxis.class\u0024("org.jfree.data.time.Year")), (DateFormat) new SimpleDateFormat("yyyy", locale));
        periodAxisLabelInfoArray2[index2] = periodAxisLabelInfo2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PeriodAxis(string label)
      : this(label, (RegularTimePeriod) new Day(), (RegularTimePeriod) new Day())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PeriodAxis(string label, RegularTimePeriod first, RegularTimePeriod last, TimeZone timeZone)
      : this(label, first, last, timeZone, Locale.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PeriodAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PeriodAxis obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PeriodAxis obj0)
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

    public virtual PeriodAxisLabelInfo[] getLabelInfo()
    {
      return this.labelInfo;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 179, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelInfo(PeriodAxisLabelInfo[] info)
    {
      this.labelInfo = info;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable((ushort) 256)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal new static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, PeriodAxis.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 164, (byte) 52, (byte) 130, (byte) 159, (byte) 86, (byte) 255, (byte) 26, (byte) 77, (byte) 229, (byte) 54, (byte) 129, (byte) 159, (byte) 20, (byte) 255, (byte) 17, (byte) 69, (byte) 2, (byte) 193})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private RegularTimePeriod createInstance([In] Class obj0, [In] Date obj1, [In] TimeZone obj2, [In] Locale obj3)
    {
      RegularTimePeriod regularTimePeriod = (RegularTimePeriod) null;
      try
      {
        Class class1 = obj0;
        Class[] classArray = new Class[3];
        int index1 = 0;
        Class class2 = PeriodAxis.class\u0024java\u0024util\u0024Date != null ? PeriodAxis.class\u0024java\u0024util\u0024Date : (PeriodAxis.class\u0024java\u0024util\u0024Date = PeriodAxis.class\u0024("java.util.Date"));
        classArray[index1] = class2;
        int index2 = 1;
        Class class3 = PeriodAxis.class\u0024java\u0024util\u0024TimeZone != null ? PeriodAxis.class\u0024java\u0024util\u0024TimeZone : (PeriodAxis.class\u0024java\u0024util\u0024TimeZone = PeriodAxis.class\u0024("java.util.TimeZone"));
        classArray[index2] = class3;
        int index3 = 2;
        Class class4 = PeriodAxis.class\u0024java\u0024util\u0024Locale != null ? PeriodAxis.class\u0024java\u0024util\u0024Locale : (PeriodAxis.class\u0024java\u0024util\u0024Locale = PeriodAxis.class\u0024("java.util.Locale"));
        classArray[index3] = class4;
        CallerID callerId1 = PeriodAxis.__\u003CGetCallerID\u003E();
        Constructor declaredConstructor = class1.getDeclaredConstructor(classArray, callerId1);
        object[] objArray = new object[3];
        int index4 = 0;
        Date date = obj1;
        objArray[index4] = (object) date;
        int index5 = 1;
        TimeZone timeZone = obj2;
        objArray[index5] = (object) timeZone;
        int index6 = 2;
        Locale locale = obj3;
        objArray[index6] = (object) locale;
        CallerID callerId2 = PeriodAxis.__\u003CGetCallerID\u003E();
        regularTimePeriod = (RegularTimePeriod) declaredConstructor.newInstance(objArray, callerId2);
        goto label_9;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      try
      {
        Class class1 = obj0;
        Class[] classArray = new Class[1];
        int index1 = 0;
        Class class2 = PeriodAxis.class\u0024java\u0024util\u0024Date != null ? PeriodAxis.class\u0024java\u0024util\u0024Date : (PeriodAxis.class\u0024java\u0024util\u0024Date = PeriodAxis.class\u0024("java.util.Date"));
        classArray[index1] = class2;
        CallerID callerId1 = PeriodAxis.__\u003CGetCallerID\u003E();
        Constructor declaredConstructor = class1.getDeclaredConstructor(classArray, callerId1);
        object[] objArray = new object[1];
        int index2 = 0;
        Date date = obj1;
        objArray[index2] = (object) date;
        CallerID callerId2 = PeriodAxis.__\u003CGetCallerID\u003E();
        regularTimePeriod = (RegularTimePeriod) declaredConstructor.newInstance(objArray, callerId2);
        goto label_9;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
label_9:
      return regularTimePeriod;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 183, (byte) 103, (byte) 99, (byte) 161, (byte) 107, (byte) 135, (byte) 104, (byte) 99, (byte) 167, (byte) 108, (byte) 109, (byte) 159, (byte) 6, (byte) 159, (byte) 5, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void autoAdjustRange()
    {
      Plot plot = this.getPlot();
      if (plot == null || !(plot is ValueAxisPlot))
        return;
      Range range = ((ValueAxisPlot) plot).getDataRange((ValueAxis) this) ?? this.getDefaultAutoRange();
      long num = Math.round(range.getUpperBound());
      this.first = this.createInstance(this.autoRangeTimePeriodClass, new Date(Math.round(range.getLowerBound())), this.timeZone, this.locale);
      this.last = this.createInstance(this.autoRangeTimePeriodClass, new Date(num), this.timeZone, this.locale);
      this.setRange(range, false, false);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 78, (byte) 105, (byte) 141, (byte) 105, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawTickMarks(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      if (RectangleEdge.isTopOrBottom(edge))
      {
        this.drawTickMarksHorizontal(g2, state, dataArea, edge);
      }
      else
      {
        if (!RectangleEdge.isLeftOrRight(edge))
          return;
        this.drawTickMarksVertical(g2, state, dataArea, edge);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 205, (byte) 102, (byte) 116, (byte) 105, (byte) 189, (byte) 105, (byte) 187, (byte) 105, (byte) 108, (byte) 108, (byte) 115, (byte) 179, (byte) 159, (byte) 2, (byte) 159, (byte) 2, (byte) 159, (byte) 6, (byte) 159, (byte) 6, (byte) 144, (byte) 144, (byte) 118, (byte) 159, (byte) 6, (byte) 104, (byte) 168, (byte) 134, (byte) 145, (byte) 147, (byte) 159, (byte) 2, (byte) 99, (byte) 100, (byte) 105, (byte) 103, (byte) 106, (byte) 105, (byte) 103, (byte) 133, (byte) 109, (byte) 149, (byte) 111, (byte) 122, (byte) 105, (byte) 105, (byte) 168, (byte) 144, (byte) 126, (byte) 150, (byte) 116, (byte) 183, (byte) 195, (byte) 168, (byte) 144, (byte) 126, (byte) 150, (byte) 116, (byte) 183, (byte) 227, (byte) 69, (byte) 100, (byte) 115, (byte) 144, (byte) 105, (byte) 111, (byte) 105, (byte) 106, (byte) 112, (byte) 115, (byte) 115, (byte) 183, (byte) 100, (byte) 105, (byte) 41, (byte) 168, (byte) 109, (byte) 101, (byte) 103, (byte) 100, (byte) 138, (byte) 105, (byte) 191, (byte) 2, (byte) 105, (byte) 223, (byte) 0, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisState drawTickLabels(int band, Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      double units1 = 0.0;
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.labelInfo[band].getLabelFont());
      if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        units1 = this.labelInfo[band].getPadding().calculateTopOutset((double) fontMetrics.getHeight());
      else if (edge == RectangleEdge.__\u003C\u003ETOP)
        units1 = this.labelInfo[band].getPadding().calculateBottomOutset((double) fontMetrics.getHeight());
      state.moveCursor(units1, edge);
      long firstMillisecond1 = this.first.getFirstMillisecond();
      long lastMillisecond1 = this.last.getLastMillisecond();
      ((Graphics) g2).setFont(this.labelInfo[band].getLabelFont());
      g2.setPaint(this.labelInfo[band].getLabelPaint());
      RegularTimePeriod instance1 = this.labelInfo[band].createInstance(new Date(firstMillisecond1), this.timeZone, this.locale);
      RegularTimePeriod instance2 = this.labelInfo[band].createInstance(new Date(lastMillisecond1), this.timeZone, this.locale);
      DateFormat dateFormat1 = this.labelInfo[band].getDateFormat();
      Date.__\u003Cclinit\u003E();
      Date date1 = new Date(instance1.getMiddleMillisecond());
      string text1 = dateFormat1.format(date1);
      DateFormat dateFormat2 = this.labelInfo[band].getDateFormat();
      Date.__\u003Cclinit\u003E();
      Date date2 = new Date(instance2.getMiddleMillisecond());
      string text2 = dateFormat2.format(date2);
      Rectangle2D textBounds1 = TextUtilities.getTextBounds(text1, g2, ((Graphics) g2).getFontMetrics());
      Rectangle2D textBounds2 = TextUtilities.getTextBounds(text2, g2, ((Graphics) g2).getFontMetrics());
      double num1 = Math.max(((RectangularShape) textBounds1).getWidth(), ((RectangularShape) textBounds2).getWidth());
      long num2 = Math.round(this.java2DToValue(((RectangularShape) dataArea).getX() + num1 + 5.0, dataArea, edge));
      long num3 = !this.isInverted() ? num2 - firstMillisecond1 : lastMillisecond1 - num2;
      long num4 = instance1.getLastMillisecond() - instance1.getFirstMillisecond();
      long num5 = num3;
      long num6 = num4;
      long num7 = -1L;
      int num8 = (num6 != num7 ? (int) (num5 / num6) : (int) -num5) + 1;
      RegularTimePeriod regularTimePeriod = this.labelInfo[band].createInstance(new Date(firstMillisecond1), this.timeZone, this.locale);
      Rectangle2D rectangle2D = (Rectangle2D) null;
      long num9 = 0L;
      float y = (float) state.getCursor();
      TextAnchor anchor = TextAnchor.__\u003C\u003ETOP_CENTER;
      float num10 = (float) ((RectangularShape) textBounds1).getHeight();
      if (edge == RectangleEdge.__\u003C\u003ETOP)
      {
        anchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
        num10 = -num10;
      }
      while (regularTimePeriod.getFirstMillisecond() <= lastMillisecond1)
      {
        float x = (float) this.valueToJava2D((double) regularTimePeriod.getMiddleMillisecond(), dataArea, edge);
        DateFormat dateFormat3 = this.labelInfo[band].getDateFormat();
        Date.__\u003Cclinit\u003E();
        Date date3 = new Date(regularTimePeriod.getMiddleMillisecond());
        string text3 = dateFormat3.format(date3);
        long firstMillisecond2 = regularTimePeriod.getFirstMillisecond();
        long lastMillisecond2 = regularTimePeriod.getLastMillisecond();
        if (lastMillisecond2 > lastMillisecond1)
        {
          Rectangle2D textBounds3 = TextUtilities.getTextBounds(text3, g2, ((Graphics) g2).getFontMetrics());
          if ((double) x + ((RectangularShape) textBounds3).getWidth() / 2.0 > ((RectangularShape) dataArea).getMaxX())
          {
            float num11 = (float) this.valueToJava2D((double) Math.max(firstMillisecond2, firstMillisecond1), dataArea, edge);
            if (((RectangularShape) textBounds3).getWidth() < ((RectangularShape) dataArea).getMaxX() - (double) num11)
              x = ((float) ((RectangularShape) dataArea).getMaxX() + num11) / 2f;
            else
              text3 = (string) null;
          }
        }
        if (firstMillisecond2 < firstMillisecond1)
        {
          Rectangle2D textBounds3 = TextUtilities.getTextBounds(text3, g2, ((Graphics) g2).getFontMetrics());
          if ((double) x - ((RectangularShape) textBounds3).getWidth() / 2.0 < ((RectangularShape) dataArea).getX())
          {
            float num11 = (float) this.valueToJava2D((double) Math.min(lastMillisecond2, lastMillisecond1), dataArea, edge);
            if (((RectangularShape) textBounds3).getWidth() < (double) num11 - ((RectangularShape) dataArea).getX())
              x = (num11 + (float) ((RectangularShape) dataArea).getX()) / 2f;
            else
              text3 = (string) null;
          }
        }
        if (text3 != null)
        {
          g2.setPaint(this.labelInfo[band].getLabelPaint());
          rectangle2D = TextUtilities.drawAlignedString(text3, g2, x, y, anchor);
        }
        if (num9 > 0L && this.labelInfo[band].getDrawDividers())
        {
          long firstMillisecond3 = regularTimePeriod.getFirstMillisecond();
          float num11 = (float) this.valueToJava2D((double) ((num9 + firstMillisecond3) / 2L), dataArea, edge);
          g2.setStroke(this.labelInfo[band].getDividerStroke());
          g2.setPaint(this.labelInfo[band].getDividerPaint());
          g2.draw((Shape) new Line2D.Float(num11, y, num11, y + num10));
        }
        num9 = lastMillisecond2;
        for (int index = 0; index < num8; ++index)
          regularTimePeriod = regularTimePeriod.next();
        regularTimePeriod.peg(this.calendar);
      }
      double units2 = 0.0;
      if (rectangle2D != null)
      {
        units2 = ((RectangularShape) rectangle2D).getHeight();
        if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
          units2 += this.labelInfo[band].getPadding().calculateBottomOutset((double) fontMetrics.getHeight());
        else if (edge == RectangleEdge.__\u003C\u003ETOP)
          units2 += this.labelInfo[band].getPadding().calculateTopOutset((double) fontMetrics.getHeight());
      }
      state.moveCursor(units2, edge);
      return state;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 98, (byte) 102, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 159, (byte) 6, (byte) 105, (byte) 99, (byte) 99, (byte) 109, (byte) 112, (byte) 105, (byte) 159, (byte) 9, (byte) 111, (byte) 105, (byte) 111, (byte) 145, (byte) 105, (byte) 111, (byte) 143, (byte) 102, (byte) 108, (byte) 108, (byte) 104, (byte) 168, (byte) 107, (byte) 191, (byte) 2, (byte) 137, (byte) 119, (byte) 111, (byte) 105, (byte) 149, (byte) 183, (byte) 105, (byte) 149, (byte) 181, (byte) 102, (byte) 108, (byte) 108, (byte) 104, (byte) 136, (byte) 105, (byte) 109, (byte) 105, (byte) 133, (byte) 105, (byte) 109, (byte) 142, (byte) 105, (byte) 181, (byte) 105, (byte) 179, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawTickMarksHorizontal(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      ((RectangularShape) dataArea).getX();
      double cursor = state.getCursor();
      double num1 = (double) this.getTickMarkInsideLength();
      double num2 = (double) this.getTickMarkOutsideLength();
      RegularTimePeriod regularTimePeriod1 = this.createInstance(this.majorTickTimePeriodClass, this.first.getStart(), this.getTimeZone(), this.locale);
      long firstMillisecond1 = regularTimePeriod1.getFirstMillisecond();
      Line2D.Double double1 = (Line2D.Double) null;
      Line2D.Double double2 = (Line2D.Double) null;
      long firstMillisecond2 = this.getFirst().getFirstMillisecond();
      for (long index = this.getLast().getLastMillisecond() + 1L; firstMillisecond1 <= index; firstMillisecond1 = regularTimePeriod1.getFirstMillisecond())
      {
        ((List) arrayList).add((object) new NumberTick((Number) new Double((double) firstMillisecond1), "", TextAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
        double num3 = this.valueToJava2D((double) firstMillisecond1, dataArea, edge);
        if (edge == RectangleEdge.__\u003C\u003ETOP)
        {
          double1 = new Line2D.Double(num3, cursor, num3, cursor + num1);
          double2 = new Line2D.Double(num3, cursor, num3, cursor - num2);
        }
        else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        {
          double1 = new Line2D.Double(num3, cursor, num3, cursor - num1);
          double2 = new Line2D.Double(num3, cursor, num3, cursor + num2);
        }
        if (firstMillisecond1 >= firstMillisecond2)
        {
          g2.setPaint(this.getTickMarkPaint());
          g2.setStroke(this.getTickMarkStroke());
          g2.draw((Shape) double1);
          g2.draw((Shape) double2);
        }
        if (this.minorTickMarksVisible)
        {
          RegularTimePeriod regularTimePeriod2 = this.createInstance(this.minorTickTimePeriodClass, new Date(firstMillisecond1), this.getTimeZone(), this.locale);
          for (long firstMillisecond3 = regularTimePeriod2.getFirstMillisecond(); firstMillisecond3 < regularTimePeriod1.getLastMillisecond() && firstMillisecond3 < index; firstMillisecond3 = regularTimePeriod2.getFirstMillisecond())
          {
            double num4 = this.valueToJava2D((double) firstMillisecond3, dataArea, edge);
            if (edge == RectangleEdge.__\u003C\u003ETOP)
            {
              double1 = new Line2D.Double(num4, cursor, num4, cursor + (double) this.minorTickMarkInsideLength);
              double2 = new Line2D.Double(num4, cursor, num4, cursor - (double) this.minorTickMarkOutsideLength);
            }
            else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
            {
              double1 = new Line2D.Double(num4, cursor, num4, cursor - (double) this.minorTickMarkInsideLength);
              double2 = new Line2D.Double(num4, cursor, num4, cursor + (double) this.minorTickMarkOutsideLength);
            }
            if (firstMillisecond3 >= firstMillisecond2)
            {
              g2.setPaint(this.minorTickMarkPaint);
              g2.setStroke(this.minorTickMarkStroke);
              g2.draw((Shape) double1);
              g2.draw((Shape) double2);
            }
            regularTimePeriod2 = regularTimePeriod2.next();
            regularTimePeriod2.peg(this.calendar);
          }
        }
        regularTimePeriod1 = regularTimePeriod1.next();
        regularTimePeriod1.peg(this.calendar);
      }
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        state.cursorUp(Math.max(num2, (double) this.minorTickMarkOutsideLength));
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        state.cursorDown(Math.max(num2, (double) this.minorTickMarkOutsideLength));
      state.setTicks((List) arrayList);
    }

    protected internal virtual void drawTickMarksVertical(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
    }

    public virtual TimeZone getTimeZone()
    {
      return this.timeZone;
    }

    public virtual RegularTimePeriod getFirst()
    {
      return this.first;
    }

    public virtual RegularTimePeriod getLast()
    {
      return this.last;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 110, (byte) 106, (byte) 109, (byte) 109, (byte) 104, (byte) 104, (byte) 105, (byte) 104, (byte) 212, (byte) 177, (byte) 98, (byte) 104, (byte) 104, (byte) 105, (byte) 104, (byte) 211, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double valueToJava2D(double value, Rectangle2D area, RectangleEdge edge)
    {
      double num1 = double.NaN;
      double num2 = (double) this.first.getFirstMillisecond();
      double num3 = (double) this.last.getLastMillisecond();
      if (RectangleEdge.isTopOrBottom(edge))
      {
        double x = ((RectangularShape) area).getX();
        double maxX = ((RectangularShape) area).getMaxX();
        num1 = !this.isInverted() ? x + (value - num2) / (num3 - num2) * (maxX - x) : maxX + (value - num2) / (num3 - num2) * (x - maxX);
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        double minY = ((RectangularShape) area).getMinY();
        double maxY = ((RectangularShape) area).getMaxY();
        num1 = !this.isInverted() ? maxY - (value - num2) / (num3 - num2) * (maxY - minY) : minY + (value - num2) / (num3 - num2) * (maxY - minY);
      }
      return num1;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 154, (byte) 106, (byte) 102, (byte) 102, (byte) 109, (byte) 109, (byte) 104, (byte) 104, (byte) 138, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 211, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double java2DToValue(double java2DValue, Rectangle2D area, RectangleEdge edge)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = (double) this.first.getFirstMillisecond();
      double num4 = (double) this.last.getLastMillisecond();
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num1 = ((RectangularShape) area).getX();
        num2 = ((RectangularShape) area).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num1 = ((RectangularShape) area).getMaxY();
        num2 = ((RectangularShape) area).getY();
      }
      return !this.isInverted() ? num3 + (java2DValue - num1) / (num2 - num1) * (num4 - num3) : num4 - (java2DValue - num1) / (num2 - num1) * (num4 - num3);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 1, (byte) 132, (byte) 108, (byte) 108, (byte) 159, (byte) 5, (byte) 159, (byte) 5, (byte) 191, (byte) 14})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setRange(Range range, bool turnOffAutoRange, bool notify)
    {
      int num1 = turnOffAutoRange ? 1 : 0;
      int num2 = notify ? 1 : 0;
      long num3 = Math.round(range.getUpperBound());
      this.first = this.createInstance(this.autoRangeTimePeriodClass, new Date(Math.round(range.getLowerBound())), this.timeZone, this.locale);
      this.last = this.createInstance(this.autoRangeTimePeriodClass, new Date(num3), this.timeZone, this.locale);
      base.setRange(new Range((double) this.first.getFirstMillisecond(), (double) this.last.getLastMillisecond() + 1.0), num1 != 0, num2 != 0);
    }

    public override bool isMinorTickMarksVisible()
    {
      return this.minorTickMarksVisible;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 99, (byte) 144, (byte) 103, (byte) 113, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFirst(RegularTimePeriod first)
    {
      if (first == null)
      {
        string str = "Null 'first' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.first = first;
        this.first.peg(this.calendar);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 188, (byte) 99, (byte) 144, (byte) 103, (byte) 113, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLast(RegularTimePeriod last)
    {
      if (last == null)
      {
        string str = "Null 'last' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.last = last;
        this.last.peg(this.calendar);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 213, (byte) 99, (byte) 144, (byte) 103, (byte) 114, (byte) 113, (byte) 113, (byte) 110})]
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
        this.timeZone = zone;
        this.calendar = Calendar.getInstance(zone, this.locale);
        this.first.peg(this.calendar);
        this.last.peg(this.calendar);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Locale getLocale()
    {
      return this.locale;
    }

    public virtual Class getAutoRangeTimePeriodClass()
    {
      return this.autoRangeTimePeriodClass;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoRangeTimePeriodClass(Class c)
    {
      if (c == null)
      {
        string str = "Null 'c' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.autoRangeTimePeriodClass = c;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Class getMajorTickTimePeriodClass()
    {
      return this.majorTickTimePeriodClass;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMajorTickTimePeriodClass(Class c)
    {
      if (c == null)
      {
        string str = "Null 'c' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.majorTickTimePeriodClass = c;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 39, (byte) 162, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setMinorTickMarksVisible(bool visible)
    {
      this.minorTickMarksVisible = visible;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual Class getMinorTickTimePeriodClass()
    {
      return this.minorTickTimePeriodClass;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 66, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickTimePeriodClass(Class c)
    {
      if (c == null)
      {
        string str = "Null 'c' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minorTickTimePeriodClass = c;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Stroke getMinorTickMarkStroke()
    {
      return this.minorTickMarkStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 91, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickMarkStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minorTickMarkStroke = stroke;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Paint getMinorTickMarkPaint()
    {
      return this.minorTickMarkPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 116, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickMarkPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minorTickMarkPaint = paint;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public override float getMinorTickMarkInsideLength()
    {
      return this.minorTickMarkInsideLength;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 139, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setMinorTickMarkInsideLength(float length)
    {
      this.minorTickMarkInsideLength = length;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public override float getMinorTickMarkOutsideLength()
    {
      return this.minorTickMarkOutsideLength;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 159, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setMinorTickMarkOutsideLength(float length)
    {
      this.minorTickMarkOutsideLength = length;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 212, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void configure()
    {
      if (!this.isAutoRange())
        return;
      this.autoAdjustRange();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 234, (byte) 100, (byte) 199, (byte) 104, (byte) 195, (byte) 104, (byte) 104, (byte) 202, (byte) 106, (byte) 102, (byte) 102, (byte) 134, (byte) 108, (byte) 106, (byte) 111, (byte) 248, (byte) 61, (byte) 230, (byte) 71, (byte) 105, (byte) 105, (byte) 143, (byte) 105, (byte) 105, (byte) 205, (byte) 103, (byte) 104, (byte) 137, (byte) 104, (byte) 177, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisSpace reserveSpace(Graphics2D g2, Plot plot, Rectangle2D plotArea, RectangleEdge edge, AxisSpace space)
    {
      if (space == null)
        space = new AxisSpace();
      if (!this.isVisible())
        return space;
      double fixedDimension = this.getFixedDimension();
      if (fixedDimension > 0.0)
        space.ensureAtLeast(fixedDimension, edge);
      Rectangle2D labelEnclosure = this.getLabelEnclosure(g2, edge);
      double num = 0.0;
      for (int index = 0; index < this.labelInfo.Length; ++index)
      {
        PeriodAxisLabelInfo periodAxisLabelInfo = this.labelInfo[index];
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(periodAxisLabelInfo.getLabelFont());
        num += periodAxisLabelInfo.getPadding().extendHeight((double) fontMetrics.getHeight());
      }
      if (RectangleEdge.isTopOrBottom(edge))
      {
        double height = ((RectangularShape) labelEnclosure).getHeight();
        space.add(height + num, edge);
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        double width = ((RectangularShape) labelEnclosure).getWidth();
        space.add(width + num, edge);
      }
      double space1 = 0.0;
      if (this.isTickMarksVisible())
        space1 = (double) this.getTickMarkOutsideLength();
      if (this.minorTickMarksVisible)
        space1 = Math.max(space1, (double) this.minorTickMarkOutsideLength);
      space.add(space1, edge);
      return space;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 46, (byte) 104, (byte) 104, (byte) 141, (byte) 104, (byte) 140, (byte) 104, (byte) 108, (byte) 46, (byte) 230, (byte) 71, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      AxisState state = new AxisState(cursor);
      if (this.isAxisLineVisible())
        this.drawAxisLine(g2, cursor, dataArea, edge);
      if (this.isTickMarksVisible())
        this.drawTickMarks(g2, state, dataArea, edge);
      if (this.isTickLabelsVisible())
      {
        for (int band = 0; band < this.labelInfo.Length; ++band)
          state = this.drawTickLabels(band, g2, state, dataArea, edge);
      }
      return this.drawLabel(this.getLabel(), g2, plotArea, dataArea, edge, state);
    }

    [LineNumberTable((ushort) 974)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override List refreshTicks(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      return (List) Collections.EMPTY_LIST;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 215, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PeriodAxis))
        return false;
      PeriodAxis periodAxis = (PeriodAxis) obj;
      if (!Object.instancehelper_equals((object) this.first, (object) periodAxis.first) || !Object.instancehelper_equals((object) this.last, (object) periodAxis.last) || (!Object.instancehelper_equals((object) this.timeZone, (object) periodAxis.timeZone) || !this.locale.equals((object) periodAxis.locale)) || (!Object.instancehelper_equals((object) this.autoRangeTimePeriodClass, (object) periodAxis.autoRangeTimePeriodClass) || this.isMinorTickMarksVisible() != periodAxis.isMinorTickMarksVisible() || (!Object.instancehelper_equals((object) this.majorTickTimePeriodClass, (object) periodAxis.majorTickTimePeriodClass) || !Object.instancehelper_equals((object) this.minorTickTimePeriodClass, (object) periodAxis.minorTickTimePeriodClass))) || (!Object.instancehelper_equals((object) this.minorTickMarkPaint, (object) periodAxis.minorTickMarkPaint) || !Object.instancehelper_equals((object) this.minorTickMarkStroke, (object) periodAxis.minorTickMarkStroke) || !Arrays.equals((object[]) this.labelInfo, (object[]) periodAxis.labelInfo)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 11, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.getLabel() == null)
        return 0;
      return String.instancehelper_hashCode(this.getLabel());
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 28, (byte) 108, (byte) 118, (byte) 114, (byte) 108, (byte) 48, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      PeriodAxis periodAxis = (PeriodAxis) base.clone();
      periodAxis.timeZone = (TimeZone) this.timeZone.clone();
      periodAxis.labelInfo = new PeriodAxisLabelInfo[this.labelInfo.Length];
      for (int index = 0; index < this.labelInfo.Length; ++index)
        periodAxis.labelInfo[index] = this.labelInfo[index];
      return (object) periodAxis;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 81, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.minorTickMarkStroke, obj0);
      SerialUtilities.writePaint(this.minorTickMarkPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 96, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.minorTickMarkStroke = SerialUtilities.readStroke(obj0);
      this.minorTickMarkPaint = SerialUtilities.readPaint(obj0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (PeriodAxis.__\u003CcallerID\u003E == null)
        PeriodAxis.__\u003CcallerID\u003E = (CallerID) new PeriodAxis.__\u003CCallerID\u003E();
      return PeriodAxis.__\u003CcallerID\u003E;
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
