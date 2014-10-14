// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYBubbleRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.ui;
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
  public class XYBubbleRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, PublicCloneable, Cloneable.__Interface
  {
    public const long serialVersionUID = -5221991598674249125L;
    public const int SCALE_ON_BOTH_AXES = 0;
    public const int SCALE_ON_DOMAIN_AXIS = 1;
    public const int SCALE_ON_RANGE_AXIS = 2;
    private int scaleType;

    [HideFromJava]
    static XYBubbleRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 104, (byte) 104, (byte) 144, (byte) 103, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBubbleRenderer(int scaleType)
    {
      XYBubbleRenderer xyBubbleRenderer = this;
      if (scaleType < 0 || scaleType > 2)
      {
        string str = "Invalid 'scaleType'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.scaleType = scaleType;
        this.setBaseLegendShape((Shape) new Ellipse2D.Double(-4.0, -4.0, 8.0, 8.0));
      }
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBubbleRenderer()
      : this(0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYBubbleRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYBubbleRenderer obj0)
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

    public virtual int getScaleType()
    {
      return this.scaleType;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 108, (byte) 161, (byte) 168, (byte) 109, (byte) 109, (byte) 106, (byte) 105, (byte) 105, (byte) 141, (byte) 107, (byte) 105, (byte) 105, (byte) 142, (byte) 174, (byte) 102, (byte) 166, (byte) 151, (byte) 146, (byte) 145, (byte) 100, (byte) 133, (byte) 146, (byte) 145, (byte) 100, (byte) 130, (byte) 146, (byte) 146, (byte) 145, (byte) 177, (byte) 106, (byte) 106, (byte) 99, (byte) 104, (byte) 191, (byte) 12, (byte) 104, (byte) 191, (byte) 10, (byte) 112, (byte) 104, (byte) 112, (byte) 112, (byte) 136, (byte) 108, (byte) 104, (byte) 181, (byte) 104, (byte) 243, (byte) 70, (byte) 98, (byte) 100, (byte) 110, (byte) 110, (byte) 254, (byte) 69, (byte) 107, (byte) 107, (byte) 213})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      PlotOrientation orientation = plot.getOrientation();
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double d = double.NaN;
      if (dataset is XYZDataset)
        d = ((XYZDataset) dataset).getZValue(series, item);
      if (Double.isNaN(d))
        return;
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num1 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
      double num2 = rangeAxis.valueToJava2D(yvalue, dataArea, rangeAxisEdge);
      int scaleType = this.getScaleType();
      int num3 = 1;
      double num4;
      double num5;
      if (scaleType == num3)
      {
        double num6 = domainAxis.valueToJava2D(0.0, dataArea, domainAxisEdge);
        num4 = domainAxis.valueToJava2D(d, dataArea, domainAxisEdge) - num6;
        num5 = num4;
      }
      else
      {
        int num6 = 2;
        if (scaleType == num6)
        {
          num5 = rangeAxis.valueToJava2D(0.0, dataArea, rangeAxisEdge) - rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
          num4 = num5;
        }
        else
        {
          double num7 = domainAxis.valueToJava2D(0.0, dataArea, domainAxisEdge);
          double num8 = rangeAxis.valueToJava2D(0.0, dataArea, rangeAxisEdge);
          num4 = domainAxis.valueToJava2D(d, dataArea, domainAxisEdge) - num7;
          num5 = num8 - rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
        }
      }
      double num9 = Math.abs(num4);
      double num10 = Math.abs(num5);
      Ellipse2D.Double @double = (Ellipse2D.Double) null;
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Ellipse2D.Double(num1 - num9 / 2.0, num2 - num10 / 2.0, num9, num10);
      else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Ellipse2D.Double(num2 - num10 / 2.0, num1 - num9 / 2.0, num10, num9);
      g2.setPaint(this.getItemPaint(series, item));
      g2.fill((Shape) @double);
      g2.setStroke(this.getItemOutlineStroke(series, item));
      g2.setPaint(this.getItemOutlinePaint(series, item));
      g2.draw((Shape) @double);
      if (this.isItemLabelVisible(series, item))
      {
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          this.drawItemLabel(g2, orientation, dataset, series, item, num1, num2, false);
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          this.drawItemLabel(g2, orientation, dataset, series, item, num2, num1, false);
      }
      if (info != null)
      {
        EntityCollection entityCollection = info.getOwner().getEntityCollection();
        if (entityCollection != null && ((RectangularShape) @double).intersects(dataArea))
          this.addEntity(entityCollection, (Shape) @double, dataset, series, item, ((RectangularShape) @double).getCenterX(), ((RectangularShape) @double).getCenterY());
      }
      int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
      int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
      this.updateCrosshairValues(crosshairState, xvalue, yvalue, domainAxisIndex, rangeAxisIndex, num1, num2, orientation);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 98, (byte) 103, (byte) 99, (byte) 162, (byte) 104, (byte) 102, (byte) 109, (byte) 142, (byte) 99, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 149, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 103, (byte) 103, (byte) 109, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItem getLegendItem(int datasetIndex, int series)
    {
      LegendItem legendItem = (LegendItem) null;
      XYPlot plot = this.getPlot();
      if (plot == null)
        return (LegendItem) null;
      XYDataset dataset = plot.getDataset(datasetIndex);
      if (dataset != null && this.getItemVisible(series, 0))
      {
        string label = this.getLegendItemLabelGenerator().generateLabel(dataset, series);
        string description = label;
        string toolTipText = (string) null;
        if (this.getLegendItemToolTipGenerator() != null)
          toolTipText = this.getLegendItemToolTipGenerator().generateLabel(dataset, series);
        string urlText = (string) null;
        if (this.getLegendItemURLGenerator() != null)
          urlText = this.getLegendItemURLGenerator().generateLabel(dataset, series);
        Shape shape = this.lookupLegendShape(series);
        Paint fillPaint = this.lookupSeriesPaint(series);
        Paint outlinePaint = this.lookupSeriesOutlinePaint(series);
        Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
        legendItem = new LegendItem(label, description, toolTipText, urlText, shape, fillPaint, outlineStroke, outlinePaint);
        legendItem.setLabelFont(this.lookupLegendTextFont(series));
        Paint paint = this.lookupLegendTextPaint(series);
        if (paint != null)
          legendItem.setLabelPaint(paint);
        legendItem.setDataset((Dataset) dataset);
        legendItem.setDatasetIndex(datasetIndex);
        legendItem.setSeriesKey(dataset.getSeriesKey(series));
        legendItem.setSeriesIndex(series);
      }
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 222, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYBubbleRenderer) || this.scaleType != ((XYBubbleRenderer) obj).scaleType)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 357)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
