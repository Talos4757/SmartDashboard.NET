// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYStepAreaRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYStepAreaRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -7311560779702649635L;
    public const int SHAPES = 1;
    public const int AREA = 2;
    public const int AREA_AND_SHAPES = 3;
    private bool shapesVisible;
    private bool shapesFilled;
    private bool plotArea;
    private bool showOutline;
    [NonSerialized]
    protected internal Polygon pArea;
    private double rangeBase;

    [HideFromJava]
    static XYStepAreaRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 232, (byte) 25, (byte) 231, (byte) 104, (byte) 103, (byte) 135, (byte) 100, (byte) 137, (byte) 100, (byte) 137, (byte) 100, (byte) 103, (byte) 135, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYStepAreaRenderer(int type, XYToolTipGenerator toolTipGenerator, XYURLGenerator urlGenerator)
    {
      XYStepAreaRenderer stepAreaRenderer = this;
      this.pArea = (Polygon) null;
      this.setBaseToolTipGenerator(toolTipGenerator);
      this.setURLGenerator(urlGenerator);
      if (type == 2)
        this.plotArea = true;
      else if (type == 1)
        this.shapesVisible = true;
      else if (type == 3)
      {
        this.plotArea = true;
        this.shapesVisible = true;
      }
      this.showOutline = false;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYStepAreaRenderer(int type)
      : this(type, (XYToolTipGenerator) null, (XYURLGenerator) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYStepAreaRenderer()
      : this(2)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYStepAreaRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYStepAreaRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYStepAreaRenderer obj0)
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

    public virtual double getRangeBase()
    {
      return this.rangeBase;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 227, (byte) 102, (byte) 102, (byte) 109, (byte) 104, (byte) 138, (byte) 109, (byte) 104, (byte) 136, (byte) 101, (byte) 133, (byte) 101, (byte) 131})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static double restrictValueToDataArea(double value, XYPlot plot, Rectangle2D dataArea)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        num1 = ((RectangularShape) dataArea).getMinY();
        num2 = ((RectangularShape) dataArea).getMaxY();
      }
      else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        num1 = ((RectangularShape) dataArea).getMinX();
        num2 = ((RectangularShape) dataArea).getMaxX();
      }
      if (value < num1)
        value = num1;
      else if (value > num2)
        value = num2;
      return value;
    }

    public virtual bool getShapesVisible()
    {
      return this.shapesVisible;
    }

    public virtual bool isShapesFilled()
    {
      return this.shapesFilled;
    }

    public virtual bool getPlotArea()
    {
      return this.plotArea;
    }

    public virtual bool isOutline()
    {
      return this.showOutline;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 94, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutline(bool show)
    {
      this.showOutline = show;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 87, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesVisible(bool flag)
    {
      this.shapesVisible = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 81, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesFilled(bool filled)
    {
      this.shapesFilled = filled;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 75, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlotArea(bool flag)
    {
      this.plotArea = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeBase(double val)
    {
      this.rangeBase = val;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 208, (byte) 206, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      XYItemRendererState itemRendererState = base.initialise(g2, dataArea, plot, data, info);
      itemRendererState.setProcessVisibleItemsOnly(false);
      return itemRendererState;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 249, (byte) 200, (byte) 138, (byte) 107, (byte) 107, (byte) 103, (byte) 167, (byte) 110, (byte) 110, (byte) 100, (byte) 118, (byte) 148, (byte) 212, (byte) 141, (byte) 183, (byte) 171, (byte) 216, (byte) 173, (byte) 104, (byte) 155, (byte) 104, (byte) 217, (byte) 102, (byte) 240, (byte) 69, (byte) 136, (byte) 112, (byte) 157, (byte) 100, (byte) 118, (byte) 148, (byte) 212, (byte) 141, (byte) 169, (byte) 100, (byte) 132, (byte) 134, (byte) 104, (byte) 155, (byte) 104, (byte) 249, (byte) 69, (byte) 99, (byte) 140, (byte) 104, (byte) 155, (byte) 104, (byte) 185, (byte) 107, (byte) 108, (byte) 104, (byte) 180, (byte) 104, (byte) 178, (byte) 104, (byte) 178, (byte) 210, (byte) 104, (byte) 191, (byte) 20, (byte) 104, (byte) 255, (byte) 18, (byte) 73, (byte) 191, (byte) 18, (byte) 216, (byte) 141, (byte) 136, (byte) 155, (byte) 136, (byte) 217, (byte) 172, (byte) 104, (byte) 109, (byte) 109, (byte) 204, (byte) 199, (byte) 105, (byte) 107, (byte) 107, (byte) 245, (byte) 69, (byte) 104, (byte) 100, (byte) 159, (byte) 30})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      PlotOrientation orientation = plot.getOrientation();
      int itemCount = dataset.getItemCount(series);
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      double xvalue1 = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double d1 = xvalue1;
      double d2 = !Double.isNaN(yvalue) ? yvalue : this.getRangeBase();
      double num1 = domainAxis.valueToJava2D(d1, dataArea, plot.getDomainAxisEdge());
      double num2 = XYStepAreaRenderer.restrictValueToDataArea(rangeAxis.valueToJava2D(d2, dataArea, plot.getRangeAxisEdge()), plot, dataArea);
      if (this.pArea == null && !Double.isNaN(yvalue))
      {
        this.pArea = new Polygon();
        double num3 = XYStepAreaRenderer.restrictValueToDataArea(rangeAxis.valueToJava2D(this.getRangeBase(), dataArea, plot.getRangeAxisEdge()), plot, dataArea);
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          this.pArea.addPoint(ByteCodeHelper.d2i(num1), ByteCodeHelper.d2i(num3));
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          this.pArea.addPoint(ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num1));
      }
      XYStepAreaRenderer.restrictValueToDataArea(this.getRangeBase(), plot, dataArea);
      if (item > 0)
      {
        double xvalue2 = dataset.getXValue(series, item - 1);
        double num3 = !Double.isNaN(yvalue) ? dataset.getYValue(series, item - 1) : yvalue;
        double d3 = xvalue2;
        double d4 = !Double.isNaN(num3) ? num3 : this.getRangeBase();
        double num4 = domainAxis.valueToJava2D(d3, dataArea, plot.getDomainAxisEdge());
        double num5 = XYStepAreaRenderer.restrictValueToDataArea(rangeAxis.valueToJava2D(d4, dataArea, plot.getRangeAxisEdge()), plot, dataArea);
        if (Double.isNaN(yvalue))
        {
          num1 = num4;
          num5 = num2;
        }
        if (num5 != num2)
        {
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            this.pArea.addPoint(ByteCodeHelper.d2i(num1), ByteCodeHelper.d2i(num5));
          else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            this.pArea.addPoint(ByteCodeHelper.d2i(num5), ByteCodeHelper.d2i(num1));
        }
      }
      object obj1 = (object) null;
      if (!Double.isNaN(yvalue))
      {
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          this.pArea.addPoint(ByteCodeHelper.d2i(num1), ByteCodeHelper.d2i(num2));
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          this.pArea.addPoint(ByteCodeHelper.d2i(num2), ByteCodeHelper.d2i(num1));
        if (this.getShapesVisible())
        {
          obj1 = (object) this.getItemShape(series, item);
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            obj1 = (object) ShapeUtilities.createTranslatedShape((Shape) obj1, num1, num2);
          else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            obj1 = (object) ShapeUtilities.createTranslatedShape((Shape) obj1, num2, num1);
          if (this.isShapesFilled())
            g2.fill((Shape) obj1);
          else
            g2.draw((Shape) obj1);
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          obj1 = (object) new Rectangle2D.Double(num1 - 2.0, num2 - 2.0, 4.0, 4.0);
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          obj1 = (object) new Rectangle2D.Double(num2 - 2.0, num1 - 2.0, 4.0, 4.0);
      }
      if (this.getPlotArea() && item > 0 && this.pArea != null && (item == itemCount - 1 || Double.isNaN(yvalue)))
      {
        double num3 = XYStepAreaRenderer.restrictValueToDataArea(rangeAxis.valueToJava2D(this.getRangeBase(), dataArea, plot.getRangeAxisEdge()), plot, dataArea);
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          this.pArea.addPoint(ByteCodeHelper.d2i(num1), ByteCodeHelper.d2i(num3));
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          this.pArea.addPoint(ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num1));
        g2.fill((Shape) this.pArea);
        if (this.isOutline())
        {
          g2.setStroke(plot.getOutlineStroke());
          g2.setPaint(plot.getOutlinePaint());
          g2.draw((Shape) this.pArea);
        }
        this.pArea = (Polygon) null;
      }
      if (!Double.isNaN(yvalue))
      {
        int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
        int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
        this.updateCrosshairValues(crosshairState, xvalue1, yvalue, domainAxisIndex, rangeAxisIndex, num1, num2, orientation);
      }
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      EntityCollection entities = entityCollection;
      object obj2 = obj1;
      XYDataset xyDataset1 = dataset;
      int num6 = series;
      int num7 = item;
      double num8 = num1;
      double num9 = num2;
      double num10 = num8;
      int num11 = num7;
      int num12 = num6;
      XYDataset xyDataset2 = xyDataset1;
      Shape area;
      if (obj2 != null)
      {
        Shape shape = obj2 as Shape;
        if (shape == null)
          throw new IncompatibleClassChangeError();
        area = shape;
      }
      else
        area = (Shape) null;
      XYDataset dataset1 = xyDataset2;
      int series1 = num12;
      int num13 = num11;
      double entityX = num10;
      double entityY = num9;
      this.addEntity(entities, area, dataset1, series1, num13, entityX, entityY);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 173, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYStepAreaRenderer))
        return false;
      XYStepAreaRenderer stepAreaRenderer = (XYStepAreaRenderer) obj;
      if (this.showOutline != stepAreaRenderer.showOutline || this.shapesVisible != stepAreaRenderer.shapesVisible || (this.shapesFilled != stepAreaRenderer.shapesFilled || this.plotArea != stepAreaRenderer.plotArea) || this.rangeBase != stepAreaRenderer.rangeBase)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 576)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
