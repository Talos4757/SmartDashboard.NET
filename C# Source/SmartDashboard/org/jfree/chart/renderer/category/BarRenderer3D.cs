// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.BarRenderer3D
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
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Implements(new string[] {"org.jfree.chart.Effect3D", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class BarRenderer3D : BarRenderer, Effect3D, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 7686976503536003636L;
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
        return BarRenderer3D.__\u003C\u003EDEFAULT_WALL_PAINT;
      }
    }

    [LineNumberTable((ushort) 164)]
    static BarRenderer3D()
    {
      BarRenderer.__\u003Cclinit\u003E();
      BarRenderer3D.__\u003C\u003EDEFAULT_WALL_PAINT = (Paint) new Color(221, 221, 221);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarRenderer3D()
      : this(12.0, 8.0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 104, (byte) 105, (byte) 105, (byte) 139, (byte) 144, (byte) 103, (byte) 144, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarRenderer3D(double xOffset, double yOffset)
    {
      BarRenderer3D barRenderer3D = this;
      this.xOffset = xOffset;
      this.yOffset = yOffset;
      this.wallPaint = BarRenderer3D.__\u003C\u003EDEFAULT_WALL_PAINT;
      this.setBasePositiveItemLabelPosition(new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EINSIDE12, TextAnchor.__\u003C\u003ETOP_CENTER));
      this.setBaseNegativeItemLabelPosition(new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003EINSIDE12, TextAnchor.__\u003C\u003ETOP_CENTER));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BarRenderer3D([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] BarRenderer3D obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BarRenderer3D obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    public virtual double getYOffset()
    {
      return this.yOffset;
    }

    public virtual double getXOffset()
    {
      return this.xOffset;
    }

    public virtual Paint getWallPaint()
    {
      return this.wallPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 159, (byte) 191, (byte) 20, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CategoryItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, CategoryPlot plot, int rendererIndex, PlotRenderingInfo info)
    {
      Rectangle2D.Double @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) dataArea).getY() + this.getYOffset(), ((RectangularShape) dataArea).getWidth() - this.getXOffset(), ((RectangularShape) dataArea).getHeight() - this.getYOffset());
      return base.initialise(g2, (Rectangle2D) @double, plot, rendererIndex, info);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 178, (byte) 104, (byte) 112, (byte) 104, (byte) 144, (byte) 105, (byte) 114, (byte) 105, (byte) 146, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 135, (byte) 104, (byte) 210, (byte) 104, (byte) 100, (byte) 104, (byte) 168, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 103, (byte) 108, (byte) 136, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 103, (byte) 108, (byte) 168, (byte) 107, (byte) 113, (byte) 104, (byte) 113, (byte) 104, (byte) 113, (byte) 168, (byte) 104, (byte) 100, (byte) 223, (byte) 21, (byte) 169, (byte) 138})]
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 3, (byte) 104, (byte) 112, (byte) 104, (byte) 144, (byte) 105, (byte) 114, (byte) 105, (byte) 146, (byte) 103, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 167, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 170})]
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 98, (byte) 98, (byte) 103, (byte) 104, (byte) 100, (byte) 109, (byte) 105, (byte) 108, (byte) 105, (byte) 109, (byte) 110, (byte) 98, (byte) 104, (byte) 100, (byte) 109, (byte) 105, (byte) 108, (byte) 105, (byte) 109, (byte) 142, (byte) 104, (byte) 104, (byte) 115, (byte) 115, (byte) 103, (byte) 137})]
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
      Paint domainGridlinePaint = plot.getDomainGridlinePaint();
      Stroke domainGridlineStroke = plot.getDomainGridlineStroke();
      g2.setPaint(domainGridlinePaint == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT : domainGridlinePaint);
      g2.setStroke(domainGridlineStroke == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE : domainGridlineStroke);
      g2.draw((Shape) double1);
      g2.draw((Shape) double2);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 135, (byte) 107, (byte) 161, (byte) 223, (byte) 24, (byte) 98, (byte) 98, (byte) 104, (byte) 108, (byte) 147, (byte) 108, (byte) 106, (byte) 108, (byte) 106, (byte) 110, (byte) 110, (byte) 101, (byte) 108, (byte) 147, (byte) 108, (byte) 106, (byte) 108, (byte) 106, (byte) 110, (byte) 142, (byte) 104, (byte) 104, (byte) 115, (byte) 115, (byte) 103, (byte) 137})]
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
      Paint rangeGridlinePaint = plot.getRangeGridlinePaint();
      Stroke rangeGridlineStroke = plot.getRangeGridlineStroke();
      g2.setPaint(rangeGridlinePaint == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT : rangeGridlinePaint);
      g2.setStroke(rangeGridlineStroke == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE : rangeGridlineStroke);
      g2.draw((Shape) double2);
      g2.draw((Shape) double3);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 153, (byte) 103, (byte) 107, (byte) 161, (byte) 223, (byte) 24, (byte) 98, (byte) 98, (byte) 104, (byte) 108, (byte) 147, (byte) 108, (byte) 106, (byte) 108, (byte) 106, (byte) 110, (byte) 110, (byte) 101, (byte) 108, (byte) 147, (byte) 108, (byte) 106, (byte) 108, (byte) 106, (byte) 110, (byte) 142, (byte) 104, (byte) 104, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawRangeLine(Graphics2D g2, CategoryPlot plot, ValueAxis axis, Rectangle2D dataArea, double value, Paint paint, Stroke stroke)
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
      g2.setPaint(paint);
      g2.setStroke(stroke);
      g2.draw((Shape) double2);
      g2.draw((Shape) double3);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 208, (byte) 191, (byte) 24, (byte) 108, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 161, (byte) 99, (byte) 104, (byte) 108, (byte) 145, (byte) 105, (byte) 103, (byte) 107, (byte) 157, (byte) 159, (byte) 1, (byte) 112, (byte) 103, (byte) 101, (byte) 108, (byte) 145, (byte) 106, (byte) 103, (byte) 107, (byte) 125, (byte) 159, (byte) 1, (byte) 112, (byte) 135, (byte) 109, (byte) 104, (byte) 109, (byte) 136, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 223, (byte) 3, (byte) 255, (byte) 1, (byte) 69, (byte) 130, (byte) 174})]
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
        string label = marker.getLabel();
        RectangleAnchor labelAnchor = marker.getLabelAnchor();
        if (label == null)
          return;
        Font labelFont = marker.getLabelFont();
        ((Graphics) g2).setFont(labelFont);
        g2.setPaint(marker.getLabelPaint());
        Point2D point2D = this.calculateRangeMarkerTextAnchorPoint(g2, orientation, dataArea, ((Path2D.Float) generalPath).getBounds2D(), marker.getLabelOffset(), LengthAdjustmentType.__\u003C\u003EEXPAND, labelAnchor);
        TextUtilities.drawAlignedString(label, g2, (float) point2D.getX(), (float) point2D.getY(), marker.getLabelTextAnchor());
      }
      else
        base.drawRangeMarker(g2, plot, axis, marker, (Rectangle2D) @double);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 43, (byte) 108, (byte) 99, (byte) 161, (byte) 136, (byte) 255, (byte) 20, (byte) 69, (byte) 136, (byte) 148, (byte) 105, (byte) 100, (byte) 161, (byte) 105, (byte) 113, (byte) 113, (byte) 108, (byte) 173, (byte) 98, (byte) 104, (byte) 213, (byte) 179, (byte) 108, (byte) 104, (byte) 136, (byte) 106, (byte) 108, (byte) 106, (byte) 140, (byte) 113, (byte) 106, (byte) 113, (byte) 138, (byte) 99, (byte) 98, (byte) 108, (byte) 103, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 135, (byte) 105, (byte) 146, (byte) 168, (byte) 103, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 103, (byte) 136, (byte) 153, (byte) 112, (byte) 112, (byte) 104, (byte) 100, (byte) 136, (byte) 100, (byte) 200, (byte) 140, (byte) 112, (byte) 251, (byte) 69, (byte) 104, (byte) 103, (byte) 103, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 103, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      Number number = dataset.getValue(row, column);
      if (number == null)
        return;
      double num1 = number.doubleValue();
      Rectangle2D.Double double1 = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) dataArea).getY() + this.getYOffset(), ((RectangularShape) dataArea).getWidth() - this.getXOffset(), ((RectangularShape) dataArea).getHeight() - this.getYOffset());
      PlotOrientation orientation = plot.getOrientation();
      double num2 = this.calculateBarW0(plot, orientation, (Rectangle2D) double1, domainAxis, state, row, column);
      double[] numArray = this.calculateBarL0L1(num1);
      if (numArray == null)
        return;
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num3 = rangeAxis.valueToJava2D(numArray[0], (Rectangle2D) double1, rangeAxisEdge);
      double num4 = rangeAxis.valueToJava2D(numArray[1], (Rectangle2D) double1, rangeAxisEdge);
      double num5 = Math.min(num3, num4);
      double num6 = Math.abs(num4 - num3);
      Rectangle2D.Double double2 = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? new Rectangle2D.Double(num2, num5, state.getBarWidth(), num6) : new Rectangle2D.Double(num5, num2, num6, state.getBarWidth());
      Paint itemPaint = this.getItemPaint(row, column);
      g2.setPaint(itemPaint);
      g2.fill((Shape) double2);
      double minX = ((RectangularShape) double2).getMinX();
      double num7 = minX + this.getXOffset();
      double maxX = ((RectangularShape) double2).getMaxX();
      double num8 = maxX + this.getXOffset();
      double num9 = ((RectangularShape) double2).getMinY() - this.getYOffset();
      double minY = ((RectangularShape) double2).getMinY();
      double num10 = ((RectangularShape) double2).getMaxY() - this.getYOffset();
      double maxY = ((RectangularShape) double2).getMaxY();
      GeneralPath generalPath1 = (GeneralPath) null;
      if (num6 > 0.0)
      {
        generalPath1 = new GeneralPath();
        ((Path2D.Float) generalPath1).moveTo((float) maxX, (float) maxY);
        ((Path2D.Float) generalPath1).lineTo((float) maxX, (float) minY);
        ((Path2D.Float) generalPath1).lineTo((float) num8, (float) num9);
        ((Path2D.Float) generalPath1).lineTo((float) num8, (float) num10);
        ((Path2D) generalPath1).closePath();
        if (itemPaint is Color)
          g2.setPaint((Paint) ((Color) itemPaint).darker());
        g2.fill((Shape) generalPath1);
      }
      GeneralPath generalPath2 = new GeneralPath();
      ((Path2D.Float) generalPath2).moveTo((float) minX, (float) minY);
      ((Path2D.Float) generalPath2).lineTo((float) num7, (float) num9);
      ((Path2D.Float) generalPath2).lineTo((float) num8, (float) num9);
      ((Path2D.Float) generalPath2).lineTo((float) maxX, (float) minY);
      ((Path2D) generalPath2).closePath();
      g2.fill((Shape) generalPath2);
      if (this.isDrawBarOutline() && state.getBarWidth() > 3.0)
      {
        g2.setStroke(this.getItemOutlineStroke(row, column));
        g2.setPaint(this.getItemOutlinePaint(row, column));
        g2.draw((Shape) double2);
        if (generalPath1 != null)
          g2.draw((Shape) generalPath1);
        if (generalPath2 != null)
          g2.draw((Shape) generalPath2);
      }
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) double2, num1 < 0.0);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      GeneralPath generalPath3 = new GeneralPath();
      ((Path2D.Float) generalPath3).moveTo((float) minX, (float) maxY);
      ((Path2D.Float) generalPath3).lineTo((float) minX, (float) minY);
      ((Path2D.Float) generalPath3).lineTo((float) num7, (float) num9);
      ((Path2D.Float) generalPath3).lineTo((float) num8, (float) num9);
      ((Path2D.Float) generalPath3).lineTo((float) num8, (float) num10);
      ((Path2D.Float) generalPath3).lineTo((float) maxX, (float) maxY);
      ((Path2D) generalPath3).closePath();
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) generalPath3);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 162, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BarRenderer3D))
        return false;
      BarRenderer3D barRenderer3D = (BarRenderer3D) obj;
      if (this.xOffset != barRenderer3D.xOffset || this.yOffset != barRenderer3D.yOffset || !PaintUtilities.equal(this.wallPaint, barRenderer3D.wallPaint))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 189, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.wallPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 203, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.wallPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
