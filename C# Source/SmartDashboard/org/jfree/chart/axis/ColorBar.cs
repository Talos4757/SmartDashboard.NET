// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.ColorBar
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.plot;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Obsolete]
  [Serializable]
  public class ColorBar : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -2101776212647268103L;
    public const int DEFAULT_COLORBAR_THICKNESS = 0;
    public const double DEFAULT_COLORBAR_THICKNESS_PERCENT = 0.1;
    public const int DEFAULT_OUTERGAP = 2;
    private ValueAxis axis;
    private int colorBarThickness;
    private double colorBarThicknessPercent;
    private ColorPalette colorPalette;
    private int colorBarLength;
    private int outerGap;

    [LineNumberTable(new byte[] {(byte) 70, (byte) 232, (byte) 41, (byte) 231, (byte) 69, (byte) 208, (byte) 167, (byte) 231, (byte) 77, (byte) 103, (byte) 103, (byte) 103, (byte) 112, (byte) 144, (byte) 107, (byte) 103, (byte) 112, (byte) 103, (byte) 123, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorBar(string label)
    {
      base.\u002Ector();
      ColorBar colorBar = this;
      this.colorBarThickness = 0;
      this.colorBarThicknessPercent = 0.1;
      this.colorPalette = (ColorPalette) null;
      this.colorBarLength = 0;
      NumberAxis numberAxis = new NumberAxis(label);
      numberAxis.setAutoRangeIncludesZero(false);
      this.axis = (ValueAxis) numberAxis;
      this.axis.setLowerMargin(0.0);
      this.axis.setUpperMargin(0.0);
      this.colorPalette = (ColorPalette) new RainbowPalette();
      this.colorBarThickness = 0;
      this.colorBarThicknessPercent = 0.1;
      this.outerGap = 2;
      this.colorPalette.setMinZ(this.axis.getRange().getLowerBound());
      this.colorPalette.setMaxZ(this.axis.getRange().getUpperBound());
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ColorBar([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ColorBar obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ColorBar obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 245, (byte) 109, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinimumValue(double value)
    {
      this.colorPalette.setMinZ(value);
      this.axis.setLowerBound(value);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 235, (byte) 109, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumValue(double value)
    {
      this.colorPalette.setMaxZ(value);
      this.axis.setUpperBound(value);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 102, (byte) 104, (byte) 177, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double calculateBarThickness([In] Rectangle2D obj0, [In] RectangleEdge obj1)
    {
      return !RectangleEdge.isLeftOrRight(obj1) ? ((RectangularShape) obj0).getHeight() * this.colorBarThicknessPercent : ((RectangularShape) obj0).getWidth() * this.colorBarThicknessPercent;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 158, (byte) 108, (byte) 240, (byte) 70, (byte) 103, (byte) 144, (byte) 107, (byte) 104, (byte) 104, (byte) 105, (byte) 103, (byte) 106, (byte) 114, (byte) 109, (byte) 110, (byte) 104, (byte) 107, (byte) 98, (byte) 133, (byte) 104, (byte) 104, (byte) 105, (byte) 103, (byte) 106, (byte) 114, (byte) 109, (byte) 110, (byte) 104, (byte) 107, (byte) 162, (byte) 108, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawColorBar(Graphics2D g2, Rectangle2D colorBarArea, RectangleEdge edge)
    {
      object renderingHint = g2.getRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING);
      g2.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, (object) RenderingHints.VALUE_ANTIALIAS_OFF);
      Stroke stroke = g2.getStroke();
      g2.setStroke((Stroke) new BasicStroke(1f));
      if (RectangleEdge.isTopOrBottom(edge))
      {
        double y = ((RectangularShape) colorBarArea).getY();
        double maxY = ((RectangularShape) colorBarArea).getMaxY();
        double x = ((RectangularShape) colorBarArea).getX();
        Line2D.Double @double = new Line2D.Double();
        for (; x <= ((RectangularShape) colorBarArea).getMaxX(); ++x)
        {
          double num = this.axis.java2DToValue(x, colorBarArea, edge);
          ((Line2D) @double).setLine(x, y, x, maxY);
          g2.setPaint(this.getPaint(num));
          g2.draw((Shape) @double);
        }
      }
      else
      {
        double x = ((RectangularShape) colorBarArea).getX();
        double maxX = ((RectangularShape) colorBarArea).getMaxX();
        double y = ((RectangularShape) colorBarArea).getY();
        Line2D.Double @double = new Line2D.Double();
        for (; y <= ((RectangularShape) colorBarArea).getMaxY(); ++y)
        {
          double num = this.axis.java2DToValue(y, colorBarArea, edge);
          ((Line2D) @double).setLine(x, y, maxX, y);
          g2.setPaint(this.getPaint(num));
          g2.draw((Shape) @double);
        }
      }
      g2.setRenderingHint((RenderingHints.Key) RenderingHints.KEY_ANTIALIASING, renderingHint);
      g2.setStroke(stroke);
    }

    [LineNumberTable((ushort) 331)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getPaint(double value)
    {
      return this.colorPalette.getPaint(value);
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 109, (byte) 109, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void configure(ContourPlot plot)
    {
      double minZvalue = plot.getDataset().getMinZValue();
      double maxZvalue = plot.getDataset().getMaxZValue();
      this.setMinimumValue(minZvalue);
      this.setMaximumValue(maxZvalue);
    }

    public virtual ValueAxis getAxis()
    {
      return this.axis;
    }

    public virtual void setAxis(ValueAxis axis)
    {
      this.axis = axis;
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 107, (byte) 118, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void autoAdjustRange()
    {
      this.axis.autoAdjustRange();
      this.colorPalette.setMinZ(this.axis.getLowerBound());
      this.colorPalette.setMaxZ(this.axis.getUpperBound());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 130, (byte) 108, (byte) 105, (byte) 168, (byte) 102, (byte) 105, (byte) 171, (byte) 169, (byte) 105, (byte) 168, (byte) 105, (byte) 191, (byte) 3, (byte) 105, (byte) 191, (byte) 1, (byte) 105, (byte) 191, (byte) 2, (byte) 105, (byte) 253, (byte) 69, (byte) 149, (byte) 138, (byte) 98, (byte) 105, (byte) 105, (byte) 189, (byte) 105, (byte) 105, (byte) 186, (byte) 105, (byte) 105, (byte) 186, (byte) 105, (byte) 105, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, Rectangle2D reservedArea, RectangleEdge edge)
    {
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      double num1 = this.calculateBarThickness(dataArea, edge);
      if (this.colorBarThickness > 0)
        num1 = (double) this.colorBarThickness;
      double num2 = !RectangleEdge.isLeftOrRight(edge) ? ((RectangularShape) dataArea).getWidth() : ((RectangularShape) dataArea).getHeight();
      if (this.colorBarLength > 0)
        num2 = (double) this.colorBarLength;
      if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) plotArea).getMaxY() + (double) this.outerGap, num2, num1);
      else if (edge == RectangleEdge.__\u003C\u003ETOP)
        @double = new Rectangle2D.Double(((RectangularShape) dataArea).getX(), ((RectangularShape) reservedArea).getMinY() + (double) this.outerGap, num2, num1);
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        @double = new Rectangle2D.Double(((RectangularShape) plotArea).getX() - num1 - (double) this.outerGap, ((RectangularShape) dataArea).getMinY(), num1, num2);
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        @double = new Rectangle2D.Double(((RectangularShape) plotArea).getMaxX() + (double) this.outerGap, ((RectangularShape) dataArea).getMinY(), num1, num2);
      this.axis.refreshTicks(g2, new AxisState(), (Rectangle2D) @double, edge);
      this.drawColorBar(g2, (Rectangle2D) @double, edge);
      AxisState axisState = (AxisState) null;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
      {
        double minY = ((RectangularShape) @double).getMinY();
        axisState = this.axis.draw(g2, minY, reservedArea, (Rectangle2D) @double, RectangleEdge.__\u003C\u003ETOP, (PlotRenderingInfo) null);
      }
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        double maxY = ((RectangularShape) @double).getMaxY();
        axisState = this.axis.draw(g2, maxY, reservedArea, (Rectangle2D) @double, RectangleEdge.__\u003C\u003EBOTTOM, (PlotRenderingInfo) null);
      }
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
      {
        double minX = ((RectangularShape) @double).getMinX();
        axisState = this.axis.draw(g2, minX, reservedArea, (Rectangle2D) @double, RectangleEdge.__\u003C\u003ELEFT, (PlotRenderingInfo) null);
      }
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
      {
        double maxX = ((RectangularShape) @double).getMaxX();
        axisState = this.axis.draw(g2, maxX, reservedArea, (Rectangle2D) @double, RectangleEdge.__\u003C\u003ERIGHT, (PlotRenderingInfo) null);
      }
      return axisState.getCursor();
    }

    public virtual ColorPalette getColorPalette()
    {
      return this.colorPalette;
    }

    public virtual void setColorPalette(ColorPalette palette)
    {
      this.colorPalette = palette;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 147, (byte) 108, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual AxisSpace reserveSpace(Graphics2D g2, Plot plot, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, AxisSpace space)
    {
      AxisSpace axisSpace = this.axis.reserveSpace(g2, plot, plotArea, edge, space);
      double num = this.calculateBarThickness(dataArea, edge);
      axisSpace.add(num + (double) (2 * this.outerGap), edge);
      return axisSpace;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      ColorBar colorBar = (ColorBar) base.clone();
      colorBar.axis = (ValueAxis) this.axis.clone();
      return (object) colorBar;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 63, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ColorBar))
        return false;
      ColorBar colorBar = (ColorBar) obj;
      return this.axis.equals((object) colorBar.axis) && this.colorBarThickness == colorBar.colorBarThickness && (this.colorBarThicknessPercent == colorBar.colorBarThicknessPercent && this.colorPalette.equals((object) colorBar.colorPalette)) && (this.colorBarLength == colorBar.colorBarLength && this.outerGap == colorBar.outerGap);
    }

    [LineNumberTable((ushort) 468)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return Object.instancehelper_hashCode((object) this.axis);
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
