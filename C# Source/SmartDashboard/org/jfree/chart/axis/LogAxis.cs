// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.LogAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.font;
using java.awt.geom;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart.@event;
using org.jfree.chart.plot;
using org.jfree.chart.util;
using org.jfree.data;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class LogAxis : ValueAxis
  {
    private double @base;
    private double baseLog;
    private double smallestValue;
    private NumberTickUnit tickUnit;
    private NumberFormat numberFormatOverride;

    [HideFromJava]
    static LogAxis()
    {
      ValueAxis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 243, (byte) 37, (byte) 176, (byte) 181, (byte) 240, (byte) 86, (byte) 121, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogAxis(string label)
      : base(label, LogAxis.createLogTickUnits(Locale.getDefault()))
    {
      LogAxis logAxis = this;
      this.@base = 10.0;
      this.baseLog = Math.log(10.0);
      this.smallestValue = 1E-100;
      this.setDefaultAutoRange(new Range(0.01, 1.0));
      this.tickUnit = new NumberTickUnit(1.0, (NumberFormat) new DecimalFormat("0.#"), 9);
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogAxis()
      : this((string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LogAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 26, (byte) 102, (byte) 102, (byte) 118, (byte) 119, (byte) 118, (byte) 118, (byte) 115, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 117, (byte) 117, (byte) 117, (byte) 117, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createLogTickUnits(Locale locale)
    {
      TickUnits tickUnits = new TickUnits();
      LogFormat logFormat = new LogFormat();
      tickUnits.add((TickUnit) new NumberTickUnit(0.05, (NumberFormat) logFormat, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.1, (NumberFormat) logFormat, 10));
      tickUnits.add((TickUnit) new NumberTickUnit(0.2, (NumberFormat) logFormat, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.5, (NumberFormat) logFormat, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1.0, (NumberFormat) logFormat, 10));
      tickUnits.add((TickUnit) new NumberTickUnit(2.0, (NumberFormat) logFormat, 10));
      tickUnits.add((TickUnit) new NumberTickUnit(3.0, (NumberFormat) logFormat, 15));
      tickUnits.add((TickUnit) new NumberTickUnit(4.0, (NumberFormat) logFormat, 20));
      tickUnits.add((TickUnit) new NumberTickUnit(5.0, (NumberFormat) logFormat, 25));
      tickUnits.add((TickUnit) new NumberTickUnit(6.0, (NumberFormat) logFormat));
      tickUnits.add((TickUnit) new NumberTickUnit(7.0, (NumberFormat) logFormat));
      tickUnits.add((TickUnit) new NumberTickUnit(8.0, (NumberFormat) logFormat));
      tickUnits.add((TickUnit) new NumberTickUnit(9.0, (NumberFormat) logFormat));
      tickUnits.add((TickUnit) new NumberTickUnit(10.0, (NumberFormat) logFormat));
      return (TickUnitSource) tickUnits;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 87, (byte) 164, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickUnit(NumberTickUnit unit, bool notify, bool turnOffAutoSelect)
    {
      int num1 = turnOffAutoSelect ? 1 : 0;
      int num2 = notify ? 1 : 0;
      if (unit == null)
      {
        string str = "Null 'unit' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickUnit = unit;
        if (num1 != 0)
          this.setAutoTickUnitSelection(false, false);
        if (num2 == 0)
          return;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable((ushort) 272)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateLog(double value)
    {
      return Math.log(value) / this.baseLog;
    }

    [LineNumberTable((ushort) 286)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateValue(double log)
    {
      return Math.pow(this.@base, log);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 12, (byte) 103, (byte) 99, (byte) 161, (byte) 107, (byte) 135, (byte) 104, (byte) 99, (byte) 167, (byte) 104, (byte) 116, (byte) 167, (byte) 105, (byte) 105, (byte) 215, (byte) 105, (byte) 102, (byte) 114, (byte) 102, (byte) 200, (byte) 106, (byte) 107, (byte) 104, (byte) 111, (byte) 111, (byte) 106, (byte) 171, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void autoAdjustRange()
    {
      Plot plot = this.getPlot();
      if (plot == null || !(plot is ValueAxisPlot))
        return;
      Range range = ((ValueAxisPlot) plot).getDataRange((ValueAxis) this) ?? this.getDefaultAutoRange();
      double upper = range.getUpperBound();
      double num1 = Math.max(range.getLowerBound(), this.smallestValue);
      double num2 = upper - num1;
      double fixedAutoRange = this.getFixedAutoRange();
      double lower;
      if (fixedAutoRange > 0.0)
      {
        lower = Math.max(upper - fixedAutoRange, this.smallestValue);
      }
      else
      {
        double rangeMinimumSize = this.getAutoRangeMinimumSize();
        if (num2 < rangeMinimumSize)
        {
          double num3 = (rangeMinimumSize - num2) / 2.0;
          upper += num3;
          num1 -= num3;
        }
        double num4 = this.calculateLog(upper);
        double num5 = this.calculateLog(num1);
        double num6 = num4 - num5;
        double log1 = num4 + this.getUpperMargin() * num6;
        double log2 = num5 - this.getLowerMargin() * num6;
        upper = this.calculateValue(log1);
        lower = this.calculateValue(log2);
      }
      this.setRange(new Range(lower, upper), false, false);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 107, (byte) 102, (byte) 105, (byte) 141, (byte) 105, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override List refreshTicks(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      object obj1 = (object) new ArrayList();
      if (RectangleEdge.isTopOrBottom(edge))
        obj1 = (object) this.refreshTicksHorizontal(g2, dataArea, edge);
      else if (RectangleEdge.isLeftOrRight(edge))
        obj1 = (object) this.refreshTicksVertical(g2, dataArea, edge);
      object obj2 = obj1;
      if (obj2 == null)
        return (List) null;
      List list = obj2 as List;
      if (list != null)
        return list;
      else
        throw new IncompatibleClassChangeError();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 130, (byte) 103, (byte) 102, (byte) 103, (byte) 135, (byte) 104, (byte) 168, (byte) 166, (byte) 104, (byte) 137, (byte) 109, (byte) 116, (byte) 116, (byte) 100, (byte) 105, (byte) 107, (byte) 106, (byte) 223, (byte) 7, (byte) 156, (byte) 105, (byte) 115, (byte) 106, (byte) 255, (byte) 4, (byte) 61, (byte) 232, (byte) 71, (byte) 113, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshTicksHorizontal(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      Range range = this.getRange();
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      TextAnchor textAnchor = edge != RectangleEdge.__\u003C\u003ETOP ? TextAnchor.__\u003C\u003ETOP_CENTER : TextAnchor.__\u003C\u003EBOTTOM_CENTER;
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      int minorTickCount = this.tickUnit.getMinorTickCount();
      double num1 = Math.floor(this.calculateLog(this.getLowerBound()));
      double num2 = Math.ceil(this.calculateLog(this.getUpperBound()));
      double log = num1;
      while (log <= num2)
      {
        double num3 = this.calculateValue(log);
        if (range.contains(num3))
          ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMAJOR, num3, this.createTickLabel(num3), textAnchor, TextAnchor.__\u003C\u003ECENTER, 0.0));
        double num4 = Math.pow(this.@base, log + this.tickUnit.getSize());
        for (int index = 1; index < minorTickCount; ++index)
        {
          double num5 = num3 + (double) index * ((num4 - num3) / (double) minorTickCount);
          if (range.contains(num5))
            ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMINOR, num5, "", textAnchor, TextAnchor.__\u003C\u003ECENTER, 0.0));
        }
        log += this.tickUnit.getSize();
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 182, (byte) 103, (byte) 102, (byte) 103, (byte) 135, (byte) 104, (byte) 168, (byte) 166, (byte) 104, (byte) 137, (byte) 109, (byte) 116, (byte) 116, (byte) 100, (byte) 105, (byte) 107, (byte) 106, (byte) 223, (byte) 7, (byte) 156, (byte) 105, (byte) 115, (byte) 106, (byte) 255, (byte) 4, (byte) 61, (byte) 232, (byte) 71, (byte) 113, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshTicksVertical(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      Range range = this.getRange();
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      TextAnchor textAnchor = edge != RectangleEdge.__\u003C\u003ERIGHT ? TextAnchor.__\u003C\u003ECENTER_RIGHT : TextAnchor.__\u003C\u003ECENTER_LEFT;
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      int minorTickCount = this.tickUnit.getMinorTickCount();
      double num1 = Math.floor(this.calculateLog(this.getLowerBound()));
      double num2 = Math.ceil(this.calculateLog(this.getUpperBound()));
      double log = num1;
      while (log <= num2)
      {
        double num3 = this.calculateValue(log);
        if (range.contains(num3))
          ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMAJOR, num3, this.createTickLabel(num3), textAnchor, TextAnchor.__\u003C\u003ECENTER, 0.0));
        double num4 = Math.pow(this.@base, log + this.tickUnit.getSize());
        for (int index = 1; index < minorTickCount; ++index)
        {
          double num5 = num3 + (double) index * ((num4 - num3) / (double) minorTickCount);
          if (range.contains(num5))
            ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMINOR, num5, "", textAnchor, TextAnchor.__\u003C\u003ECENTER, 0.0));
        }
        log += this.tickUnit.getSize();
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 236, (byte) 104, (byte) 139, (byte) 104, (byte) 171})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 221, (byte) 104, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string createTickLabel(double value)
    {
      if (this.numberFormatOverride != null)
        return this.numberFormatOverride.format(value);
      else
        return this.tickUnit.valueToString(value);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 3, (byte) 207, (byte) 103, (byte) 109, (byte) 208, (byte) 141, (byte) 143, (byte) 178, (byte) 107, (byte) 101, (byte) 175, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectHorizontalAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      double num1 = this.estimateMaximumTickLabelWidth(g2, (TickUnit) this.getTickUnit());
      TickUnitSource standardTickUnits = this.getStandardTickUnits();
      TickUnit ceilingTickUnit = standardTickUnits.getCeilingTickUnit((TickUnit) this.getTickUnit());
      double num2 = this.exponentLengthToJava2D(ceilingTickUnit.getSize(), dataArea, edge);
      double d = num1 / num2 * ceilingTickUnit.getSize();
      NumberTickUnit unit = (NumberTickUnit) standardTickUnits.getCeilingTickUnit(d);
      double num3 = this.exponentLengthToJava2D(unit.getSize(), dataArea, edge);
      if (this.estimateMaximumTickLabelWidth(g2, (TickUnit) unit) > num3)
        unit = (NumberTickUnit) standardTickUnits.getLargerTickUnit((TickUnit) unit);
      this.setTickUnit(unit, false, false);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 63, (byte) 169, (byte) 103, (byte) 109, (byte) 208, (byte) 141, (byte) 143, (byte) 178, (byte) 105, (byte) 101, (byte) 175, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectVerticalAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      double num1 = this.estimateMaximumTickLabelHeight(g2);
      TickUnitSource standardTickUnits = this.getStandardTickUnits();
      TickUnit ceilingTickUnit = standardTickUnits.getCeilingTickUnit((TickUnit) this.getTickUnit());
      double num2 = this.exponentLengthToJava2D(ceilingTickUnit.getSize(), dataArea, edge);
      double d = num1 / num2 * ceilingTickUnit.getSize();
      NumberTickUnit unit = (NumberTickUnit) standardTickUnits.getCeilingTickUnit(d);
      double num3 = this.exponentLengthToJava2D(unit.getSize(), dataArea, edge);
      if (this.estimateMaximumTickLabelHeight(g2) > num3)
        unit = (NumberTickUnit) standardTickUnits.getLargerTickUnit((TickUnit) unit);
      this.setTickUnit(unit, false, false);
    }

    public virtual NumberTickUnit getTickUnit()
    {
      return this.tickUnit;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 127, (byte) 103, (byte) 143, (byte) 168, (byte) 103, (byte) 114, (byte) 107, (byte) 165, (byte) 110, (byte) 104, (byte) 106, (byte) 106, (byte) 102, (byte) 102, (byte) 104, (byte) 100, (byte) 107, (byte) 173, (byte) 106, (byte) 138, (byte) 108, (byte) 108, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double estimateMaximumTickLabelWidth(Graphics2D g2, TickUnit unit)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      double num1 = tickLabelInsets.getLeft() + tickLabelInsets.getRight();
      double num2;
      if (this.isVerticalTickLabels())
      {
        LineMetrics lineMetrics = this.getTickLabelFont().getLineMetrics("0", g2.getFontRenderContext());
        num2 = num1 + (double) lineMetrics.getHeight();
      }
      else
      {
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.getTickLabelFont());
        Range range = this.getRange();
        double lowerBound = range.getLowerBound();
        double upperBound = range.getUpperBound();
        NumberFormat numberFormatOverride = this.getNumberFormatOverride();
        string str1;
        string str2;
        if (numberFormatOverride != null)
        {
          str1 = numberFormatOverride.format(lowerBound);
          str2 = numberFormatOverride.format(upperBound);
        }
        else
        {
          str1 = unit.valueToString(lowerBound);
          str2 = unit.valueToString(upperBound);
        }
        double num3 = (double) fontMetrics.stringWidth(str1);
        double num4 = (double) fontMetrics.stringWidth(str2);
        num2 = num1 + Math.max(num3, num4);
      }
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 43, (byte) 117, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double exponentLengthToJava2D(double length, Rectangle2D area, RectangleEdge edge)
    {
      double num = this.valueToJava2D(this.calculateValue(1.0), area, edge);
      return Math.abs(this.valueToJava2D(this.calculateValue(length + 1.0), area, edge) - num);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 103, (byte) 110, (byte) 110, (byte) 139, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 105, (byte) 136, (byte) 104, (byte) 209})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double valueToJava2D(double value, Rectangle2D area, RectangleEdge edge)
    {
      Range range = this.getRange();
      double num1 = this.calculateLog(range.getLowerBound());
      double num2 = this.calculateLog(range.getUpperBound());
      value = this.calculateLog(value);
      double num3 = 0.0;
      double num4 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num3 = ((RectangularShape) area).getX();
        num4 = ((RectangularShape) area).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num4 = ((RectangularShape) area).getMinY();
        num3 = ((RectangularShape) area).getMaxY();
      }
      if (this.isInverted())
        return num4 - (value - num1) / (num2 - num1) * (num4 - num3);
      else
        return num3 + (value - num1) / (num2 - num1) * (num4 - num3);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 99, (byte) 103, (byte) 143, (byte) 103, (byte) 103, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double estimateMaximumTickLabelHeight(Graphics2D g2)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      return tickLabelInsets.getTop() + tickLabelInsets.getBottom() + (double) this.getTickLabelFont().getLineMetrics("123", g2.getFontRenderContext()).getHeight();
    }

    public virtual NumberFormat getNumberFormatOverride()
    {
      return this.numberFormatOverride;
    }

    public virtual double getBase()
    {
      return this.@base;
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 105, (byte) 144, (byte) 105, (byte) 110, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBase(double @base)
    {
      if (@base <= 1.0)
      {
        string str = "Requires 'base' > 1.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.@base = @base;
        this.baseLog = Math.log(@base);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual double getSmallestValue()
    {
      return this.smallestValue;
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 105, (byte) 144, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSmallestValue(double value)
    {
      if (value <= 0.0)
      {
        string str = "Requires 'value' > 0.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.smallestValue = value;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickUnit(NumberTickUnit unit)
    {
      this.setTickUnit(unit, true, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 143, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNumberFormatOverride(NumberFormat formatter)
    {
      this.numberFormatOverride = formatter;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 188, (byte) 103, (byte) 110, (byte) 142, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 104, (byte) 137, (byte) 102, (byte) 104, (byte) 212, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double java2DToValue(double java2DValue, Rectangle2D area, RectangleEdge edge)
    {
      Range range = this.getRange();
      double num1 = this.calculateLog(range.getLowerBound());
      double num2 = this.calculateLog(range.getUpperBound());
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
      return this.calculateValue(!this.isInverted() ? num1 + (java2DValue - num3) / (num4 - num3) * (num2 - num1) : num2 - (java2DValue - num3) / (num4 - num3) * (num2 - num1));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 2, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void configure()
    {
      if (!this.isAutoRange())
        return;
      this.autoAdjustRange();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 76, (byte) 130, (byte) 104, (byte) 168, (byte) 109, (byte) 103, (byte) 130, (byte) 111, (byte) 116, (byte) 111})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 170, (byte) 103, (byte) 104, (byte) 104, (byte) 105, (byte) 106, (byte) 103, (byte) 98, (byte) 104, (byte) 112, (byte) 112, (byte) 119, (byte) 130, (byte) 106, (byte) 106, (byte) 151, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoomRange(double lowerPercent, double upperPercent)
    {
      Range range = this.getRange();
      double lowerBound = range.getLowerBound();
      double upperBound = range.getUpperBound();
      double num1 = this.calculateLog(lowerBound);
      double num2 = this.calculateLog(upperBound) - num1;
      this.setRange(!this.isInverted() ? new Range(this.calculateValue(num1 + num2 * lowerPercent), this.calculateValue(num1 + num2 * upperPercent)) : new Range(this.calculateValue(num1 + num2 * (1.0 - upperPercent)), this.calculateValue(num1 + num2 * (1.0 - lowerPercent))));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 198, (byte) 103, (byte) 104, (byte) 104, (byte) 105, (byte) 106, (byte) 103, (byte) 104, (byte) 102, (byte) 104, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void pan(double percent)
    {
      Range range = this.getRange();
      double lowerBound = range.getLowerBound();
      double upperBound = range.getUpperBound();
      double num1 = this.calculateLog(lowerBound);
      double num2 = this.calculateLog(upperBound);
      double num3 = (num2 - num1) * percent;
      this.setRange(this.calculateValue(num1 + num3), this.calculateValue(num2 + num3));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 237, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LogAxis))
        return false;
      LogAxis logAxis = (LogAxis) obj;
      if (this.@base != logAxis.@base || this.smallestValue != logAxis.smallestValue)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 3, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 104, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.@base);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.smallestValue);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      if (this.numberFormatOverride != null)
        num5 = 37 * num5 + this.numberFormatOverride.hashCode();
      return 37 * num5 + this.tickUnit.hashCode();
    }
  }
}
