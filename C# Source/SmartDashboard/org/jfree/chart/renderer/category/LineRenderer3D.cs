// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.LineRenderer3D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Implements(new string[] {"org.jfree.chart.Effect3D", "java.io.Serializable"})]
  [Serializable]
  public class LineRenderer3D : LineAndShapeRenderer, Effect3D, Serializable.__Interface
  {
    private const long serialVersionUID = 5467931468380928736L;
    public const double DEFAULT_X_OFFSET = 12.0;
    public const double DEFAULT_Y_OFFSET = 8.0;
    internal static Paint __\u003C\u003EDEFAULT_WALL_PAINT;
    private double xOffset;
    private double yOffset;
    [NonSerialized]
    private Paint wallPaint;

    [Modifiers]
    public static Paint DEFAULT_WALL_PAINT
    {
      [HideFromJava] get
      {
        return LineRenderer3D.__\u003C\u003EDEFAULT_WALL_PAINT;
      }
    }

    [LineNumberTable((ushort) 107)]
    static LineRenderer3D()
    {
      LineAndShapeRenderer.__\u003Cclinit\u003E();
      LineRenderer3D.__\u003C\u003EDEFAULT_WALL_PAINT = (Paint) new Color(221, 221, 221);
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 106, (byte) 112, (byte) 112, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineRenderer3D()
      : base(true, false)
    {
      LineRenderer3D lineRenderer3D = this;
      this.xOffset = 12.0;
      this.yOffset = 8.0;
      this.wallPaint = LineRenderer3D.__\u003C\u003EDEFAULT_WALL_PAINT;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LineRenderer3D([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LineRenderer3D obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setWallPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.wallPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getWallPaint()
    {
      return this.wallPaint;
    }

    public virtual double getXOffset()
    {
      return this.xOffset;
    }

    public virtual double getYOffset()
    {
      return this.yOffset;
    }

    [LineNumberTable(new byte[] {(byte) 111, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setXOffset(double xOffset)
    {
      this.xOffset = xOffset;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 124, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setYOffset(double yOffset)
    {
      this.yOffset = yOffset;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 104, (byte) 112, (byte) 104, (byte) 144, (byte) 105, (byte) 114, (byte) 105, (byte) 146, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 135, (byte) 104, (byte) 210, (byte) 104, (byte) 100, (byte) 104, (byte) 168, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 103, (byte) 108, (byte) 136, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 103, (byte) 108, (byte) 168, (byte) 107, (byte) 113, (byte) 104, (byte) 113, (byte) 104, (byte) 113, (byte) 168, (byte) 104, (byte) 100, (byte) 223, (byte) 21, (byte) 169, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawBackground(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea)
    {
      float num1 = (float) ((RectangularShape) dataArea).getX();
      float num2 = num1 + (float) Math.abs(this.xOffset);
      float num3 = (float) ((RectangularShape) dataArea).getMaxX();
      float num4 = num3 - (float) Math.abs(this.xOffset);
      float num5 = (float) ((RectangularShape) dataArea).getMaxY();
      float num6 = num5 - (float) Math.abs(this.yOffset);
      float num7 = (float) ((RectangularShape) dataArea).getMinY();
      float num8 = num7 + (float) Math.abs(this.yOffset);
      GeneralPath generalPath1 = new GeneralPath();
      ((Path2D.Float) generalPath1).moveTo(num1, num5);
      ((Path2D.Float) generalPath1).lineTo(num1, num8);
      ((Path2D.Float) generalPath1).lineTo(num2, num7);
      ((Path2D.Float) generalPath1).lineTo(num3, num7);
      ((Path2D.Float) generalPath1).lineTo(num3, num6);
      ((Path2D.Float) generalPath1).lineTo(num4, num5);
      ((Path2D) generalPath1).closePath();
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, plot.getBackgroundAlpha()));
      Paint backgroundPaint = plot.getBackgroundPaint();
      if (backgroundPaint != null)
      {
        g2.setPaint(backgroundPaint);
        g2.fill((Shape) generalPath1);
      }
      GeneralPath generalPath2 = new GeneralPath();
      ((Path2D.Float) generalPath2).moveTo(num1, num5);
      ((Path2D.Float) generalPath2).lineTo(num1, num8);
      ((Path2D.Float) generalPath2).lineTo(num2, num7);
      ((Path2D.Float) generalPath2).lineTo(num2, num6);
      ((Path2D) generalPath2).closePath();
      g2.setPaint(this.getWallPaint());
      g2.fill((Shape) generalPath2);
      GeneralPath generalPath3 = new GeneralPath();
      ((Path2D.Float) generalPath3).moveTo(num1, num5);
      ((Path2D.Float) generalPath3).lineTo(num2, num6);
      ((Path2D.Float) generalPath3).lineTo(num3, num6);
      ((Path2D.Float) generalPath3).lineTo(num4, num5);
      ((Path2D) generalPath3).closePath();
      g2.setPaint(this.getWallPaint());
      g2.fill((Shape) generalPath3);
      g2.setPaint((Paint) Color.lightGray);
      Line2D.Double double1 = new Line2D.Double((double) num1, (double) num5, (double) num2, (double) num6);
      g2.draw((Shape) double1);
      ((Line2D) double1).setLine((double) num2, (double) num6, (double) num2, (double) num7);
      g2.draw((Shape) double1);
      ((Line2D) double1).setLine((double) num2, (double) num6, (double) num3, (double) num6);
      g2.draw((Shape) double1);
      if (plot.getBackgroundImage() != null)
      {
        Rectangle2D.Double double2 = new Rectangle2D.Double(((RectangularShape) dataArea).getX() + this.getXOffset(), ((RectangularShape) dataArea).getY(), ((RectangularShape) dataArea).getWidth() - this.getXOffset(), ((RectangularShape) dataArea).getHeight() - this.getYOffset());
        plot.drawBackgroundImage(g2, (Rectangle2D) double2);
      }
      g2.setComposite(composite);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 104, (byte) 112, (byte) 104, (byte) 144, (byte) 105, (byte) 114, (byte) 105, (byte) 146, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 167, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawOutline(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea)
    {
      float num1 = (float) ((RectangularShape) dataArea).getX();
      float num2 = num1 + (float) Math.abs(this.xOffset);
      float num3 = (float) ((RectangularShape) dataArea).getMaxX();
      float num4 = num3 - (float) Math.abs(this.xOffset);
      float num5 = (float) ((RectangularShape) dataArea).getMaxY();
      float num6 = num5 - (float) Math.abs(this.yOffset);
      float num7 = (float) ((RectangularShape) dataArea).getMinY();
      float num8 = num7 + (float) Math.abs(this.yOffset);
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(num1, num5);
      ((Path2D.Float) generalPath).lineTo(num1, num8);
      ((Path2D.Float) generalPath).lineTo(num2, num7);
      ((Path2D.Float) generalPath).lineTo(num3, num7);
      ((Path2D.Float) generalPath).lineTo(num3, num6);
      ((Path2D.Float) generalPath).lineTo(num4, num5);
      ((Path2D) generalPath).closePath();
      Stroke outlineStroke = plot.getOutlineStroke();
      Paint outlinePaint = plot.getOutlinePaint();
      if (outlineStroke == null || outlinePaint == null)
        return;
      g2.setStroke(outlineStroke);
      g2.setPaint(outlinePaint);
      g2.draw((Shape) generalPath);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 100, (byte) 109, (byte) 105, (byte) 108, (byte) 105, (byte) 109, (byte) 110, (byte) 98, (byte) 104, (byte) 100, (byte) 109, (byte) 105, (byte) 108, (byte) 105, (byte) 109, (byte) 142, (byte) 108, (byte) 108, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawDomainGridline(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea, double value)
    {
      Line2D.Double double1 = (Line2D.Double) null;
      Line2D.Double double2 = (Line2D.Double) null;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double num1 = value;
        double num2 = value - this.getYOffset();
        double minX = ((RectangularShape) dataArea).getMinX();
        double num3 = minX + this.getXOffset();
        double maxX = ((RectangularShape) dataArea).getMaxX();
        double1 = new Line2D.Double(minX, num1, num3, num2);
        double2 = new Line2D.Double(num3, num2, maxX, num2);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double num1 = value;
        double num2 = value + this.getXOffset();
        double maxY = ((RectangularShape) dataArea).getMaxY();
        double num3 = maxY - this.getYOffset();
        double minY = ((RectangularShape) dataArea).getMinY();
        double1 = new Line2D.Double(num1, maxY, num2, num3);
        double2 = new Line2D.Double(num2, num3, num2, minY);
      }
      g2.setPaint(plot.getDomainGridlinePaint());
      g2.setStroke(plot.getDomainGridlineStroke());
      g2.draw((Shape) double1);
      g2.draw((Shape) double2);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 18, (byte) 135, (byte) 107, (byte) 161, (byte) 255, (byte) 24, (byte) 69, (byte) 98, (byte) 98, (byte) 104, (byte) 108, (byte) 147, (byte) 108, (byte) 106, (byte) 108, (byte) 106, (byte) 110, (byte) 110, (byte) 101, (byte) 108, (byte) 147, (byte) 108, (byte) 106, (byte) 108, (byte) 106, (byte) 110, (byte) 142, (byte) 108, (byte) 108, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawRangeGridline(Graphics2D g2, CategoryPlot plot, ValueAxis axis, Rectangle2D dataArea, double value)
    {
      if (!axis.getRange().contains(value))
        return;
      Rectangle2D.Double double1 = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) dataArea).getY() + this.getYOffset(), ((RectangularShape) dataArea).getWidth() - this.getXOffset(), ((RectangularShape) dataArea).getHeight() - this.getYOffset());
      Line2D.Double double2 = (Line2D.Double) null;
      Line2D.Double double3 = (Line2D.Double) null;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double num1 = axis.valueToJava2D(value, (Rectangle2D) double1, plot.getRangeAxisEdge());
        double num2 = num1 + this.getXOffset();
        double maxY = ((RectangularShape) dataArea).getMaxY();
        double num3 = maxY - this.getYOffset();
        double minY = ((RectangularShape) dataArea).getMinY();
        double2 = new Line2D.Double(num1, maxY, num2, num3);
        double3 = new Line2D.Double(num2, num3, num2, minY);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double num1 = axis.valueToJava2D(value, (Rectangle2D) double1, plot.getRangeAxisEdge());
        double num2 = num1 - this.getYOffset();
        double minX = ((RectangularShape) dataArea).getMinX();
        double num3 = minX + this.getXOffset();
        double maxX = ((RectangularShape) dataArea).getMaxX();
        double2 = new Line2D.Double(minX, num1, num3, num2);
        double3 = new Line2D.Double(num3, num2, maxX, num2);
      }
      g2.setPaint(plot.getRangeGridlinePaint());
      g2.setStroke(plot.getRangeGridlineStroke());
      g2.draw((Shape) double2);
      g2.draw((Shape) double3);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 74, (byte) 255, (byte) 24, (byte) 69, (byte) 108, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 161, (byte) 99, (byte) 104, (byte) 108, (byte) 145, (byte) 105, (byte) 103, (byte) 107, (byte) 157, (byte) 159, (byte) 1, (byte) 112, (byte) 103, (byte) 101, (byte) 108, (byte) 145, (byte) 106, (byte) 103, (byte) 107, (byte) 125, (byte) 159, (byte) 1, (byte) 112, (byte) 135, (byte) 109, (byte) 104, (byte) 109, (byte) 104, (byte) 130, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawRangeMarker(Graphics2D g2, CategoryPlot plot, ValueAxis axis, Marker marker, Rectangle2D dataArea)
    {
      Rectangle2D.Double @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) dataArea).getY() + this.getYOffset(), ((RectangularShape) dataArea).getWidth() - this.getXOffset(), ((RectangularShape) dataArea).getHeight() - this.getYOffset());
      if (marker is ValueMarker)
      {
        double d = ((ValueMarker) marker).getValue();
        if (!axis.getRange().contains(d))
          return;
        GeneralPath generalPath = (GeneralPath) null;
        PlotOrientation orientation = plot.getOrientation();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          float num1 = (float) axis.valueToJava2D(d, (Rectangle2D) @double, plot.getRangeAxisEdge());
          float num2 = (float) ((RectangularShape) @double).getMaxY();
          generalPath = new GeneralPath();
          ((Path2D.Float) generalPath).moveTo(num1, num2);
          ((Path2D.Float) generalPath).lineTo(num1 + (float) this.getXOffset(), num2 - (float) this.getYOffset());
          ((Path2D.Float) generalPath).lineTo(num1 + (float) this.getXOffset(), (float) (((RectangularShape) @double).getMinY() - this.getYOffset()));
          ((Path2D.Float) generalPath).lineTo(num1, (float) ((RectangularShape) @double).getMinY());
          ((Path2D) generalPath).closePath();
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          float num1 = (float) axis.valueToJava2D(d, (Rectangle2D) @double, plot.getRangeAxisEdge());
          float num2 = (float) ((RectangularShape) dataArea).getX();
          generalPath = new GeneralPath();
          ((Path2D.Float) generalPath).moveTo(num2, num1);
          ((Path2D.Float) generalPath).lineTo(num2 + (float) this.xOffset, num1 - (float) this.yOffset);
          ((Path2D.Float) generalPath).lineTo((float) (((RectangularShape) @double).getMaxX() + this.xOffset), num1 - (float) this.yOffset);
          ((Path2D.Float) generalPath).lineTo((float) ((RectangularShape) @double).getMaxX(), num1);
          ((Path2D) generalPath).closePath();
        }
        g2.setPaint(marker.getPaint());
        g2.fill((Shape) generalPath);
        g2.setPaint(marker.getOutlinePaint());
        g2.draw((Shape) generalPath);
      }
      else
        base.drawRangeMarker(g2, plot, axis, marker, (Rectangle2D) @double);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 150, (byte) 108, (byte) 193, (byte) 108, (byte) 99, (byte) 161, (byte) 255, (byte) 20, (byte) 69, (byte) 168, (byte) 153, (byte) 105, (byte) 180, (byte) 108, (byte) 104, (byte) 142, (byte) 104, (byte) 172, (byte) 111, (byte) 135, (byte) 111, (byte) 167, (byte) 106, (byte) 188, (byte) 180, (byte) 108, (byte) 108, (byte) 107, (byte) 140, (byte) 135, (byte) 104, (byte) 109, (byte) 108, (byte) 109, (byte) 109, (byte) 109, (byte) 137, (byte) 104, (byte) 109, (byte) 108, (byte) 109, (byte) 109, (byte) 109, (byte) 167, (byte) 112, (byte) 104, (byte) 112, (byte) 112, (byte) 232, (byte) 70, (byte) 108, (byte) 250, (byte) 69, (byte) 104, (byte) 100, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.getItemVisible(row, column))
        return;
      Number number1 = dataset.getValue(row, column);
      if (number1 == null)
        return;
      Rectangle2D.Double @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) dataArea).getY() + this.getYOffset(), ((RectangularShape) dataArea).getWidth() - this.getXOffset(), ((RectangularShape) dataArea).getHeight() - this.getYOffset());
      PlotOrientation orientation = plot.getOrientation();
      double categoryMiddle1 = domainAxis.getCategoryMiddle(column, this.getColumnCount(), (Rectangle2D) @double, plot.getDomainAxisEdge());
      double d1 = number1.doubleValue();
      double num1 = rangeAxis.valueToJava2D(d1, (Rectangle2D) @double, plot.getRangeAxisEdge());
      Shape shape = this.getItemShape(row, column);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        shape = ShapeUtilities.createTranslatedShape(shape, num1, categoryMiddle1);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        shape = ShapeUtilities.createTranslatedShape(shape, categoryMiddle1, num1);
      if (this.getItemLineVisible(row, column) && column != 0)
      {
        Number number2 = dataset.getValue(row, column - 1);
        if (number2 != null)
        {
          double d2 = number2.doubleValue();
          double categoryMiddle2 = domainAxis.getCategoryMiddle(column - 1, this.getColumnCount(), (Rectangle2D) @double, plot.getDomainAxisEdge());
          double num2 = rangeAxis.valueToJava2D(d2, (Rectangle2D) @double, plot.getRangeAxisEdge());
          double num3 = categoryMiddle2 + this.getXOffset();
          double num4 = num2 - this.getYOffset();
          double num5 = categoryMiddle1 + this.getXOffset();
          double num6 = num1 - this.getYOffset();
          GeneralPath generalPath = new GeneralPath();
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          {
            ((Path2D.Float) generalPath).moveTo((float) num2, (float) categoryMiddle2);
            ((Path2D.Float) generalPath).lineTo((float) num1, (float) categoryMiddle1);
            ((Path2D.Float) generalPath).lineTo((float) num6, (float) num5);
            ((Path2D.Float) generalPath).lineTo((float) num4, (float) num3);
            ((Path2D.Float) generalPath).lineTo((float) num2, (float) categoryMiddle2);
            ((Path2D) generalPath).closePath();
          }
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            ((Path2D.Float) generalPath).moveTo((float) categoryMiddle2, (float) num2);
            ((Path2D.Float) generalPath).lineTo((float) categoryMiddle1, (float) num1);
            ((Path2D.Float) generalPath).lineTo((float) num5, (float) num6);
            ((Path2D.Float) generalPath).lineTo((float) num3, (float) num4);
            ((Path2D.Float) generalPath).lineTo((float) categoryMiddle2, (float) num2);
            ((Path2D) generalPath).closePath();
          }
          g2.setPaint(this.getItemPaint(row, column));
          g2.fill((Shape) generalPath);
          g2.setStroke(this.getItemOutlineStroke(row, column));
          g2.setPaint(this.getItemOutlinePaint(row, column));
          g2.draw((Shape) generalPath);
        }
      }
      if (this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, orientation, dataset, row, column, categoryMiddle1, num1, d1 < 0.0);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, shape);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 251, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LineRenderer3D))
        return false;
      LineRenderer3D lineRenderer3D = (LineRenderer3D) obj;
      if (this.xOffset != lineRenderer3D.xOffset || this.yOffset != lineRenderer3D.yOffset || !PaintUtilities.equal(this.wallPaint, lineRenderer3D.wallPaint))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 22, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.wallPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 36, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.wallPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
