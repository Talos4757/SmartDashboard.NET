// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.PaintScaleLegend
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
using org.jfree.chart.axis;
using org.jfree.chart.block;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.data;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Implements(new string[] {"org.jfree.chart.event.AxisChangeListener", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class PaintScaleLegend : Title, AxisChangeListener, EventListener, PublicCloneable, Cloneable.__Interface
  {
    internal const long serialVersionUID = -1365146490993227503L;
    private PaintScale scale;
    private ValueAxis axis;
    private AxisLocation axisLocation;
    private double axisOffset;
    private double stripWidth;
    private bool stripOutlineVisible;
    [NonSerialized]
    private Paint stripOutlinePaint;
    [NonSerialized]
    private Stroke stripOutlineStroke;
    [NonSerialized]
    private Paint backgroundPaint;
    private int subdivisions;

    [HideFromJava]
    static PaintScaleLegend()
    {
      Title.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 108, (byte) 107, (byte) 108, (byte) 119, (byte) 112, (byte) 103, (byte) 107, (byte) 112, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PaintScaleLegend(PaintScale scale, ValueAxis axis)
    {
      PaintScaleLegend paintScaleLegend = this;
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.scale = scale;
        this.axis = axis;
        this.axis.addChangeListener((AxisChangeListener) this);
        this.axisLocation = AxisLocation.__\u003C\u003EBOTTOM_OR_LEFT;
        this.axisOffset = 0.0;
        this.axis.setRange(scale.getLowerBound(), scale.getUpperBound());
        this.stripWidth = 15.0;
        this.stripOutlineVisible = true;
        this.stripOutlinePaint = (Paint) Color.gray;
        this.stripOutlineStroke = (Stroke) new BasicStroke(0.5f);
        this.backgroundPaint = (Paint) Color.white;
        this.subdivisions = 100;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PaintScaleLegend([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PaintScaleLegend obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 5, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      this.backgroundPaint = paint;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual ValueAxis getAxis()
    {
      return this.axis;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 116, (byte) 103, (byte) 176, (byte) 168, (byte) 223, (byte) 15, (byte) 191, (byte) 6, (byte) 144, (byte) 104, (byte) 191, (byte) 15, (byte) 223, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRR(Graphics2D g2, Range widthRange, Range heightRange)
    {
      RectangleEdge position = this.getPosition();
      if (position == RectangleEdge.__\u003C\u003ETOP || position == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        float num = (float) widthRange.getUpperBound();
        AxisSpace axisSpace = this.axis.reserveSpace(g2, (Plot) null, (Rectangle2D) new Rectangle2D.Double(0.0, 0.0, (double) num, 100.0), RectangleEdge.__\u003C\u003EBOTTOM, (AxisSpace) null);
        return new Size2D((double) num, this.stripWidth + this.axisOffset + axisSpace.getTop() + axisSpace.getBottom());
      }
      else if (position == RectangleEdge.__\u003C\u003ELEFT || position == RectangleEdge.__\u003C\u003ERIGHT)
      {
        float num = (float) heightRange.getUpperBound();
        AxisSpace axisSpace = this.axis.reserveSpace(g2, (Plot) null, (Rectangle2D) new Rectangle2D.Double(0.0, 0.0, 100.0, (double) num), RectangleEdge.__\u003C\u003ERIGHT, (AxisSpace) null);
        return new Size2D(this.stripWidth + this.axisOffset + axisSpace.getLeft() + axisSpace.getRight(), (double) num);
      }
      else
      {
        string str = "Unrecognised position.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 165, (byte) 108, (byte) 104, (byte) 104, (byte) 108, (byte) 135, (byte) 109, (byte) 113, (byte) 104, (byte) 109, (byte) 122, (byte) 134, (byte) 112, (byte) 146, (byte) 108, (byte) 112, (byte) 106, (byte) 111, (byte) 150, (byte) 152, (byte) 115, (byte) 159, (byte) 5, (byte) 104, (byte) 231, (byte) 53, (byte) 235, (byte) 77, (byte) 104, (byte) 108, (byte) 108, (byte) 223, (byte) 11, (byte) 223, (byte) 15, (byte) 108, (byte) 112, (byte) 106, (byte) 111, (byte) 150, (byte) 152, (byte) 115, (byte) 157, (byte) 104, (byte) 231, (byte) 53, (byte) 235, (byte) 77, (byte) 104, (byte) 108, (byte) 108, (byte) 223, (byte) 4, (byte) 223, (byte) 10, (byte) 133, (byte) 146, (byte) 108, (byte) 112, (byte) 106, (byte) 111, (byte) 150, (byte) 152, (byte) 115, (byte) 159, (byte) 5, (byte) 104, (byte) 231, (byte) 53, (byte) 235, (byte) 77, (byte) 104, (byte) 108, (byte) 108, (byte) 223, (byte) 11, (byte) 223, (byte) 15, (byte) 108, (byte) 112, (byte) 106, (byte) 111, (byte) 150, (byte) 152, (byte) 115, (byte) 157, (byte) 104, (byte) 231, (byte) 53, (byte) 235, (byte) 77, (byte) 104, (byte) 108, (byte) 108, (byte) 223, (byte) 4, (byte) 255, (byte) 10, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      Rectangle2D rectangle2D1 = this.trimMargin((Rectangle2D) ((RectangularShape) area).clone());
      if (this.backgroundPaint != null)
      {
        g2.setPaint(this.backgroundPaint);
        g2.fill((Shape) rectangle2D1);
      }
      this.getFrame().draw(g2, rectangle2D1);
      this.getFrame().getInsets().trim(rectangle2D1);
      Rectangle2D rectangle2D2 = this.trimPadding(rectangle2D1);
      double lowerBound = this.axis.getLowerBound();
      double num1 = this.axis.getRange().getLength() / (double) this.subdivisions;
      Rectangle2D.Double @double = new Rectangle2D.Double();
      if (RectangleEdge.isTopOrBottom(this.getPosition()))
      {
        RectangleEdge rectangleEdge = Plot.resolveRangeAxisLocation(this.axisLocation, PlotOrientation.__\u003C\u003EHORIZONTAL);
        if (rectangleEdge == RectangleEdge.__\u003C\u003ETOP)
        {
          for (int index = 0; index < this.subdivisions; ++index)
          {
            double d = lowerBound + (double) index * num1;
            Paint paint = this.scale.getPaint(d);
            double num2 = this.axis.valueToJava2D(d, rectangle2D2, RectangleEdge.__\u003C\u003ETOP);
            double num3 = this.axis.valueToJava2D(d + num1, rectangle2D2, RectangleEdge.__\u003C\u003ETOP);
            double num4 = Math.abs(num3 - num2) + 1.0;
            ((Rectangle2D) @double).setRect(Math.min(num2, num3), ((RectangularShape) rectangle2D2).getMaxY() - this.stripWidth, num4, this.stripWidth);
            g2.setPaint(paint);
            g2.fill((Shape) @double);
          }
          if (this.isStripOutlineVisible())
          {
            g2.setPaint(this.stripOutlinePaint);
            g2.setStroke(this.stripOutlineStroke);
            g2.draw((Shape) new Rectangle2D.Double(((RectangularShape) rectangle2D2).getMinX(), ((RectangularShape) rectangle2D2).getMaxY() - this.stripWidth, ((RectangularShape) rectangle2D2).getWidth(), this.stripWidth));
          }
          this.axis.draw(g2, ((RectangularShape) rectangle2D2).getMaxY() - this.stripWidth - this.axisOffset, rectangle2D2, rectangle2D2, RectangleEdge.__\u003C\u003ETOP, (PlotRenderingInfo) null);
        }
        else if (rectangleEdge == RectangleEdge.__\u003C\u003EBOTTOM)
        {
          for (int index = 0; index < this.subdivisions; ++index)
          {
            double d = lowerBound + (double) index * num1;
            Paint paint = this.scale.getPaint(d);
            double num2 = this.axis.valueToJava2D(d, rectangle2D2, RectangleEdge.__\u003C\u003EBOTTOM);
            double num3 = this.axis.valueToJava2D(d + num1, rectangle2D2, RectangleEdge.__\u003C\u003EBOTTOM);
            double num4 = Math.abs(num3 - num2) + 1.0;
            ((Rectangle2D) @double).setRect(Math.min(num2, num3), ((RectangularShape) rectangle2D2).getMinY(), num4, this.stripWidth);
            g2.setPaint(paint);
            g2.fill((Shape) @double);
          }
          if (this.isStripOutlineVisible())
          {
            g2.setPaint(this.stripOutlinePaint);
            g2.setStroke(this.stripOutlineStroke);
            g2.draw((Shape) new Rectangle2D.Double(((RectangularShape) rectangle2D2).getMinX(), ((RectangularShape) rectangle2D2).getMinY(), ((RectangularShape) rectangle2D2).getWidth(), this.stripWidth));
          }
          this.axis.draw(g2, ((RectangularShape) rectangle2D2).getMinY() + this.stripWidth + this.axisOffset, rectangle2D2, rectangle2D2, RectangleEdge.__\u003C\u003EBOTTOM, (PlotRenderingInfo) null);
        }
      }
      else
      {
        RectangleEdge rectangleEdge = Plot.resolveRangeAxisLocation(this.axisLocation, PlotOrientation.__\u003C\u003EVERTICAL);
        if (rectangleEdge == RectangleEdge.__\u003C\u003ELEFT)
        {
          for (int index = 0; index < this.subdivisions; ++index)
          {
            double d = lowerBound + (double) index * num1;
            Paint paint = this.scale.getPaint(d);
            double num2 = this.axis.valueToJava2D(d, rectangle2D2, RectangleEdge.__\u003C\u003ELEFT);
            double num3 = this.axis.valueToJava2D(d + num1, rectangle2D2, RectangleEdge.__\u003C\u003ELEFT);
            double num4 = Math.abs(num3 - num2) + 1.0;
            ((Rectangle2D) @double).setRect(((RectangularShape) rectangle2D2).getMaxX() - this.stripWidth, Math.min(num2, num3), this.stripWidth, num4);
            g2.setPaint(paint);
            g2.fill((Shape) @double);
          }
          if (this.isStripOutlineVisible())
          {
            g2.setPaint(this.stripOutlinePaint);
            g2.setStroke(this.stripOutlineStroke);
            g2.draw((Shape) new Rectangle2D.Double(((RectangularShape) rectangle2D2).getMaxX() - this.stripWidth, ((RectangularShape) rectangle2D2).getMinY(), this.stripWidth, ((RectangularShape) rectangle2D2).getHeight()));
          }
          this.axis.draw(g2, ((RectangularShape) rectangle2D2).getMaxX() - this.stripWidth - this.axisOffset, rectangle2D2, rectangle2D2, RectangleEdge.__\u003C\u003ELEFT, (PlotRenderingInfo) null);
        }
        else if (rectangleEdge == RectangleEdge.__\u003C\u003ERIGHT)
        {
          for (int index = 0; index < this.subdivisions; ++index)
          {
            double d = lowerBound + (double) index * num1;
            Paint paint = this.scale.getPaint(d);
            double num2 = this.axis.valueToJava2D(d, rectangle2D2, RectangleEdge.__\u003C\u003ELEFT);
            double num3 = this.axis.valueToJava2D(d + num1, rectangle2D2, RectangleEdge.__\u003C\u003ELEFT);
            double num4 = Math.abs(num3 - num2) + 1.0;
            ((Rectangle2D) @double).setRect(((RectangularShape) rectangle2D2).getMinX(), Math.min(num2, num3), this.stripWidth, num4);
            g2.setPaint(paint);
            g2.fill((Shape) @double);
          }
          if (this.isStripOutlineVisible())
          {
            g2.setPaint(this.stripOutlinePaint);
            g2.setStroke(this.stripOutlineStroke);
            g2.draw((Shape) new Rectangle2D.Double(((RectangularShape) rectangle2D2).getMinX(), ((RectangularShape) rectangle2D2).getMinY(), this.stripWidth, ((RectangularShape) rectangle2D2).getHeight()));
          }
          this.axis.draw(g2, ((RectangularShape) rectangle2D2).getMinX() + this.stripWidth + this.axisOffset, rectangle2D2, rectangle2D2, RectangleEdge.__\u003C\u003ERIGHT, (PlotRenderingInfo) null);
        }
      }
      return (object) null;
    }

    public virtual bool isStripOutlineVisible()
    {
      return this.stripOutlineVisible;
    }

    public virtual PaintScale getScale()
    {
      return this.scale;
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setScale(PaintScale scale)
    {
      if (scale == null)
      {
        string str = "Null 'scale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.scale = scale;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 99, (byte) 144, (byte) 108, (byte) 103, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxis(ValueAxis axis)
    {
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.axis.removeChangeListener((AxisChangeListener) this);
        this.axis = axis;
        this.axis.addChangeListener((AxisChangeListener) this);
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual AxisLocation getAxisLocation()
    {
      return this.axisLocation;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLocation(AxisLocation location)
    {
      if (location == null)
      {
        string str = "Null 'location' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.axisLocation = location;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual double getAxisOffset()
    {
      return this.axisOffset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisOffset(double offset)
    {
      this.axisOffset = offset;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual double getStripWidth()
    {
      return this.stripWidth;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 161, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStripWidth(double width)
    {
      this.stripWidth = width;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 67, (byte) 98, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStripOutlineVisible(bool visible)
    {
      this.stripOutlineVisible = visible;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual Paint getStripOutlinePaint()
    {
      return this.stripOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStripOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.stripOutlinePaint = paint;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual Stroke getStripOutlineStroke()
    {
      return this.stripOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 238, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStripOutlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.stripOutlineStroke = stroke;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    public virtual int getSubdivisionCount()
    {
      return this.subdivisions;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 29, (byte) 100, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubdivisionCount(int count)
    {
      if (count <= 0)
      {
        string str = "Requires 'count' > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.subdivisions = count;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 45, (byte) 110, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void axisChanged(AxisChangeEvent @event)
    {
      if (this.axis != @event.getAxis())
        return;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 60, (byte) 104, (byte) 103, (byte) 103, (byte) 98, (byte) 104, (byte) 104, (byte) 151, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 185, (byte) 104, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 144, (byte) 104, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint rectangleConstraint = this.toContentConstraint(constraint);
      LengthConstraintType widthConstraintType = rectangleConstraint.getWidthConstraintType();
      LengthConstraintType heightConstraintType = rectangleConstraint.getHeightConstraintType();
      Size2D size2D = (Size2D) null;
      if (widthConstraintType == LengthConstraintType.__\u003C\u003ENONE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D = new Size2D(this.getWidth(), this.getHeight());
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          size2D = this.arrangeRR(g2, rectangleConstraint.getWidthRange(), rectangleConstraint.getHeightRange());
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      return new Size2D(this.calculateTotalWidth(size2D.getWidth()), this.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 151, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area)
    {
      this.draw(g2, area, (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 41, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (!(obj is PaintScaleLegend))
        return false;
      PaintScaleLegend paintScaleLegend = (PaintScaleLegend) obj;
      if (!Object.instancehelper_equals((object) this.scale, (object) paintScaleLegend.scale) || !this.axis.equals((object) paintScaleLegend.axis) || (!this.axisLocation.equals((object) paintScaleLegend.axisLocation) || this.axisOffset != paintScaleLegend.axisOffset) || (this.stripWidth != paintScaleLegend.stripWidth || this.stripOutlineVisible != paintScaleLegend.stripOutlineVisible || (!PaintUtilities.equal(this.stripOutlinePaint, paintScaleLegend.stripOutlinePaint) || !Object.instancehelper_equals((object) this.stripOutlineStroke, (object) paintScaleLegend.stripOutlineStroke))) || (!PaintUtilities.equal(this.backgroundPaint, paintScaleLegend.backgroundPaint) || this.subdivisions != paintScaleLegend.subdivisions))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 87, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
      SerialUtilities.writePaint(this.stripOutlinePaint, obj0);
      SerialUtilities.writeStroke(this.stripOutlineStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 103, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
      this.stripOutlinePaint = SerialUtilities.readPaint(obj0);
      this.stripOutlineStroke = SerialUtilities.readStroke(obj0);
    }
  }
}
