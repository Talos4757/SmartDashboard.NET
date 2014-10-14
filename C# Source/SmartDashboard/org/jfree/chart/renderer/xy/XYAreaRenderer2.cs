// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYAreaRenderer2
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
  public class XYAreaRenderer2 : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, PublicCloneable, Cloneable.__Interface
  {
    private const long serialVersionUID = -7378069681579984133L;
    private bool showOutline;
    [NonSerialized]
    private Shape legendArea;

    [HideFromJava]
    static XYAreaRenderer2()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 102, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 102, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYAreaRenderer2(XYToolTipGenerator labelGenerator, XYURLGenerator urlGenerator)
    {
      XYAreaRenderer2 xyAreaRenderer2 = this;
      this.showOutline = false;
      this.setBaseToolTipGenerator(labelGenerator);
      this.setURLGenerator(urlGenerator);
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo(0.0f, -4f);
      ((Path2D.Float) generalPath).lineTo(3f, -2f);
      ((Path2D.Float) generalPath).lineTo(4f, 4f);
      ((Path2D.Float) generalPath).lineTo(-4f, 4f);
      ((Path2D.Float) generalPath).lineTo(-3f, -2f);
      ((Path2D) generalPath).closePath();
      this.legendArea = (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYAreaRenderer2()
      : this((XYToolTipGenerator) null, (XYURLGenerator) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYAreaRenderer2([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYAreaRenderer2 obj0)
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 96, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutline(bool show)
    {
      this.showOutline = show;
      this.fireChangeEvent();
    }

    public virtual bool isOutline()
    {
      return this.showOutline;
    }

    [Obsolete]
    public virtual bool getPlotLines()
    {
      return false;
    }

    public virtual Shape getLegendArea()
    {
      return this.legendArea;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 98, (byte) 103, (byte) 102, (byte) 104, (byte) 102, (byte) 103, (byte) 106, (byte) 100, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 155, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 103, (byte) 103, (byte) 109, (byte) 167})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 192, (byte) 108, (byte) 161, (byte) 109, (byte) 109, (byte) 104, (byte) 166, (byte) 146, (byte) 242, (byte) 69, (byte) 118, (byte) 118, (byte) 105, (byte) 135, (byte) 148, (byte) 180, (byte) 107, (byte) 153, (byte) 153, (byte) 105, (byte) 135, (byte) 148, (byte) 180, (byte) 151, (byte) 98, (byte) 113, (byte) 103, (byte) 159, (byte) 2, (byte) 159, (byte) 14, (byte) 115, (byte) 159, (byte) 14, (byte) 223, (byte) 7, (byte) 103, (byte) 159, (byte) 2, (byte) 159, (byte) 14, (byte) 115, (byte) 159, (byte) 14, (byte) 223, (byte) 2, (byte) 105, (byte) 108, (byte) 108, (byte) 104, (byte) 200, (byte) 168, (byte) 104, (byte) 110, (byte) 110, (byte) 136, (byte) 107, (byte) 107, (byte) 210, (byte) 107, (byte) 104, (byte) 107, (byte) 99, (byte) 140, (byte) 100, (byte) 143, (byte) 99, (byte) 104, (byte) 147, (byte) 147, (byte) 203})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      double xvalue1 = dataset.getXValue(series, item);
      double num1 = dataset.getYValue(series, item);
      if (Double.isNaN(num1))
        num1 = 0.0;
      double transX = domainAxis.valueToJava2D(xvalue1, dataArea, plot.getDomainAxisEdge());
      double transY = rangeAxis.valueToJava2D(num1, dataArea, plot.getRangeAxisEdge());
      double xvalue2 = dataset.getXValue(series, Math.max(item - 1, 0));
      double d1 = dataset.getYValue(series, Math.max(item - 1, 0));
      if (Double.isNaN(d1))
        d1 = 0.0;
      double num2 = domainAxis.valueToJava2D(xvalue2, dataArea, plot.getDomainAxisEdge());
      double num3 = rangeAxis.valueToJava2D(d1, dataArea, plot.getRangeAxisEdge());
      int itemCount = dataset.getItemCount(series);
      double xvalue3 = dataset.getXValue(series, Math.min(item + 1, itemCount - 1));
      double d2 = dataset.getYValue(series, Math.min(item + 1, itemCount - 1));
      if (Double.isNaN(d2))
        d2 = 0.0;
      double num4 = domainAxis.valueToJava2D(xvalue3, dataArea, plot.getDomainAxisEdge());
      double num5 = rangeAxis.valueToJava2D(d2, dataArea, plot.getRangeAxisEdge());
      double num6 = rangeAxis.valueToJava2D(0.0, dataArea, plot.getRangeAxisEdge());
      Polygon polygon;
      if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        polygon = new Polygon();
        polygon.addPoint(ByteCodeHelper.d2i(num6), ByteCodeHelper.d2i((num2 + transX) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i((num3 + transY) / 2.0), ByteCodeHelper.d2i((num2 + transX) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i(transY), ByteCodeHelper.d2i(transX));
        polygon.addPoint(ByteCodeHelper.d2i((transY + num5) / 2.0), ByteCodeHelper.d2i((transX + num4) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i(num6), ByteCodeHelper.d2i((transX + num4) / 2.0));
      }
      else
      {
        polygon = new Polygon();
        polygon.addPoint(ByteCodeHelper.d2i((num2 + transX) / 2.0), ByteCodeHelper.d2i(num6));
        polygon.addPoint(ByteCodeHelper.d2i((num2 + transX) / 2.0), ByteCodeHelper.d2i((num3 + transY) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i(transX), ByteCodeHelper.d2i(transY));
        polygon.addPoint(ByteCodeHelper.d2i((transX + num4) / 2.0), ByteCodeHelper.d2i((transY + num5) / 2.0));
        polygon.addPoint(ByteCodeHelper.d2i((transX + num4) / 2.0), ByteCodeHelper.d2i(num6));
      }
      PlotOrientation orientation = plot.getOrientation();
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      g2.fill((Shape) polygon);
      if (this.isOutline())
      {
        g2.setStroke(this.lookupSeriesOutlineStroke(series));
        g2.setPaint(this.lookupSeriesOutlinePaint(series));
        g2.draw((Shape) polygon);
      }
      int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
      int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
      this.updateCrosshairValues(crosshairState, xvalue1, num1, domainAxisIndex, rangeAxisIndex, transX, transY, orientation);
      if (state.getInfo() == null)
        return;
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null || polygon == null)
        return;
      string toolTipText = (string) null;
      XYToolTipGenerator toolTipGenerator = this.getToolTipGenerator(series, item);
      if (toolTipGenerator != null)
        toolTipText = toolTipGenerator.generateToolTip(dataset, series, item);
      string urlText = (string) null;
      if (this.getURLGenerator() != null)
        urlText = this.getURLGenerator().generateURL(dataset, series, item);
      XYItemEntity xyItemEntity = new XYItemEntity((Shape) polygon, dataset, series, item, toolTipText, urlText);
      entityCollection.add((ChartEntity) xyItemEntity);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 55, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYAreaRenderer2))
        return false;
      XYAreaRenderer2 xyAreaRenderer2 = (XYAreaRenderer2) obj;
      if (this.showOutline != xyAreaRenderer2.showOutline || !ShapeUtilities.equal(this.legendArea, xyAreaRenderer2.legendArea))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 79, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYAreaRenderer2 xyAreaRenderer2 = (XYAreaRenderer2) base.clone();
      xyAreaRenderer2.legendArea = ShapeUtilities.clone(this.legendArea);
      return (object) xyAreaRenderer2;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 94, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendArea = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 106, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendArea, obj0);
    }
  }
}
