// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYAreaRenderer
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
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class XYAreaRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, PublicCloneable, Cloneable.__Interface
  {
    private const long serialVersionUID = -4481971353973876747L;
    public const int SHAPES = 1;
    public const int LINES = 2;
    public const int SHAPES_AND_LINES = 3;
    public const int AREA = 4;
    public const int AREA_AND_SHAPES = 5;
    private bool plotShapes;
    private bool plotLines;
    private bool plotArea;
    private bool showOutline;
    [NonSerialized]
    private Shape legendArea;

    [HideFromJava]
    static XYAreaRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 104, (byte) 103, (byte) 135, (byte) 100, (byte) 135, (byte) 100, (byte) 135, (byte) 100, (byte) 103, (byte) 135, (byte) 100, (byte) 135, (byte) 100, (byte) 103, (byte) 135, (byte) 103, (byte) 102, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 102, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYAreaRenderer(int type, XYToolTipGenerator toolTipGenerator, XYURLGenerator urlGenerator)
    {
      XYAreaRenderer xyAreaRenderer = this;
      this.setBaseToolTipGenerator(toolTipGenerator);
      this.setURLGenerator(urlGenerator);
      if (type == 1)
        this.plotShapes = true;
      if (type == 2)
        this.plotLines = true;
      if (type == 3)
      {
        this.plotShapes = true;
        this.plotLines = true;
      }
      if (type == 4)
        this.plotArea = true;
      if (type == 5)
      {
        this.plotArea = true;
        this.plotShapes = true;
      }
      this.showOutline = false;
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(0.0f, -4f);
      ((Path2D.Float) generalPath).lineTo(3f, -2f);
      ((Path2D.Float) generalPath).lineTo(4f, 4f);
      ((Path2D.Float) generalPath).lineTo(-4f, 4f);
      ((Path2D.Float) generalPath).lineTo(-3f, -2f);
      ((Path2D) generalPath).closePath();
      this.legendArea = (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYAreaRenderer(int type)
      : this(type, (XYToolTipGenerator) null, (XYURLGenerator) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYAreaRenderer()
      : this(4)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYAreaRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYAreaRenderer obj0)
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

    public virtual bool getPlotShapes()
    {
      return this.plotShapes;
    }

    public virtual bool getPlotLines()
    {
      return this.plotLines;
    }

    public virtual bool getPlotArea()
    {
      return this.plotArea;
    }

    public virtual bool isOutline()
    {
      return this.showOutline;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 67, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutline(bool show)
    {
      this.showOutline = show;
      this.fireChangeEvent();
    }

    public virtual Shape getLegendArea()
    {
      return this.legendArea;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 207, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendArea(Shape area)
    {
      if (area == null)
      {
        string str = "Null 'area' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendArea = area;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 200, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      XYAreaRenderer.XYAreaRendererState areaRendererState = new XYAreaRenderer.XYAreaRendererState(info);
      areaRendererState.setProcessVisibleItemsOnly(false);
      return (XYItemRendererState) areaRendererState;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 247, (byte) 98, (byte) 103, (byte) 102, (byte) 104, (byte) 102, (byte) 103, (byte) 106, (byte) 100, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 155, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 103, (byte) 103, (byte) 109, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItem getLegendItem(int datasetIndex, int series)
    {
      LegendItem legendItem = (LegendItem) null;
      XYPlot plot = this.getPlot();
      if (plot != null)
      {
        XYDataset dataset = plot.getDataset(datasetIndex);
        if (dataset != null)
        {
          string label = this.getLegendItemLabelGenerator().generateLabel(dataset, series);
          string description = label;
          string toolTipText = (string) null;
          if (this.getLegendItemToolTipGenerator() != null)
            toolTipText = this.getLegendItemToolTipGenerator().generateLabel(dataset, series);
          string urlText = (string) null;
          if (this.getLegendItemURLGenerator() != null)
            urlText = this.getLegendItemURLGenerator().generateLabel(dataset, series);
          Paint fillPaint = this.lookupSeriesPaint(series);
          LegendItem.__\u003Cclinit\u003E();
          legendItem = new LegendItem(label, description, toolTipText, urlText, this.legendArea, fillPaint);
          legendItem.setLabelFont(this.lookupLegendTextFont(series));
          Paint paint = this.lookupLegendTextPaint(series);
          if (paint != null)
            legendItem.setLabelPaint(paint);
          legendItem.setDataset((Dataset) dataset);
          legendItem.setDatasetIndex(datasetIndex);
          legendItem.setSeriesKey(dataset.getSeriesKey(series));
          legendItem.setSeriesIndex(series);
        }
      }
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 108, (byte) 129, (byte) 167, (byte) 109, (byte) 109, (byte) 104, (byte) 134, (byte) 146, (byte) 243, (byte) 69, (byte) 107, (byte) 118, (byte) 118, (byte) 105, (byte) 135, (byte) 148, (byte) 180, (byte) 153, (byte) 153, (byte) 105, (byte) 135, (byte) 148, (byte) 180, (byte) 151, (byte) 98, (byte) 113, (byte) 103, (byte) 159, (byte) 2, (byte) 159, (byte) 15, (byte) 116, (byte) 159, (byte) 15, (byte) 223, (byte) 7, (byte) 103, (byte) 159, (byte) 2, (byte) 159, (byte) 15, (byte) 116, (byte) 159, (byte) 15, (byte) 223, (byte) 2, (byte) 103, (byte) 139, (byte) 151, (byte) 110, (byte) 154, (byte) 110, (byte) 248, (byte) 69, (byte) 110, (byte) 154, (byte) 110, (byte) 184, (byte) 105, (byte) 108, (byte) 108, (byte) 104, (byte) 136, (byte) 98, (byte) 104, (byte) 108, (byte) 105, (byte) 174, (byte) 105, (byte) 172, (byte) 168, (byte) 104, (byte) 101, (byte) 110, (byte) 148, (byte) 110, (byte) 146, (byte) 236, (byte) 70, (byte) 158, (byte) 137, (byte) 154, (byte) 137, (byte) 184, (byte) 172, (byte) 107, (byte) 232, (byte) 71, (byte) 106, (byte) 108, (byte) 105, (byte) 108, (byte) 210, (byte) 223, (byte) 50, (byte) 105, (byte) 196, (byte) 104, (byte) 110, (byte) 219, (byte) 107, (byte) 107, (byte) 211, (byte) 104, (byte) 104, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      XYAreaRenderer.XYAreaRendererState areaRendererState = (XYAreaRenderer.XYAreaRendererState) state;
      double xvalue1 = dataset.getXValue(series, item);
      double num1 = dataset.getYValue(series, item);
      if (Double.isNaN(num1))
        num1 = 0.0;
      double num2 = domainAxis.valueToJava2D(xvalue1, dataArea, plot.getDomainAxisEdge());
      double num3 = rangeAxis.valueToJava2D(num1, dataArea, plot.getRangeAxisEdge());
      int itemCount = dataset.getItemCount(series);
      double xvalue2 = dataset.getXValue(series, Math.max(item - 1, 0));
      double d1 = dataset.getYValue(series, Math.max(item - 1, 0));
      if (Double.isNaN(d1))
        d1 = 0.0;
      double num4 = domainAxis.valueToJava2D(xvalue2, dataArea, plot.getDomainAxisEdge());
      double num5 = rangeAxis.valueToJava2D(d1, dataArea, plot.getRangeAxisEdge());
      double xvalue3 = dataset.getXValue(series, Math.min(item + 1, itemCount - 1));
      double d2 = dataset.getYValue(series, Math.min(item + 1, itemCount - 1));
      if (Double.isNaN(d2))
        d2 = 0.0;
      double num6 = domainAxis.valueToJava2D(xvalue3, dataArea, plot.getDomainAxisEdge());
      double num7 = rangeAxis.valueToJava2D(d2, dataArea, plot.getRangeAxisEdge());
      double num8 = rangeAxis.valueToJava2D(0.0, dataArea, plot.getRangeAxisEdge());
      Polygon polygon;
      if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        polygon = new Polygon();
        polygon.addPoint(ByteCodeHelper.d2i(num8), ByteCodeHelper.d2i((num4 + num2) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i((num5 + num3) / 2.0), ByteCodeHelper.d2i((num4 + num2) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num2));
        polygon.addPoint(ByteCodeHelper.d2i((num3 + num7) / 2.0), ByteCodeHelper.d2i((num2 + num6) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i(num8), ByteCodeHelper.d2i((num2 + num6) / 2.0));
      }
      else
      {
        polygon = new Polygon();
        polygon.addPoint(ByteCodeHelper.d2i((num4 + num2) / 2.0), ByteCodeHelper.d2i(num8));
        polygon.addPoint(ByteCodeHelper.d2i((num4 + num2) / 2.0), ByteCodeHelper.d2i((num5 + num3) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i(num2), ByteCodeHelper.d2i(num3));
        polygon.addPoint(ByteCodeHelper.d2i((num2 + num6) / 2.0), ByteCodeHelper.d2i((num3 + num7) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i((num2 + num6) / 2.0), ByteCodeHelper.d2i(num8));
      }
      if (item == 0)
      {
        areaRendererState.area = new Polygon();
        double num9 = rangeAxis.valueToJava2D(0.0, dataArea, plot.getRangeAxisEdge());
        if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
          areaRendererState.area.addPoint(ByteCodeHelper.d2i(num2), ByteCodeHelper.d2i(num9));
        else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
          areaRendererState.area.addPoint(ByteCodeHelper.d2i(num9), ByteCodeHelper.d2i(num2));
      }
      if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
        areaRendererState.area.addPoint(ByteCodeHelper.d2i(num2), ByteCodeHelper.d2i(num3));
      else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        areaRendererState.area.addPoint(ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num2));
      PlotOrientation orientation = plot.getOrientation();
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      if (this.getPlotShapes())
      {
        Shape shape = this.getItemShape(series, item);
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num2, num3);
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num3, num2);
        g2.draw(shape);
      }
      if (this.getPlotLines() && item > 0)
      {
        if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
          areaRendererState.line.setLine(num4, num5, num2, num3);
        else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
          areaRendererState.line.setLine(num5, num4, num3, num2);
        g2.draw((Shape) areaRendererState.line);
      }
      if (this.getPlotArea() && item > 0 && item == itemCount - 1)
      {
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          areaRendererState.area.addPoint(ByteCodeHelper.d2i(num2), ByteCodeHelper.d2i(num8));
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          areaRendererState.area.addPoint(ByteCodeHelper.d2i(num8), ByteCodeHelper.d2i(num2));
        g2.fill((Shape) areaRendererState.area);
        if (this.isOutline())
        {
          object obj1 = (object) areaRendererState.area;
          Stroke stroke = this.lookupSeriesOutlineStroke(series);
          if (stroke is BasicStroke && ((BasicStroke) stroke).getDashArray() != null)
          {
            Area.__\u003Cclinit\u003E();
            Area area1 = new Area((Shape) areaRendererState.area);
            Area.__\u003Cclinit\u003E();
            Area area2 = new Area((Shape) new Rectangle2D.Double(((RectangularShape) dataArea).getX() - 5.0, ((RectangularShape) dataArea).getY() - 5.0, ((RectangularShape) dataArea).getWidth() + 10.0, ((RectangularShape) dataArea).getHeight() + 10.0));
            area1.intersect(area2);
            obj1 = (object) area1;
          }
          g2.setStroke(stroke);
          g2.setPaint(this.lookupSeriesOutlinePaint(series));
          Graphics2D graphics2D = g2;
          object obj2 = obj1;
          Shape shape1;
          if (obj2 != null)
          {
            Shape shape2 = obj2 as Shape;
            if (shape2 == null)
              throw new IncompatibleClassChangeError();
            shape1 = shape2;
          }
          else
            shape1 = (Shape) null;
          graphics2D.draw(shape1);
        }
      }
      int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
      int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
      this.updateCrosshairValues(crosshairState, xvalue1, num1, domainAxisIndex, rangeAxisIndex, num2, num3, orientation);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null || polygon == null)
        return;
      this.addEntity(entityCollection, (Shape) polygon, dataset, series, item, 0.0, 0.0);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 239, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYAreaRenderer xyAreaRenderer = (XYAreaRenderer) base.clone();
      xyAreaRenderer.legendArea = ShapeUtilities.clone(this.legendArea);
      return (object) xyAreaRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 252, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYAreaRenderer))
        return false;
      XYAreaRenderer xyAreaRenderer = (XYAreaRenderer) obj;
      return this.plotArea == xyAreaRenderer.plotArea && this.plotLines == xyAreaRenderer.plotLines && (this.plotShapes == xyAreaRenderer.plotShapes && this.showOutline == xyAreaRenderer.showOutline) && ShapeUtilities.equal(this.legendArea, xyAreaRenderer.legendArea);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 31, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendArea = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 43, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendArea, obj0);
    }

    [InnerClass]
    [SourceFile("XYAreaRenderer.java")]
    [Modifiers]
    internal sealed class XYAreaRendererState : XYItemRendererState
    {
      public Polygon area;
      public Line2D line;

      [LineNumberTable(new byte[] {(byte) 96, (byte) 105, (byte) 107, (byte) 107})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public XYAreaRendererState([In] PlotRenderingInfo obj0)
        : base(obj0)
      {
        XYAreaRenderer.XYAreaRendererState areaRendererState = this;
        this.area = new Polygon();
        this.line = (Line2D) new Line2D.Double();
      }
    }
  }
}
