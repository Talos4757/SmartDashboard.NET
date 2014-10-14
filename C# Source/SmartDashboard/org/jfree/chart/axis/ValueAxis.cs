// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.ValueAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.@event;
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
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class ValueAxis : Axis, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 3698345477322391456L;
    internal static Range __\u003C\u003EDEFAULT_RANGE;
    public const bool DEFAULT_AUTO_RANGE = true;
    public const bool DEFAULT_INVERTED = false;
    public const double DEFAULT_AUTO_RANGE_MINIMUM_SIZE = 1E-08;
    public const double DEFAULT_LOWER_MARGIN = 0.05;
    public const double DEFAULT_UPPER_MARGIN = 0.05;
    [Obsolete]
    public const double DEFAULT_LOWER_BOUND = 0.0;
    [Obsolete]
    public const double DEFAULT_UPPER_BOUND = 1.0;
    public const bool DEFAULT_AUTO_TICK_UNIT_SELECTION = true;
    public const int MAXIMUM_TICK_COUNT = 500;
    private bool positiveArrowVisible;
    private bool negativeArrowVisible;
    [NonSerialized]
    private Shape upArrow;
    [NonSerialized]
    private Shape downArrow;
    [NonSerialized]
    private Shape leftArrow;
    [NonSerialized]
    private Shape rightArrow;
    private bool inverted;
    private Range range;
    private bool autoRange;
    private double autoRangeMinimumSize;
    private Range defaultAutoRange;
    private double upperMargin;
    private double lowerMargin;
    private double fixedAutoRange;
    private bool autoTickUnitSelection;
    private TickUnitSource standardTickUnits;
    private int autoTickIndex;
    private int minorTickCount;
    private bool verticalTickLabels;

    [Modifiers]
    public static Range DEFAULT_RANGE
    {
      [HideFromJava] get
      {
        return ValueAxis.__\u003C\u003EDEFAULT_RANGE;
      }
    }

    [LineNumberTable((ushort) 151)]
    static ValueAxis()
    {
      Axis.__\u003Cclinit\u003E();
      ValueAxis.__\u003C\u003EDEFAULT_RANGE = new Range(0.0, 1.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 137, (byte) 103, (byte) 135, (byte) 107, (byte) 103, (byte) 139, (byte) 103, (byte) 144, (byte) 112, (byte) 144, (byte) 140, (byte) 103, (byte) 135, (byte) 102, (byte) 104, (byte) 105, (byte) 136, (byte) 135, (byte) 102, (byte) 104, (byte) 106, (byte) 137, (byte) 135, (byte) 102, (byte) 104, (byte) 106, (byte) 137, (byte) 135, (byte) 103, (byte) 105, (byte) 106, (byte) 137, (byte) 136, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ValueAxis(string label, TickUnitSource standardTickUnits)
      : base(label)
    {
      ValueAxis valueAxis = this;
      this.positiveArrowVisible = false;
      this.negativeArrowVisible = false;
      this.range = ValueAxis.__\u003C\u003EDEFAULT_RANGE;
      this.autoRange = true;
      this.defaultAutoRange = ValueAxis.__\u003C\u003EDEFAULT_RANGE;
      this.inverted = false;
      this.autoRangeMinimumSize = 1E-08;
      this.lowerMargin = 0.05;
      this.upperMargin = 0.05;
      this.fixedAutoRange = 0.0;
      this.autoTickUnitSelection = true;
      this.standardTickUnits = standardTickUnits;
      Polygon polygon1 = new Polygon();
      polygon1.addPoint(0, 0);
      polygon1.addPoint(-2, 2);
      polygon1.addPoint(2, 2);
      this.upArrow = (Shape) polygon1;
      Polygon polygon2 = new Polygon();
      polygon2.addPoint(0, 0);
      polygon2.addPoint(-2, -2);
      polygon2.addPoint(2, -2);
      this.downArrow = (Shape) polygon2;
      Polygon polygon3 = new Polygon();
      polygon3.addPoint(0, 0);
      polygon3.addPoint(-2, -2);
      polygon3.addPoint(-2, 2);
      this.rightArrow = (Shape) polygon3;
      Polygon polygon4 = new Polygon();
      polygon4.addPoint(0, 0);
      polygon4.addPoint(2, -2);
      polygon4.addPoint(2, 2);
      this.leftArrow = (Shape) polygon4;
      this.verticalTickLabels = false;
      this.minorTickCount = 0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ValueAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ValueAxis obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ValueAxis obj0)
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

    [LineNumberTable(new byte[] {(byte) 163, (byte) 225, (byte) 105, (byte) 104, (byte) 134, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLowerMargin(double margin)
    {
      this.lowerMargin = margin;
      if (this.isAutoRange())
        this.autoAdjustRange();
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 2, (byte) 105, (byte) 104, (byte) 134, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpperMargin(double margin)
    {
      this.upperMargin = margin;
      if (this.isAutoRange())
        this.autoAdjustRange();
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 27, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStandardTickUnits(TickUnitSource source)
    {
      this.standardTickUnits = source;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 155, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRange(double lower, double upper)
    {
      this.setRange(new Range(lower, upper));
    }

    public abstract double valueToJava2D(double d, Rectangle2D rd, RectangleEdge re);

    [LineNumberTable(new byte[] {(byte) 158, (byte) 155, (byte) 162, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoRange(bool auto)
    {
      this.setAutoRange(auto, true);
    }

    public virtual Range getRange()
    {
      return this.range;
    }

    protected internal abstract void autoAdjustRange();

    [LineNumberTable((ushort) 1181)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLowerBound()
    {
      return this.range.getLowerBound();
    }

    [LineNumberTable((ushort) 1209)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getUpperBound()
    {
      return this.range.getUpperBound();
    }

    public abstract double java2DToValue(double d, Rectangle2D rd, RectangleEdge re);

    [LineNumberTable(new byte[] {(byte) 164, (byte) 83, (byte) 111, (byte) 186, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpperBound(double max)
    {
      if (this.range.getLowerBound() < max)
        this.setRange(new Range(this.range.getLowerBound(), max));
      else
        this.setRange(max - 1.0, max);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 55, (byte) 111, (byte) 186, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLowerBound(double min)
    {
      if (this.range.getUpperBound() > min)
        this.setRange(new Range(min, this.range.getUpperBound()));
      else
        this.setRange(new Range(min, min + 1.0));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 161, (byte) 100, (byte) 199, (byte) 104, (byte) 195, (byte) 104, (byte) 104, (byte) 202, (byte) 102, (byte) 102, (byte) 104, (byte) 108, (byte) 112, (byte) 105, (byte) 179, (byte) 105, (byte) 241, (byte) 70, (byte) 107, (byte) 102, (byte) 102, (byte) 105, (byte) 106, (byte) 143, (byte) 105, (byte) 106, (byte) 173})]
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
      double num1 = 0.0;
      double num2 = 0.0;
      if (this.isTickLabelsVisible())
      {
        ((Graphics) g2).setFont(this.getTickLabelFont());
        List ticks = this.refreshTicks(g2, new AxisState(), plotArea, edge);
        if (RectangleEdge.isTopOrBottom(edge))
          num1 = this.findMaximumTickLabelHeight(ticks, g2, plotArea, this.isVerticalTickLabels());
        else if (RectangleEdge.isLeftOrRight(edge))
          num2 = this.findMaximumTickLabelWidth(ticks, g2, plotArea, this.isVerticalTickLabels());
      }
      Rectangle2D labelEnclosure = this.getLabelEnclosure(g2, edge);
      if (RectangleEdge.isTopOrBottom(edge))
      {
        double height = ((RectangularShape) labelEnclosure).getHeight();
        space.add(height + num1, edge);
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        double width = ((RectangularShape) labelEnclosure).getWidth();
        space.add(width + num2, edge);
      }
      return space;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 75, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return (object) (ValueAxis) base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 12, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 162, (byte) 123, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ValueAxis))
        return false;
      ValueAxis valueAxis = (ValueAxis) obj;
      if (this.positiveArrowVisible != valueAxis.positiveArrowVisible || this.negativeArrowVisible != valueAxis.negativeArrowVisible || this.inverted != valueAxis.inverted || (!this.autoRange && !ObjectUtilities.equal((object) this.range, (object) valueAxis.range) || (this.autoRange != valueAxis.autoRange || this.autoRangeMinimumSize != valueAxis.autoRangeMinimumSize)) || (!this.defaultAutoRange.equals((object) valueAxis.defaultAutoRange) || this.upperMargin != valueAxis.upperMargin || (this.lowerMargin != valueAxis.lowerMargin || this.fixedAutoRange != valueAxis.fixedAutoRange) || (this.autoTickUnitSelection != valueAxis.autoTickUnitSelection || !ObjectUtilities.equal((object) this.standardTickUnits, (object) valueAxis.standardTickUnits) || (this.verticalTickLabels != valueAxis.verticalTickLabels || this.minorTickCount != valueAxis.minorTickCount))))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 179, (byte) 98, (byte) 105, (byte) 184, (byte) 105, (byte) 184, (byte) 105, (byte) 184, (byte) 105, (byte) 182, (byte) 108, (byte) 108, (byte) 135, (byte) 98, (byte) 98, (byte) 104, (byte) 104, (byte) 164, (byte) 162, (byte) 104, (byte) 104, (byte) 164, (byte) 162, (byte) 102, (byte) 102, (byte) 103, (byte) 99, (byte) 114, (byte) 104, (byte) 100, (byte) 138, (byte) 146, (byte) 99, (byte) 105, (byte) 200, (byte) 103, (byte) 106, (byte) 107, (byte) 104, (byte) 168, (byte) 102, (byte) 102, (byte) 103, (byte) 99, (byte) 114, (byte) 104, (byte) 100, (byte) 138, (byte) 146, (byte) 99, (byte) 105, (byte) 200, (byte) 103, (byte) 106, (byte) 107, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawAxisLine(Graphics2D g2, double cursor, Rectangle2D dataArea, RectangleEdge edge)
    {
      Line2D.Double @double = (Line2D.Double) null;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        @double = new Line2D.Double(((RectangularShape) dataArea).getX(), cursor, ((RectangularShape) dataArea).getMaxX(), cursor);
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        @double = new Line2D.Double(((RectangularShape) dataArea).getX(), cursor, ((RectangularShape) dataArea).getMaxX(), cursor);
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        @double = new Line2D.Double(cursor, ((RectangularShape) dataArea).getY(), cursor, ((RectangularShape) dataArea).getMaxY());
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        @double = new Line2D.Double(cursor, ((RectangularShape) dataArea).getY(), cursor, ((RectangularShape) dataArea).getMaxY());
      g2.setPaint(this.getAxisLinePaint());
      g2.setStroke(this.getAxisLineStroke());
      g2.draw((Shape) @double);
      int num1 = 0;
      int num2 = 0;
      if (this.positiveArrowVisible)
      {
        if (this.inverted)
          num2 = 1;
        else
          num1 = 1;
      }
      if (this.negativeArrowVisible)
      {
        if (this.inverted)
          num1 = 1;
        else
          num2 = 1;
      }
      if (num1 != 0)
      {
        double num3 = 0.0;
        double num4 = 0.0;
        Shape shape = (Shape) null;
        if (edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM)
        {
          num3 = ((RectangularShape) dataArea).getMaxX();
          num4 = cursor;
          shape = this.rightArrow;
        }
        else if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
        {
          num3 = cursor;
          num4 = ((RectangularShape) dataArea).getMinY();
          shape = this.upArrow;
        }
        AffineTransform affineTransform = new AffineTransform();
        affineTransform.setToTranslation(num3, num4);
        Shape transformedShape = affineTransform.createTransformedShape(shape);
        g2.fill(transformedShape);
        g2.draw(transformedShape);
      }
      if (num2 == 0)
        return;
      double num5 = 0.0;
      double num6 = 0.0;
      Shape shape1 = (Shape) null;
      if (edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        num5 = ((RectangularShape) dataArea).getMinX();
        num6 = cursor;
        shape1 = this.leftArrow;
      }
      else if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
      {
        num5 = cursor;
        num6 = ((RectangularShape) dataArea).getMaxY();
        shape1 = this.downArrow;
      }
      AffineTransform affineTransform1 = new AffineTransform();
      affineTransform1.setToTranslation(num5, num6);
      Shape transformedShape1 = affineTransform1.createTransformedShape(shape1);
      g2.fill(transformedShape1);
      g2.draw(transformedShape1);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 27, (byte) 103, (byte) 103, (byte) 105, (byte) 115, (byte) 156, (byte) 105, (byte) 115, (byte) 156, (byte) 105, (byte) 119, (byte) 149, (byte) 105, (byte) 119, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual float[] calculateAnchorPoint(ValueTick tick, double cursor, Rectangle2D dataArea, RectangleEdge edge)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      float[] numArray = new float[2];
      if (edge == RectangleEdge.__\u003C\u003ETOP)
      {
        numArray[0] = (float) this.valueToJava2D(tick.getValue(), dataArea, edge);
        numArray[1] = (float) (cursor - tickLabelInsets.getBottom() - 2.0);
      }
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        numArray[0] = (float) this.valueToJava2D(tick.getValue(), dataArea, edge);
        numArray[1] = (float) (cursor + tickLabelInsets.getTop() + 2.0);
      }
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
      {
        numArray[0] = (float) (cursor - tickLabelInsets.getLeft() - 2.0);
        numArray[1] = (float) this.valueToJava2D(tick.getValue(), dataArea, edge);
      }
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
      {
        numArray[0] = (float) (cursor + tickLabelInsets.getRight() + 2.0);
        numArray[1] = (float) this.valueToJava2D(tick.getValue(), dataArea, edge);
      }
      return numArray;
    }

    public virtual bool isVerticalTickLabels()
    {
      return this.verticalTickLabels;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 175, (byte) 131, (byte) 103, (byte) 103, (byte) 102, (byte) 102, (byte) 105, (byte) 104, (byte) 105, (byte) 110, (byte) 145, (byte) 152, (byte) 183, (byte) 101, (byte) 130, (byte) 147, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double findMaximumTickLabelWidth(List ticks, Graphics2D g2, Rectangle2D drawArea, bool vertical)
    {
      int num1 = vertical ? 1 : 0;
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      Font tickLabelFont = this.getTickLabelFont();
      double num2 = 0.0;
      if (num1 == 0)
      {
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(tickLabelFont);
        Iterator iterator = ticks.iterator();
        while (iterator.hasNext())
        {
          Rectangle2D textBounds = TextUtilities.getTextBounds(((Tick) iterator.next()).getText(), g2, fontMetrics);
          if (((RectangularShape) textBounds).getWidth() + tickLabelInsets.getLeft() + tickLabelInsets.getRight() > num2)
            num2 = ((RectangularShape) textBounds).getWidth() + tickLabelInsets.getLeft() + tickLabelInsets.getRight();
        }
      }
      else
        num2 = (double) tickLabelFont.getLineMetrics("ABCxyz", g2.getFontRenderContext()).getHeight() + tickLabelInsets.getTop() + tickLabelInsets.getBottom();
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 186, (byte) 163, (byte) 103, (byte) 103, (byte) 102, (byte) 102, (byte) 105, (byte) 104, (byte) 105, (byte) 110, (byte) 145, (byte) 152, (byte) 183, (byte) 101, (byte) 130, (byte) 147, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double findMaximumTickLabelHeight(List ticks, Graphics2D g2, Rectangle2D drawArea, bool vertical)
    {
      int num1 = vertical ? 1 : 0;
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      Font tickLabelFont = this.getTickLabelFont();
      double num2 = 0.0;
      if (num1 != 0)
      {
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(tickLabelFont);
        Iterator iterator = ticks.iterator();
        while (iterator.hasNext())
        {
          Rectangle2D textBounds = TextUtilities.getTextBounds(((Tick) iterator.next()).getText(), g2, fontMetrics);
          if (((RectangularShape) textBounds).getWidth() + tickLabelInsets.getTop() + tickLabelInsets.getBottom() > num2)
            num2 = ((RectangularShape) textBounds).getWidth() + tickLabelInsets.getTop() + tickLabelInsets.getBottom();
        }
      }
      else
        num2 = (double) tickLabelFont.getLineMetrics("ABCxyz", g2.getFontRenderContext()).getHeight() + tickLabelInsets.getTop() + tickLabelInsets.getBottom();
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 151, (byte) 68, (byte) 105, (byte) 103, (byte) 104, (byte) 134, (byte) 99, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setAutoRange(bool auto, bool notify)
    {
      int num1 = auto ? 1 : 0;
      int num2 = notify ? 1 : 0;
      if ((this.autoRange ? 1 : 0) == num1)
        return;
      this.autoRange = num1 != 0;
      if (this.autoRange)
        this.autoAdjustRange();
      if (num2 == 0)
        return;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 140, (byte) 130, (byte) 105, (byte) 176, (byte) 106, (byte) 105, (byte) 104, (byte) 134, (byte) 99, (byte) 206})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoRangeMinimumSize(double size, bool notify)
    {
      int num = notify ? 1 : 0;
      if (size <= 0.0)
      {
        string str = "NumberAxis.setAutoRangeMinimumSize(double): must be > 0.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.autoRangeMinimumSize == size)
          return;
        this.autoRangeMinimumSize = size;
        if (this.autoRange)
          this.autoAdjustRange();
        if (num == 0)
          return;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual bool isAutoRange()
    {
      return this.autoRange;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 113, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRange(Range range)
    {
      this.setRange(range, true, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 81, (byte) 100, (byte) 99, (byte) 144, (byte) 99, (byte) 135, (byte) 103, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRange(Range range, bool turnOffAutoRange, bool notify)
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
        if (num1 != 0)
          this.autoRange = false;
        this.range = range;
        if (num2 == 0)
          return;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 68, (byte) 132, (byte) 99, (byte) 144, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeWithMargins(Range range, bool turnOffAutoRange, bool notify)
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
        this.setRange(Range.expand(range, this.getLowerMargin(), this.getUpperMargin()), num1 != 0, num2 != 0);
    }

    public virtual double getLowerMargin()
    {
      return this.lowerMargin;
    }

    public virtual double getUpperMargin()
    {
      return this.upperMargin;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 166, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeWithMargins(Range range)
    {
      this.setRangeWithMargins(range, true, true);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 51, (byte) 100, (byte) 105, (byte) 103, (byte) 99, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoTickUnitSelection(bool flag, bool notify)
    {
      int num1 = flag ? 1 : 0;
      int num2 = notify ? 1 : 0;
      if ((this.autoTickUnitSelection ? 1 : 0) == num1)
        return;
      this.autoTickUnitSelection = num1 != 0;
      if (num2 == 0)
        return;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 162, (byte) 105, (byte) 122, (byte) 142, (byte) 103, (byte) 130, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void resizeRange(double percent, double anchorValue)
    {
      if (percent > 0.0)
      {
        double num = this.range.getLength() * percent / 2.0;
        this.setRange(new Range(anchorValue - num, anchorValue + num));
      }
      else
        this.setAutoRange(true);
    }

    public virtual bool isInverted()
    {
      return this.inverted;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 51, (byte) 98, (byte) 105, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setVerticalTickLabels(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.verticalTickLabels ? 1 : 0) == num)
        return;
      this.verticalTickLabels = num != 0;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual bool isPositiveArrowVisible()
    {
      return this.positiveArrowVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 44, (byte) 98, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositiveArrowVisible(bool visible)
    {
      this.positiveArrowVisible = visible;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual bool isNegativeArrowVisible()
    {
      return this.negativeArrowVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 38, (byte) 162, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNegativeArrowVisible(bool visible)
    {
      this.negativeArrowVisible = visible;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual Shape getUpArrow()
    {
      return this.upArrow;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 75, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpArrow(Shape arrow)
    {
      if (arrow == null)
      {
        string str = "Null 'arrow' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.upArrow = arrow;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Shape getDownArrow()
    {
      return this.downArrow;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDownArrow(Shape arrow)
    {
      if (arrow == null)
      {
        string str = "Null 'arrow' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.downArrow = arrow;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Shape getLeftArrow()
    {
      return this.leftArrow;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 133, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLeftArrow(Shape arrow)
    {
      if (arrow == null)
      {
        string str = "Null 'arrow' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.leftArrow = arrow;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Shape getRightArrow()
    {
      return this.rightArrow;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 162, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRightArrow(Shape arrow)
    {
      if (arrow == null)
      {
        string str = "Null 'arrow' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rightArrow = arrow;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 63, (byte) 136, (byte) 104, (byte) 173, (byte) 109, (byte) 103, (byte) 108, (byte) 103, (byte) 107, (byte) 108, (byte) 104, (byte) 108, (byte) 143, (byte) 255, (byte) 7, (byte) 69, (byte) 223, (byte) 27, (byte) 191, (byte) 5, (byte) 191, (byte) 5, (byte) 147, (byte) 99, (byte) 108, (byte) 108, (byte) 105, (byte) 156, (byte) 105, (byte) 153, (byte) 105, (byte) 153, (byte) 105, (byte) 151, (byte) 136, (byte) 197, (byte) 103, (byte) 107, (byte) 105, (byte) 149, (byte) 141, (byte) 105, (byte) 146, (byte) 138, (byte) 105, (byte) 146, (byte) 138, (byte) 105, (byte) 146, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisState drawTickMarksAndLabels(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge)
    {
      AxisState @as = new AxisState(cursor);
      if (this.isAxisLineVisible())
        this.drawAxisLine(g2, cursor, dataArea, edge);
      List ticks = this.refreshTicks(g2, @as, dataArea, edge);
      @as.setTicks(ticks);
      ((Graphics) g2).setFont(this.getTickLabelFont());
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        ValueTick tick = (ValueTick) iterator.next();
        if (this.isTickLabelsVisible())
        {
          g2.setPaint(this.getTickLabelPaint());
          float[] numArray = this.calculateAnchorPoint(tick, cursor, dataArea, edge);
          TextUtilities.drawRotatedString(tick.getText(), g2, numArray[0], numArray[1], tick.getTextAnchor(), tick.getAngle(), tick.getRotationAnchor());
        }
        if (this.isTickMarksVisible() && tick.getTickType().equals((object) TickType.__\u003C\u003EMAJOR) || this.isMinorTickMarksVisible() && tick.getTickType().equals((object) TickType.__\u003C\u003EMINOR))
        {
          double num1 = !tick.getTickType().equals((object) TickType.__\u003C\u003EMINOR) ? (double) this.getTickMarkOutsideLength() : (double) this.getMinorTickMarkOutsideLength();
          double num2 = !tick.getTickType().equals((object) TickType.__\u003C\u003EMINOR) ? (double) this.getTickMarkInsideLength() : (double) this.getMinorTickMarkInsideLength();
          float num3 = (float) this.valueToJava2D(tick.getValue(), dataArea, edge);
          Line2D.Double @double = (Line2D.Double) null;
          g2.setStroke(this.getTickMarkStroke());
          g2.setPaint(this.getTickMarkPaint());
          if (edge == RectangleEdge.__\u003C\u003ELEFT)
            @double = new Line2D.Double(cursor - num1, (double) num3, cursor + num2, (double) num3);
          else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
            @double = new Line2D.Double(cursor + num1, (double) num3, cursor - num2, (double) num3);
          else if (edge == RectangleEdge.__\u003C\u003ETOP)
            @double = new Line2D.Double((double) num3, cursor - num1, (double) num3, cursor + num2);
          else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
            @double = new Line2D.Double((double) num3, cursor + num1, (double) num3, cursor - num2);
          g2.draw((Shape) @double);
        }
      }
      double num = 0.0;
      if (this.isTickLabelsVisible())
      {
        if (edge == RectangleEdge.__\u003C\u003ELEFT)
        {
          double units = num + this.findMaximumTickLabelWidth(ticks, g2, plotArea, this.isVerticalTickLabels());
          @as.cursorLeft(units);
        }
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        {
          double maximumTickLabelWidth = this.findMaximumTickLabelWidth(ticks, g2, plotArea, this.isVerticalTickLabels());
          @as.cursorRight(maximumTickLabelWidth);
        }
        else if (edge == RectangleEdge.__\u003C\u003ETOP)
        {
          double maximumTickLabelHeight = this.findMaximumTickLabelHeight(ticks, g2, plotArea, this.isVerticalTickLabels());
          @as.cursorUp(maximumTickLabelHeight);
        }
        else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        {
          double maximumTickLabelHeight = this.findMaximumTickLabelHeight(ticks, g2, plotArea, this.isVerticalTickLabels());
          @as.cursorDown(maximumTickLabelHeight);
        }
      }
      return @as;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 162, (byte) 130, (byte) 105, (byte) 103, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInverted(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.inverted ? 1 : 0) == num)
        return;
      this.inverted = num != 0;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual double getAutoRangeMinimumSize()
    {
      return this.autoRangeMinimumSize;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 138, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoRangeMinimumSize(double size)
    {
      this.setAutoRangeMinimumSize(size, true);
    }

    public virtual Range getDefaultAutoRange()
    {
      return this.defaultAutoRange;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 192, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDefaultAutoRange(Range range)
    {
      if (range == null)
      {
        string str = "Null 'range' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.defaultAutoRange = range;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual double getFixedAutoRange()
    {
      return this.fixedAutoRange;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 28, (byte) 105, (byte) 104, (byte) 134, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedAutoRange(double length)
    {
      this.fixedAutoRange = length;
      if (this.isAutoRange())
        this.autoAdjustRange();
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 200, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeWithMargins(double lower, double upper)
    {
      this.setRangeWithMargins(new Range(lower, upper));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 211, (byte) 127, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAboutValue(double value, double length)
    {
      this.setRange(new Range(value - length / 2.0, value + length / 2.0));
    }

    public virtual bool isAutoTickUnitSelection()
    {
      return this.autoTickUnitSelection;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 55, (byte) 162, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoTickUnitSelection(bool flag)
    {
      this.setAutoTickUnitSelection(flag, true);
    }

    public virtual TickUnitSource getStandardTickUnits()
    {
      return this.standardTickUnits;
    }

    public virtual int getMinorTickCount()
    {
      return this.minorTickCount;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 55, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinorTickCount(int count)
    {
      this.minorTickCount = count;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 88, (byte) 111, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double lengthToJava2D(double length, Rectangle2D area, RectangleEdge edge)
    {
      double num = this.valueToJava2D(0.0, area, edge);
      return Math.abs(this.valueToJava2D(length, area, edge) - num);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 125, (byte) 109, (byte) 159, (byte) 7, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void centerRange(double value)
    {
      double centralValue = this.range.getCentralValue();
      this.setRange(new Range(this.range.getLowerBound() + value - centralValue, this.range.getUpperBound() + value - centralValue));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 145, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void resizeRange(double percent)
    {
      this.resizeRange(percent, this.range.getCentralValue());
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 189, (byte) 105, (byte) 107, (byte) 107, (byte) 148, (byte) 103, (byte) 130, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void resizeRange2(double percent, double anchorValue)
    {
      if (percent > 0.0)
      {
        double num1 = anchorValue - this.getLowerBound();
        double num2 = this.getUpperBound() - anchorValue;
        this.setRange(new Range(anchorValue - num1 * percent, anchorValue + num2 * percent));
      }
      else
        this.setAutoRange(true);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 208, (byte) 109, (byte) 109, (byte) 98, (byte) 104, (byte) 223, (byte) 1, (byte) 178, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRange(double lowerPercent, double upperPercent)
    {
      double lowerBound = this.range.getLowerBound();
      double length = this.range.getLength();
      this.setRange(!this.isInverted() ? new Range(lowerBound + length * lowerPercent, lowerBound + length * upperPercent) : new Range(lowerBound + length * (1.0 - upperPercent), lowerBound + length * (1.0 - lowerPercent)));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 230, (byte) 103, (byte) 104, (byte) 102, (byte) 106, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void pan(double percent)
    {
      Range range = this.getRange();
      double num = range.getLength() * percent;
      this.setRange(range.getLowerBound() + num, range.getUpperBound() + num);
    }

    protected internal virtual int getAutoTickIndex()
    {
      return this.autoTickIndex;
    }

    protected internal virtual void setAutoTickIndex(int index)
    {
      this.autoTickIndex = index;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 87, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.upArrow, obj0);
      SerialUtilities.writeShape(this.downArrow, obj0);
      SerialUtilities.writeShape(this.leftArrow, obj0);
      SerialUtilities.writeShape(this.rightArrow, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 105, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.upArrow = SerialUtilities.readShape(obj0);
      this.downArrow = SerialUtilities.readShape(obj0);
      this.leftArrow = SerialUtilities.readShape(obj0);
      this.rightArrow = SerialUtilities.readShape(obj0);
    }
  }
}
