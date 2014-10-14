// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.NumberAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

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
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class NumberAxis : ValueAxis, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 2805933088476185789L;
    public const bool DEFAULT_AUTO_RANGE_INCLUDES_ZERO = true;
    public const bool DEFAULT_AUTO_RANGE_STICKY_ZERO = true;
    internal static NumberTickUnit __\u003C\u003EDEFAULT_TICK_UNIT;
    public const bool DEFAULT_VERTICAL_TICK_LABELS = false;
    private RangeType rangeType;
    private bool autoRangeIncludesZero;
    private bool autoRangeStickyZero;
    private NumberTickUnit tickUnit;
    private NumberFormat numberFormatOverride;
    private MarkerAxisBand markerBand;

    [Modifiers]
    public static NumberTickUnit DEFAULT_TICK_UNIT
    {
      [HideFromJava] get
      {
        return NumberAxis.__\u003C\u003EDEFAULT_TICK_UNIT;
      }
    }

    [LineNumberTable((ushort) 150)]
    static NumberAxis()
    {
      ValueAxis.__\u003Cclinit\u003E();
      NumberAxis.__\u003C\u003EDEFAULT_TICK_UNIT = new NumberTickUnit(1.0, (NumberFormat) new DecimalFormat("0"));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 110, (byte) 107, (byte) 103, (byte) 103, (byte) 107, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberAxis(string label)
      : base(label, NumberAxis.createStandardTickUnits())
    {
      NumberAxis numberAxis = this;
      this.rangeType = RangeType.__\u003C\u003EFULL;
      this.autoRangeIncludesZero = true;
      this.autoRangeStickyZero = true;
      this.tickUnit = NumberAxis.__\u003C\u003EDEFAULT_TICK_UNIT;
      this.numberFormatOverride = (NumberFormat) null;
      this.markerBand = (MarkerAxisBand) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberAxis()
      : this((string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected NumberAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] NumberAxis obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] NumberAxis obj0)
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 78, (byte) 98, (byte) 105, (byte) 103, (byte) 104, (byte) 134, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoRangeIncludesZero(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.autoRangeIncludesZero ? 1 : 0) == num)
        return;
      this.autoRangeIncludesZero = num != 0;
      if (this.isAutoRange())
        this.autoAdjustRange();
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 160, (byte) 102, (byte) 107, (byte) 107, (byte) 114, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createIntegerTickUnits()
    {
      TickUnits tickUnits = new TickUnits();
      DecimalFormat decimalFormat1 = new DecimalFormat("0");
      DecimalFormat decimalFormat2 = new DecimalFormat("#,##0");
      tickUnits.add((TickUnit) new NumberTickUnit(1.0, (NumberFormat) decimalFormat1, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2.0, (NumberFormat) decimalFormat1, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5.0, (NumberFormat) decimalFormat1, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10.0, (NumberFormat) decimalFormat1, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(20.0, (NumberFormat) decimalFormat1, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(50.0, (NumberFormat) decimalFormat1, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(100.0, (NumberFormat) decimalFormat1, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(200.0, (NumberFormat) decimalFormat1, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(500.0, (NumberFormat) decimalFormat1, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5000.0, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(20000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(50000.0, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(100000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(200000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(500000.0, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000.0, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(20000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(50000000.0, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(100000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(200000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(500000000.0, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2000000000.0, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000000.0, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000000.0, (NumberFormat) decimalFormat2, 2));
      return (TickUnitSource) tickUnits;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 72, (byte) 102, (byte) 107, (byte) 107, (byte) 107, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 204, (byte) 118, (byte) 118, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 115, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 151, (byte) 118, (byte) 118, (byte) 118, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 151, (byte) 118, (byte) 118, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 119, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createStandardTickUnits()
    {
      TickUnits tickUnits = new TickUnits();
      DecimalFormat decimalFormat1 = new DecimalFormat("0.00000000");
      DecimalFormat decimalFormat2 = new DecimalFormat("0.0000000");
      DecimalFormat decimalFormat3 = new DecimalFormat("0.000000");
      DecimalFormat decimalFormat4 = new DecimalFormat("0.00000");
      DecimalFormat decimalFormat5 = new DecimalFormat("0.0000");
      DecimalFormat decimalFormat6 = new DecimalFormat("0.000");
      DecimalFormat decimalFormat7 = new DecimalFormat("0.00");
      DecimalFormat decimalFormat8 = new DecimalFormat("0.0");
      DecimalFormat decimalFormat9 = new DecimalFormat("#,##0");
      DecimalFormat decimalFormat10 = new DecimalFormat("#,###,##0");
      DecimalFormat decimalFormat11 = new DecimalFormat("#,###,###,##0");
      tickUnits.add((TickUnit) new NumberTickUnit(1E-07, (NumberFormat) decimalFormat2, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1E-06, (NumberFormat) decimalFormat3, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1E-05, (NumberFormat) decimalFormat4, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.0001, (NumberFormat) decimalFormat5, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.001, (NumberFormat) decimalFormat6, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.01, (NumberFormat) decimalFormat7, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.1, (NumberFormat) decimalFormat8, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1.0, (NumberFormat) decimalFormat9, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10.0, (NumberFormat) decimalFormat9, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(100.0, (NumberFormat) decimalFormat9, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1000.0, (NumberFormat) decimalFormat9, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10000.0, (NumberFormat) decimalFormat9, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(100000.0, (NumberFormat) decimalFormat9, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000.0, (NumberFormat) decimalFormat10, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000.0, (NumberFormat) decimalFormat10, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(100000000.0, (NumberFormat) decimalFormat10, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000000.0, (NumberFormat) decimalFormat11, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000000.0, (NumberFormat) decimalFormat11, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(100000000000.0, (NumberFormat) decimalFormat11, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5E-07, (NumberFormat) decimalFormat1, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5E-06, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5E-05, (NumberFormat) decimalFormat3, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.00025, (NumberFormat) decimalFormat4, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1.0 / 400.0, (NumberFormat) decimalFormat5, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.025, (NumberFormat) decimalFormat6, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.25, (NumberFormat) decimalFormat7, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5, (NumberFormat) decimalFormat8, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(250.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2500.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25000.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(250000.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2500000.0, (NumberFormat) decimalFormat10, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25000000.0, (NumberFormat) decimalFormat10, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(250000000.0, (NumberFormat) decimalFormat10, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2500000000.0, (NumberFormat) decimalFormat11, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25000000000.0, (NumberFormat) decimalFormat11, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(250000000000.0, (NumberFormat) decimalFormat11, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5E-07, (NumberFormat) decimalFormat2, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5E-06, (NumberFormat) decimalFormat3, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5E-05, (NumberFormat) decimalFormat4, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.0005, (NumberFormat) decimalFormat5, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.005, (NumberFormat) decimalFormat6, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.05, (NumberFormat) decimalFormat7, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.5, (NumberFormat) decimalFormat8, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(500.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5000.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50000.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(500000.0, (NumberFormat) decimalFormat9, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000.0, (NumberFormat) decimalFormat10, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50000000.0, (NumberFormat) decimalFormat10, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(500000000.0, (NumberFormat) decimalFormat10, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000000.0, (NumberFormat) decimalFormat11, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50000000000.0, (NumberFormat) decimalFormat11, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(500000000000.0, (NumberFormat) decimalFormat11, 5));
      return (TickUnitSource) tickUnits;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 103, (byte) 99, (byte) 161, (byte) 107, (byte) 135, (byte) 104, (byte) 99, (byte) 167, (byte) 104, (byte) 105, (byte) 109, (byte) 111, (byte) 143, (byte) 109, (byte) 111, (byte) 173, (byte) 104, (byte) 111, (byte) 141, (byte) 167, (byte) 105, (byte) 105, (byte) 204, (byte) 105, (byte) 105, (byte) 114, (byte) 102, (byte) 104, (byte) 101, (byte) 116, (byte) 104, (byte) 134, (byte) 109, (byte) 105, (byte) 102, (byte) 169, (byte) 109, (byte) 104, (byte) 103, (byte) 230, (byte) 69, (byte) 107, (byte) 104, (byte) 185, (byte) 141, (byte) 105, (byte) 187, (byte) 209, (byte) 109, (byte) 207, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void autoAdjustRange()
    {
      Plot plot = this.getPlot();
      if (plot == null || !(plot is ValueAxisPlot))
        return;
      Range range = ((ValueAxisPlot) plot).getDataRange((ValueAxis) this) ?? this.getDefaultAutoRange();
      double upper = range.getUpperBound();
      double num1 = range.getLowerBound();
      if (this.rangeType == RangeType.__\u003C\u003EPOSITIVE)
      {
        num1 = Math.max(0.0, num1);
        upper = Math.max(0.0, upper);
      }
      else if (this.rangeType == RangeType.__\u003C\u003ENEGATIVE)
      {
        num1 = Math.min(0.0, num1);
        upper = Math.min(0.0, upper);
      }
      if (this.getAutoRangeIncludesZero())
      {
        num1 = Math.min(num1, 0.0);
        upper = Math.max(upper, 0.0);
      }
      double num2 = upper - num1;
      double fixedAutoRange = this.getFixedAutoRange();
      double lower;
      if (fixedAutoRange > 0.0)
      {
        lower = upper - fixedAutoRange;
      }
      else
      {
        double rangeMinimumSize = this.getAutoRangeMinimumSize();
        if (num2 < rangeMinimumSize)
        {
          double num3 = (rangeMinimumSize - num2) / 2.0;
          upper += num3;
          num1 -= num3;
          if (num1 == upper)
          {
            double num4 = Math.abs(num1) / 10.0;
            num1 -= num4;
            upper += num4;
          }
          if (this.rangeType == RangeType.__\u003C\u003EPOSITIVE)
          {
            if (num1 < 0.0)
            {
              upper -= num1;
              num1 = 0.0;
            }
          }
          else if (this.rangeType == RangeType.__\u003C\u003ENEGATIVE && upper > 0.0)
          {
            num1 -= upper;
            upper = 0.0;
          }
        }
        if (this.getAutoRangeStickyZero())
        {
          if (upper <= 0.0)
            upper = Math.min(0.0, upper + this.getUpperMargin() * num2);
          else
            upper += this.getUpperMargin() * num2;
          lower = num1 < 0.0 ? num1 - this.getLowerMargin() * num2 : Math.max(0.0, num1 - this.getLowerMargin() * num2);
        }
        else
        {
          upper += this.getUpperMargin() * num2;
          lower = num1 - this.getLowerMargin() * num2;
        }
      }
      this.setRange(new Range(lower, upper), false, false);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 56, (byte) 68, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 174})]
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

    public virtual bool getAutoRangeIncludesZero()
    {
      return this.autoRangeIncludesZero;
    }

    public virtual bool getAutoRangeStickyZero()
    {
      return this.autoRangeStickyZero;
    }

    public virtual NumberTickUnit getTickUnit()
    {
      return this.tickUnit;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 253, (byte) 102, (byte) 105, (byte) 141, (byte) 105, (byte) 139})]
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

    public virtual NumberFormat getNumberFormatOverride()
    {
      return this.numberFormatOverride;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 176, (byte) 207, (byte) 103, (byte) 109, (byte) 176, (byte) 141, (byte) 143, (byte) 146, (byte) 107, (byte) 101, (byte) 175, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectHorizontalAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      double num1 = this.estimateMaximumTickLabelWidth(g2, (TickUnit) this.getTickUnit());
      TickUnitSource standardTickUnits = this.getStandardTickUnits();
      TickUnit ceilingTickUnit = standardTickUnits.getCeilingTickUnit((TickUnit) this.getTickUnit());
      double num2 = this.lengthToJava2D(ceilingTickUnit.getSize(), dataArea, edge);
      double d = num1 / num2 * ceilingTickUnit.getSize();
      NumberTickUnit unit = (NumberTickUnit) standardTickUnits.getCeilingTickUnit(d);
      double num3 = this.lengthToJava2D(unit.getSize(), dataArea, edge);
      if (this.estimateMaximumTickLabelWidth(g2, (TickUnit) unit) > num3)
        unit = (NumberTickUnit) standardTickUnits.getLargerTickUnit((TickUnit) unit);
      this.setTickUnit(unit, false, false);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 213, (byte) 169, (byte) 103, (byte) 109, (byte) 176, (byte) 141, (byte) 143, (byte) 146, (byte) 105, (byte) 101, (byte) 175, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectVerticalAutoTickUnit(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      double num1 = this.estimateMaximumTickLabelHeight(g2);
      TickUnitSource standardTickUnits = this.getStandardTickUnits();
      TickUnit ceilingTickUnit = standardTickUnits.getCeilingTickUnit((TickUnit) this.getTickUnit());
      double num2 = this.lengthToJava2D(ceilingTickUnit.getSize(), dataArea, edge);
      double d = num1 / num2 * ceilingTickUnit.getSize();
      NumberTickUnit unit = (NumberTickUnit) standardTickUnits.getCeilingTickUnit(d);
      double num3 = this.lengthToJava2D(unit.getSize(), dataArea, edge);
      if (this.estimateMaximumTickLabelHeight(g2) > num3)
        unit = (NumberTickUnit) standardTickUnits.getLargerTickUnit((TickUnit) unit);
      this.setTickUnit(unit, false, false);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 105, (byte) 103, (byte) 143, (byte) 168, (byte) 103, (byte) 114, (byte) 107, (byte) 165, (byte) 110, (byte) 104, (byte) 106, (byte) 106, (byte) 102, (byte) 102, (byte) 104, (byte) 100, (byte) 107, (byte) 173, (byte) 106, (byte) 138, (byte) 108, (byte) 108, (byte) 173})]
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

    [LineNumberTable(new byte[] {(byte) 163, (byte) 79, (byte) 103, (byte) 143, (byte) 103, (byte) 103, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double estimateMaximumTickLabelHeight(Graphics2D g2)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      return tickLabelInsets.getTop() + tickLabelInsets.getBottom() + (double) this.getTickLabelFont().getLineMetrics("123", g2.getFontRenderContext()).getHeight();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 21, (byte) 134, (byte) 103, (byte) 135, (byte) 104, (byte) 169, (byte) 103, (byte) 104, (byte) 104, (byte) 137, (byte) 108, (byte) 104, (byte) 101, (byte) 136, (byte) 105, (byte) 143, (byte) 111, (byte) 255, (byte) 8, (byte) 60, (byte) 232, (byte) 73, (byte) 108, (byte) 139, (byte) 104, (byte) 100, (byte) 173, (byte) 143, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 173, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 199, (byte) 150, (byte) 105, (byte) 109, (byte) 137, (byte) 179, (byte) 111, (byte) 255, (byte) 8, (byte) 59, (byte) 232, (byte) 25, (byte) 235, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshTicksHorizontal(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      NumberTickUnit tickUnit = this.getTickUnit();
      double size = tickUnit.getSize();
      int num1 = this.calculateVisibleTickCount();
      double num2 = this.calculateLowestVisibleTickValue();
      if (num1 <= 500)
      {
        int minorTickCount = this.getMinorTickCount();
        if (minorTickCount <= 0)
          minorTickCount = tickUnit.getMinorTickCount();
        for (int index = 1; index < minorTickCount; ++index)
        {
          double num3 = num2 - size * (double) index / (double) minorTickCount;
          if (this.getRange().contains(num3))
            ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMINOR, num3, "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
        }
        for (int index1 = 0; index1 < num1; ++index1)
        {
          double num3 = num2 + (double) index1 * size;
          NumberFormat numberFormatOverride = this.getNumberFormatOverride();
          string label = numberFormatOverride == null ? this.getTickUnit().valueToString(num3) : numberFormatOverride.format(num3);
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
          NumberTick numberTick = new NumberTick((Number) new Double(num3), label, textAnchor, rotationAnchor, angle);
          ((List) arrayList).add((object) numberTick);
          double num4 = num2 + (double) (index1 + 1) * size;
          for (int index2 = 1; index2 < minorTickCount; ++index2)
          {
            double num5 = num3 + (num4 - num3) * (double) index2 / (double) minorTickCount;
            if (this.getRange().contains(num5))
              ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMINOR, num5, "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
          }
        }
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 117, (byte) 102, (byte) 134, (byte) 103, (byte) 103, (byte) 104, (byte) 169, (byte) 103, (byte) 104, (byte) 104, (byte) 137, (byte) 108, (byte) 104, (byte) 101, (byte) 136, (byte) 105, (byte) 143, (byte) 111, (byte) 255, (byte) 8, (byte) 60, (byte) 232, (byte) 74, (byte) 108, (byte) 139, (byte) 104, (byte) 100, (byte) 173, (byte) 175, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 104, (byte) 103, (byte) 103, (byte) 173, (byte) 103, (byte) 103, (byte) 205, (byte) 104, (byte) 103, (byte) 169, (byte) 103, (byte) 199, (byte) 150, (byte) 137, (byte) 109, (byte) 137, (byte) 179, (byte) 111, (byte) 255, (byte) 8, (byte) 59, (byte) 232, (byte) 21, (byte) 235, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshTicksVertical(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      ((List) arrayList).clear();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      NumberTickUnit tickUnit = this.getTickUnit();
      double size = tickUnit.getSize();
      int num1 = this.calculateVisibleTickCount();
      double num2 = this.calculateLowestVisibleTickValue();
      if (num1 <= 500)
      {
        int minorTickCount = this.getMinorTickCount();
        if (minorTickCount <= 0)
          minorTickCount = tickUnit.getMinorTickCount();
        for (int index = 1; index < minorTickCount; ++index)
        {
          double num3 = num2 - size * (double) index / (double) minorTickCount;
          if (this.getRange().contains(num3))
            ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMINOR, num3, "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
        }
        for (int index1 = 0; index1 < num1; ++index1)
        {
          double num3 = num2 + (double) index1 * size;
          NumberFormat numberFormatOverride = this.getNumberFormatOverride();
          string label = numberFormatOverride == null ? this.getTickUnit().valueToString(num3) : numberFormatOverride.format(num3);
          double angle = 0.0;
          TextAnchor textAnchor;
          TextAnchor rotationAnchor;
          if (this.isVerticalTickLabels())
          {
            if (edge == RectangleEdge.__\u003C\u003ELEFT)
            {
              textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
              rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
              angle = -1.0 * Math.PI / 2.0;
            }
            else
            {
              textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
              rotationAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
              angle = Math.PI / 2.0;
            }
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
          NumberTick numberTick = new NumberTick((Number) new Double(num3), label, textAnchor, rotationAnchor, angle);
          ((List) arrayList).add((object) numberTick);
          double num4 = num2 + (double) (index1 + 1) * size;
          for (int index2 = 1; index2 < minorTickCount; ++index2)
          {
            double num5 = num3 + (num4 - num3) * (double) index2 / (double) minorTickCount;
            if (this.getRange().contains(num5))
              ((List) arrayList).add((object) new NumberTick(TickType.__\u003C\u003EMINOR, num5, "", TextAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0));
          }
        }
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 154, (byte) 104, (byte) 139, (byte) 104, (byte) 171})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 2, (byte) 109, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int calculateVisibleTickCount()
    {
      double size = this.getTickUnit().getSize();
      Range range = this.getRange();
      return ByteCodeHelper.d2i(Math.floor(range.getUpperBound() / size) - Math.ceil(range.getLowerBound() / size) + 1.0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 230, (byte) 109, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateLowestVisibleTickValue()
    {
      double size = this.getTickUnit().getSize();
      return Math.ceil(this.getRange().getLowerBound() / size) * size;
    }

    public virtual RangeType getRangeType()
    {
      return this.rangeType;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeType(RangeType rangeType)
    {
      if (rangeType == null)
      {
        string str = "Null 'rangeType' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeType = rangeType;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 71, (byte) 162, (byte) 105, (byte) 103, (byte) 104, (byte) 134, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoRangeStickyZero(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.autoRangeStickyZero ? 1 : 0) == num)
        return;
      this.autoRangeStickyZero = num != 0;
      if (this.isAutoRange())
        this.autoAdjustRange();
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 213, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickUnit(NumberTickUnit unit)
    {
      this.setTickUnit(unit, true, true);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNumberFormatOverride(NumberFormat formatter)
    {
      this.numberFormatOverride = formatter;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual MarkerAxisBand getMarkerBand()
    {
      return this.markerBand;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 34, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMarkerBand(MarkerAxisBand band)
    {
      this.markerBand = band;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 43, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void configure()
    {
      if (!this.isAutoRange())
        return;
      this.autoAdjustRange();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 156, (byte) 103, (byte) 104, (byte) 136, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 105, (byte) 136, (byte) 104, (byte) 209})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double valueToJava2D(double value, Rectangle2D area, RectangleEdge edge)
    {
      Range range = this.getRange();
      double lowerBound = range.getLowerBound();
      double upperBound = range.getUpperBound();
      double num1 = 0.0;
      double num2 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num1 = ((RectangularShape) area).getX();
        num2 = ((RectangularShape) area).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num2 = ((RectangularShape) area).getMinY();
        num1 = ((RectangularShape) area).getMaxY();
      }
      if (this.isInverted())
        return num2 - (value - lowerBound) / (upperBound - lowerBound) * (num2 - num1);
      else
        return num1 + (value - lowerBound) / (upperBound - lowerBound) * (num2 - num1);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 196, (byte) 103, (byte) 104, (byte) 136, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 104, (byte) 137, (byte) 104, (byte) 208})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double java2DToValue(double java2DValue, Rectangle2D area, RectangleEdge edge)
    {
      Range range = this.getRange();
      double lowerBound = range.getLowerBound();
      double upperBound = range.getUpperBound();
      double num1 = 0.0;
      double num2 = 0.0;
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
      if (this.isInverted())
        return upperBound - (java2DValue - num1) / (num2 - num1) * (upperBound - lowerBound);
      else
        return lowerBound + (java2DValue - num1) / (num2 - num1) * (upperBound - lowerBound);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 245, (byte) 109, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateHighestVisibleTickValue()
    {
      double size = this.getTickUnit().getSize();
      return Math.floor(this.getRange().getUpperBound() / size) * size;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 29, (byte) 130, (byte) 104, (byte) 168, (byte) 109, (byte) 103, (byte) 194, (byte) 239, (byte) 75, (byte) 116, (byte) 111})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 214, (byte) 102, (byte) 167, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 114, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 150, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 150, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createStandardTickUnits(Locale locale)
    {
      TickUnits tickUnits = new TickUnits();
      NumberFormat numberInstance = NumberFormat.getNumberInstance(locale);
      tickUnits.add((TickUnit) new NumberTickUnit(1E-07, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1E-06, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1E-05, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.0001, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.001, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.01, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(0.1, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(100.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(100000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(100000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5E-07, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5E-06, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5E-05, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.00025, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1.0 / 400.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.025, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.25, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2.5, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(250.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2500.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(250000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2500000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(250000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(2500000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(25000000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5E-07, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5E-06, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5E-05, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.0005, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.005, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.05, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(0.5, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(500.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(500000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(500000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(50000000000.0, numberInstance, 5));
      return (TickUnitSource) tickUnits;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 34, (byte) 102, (byte) 103, (byte) 114, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TickUnitSource createIntegerTickUnits(Locale locale)
    {
      TickUnits tickUnits = new TickUnits();
      NumberFormat numberInstance = NumberFormat.getNumberInstance(locale);
      tickUnits.add((TickUnit) new NumberTickUnit(1.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(20.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(50.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(100.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(200.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(500.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(20000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(50000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(100000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(200000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(500000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(20000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(50000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(100000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(200000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(500000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(1000000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(2000000000.0, numberInstance, 2));
      tickUnits.add((TickUnit) new NumberTickUnit(5000000000.0, numberInstance, 5));
      tickUnits.add((TickUnit) new NumberTickUnit(10000000000.0, numberInstance, 2));
      return (TickUnitSource) tickUnits;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 214, (byte) 108, (byte) 104, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      NumberAxis numberAxis = (NumberAxis) base.clone();
      if (this.numberFormatOverride != null)
        numberAxis.numberFormatOverride = (NumberFormat) this.numberFormatOverride.clone();
      return (object) numberAxis;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 230, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is NumberAxis))
        return false;
      NumberAxis numberAxis = (NumberAxis) obj;
      if (this.autoRangeIncludesZero != numberAxis.autoRangeIncludesZero || this.autoRangeStickyZero != numberAxis.autoRangeStickyZero || (!ObjectUtilities.equal((object) this.tickUnit, (object) numberAxis.tickUnit) || !ObjectUtilities.equal((object) this.numberFormatOverride, (object) numberAxis.numberFormatOverride)) || !this.rangeType.equals((object) numberAxis.rangeType))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 6, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.getLabel() == null)
        return 0;
      return String.instancehelper_hashCode(this.getLabel());
    }
  }
}
