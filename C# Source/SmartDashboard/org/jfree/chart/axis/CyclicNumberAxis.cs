// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CyclicNumberAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart.plot;
using org.jfree.data;
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
  [Serializable]
  public class CyclicNumberAxis : NumberAxis
  {
    internal const long serialVersionUID = -7514160997164582554L;
    public static Stroke DEFAULT_ADVANCE_LINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_ADVANCE_LINE_PAINT;
    protected internal double offset;
    protected internal double period;
    protected internal bool boundMappedToLastCycle;
    protected internal bool advanceLineVisible;
    [NonSerialized]
    protected internal Stroke advanceLineStroke;
    [NonSerialized]
    protected internal Paint advanceLinePaint;
    [NonSerialized]
    private bool internalMarkerWhenTicksOverlap;
    [NonSerialized]
    private Tick internalMarkerCycleBoundTick;

    [Modifiers]
    public static Paint DEFAULT_ADVANCE_LINE_PAINT
    {
      [HideFromJava] get
      {
        return CyclicNumberAxis.__\u003C\u003EDEFAULT_ADVANCE_LINE_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 110, (byte) 165, (byte) 175})]
    static CyclicNumberAxis()
    {
      NumberAxis.__\u003Cclinit\u003E();
      CyclicNumberAxis.DEFAULT_ADVANCE_LINE_STROKE = (Stroke) new BasicStroke(1f);
      CyclicNumberAxis.__\u003C\u003EDEFAULT_ADVANCE_LINE_PAINT = (Paint) Color.gray;
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicNumberAxis(double period, double offset)
      : this(period, offset, (string) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 233, (byte) 19, (byte) 235, (byte) 110, (byte) 105, (byte) 105, (byte) 104, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicNumberAxis(double period, double offset, string label)
      : base(label)
    {
      CyclicNumberAxis cyclicNumberAxis = this;
      this.advanceLineStroke = CyclicNumberAxis.DEFAULT_ADVANCE_LINE_STROKE;
      this.period = period;
      this.offset = offset;
      this.setFixedAutoRange(period);
      this.advanceLineVisible = true;
      this.advanceLinePaint = CyclicNumberAxis.__\u003C\u003EDEFAULT_ADVANCE_LINE_PAINT;
    }

    [LineNumberTable(new byte[] {(byte) 113, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicNumberAxis(double period)
      : this(period, 0.0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicNumberAxis(double period, string label)
      : this(0.0, period, label)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CyclicNumberAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 252, (byte) 105, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setFixedAutoRange(double length)
    {
      this.period = length;
      base.setFixedAutoRange(length);
    }

    [LineNumberTable((ushort) 912)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCycleBound()
    {
      return Math.floor((this.getRange().getUpperBound() - this.offset) / this.period) * this.period + this.offset;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 170, (byte) 135, (byte) 104, (byte) 104, (byte) 136, (byte) 106, (byte) 202, (byte) 103, (byte) 103, (byte) 104, (byte) 105, (byte) 139, (byte) 104, (byte) 105, (byte) 169, (byte) 104, (byte) 101, (byte) 143, (byte) 101, (byte) 181, (byte) 213, (byte) 101, (byte) 143, (byte) 101, (byte) 181})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double valueToJava2D(double value, Rectangle2D dataArea, RectangleEdge edge)
    {
      Range range = this.getRange();
      double lowerBound = range.getLowerBound();
      double upperBound = range.getUpperBound();
      double cycleBound = this.getCycleBound();
      if (value < lowerBound || value > upperBound)
        return double.NaN;
      double num1 = 0.0;
      double num2 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num1 = ((RectangularShape) dataArea).getMinX();
        num2 = ((RectangularShape) dataArea).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num2 = ((RectangularShape) dataArea).getMinY();
        num1 = ((RectangularShape) dataArea).getMaxY();
      }
      if (this.isInverted())
      {
        if (value == cycleBound)
        {
          if (this.boundMappedToLastCycle)
            return num1;
          else
            return num2;
        }
        else if (value > cycleBound)
          return num2 - (value - cycleBound) * (num2 - num1) / this.period;
        else
          return num1 + (cycleBound - value) * (num2 - num1) / this.period;
      }
      else if (value == cycleBound)
      {
        if (this.boundMappedToLastCycle)
          return num2;
        else
          return num1;
      }
      else if (value >= cycleBound)
        return num1 + (value - cycleBound) * (num2 - num1) / this.period;
      else
        return num2 - (cycleBound - value) * (num2 - num1) / this.period;
    }

    public virtual bool isAdvanceLineVisible()
    {
      return this.advanceLineVisible;
    }

    public virtual Stroke getAdvanceLineStroke()
    {
      return this.advanceLineStroke;
    }

    public virtual Paint getAdvanceLinePaint()
    {
      return this.advanceLinePaint;
    }

    public virtual void setAdvanceLineVisible(bool visible)
    {
      this.advanceLineVisible = visible;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAdvanceLinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.advanceLinePaint = paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAdvanceLineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.advanceLineStroke = stroke;
    }

    public virtual bool isBoundMappedToLastCycle()
    {
      return this.boundMappedToLastCycle;
    }

    public virtual void setBoundMappedToLastCycle(bool boundMappedToLastCycle)
    {
      this.boundMappedToLastCycle = boundMappedToLastCycle;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 207, (byte) 182, (byte) 251, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectHorizontalAutoTickUnit(Graphics2D g2, Rectangle2D drawArea, Rectangle2D dataArea, RectangleEdge edge)
    {
      this.setTickUnit((NumberTickUnit) this.getStandardTickUnits().getCeilingTickUnit(this.getRange().getLength() * this.estimateMaximumTickLabelWidth(g2, (TickUnit) this.getTickUnit()) / ((RectangularShape) dataArea).getWidth()), false, false);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 207, (byte) 182, (byte) 251, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void selectVerticalAutoTickUnit(Graphics2D g2, Rectangle2D drawArea, Rectangle2D dataArea, RectangleEdge edge)
    {
      this.setTickUnit((NumberTickUnit) this.getStandardTickUnits().getCeilingTickUnit(this.getRange().getLength() * this.estimateMaximumTickLabelWidth(g2, (TickUnit) this.getTickUnit()) / ((RectangularShape) dataArea).getHeight()), false, false);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 104, (byte) 103, (byte) 145, (byte) 173, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override float[] calculateAnchorPoint(ValueTick tick, double cursor, Rectangle2D dataArea, RectangleEdge edge)
    {
      if (tick is CyclicNumberAxis.CycleBoundTick)
      {
        int num = this.boundMappedToLastCycle ? 1 : 0;
        this.boundMappedToLastCycle = ((CyclicNumberAxis.CycleBoundTick) tick).mapToLastCycle;
        float[] numArray = base.calculateAnchorPoint(tick, cursor, dataArea, edge);
        this.boundMappedToLastCycle = num != 0;
        return numArray;
      }
      else
        return base.calculateAnchorPoint(tick, cursor, dataArea, edge);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 57, (byte) 134, (byte) 103, (byte) 135, (byte) 104, (byte) 169, (byte) 109, (byte) 104, (byte) 109, (byte) 110, (byte) 131, (byte) 104, (byte) 135, (byte) 99, (byte) 135, (byte) 101, (byte) 105, (byte) 99, (byte) 167, (byte) 169, (byte) 99, (byte) 108, (byte) 163, (byte) 141, (byte) 104, (byte) 100, (byte) 173, (byte) 143, (byte) 101, (byte) 98, (byte) 98, (byte) 103, (byte) 107, (byte) 104, (byte) 173, (byte) 139, (byte) 135, (byte) 152, (byte) 150, (byte) 111, (byte) 255, (byte) 12, (byte) 69, (byte) 103, (byte) 182, (byte) 169, (byte) 107, (byte) 103, (byte) 152, (byte) 150, (byte) 111, (byte) 255, (byte) 12, (byte) 69, (byte) 103, (byte) 182, (byte) 169, (byte) 103, (byte) 152, (byte) 150, (byte) 111, (byte) 255, (byte) 12, (byte) 69, (byte) 103, (byte) 182, (byte) 196, (byte) 252, (byte) 69, (byte) 101, (byte) 136, (byte) 105, (byte) 100, (byte) 132, (byte) 135, (byte) 100, (byte) 105, (byte) 99, (byte) 99, (byte) 167, (byte) 101, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override List refreshTicksHorizontal(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      double size = this.getTickUnit().getSize();
      double cycleBound = this.getCycleBound();
      double num1 = Math.ceil(cycleBound / size) * size;
      double num2 = this.getRange().getUpperBound();
      int num3 = 0;
      int num4 = this.boundMappedToLastCycle ? 1 : 0;
      this.boundMappedToLastCycle = false;
      CyclicNumberAxis.CycleBoundTick cycleBoundTick1 = (CyclicNumberAxis.CycleBoundTick) null;
      float num5 = 0.0f;
      if (num2 == cycleBound)
      {
        num1 = this.calculateLowestVisibleTickValue();
        num3 = 1;
        this.boundMappedToLastCycle = true;
      }
      while (num1 <= num2)
      {
        int num6 = 0;
        if (num1 + size > num2 && num3 == 0)
          num6 = 1;
        double num7 = this.valueToJava2D(num1, dataArea, edge);
        NumberFormat numberFormatOverride = this.getNumberFormatOverride();
        string label = numberFormatOverride == null ? this.getTickUnit().valueToString(num1) : numberFormatOverride.format(num1);
        float num8 = (float) num7;
        double angle = 0.0;
        TextAnchor textAnchor1;
        TextAnchor rotationAnchor;
        if (this.isVerticalTickLabels())
        {
          angle = edge != RectangleEdge.__\u003C\u003ETOP ? -1.0 * Math.PI / 2.0 : Math.PI / 2.0;
          textAnchor1 = TextAnchor.__\u003C\u003ECENTER_RIGHT;
          if (cycleBoundTick1 != null && (double) num5 == (double) num8 && num1 != cycleBound)
          {
            TextAnchor textAnchor2 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_RIGHT : TextAnchor.__\u003C\u003ETOP_RIGHT;
            ((List) arrayList).remove(((List) arrayList).size() - 1);
            ((List) arrayList).add((object) new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, cycleBoundTick1.getNumber(), cycleBoundTick1.getText(), textAnchor2, textAnchor2, cycleBoundTick1.getAngle()));
            this.internalMarkerWhenTicksOverlap = true;
            textAnchor1 = !this.isInverted() ? TextAnchor.__\u003C\u003ETOP_RIGHT : TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
          }
          rotationAnchor = textAnchor1;
        }
        else if (edge == RectangleEdge.__\u003C\u003ETOP)
        {
          textAnchor1 = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
          if (cycleBoundTick1 != null && (double) num5 == (double) num8 && num1 != cycleBound)
          {
            TextAnchor textAnchor2 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_RIGHT : TextAnchor.__\u003C\u003EBOTTOM_LEFT;
            ((List) arrayList).remove(((List) arrayList).size() - 1);
            ((List) arrayList).add((object) new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, cycleBoundTick1.getNumber(), cycleBoundTick1.getText(), textAnchor2, textAnchor2, cycleBoundTick1.getAngle()));
            this.internalMarkerWhenTicksOverlap = true;
            textAnchor1 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_LEFT : TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
          }
          rotationAnchor = textAnchor1;
        }
        else
        {
          textAnchor1 = TextAnchor.__\u003C\u003ETOP_CENTER;
          if (cycleBoundTick1 != null && (double) num5 == (double) num8 && num1 != cycleBound)
          {
            TextAnchor textAnchor2 = !this.isInverted() ? TextAnchor.__\u003C\u003ETOP_RIGHT : TextAnchor.__\u003C\u003ETOP_LEFT;
            ((List) arrayList).remove(((List) arrayList).size() - 1);
            ((List) arrayList).add((object) new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, cycleBoundTick1.getNumber(), cycleBoundTick1.getText(), textAnchor2, textAnchor2, cycleBoundTick1.getAngle()));
            this.internalMarkerWhenTicksOverlap = true;
            textAnchor1 = !this.isInverted() ? TextAnchor.__\u003C\u003ETOP_LEFT : TextAnchor.__\u003C\u003ETOP_RIGHT;
          }
          rotationAnchor = textAnchor1;
        }
        CyclicNumberAxis.CycleBoundTick cycleBoundTick2 = new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, (Number) new Double(num1), label, textAnchor1, rotationAnchor, angle);
        if (num1 == cycleBound)
          this.internalMarkerCycleBoundTick = (Tick) cycleBoundTick2;
        ((List) arrayList).add((object) cycleBoundTick2);
        cycleBoundTick1 = cycleBoundTick2;
        num5 = num8;
        num1 += size;
        if (num6 != 0)
        {
          num1 = this.calculateLowestVisibleTickValue();
          num2 = cycleBound;
          num3 = 1;
          this.boundMappedToLastCycle = true;
        }
      }
      this.boundMappedToLastCycle = num4 != 0;
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 210, (byte) 102, (byte) 134, (byte) 103, (byte) 103, (byte) 104, (byte) 169, (byte) 109, (byte) 104, (byte) 109, (byte) 110, (byte) 131, (byte) 104, (byte) 135, (byte) 99, (byte) 135, (byte) 101, (byte) 105, (byte) 99, (byte) 167, (byte) 169, (byte) 99, (byte) 108, (byte) 163, (byte) 141, (byte) 104, (byte) 100, (byte) 173, (byte) 175, (byte) 101, (byte) 98, (byte) 98, (byte) 103, (byte) 139, (byte) 107, (byte) 103, (byte) 152, (byte) 150, (byte) 111, (byte) 255, (byte) 12, (byte) 69, (byte) 103, (byte) 182, (byte) 100, (byte) 176, (byte) 103, (byte) 152, (byte) 150, (byte) 111, (byte) 255, (byte) 12, (byte) 69, (byte) 103, (byte) 182, (byte) 100, (byte) 208, (byte) 107, (byte) 103, (byte) 152, (byte) 150, (byte) 111, (byte) 255, (byte) 12, (byte) 69, (byte) 103, (byte) 182, (byte) 169, (byte) 103, (byte) 152, (byte) 150, (byte) 111, (byte) 255, (byte) 12, (byte) 69, (byte) 103, (byte) 182, (byte) 196, (byte) 220, (byte) 101, (byte) 136, (byte) 105, (byte) 100, (byte) 132, (byte) 101, (byte) 168, (byte) 135, (byte) 100, (byte) 105, (byte) 99, (byte) 99, (byte) 167, (byte) 101, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshVerticalTicks(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      ((List) arrayList).clear();
      Font tickLabelFont = this.getTickLabelFont();
      ((Graphics) g2).setFont(tickLabelFont);
      if (this.isAutoTickUnitSelection())
        this.selectAutoTickUnit(g2, dataArea, edge);
      double size = this.getTickUnit().getSize();
      double cycleBound = this.getCycleBound();
      double num1 = Math.ceil(cycleBound / size) * size;
      double num2 = this.getRange().getUpperBound();
      int num3 = 0;
      int num4 = this.boundMappedToLastCycle ? 1 : 0;
      this.boundMappedToLastCycle = true;
      CyclicNumberAxis.CycleBoundTick cycleBoundTick1 = (CyclicNumberAxis.CycleBoundTick) null;
      float num5 = 0.0f;
      if (num2 == cycleBound)
      {
        num1 = this.calculateLowestVisibleTickValue();
        num3 = 1;
        this.boundMappedToLastCycle = true;
      }
      while (num1 <= num2)
      {
        int num6 = 0;
        if (num1 + size > num2 && num3 == 0)
          num6 = 1;
        double num7 = this.valueToJava2D(num1, dataArea, edge);
        NumberFormat numberFormatOverride = this.getNumberFormatOverride();
        string label = numberFormatOverride == null ? this.getTickUnit().valueToString(num1) : numberFormatOverride.format(num1);
        float num8 = (float) num7;
        double angle = 0.0;
        TextAnchor textAnchor1;
        TextAnchor rotationAnchor;
        if (this.isVerticalTickLabels())
        {
          if (edge == RectangleEdge.__\u003C\u003ELEFT)
          {
            textAnchor1 = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            if (cycleBoundTick1 != null && (double) num5 == (double) num8 && num1 != cycleBound)
            {
              TextAnchor textAnchor2 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_RIGHT : TextAnchor.__\u003C\u003EBOTTOM_LEFT;
              ((List) arrayList).remove(((List) arrayList).size() - 1);
              ((List) arrayList).add((object) new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, cycleBoundTick1.getNumber(), cycleBoundTick1.getText(), textAnchor2, textAnchor2, cycleBoundTick1.getAngle()));
              this.internalMarkerWhenTicksOverlap = true;
              textAnchor1 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_LEFT : TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
            }
            rotationAnchor = textAnchor1;
            angle = -1.0 * Math.PI / 2.0;
          }
          else
          {
            textAnchor1 = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
            if (cycleBoundTick1 != null && (double) num5 == (double) num8 && num1 != cycleBound)
            {
              TextAnchor textAnchor2 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_LEFT : TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
              ((List) arrayList).remove(((List) arrayList).size() - 1);
              ((List) arrayList).add((object) new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, cycleBoundTick1.getNumber(), cycleBoundTick1.getText(), textAnchor2, textAnchor2, cycleBoundTick1.getAngle()));
              this.internalMarkerWhenTicksOverlap = true;
              textAnchor1 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_RIGHT : TextAnchor.__\u003C\u003EBOTTOM_LEFT;
            }
            rotationAnchor = textAnchor1;
            angle = Math.PI / 2.0;
          }
        }
        else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        {
          textAnchor1 = TextAnchor.__\u003C\u003ECENTER_RIGHT;
          if (cycleBoundTick1 != null && (double) num5 == (double) num8 && num1 != cycleBound)
          {
            TextAnchor textAnchor2 = !this.isInverted() ? TextAnchor.__\u003C\u003ETOP_RIGHT : TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
            ((List) arrayList).remove(((List) arrayList).size() - 1);
            ((List) arrayList).add((object) new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, cycleBoundTick1.getNumber(), cycleBoundTick1.getText(), textAnchor2, textAnchor2, cycleBoundTick1.getAngle()));
            this.internalMarkerWhenTicksOverlap = true;
            textAnchor1 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_RIGHT : TextAnchor.__\u003C\u003ETOP_RIGHT;
          }
          rotationAnchor = textAnchor1;
        }
        else
        {
          textAnchor1 = TextAnchor.__\u003C\u003ECENTER_LEFT;
          if (cycleBoundTick1 != null && (double) num5 == (double) num8 && num1 != cycleBound)
          {
            TextAnchor textAnchor2 = !this.isInverted() ? TextAnchor.__\u003C\u003ETOP_LEFT : TextAnchor.__\u003C\u003EBOTTOM_LEFT;
            ((List) arrayList).remove(((List) arrayList).size() - 1);
            ((List) arrayList).add((object) new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, cycleBoundTick1.getNumber(), cycleBoundTick1.getText(), textAnchor2, textAnchor2, cycleBoundTick1.getAngle()));
            this.internalMarkerWhenTicksOverlap = true;
            textAnchor1 = !this.isInverted() ? TextAnchor.__\u003C\u003EBOTTOM_LEFT : TextAnchor.__\u003C\u003ETOP_LEFT;
          }
          rotationAnchor = textAnchor1;
        }
        CyclicNumberAxis.CycleBoundTick cycleBoundTick2 = new CyclicNumberAxis.CycleBoundTick(this.boundMappedToLastCycle, (Number) new Double(num1), label, textAnchor1, rotationAnchor, angle);
        if (num1 == cycleBound)
          this.internalMarkerCycleBoundTick = (Tick) cycleBoundTick2;
        ((List) arrayList).add((object) cycleBoundTick2);
        cycleBoundTick1 = cycleBoundTick2;
        num5 = num8;
        if (num1 == cycleBound)
          this.internalMarkerCycleBoundTick = (Tick) cycleBoundTick2;
        num1 += size;
        if (num6 != 0)
        {
          num1 = this.calculateLowestVisibleTickValue();
          num2 = cycleBound;
          num3 = 1;
          this.boundMappedToLastCycle = false;
        }
      }
      this.boundMappedToLastCycle = num4 != 0;
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 123, (byte) 135, (byte) 104, (byte) 136, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 104, (byte) 169, (byte) 104, (byte) 117, (byte) 102, (byte) 180, (byte) 211, (byte) 116, (byte) 102, (byte) 179})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double java2DToValue(double java2DValue, Rectangle2D dataArea, RectangleEdge edge)
    {
      double upperBound = this.getRange().getUpperBound();
      double cycleBound = this.getCycleBound();
      double num1 = 0.0;
      double num2 = 0.0;
      if (RectangleEdge.isTopOrBottom(edge))
      {
        num1 = ((RectangularShape) dataArea).getMinX();
        num2 = ((RectangularShape) dataArea).getMaxX();
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        num1 = ((RectangularShape) dataArea).getMaxY();
        num2 = ((RectangularShape) dataArea).getMinY();
      }
      if (this.isInverted())
      {
        double num3 = num2 - (upperBound - cycleBound) * (num2 - num1) / this.period;
        if (java2DValue >= num3)
          return cycleBound + (num2 - java2DValue) * this.period / (num2 - num1);
        else
          return cycleBound - (java2DValue - num1) * this.period / (num2 - num1);
      }
      else
      {
        double num3 = (upperBound - cycleBound) * (num2 - num1) / this.period + num1;
        if (java2DValue <= num3)
          return cycleBound + (java2DValue - num1) * this.period / (num2 - num1);
        else
          return cycleBound - (num2 - java2DValue) * this.period / (num2 - num1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 222, (byte) 127, (byte) 15})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void centerRange(double value)
    {
      this.setRange(value - this.period / 2.0, value + this.period / 2.0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 183, (byte) 162, (byte) 106, (byte) 137, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setAutoRangeMinimumSize(double size, bool notify)
    {
      int num = notify ? 1 : 0;
      if (size > this.period)
        this.period = size;
      base.setAutoRangeMinimumSize(size, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 175, (byte) 132, (byte) 111, (byte) 105, (byte) 136, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setRange(Range range, bool turnOffAutoRange, bool notify)
    {
      int num1 = turnOffAutoRange ? 1 : 0;
      int num2 = notify ? 1 : 0;
      double num3 = range.getUpperBound() - range.getLowerBound();
      if (num3 > this.period)
        this.period = num3;
      base.setRange(range, num1 != 0, num2 != 0);
    }

    public virtual double getOffset()
    {
      return this.offset;
    }

    public virtual void setOffset(double offset)
    {
      this.offset = offset;
    }

    public virtual double getPeriod()
    {
      return this.period;
    }

    public virtual void setPeriod(double period)
    {
      this.period = period;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 104, (byte) 103, (byte) 207, (byte) 104, (byte) 162, (byte) 104, (byte) 141, (byte) 104, (byte) 170, (byte) 168, (byte) 102, (byte) 107, (byte) 152, (byte) 99, (byte) 108, (byte) 108, (byte) 105, (byte) 154, (byte) 105, (byte) 151, (byte) 105, (byte) 151, (byte) 105, (byte) 149, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override AxisState drawTickMarksAndLabels(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge)
    {
      this.internalMarkerWhenTicksOverlap = false;
      AxisState axisState = base.drawTickMarksAndLabels(g2, cursor, plotArea, dataArea, edge);
      if (!this.internalMarkerWhenTicksOverlap)
        return axisState;
      double num1 = (double) this.getTickMarkOutsideLength();
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.getTickLabelFont());
      double num2 = !this.isVerticalTickLabels() ? (double) fontMetrics.getHeight() : (double) fontMetrics.getMaxAdvance();
      double num3 = 0.0;
      if (this.isTickMarksVisible())
      {
        float num4 = (float) this.valueToJava2D(this.getRange().getUpperBound(), dataArea, edge);
        Line2D.Double @double = (Line2D.Double) null;
        g2.setStroke(this.getTickMarkStroke());
        g2.setPaint(this.getTickMarkPaint());
        if (edge == RectangleEdge.__\u003C\u003ELEFT)
          @double = new Line2D.Double(cursor - num2, (double) num4, cursor + num3, (double) num4);
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
          @double = new Line2D.Double(cursor + num2, (double) num4, cursor - num3, (double) num4);
        else if (edge == RectangleEdge.__\u003C\u003ETOP)
          @double = new Line2D.Double((double) num4, cursor - num2, (double) num4, cursor + num3);
        else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
          @double = new Line2D.Double((double) num4, cursor + num2, (double) num4, cursor - num3);
        g2.draw((Shape) @double);
      }
      return axisState;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 167, (byte) 177, (byte) 107, (byte) 183, (byte) 98, (byte) 108, (byte) 108, (byte) 105, (byte) 217, (byte) 105, (byte) 214, (byte) 105, (byte) 214, (byte) 105, (byte) 212, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      AxisState axisState = base.draw(g2, cursor, plotArea, dataArea, edge, plotState);
      if (this.isAdvanceLineVisible())
      {
        double num = this.valueToJava2D(this.getRange().getUpperBound(), dataArea, edge);
        Line2D.Double @double = (Line2D.Double) null;
        g2.setStroke(this.getAdvanceLineStroke());
        g2.setPaint(this.getAdvanceLinePaint());
        if (edge == RectangleEdge.__\u003C\u003ELEFT)
          @double = new Line2D.Double(cursor, num, cursor + ((RectangularShape) dataArea).getWidth(), num);
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
          @double = new Line2D.Double(cursor - ((RectangularShape) dataArea).getWidth(), num, cursor, num);
        else if (edge == RectangleEdge.__\u003C\u003ETOP)
          @double = new Line2D.Double(num, cursor + ((RectangularShape) dataArea).getHeight(), num, cursor);
        else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
          @double = new Line2D.Double(num, cursor, num, cursor - ((RectangularShape) dataArea).getHeight());
        g2.draw((Shape) @double);
      }
      return axisState;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 220, (byte) 103, (byte) 110, (byte) 104, (byte) 162, (byte) 109, (byte) 211, (byte) 105, (byte) 104, (byte) 191, (byte) 2, (byte) 190, (byte) 105, (byte) 104, (byte) 190, (byte) 220})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisSpace reserveSpace(Graphics2D g2, Plot plot, Rectangle2D plotArea, RectangleEdge edge, AxisSpace space)
    {
      this.internalMarkerCycleBoundTick = (Tick) null;
      AxisSpace axisSpace = base.reserveSpace(g2, plot, plotArea, edge, space);
      if (this.internalMarkerCycleBoundTick == null)
        return axisSpace;
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.getTickLabelFont());
      Rectangle2D textBounds = TextUtilities.getTextBounds(this.internalMarkerCycleBoundTick.getText(), g2, fontMetrics);
      if (RectangleEdge.isTopOrBottom(edge))
      {
        if (this.isVerticalTickLabels())
          space.add(((RectangularShape) textBounds).getHeight() / 2.0, RectangleEdge.__\u003C\u003ERIGHT);
        else
          space.add(((RectangularShape) textBounds).getWidth() / 2.0, RectangleEdge.__\u003C\u003ERIGHT);
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        if (this.isVerticalTickLabels())
          space.add(((RectangularShape) textBounds).getWidth() / 2.0, RectangleEdge.__\u003C\u003ETOP);
        else
          space.add(((RectangularShape) textBounds).getHeight() / 2.0, RectangleEdge.__\u003C\u003ETOP);
      }
      return axisSpace;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 5, (byte) 102, (byte) 108, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.advanceLinePaint, obj0);
      SerialUtilities.writeStroke(this.advanceLineStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 22, (byte) 102, (byte) 108, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.advanceLinePaint = SerialUtilities.readPaint(obj0);
      this.advanceLineStroke = SerialUtilities.readStroke(obj0);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 37, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CyclicNumberAxis) || !base.equals(obj))
        return false;
      CyclicNumberAxis cyclicNumberAxis = (CyclicNumberAxis) obj;
      return this.period == cyclicNumberAxis.period && this.offset == cyclicNumberAxis.offset && (PaintUtilities.equal(this.advanceLinePaint, cyclicNumberAxis.advanceLinePaint) && ObjectUtilities.equal((object) this.advanceLineStroke, (object) cyclicNumberAxis.advanceLineStroke)) && (this.advanceLineVisible == cyclicNumberAxis.advanceLineVisible && this.boundMappedToLastCycle == cyclicNumberAxis.boundMappedToLastCycle);
    }

    [InnerClass]
    [SourceFile("CyclicNumberAxis.java")]
    [Serializable]
    public class CycleBoundTick : NumberTick
    {
      public bool mapToLastCycle;

      [LineNumberTable(new byte[] {(byte) 159, (byte) 47, (byte) 66, (byte) 113, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CycleBoundTick(bool mapToLastCycle, Number number, string label, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
      {
        int num = mapToLastCycle ? 1 : 0;
        // ISSUE: explicit constructor call
        base.\u002Ector(number, label, textAnchor, rotationAnchor, angle);
        CyclicNumberAxis.CycleBoundTick cycleBoundTick = this;
        this.mapToLastCycle = num != 0;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CycleBoundTick([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }
    }
  }
}
