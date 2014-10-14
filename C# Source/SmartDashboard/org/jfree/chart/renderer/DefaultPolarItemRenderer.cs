// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.DefaultPolarItemRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer
{
  [Implements(new string[] {"org.jfree.chart.renderer.PolarItemRenderer"})]
  [Serializable]
  public class DefaultPolarItemRenderer : AbstractRenderer, PolarItemRenderer
  {
    private PolarPlot plot;
    private BooleanList seriesFilled;

    [HideFromJava]
    static DefaultPolarItemRenderer()
    {
      AbstractRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultPolarItemRenderer()
    {
      DefaultPolarItemRenderer polarItemRenderer = this;
      this.seriesFilled = new BooleanList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultPolarItemRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public virtual PolarPlot getPlot()
    {
      return this.plot;
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 98, (byte) 109, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isSeriesFilled(int series)
    {
      int num = 0;
      Boolean boolean = this.seriesFilled.getBoolean(series);
      if (boolean != null)
        num = boolean.booleanValue() ? 1 : 0;
      return num != 0;
    }

    public virtual void setPlot(PolarPlot plot)
    {
      this.plot = plot;
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 98, (byte) 103, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DrawingSupplier getDrawingSupplier()
    {
      DrawingSupplier drawingSupplier = (DrawingSupplier) null;
      PolarPlot plot = this.getPlot();
      if (plot != null)
        drawingSupplier = plot.getDrawingSupplier();
      return drawingSupplier;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 103, (byte) 130, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesFilled(int series, bool filled)
    {
      int num = filled ? 1 : 0;
      this.seriesFilled.setBoolean(series, BooleanUtilities.valueOf(num != 0));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 102, (byte) 106, (byte) 102, (byte) 108, (byte) 109, (byte) 141, (byte) 244, (byte) 59, (byte) 230, (byte) 71, (byte) 110, (byte) 110, (byte) 106, (byte) 104, (byte) 145, (byte) 103, (byte) 104, (byte) 130, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawSeries(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info, PolarPlot plot, XYDataset dataset, int seriesIndex)
    {
      Polygon polygon = new Polygon();
      int itemCount = dataset.getItemCount(seriesIndex);
      for (int i2 = 0; i2 < itemCount; ++i2)
      {
        double xvalue = dataset.getXValue(seriesIndex, i2);
        double yvalue = dataset.getYValue(seriesIndex, i2);
        Point point = plot.translateValueThetaRadiusToJava2D(xvalue, yvalue, dataArea);
        polygon.addPoint((int) point.x, (int) point.y);
      }
      g2.setPaint(this.lookupSeriesPaint(seriesIndex));
      g2.setStroke(this.lookupSeriesStroke(seriesIndex));
      if (this.isSeriesFilled(seriesIndex))
      {
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, 0.5f));
        g2.fill((Shape) polygon);
        g2.setComposite(composite);
      }
      else
        g2.draw((Shape) polygon);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 108, (byte) 108, (byte) 140, (byte) 109, (byte) 136, (byte) 139, (byte) 103, (byte) 107, (byte) 109, (byte) 151, (byte) 108, (byte) 127, (byte) 1, (byte) 104, (byte) 105, (byte) 105, (byte) 108, (byte) 185, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawAngularGridLines(Graphics2D g2, PolarPlot plot, List ticks, Rectangle2D dataArea)
    {
      ((Graphics) g2).setFont(plot.getAngleLabelFont());
      g2.setStroke(plot.getAngleGridlineStroke());
      g2.setPaint(plot.getAngleGridlinePaint());
      double lowerBound = plot.getAxis().getLowerBound();
      double maxRadius = plot.getMaxRadius();
      Point point1 = plot.translateValueThetaRadiusToJava2D(lowerBound, lowerBound, dataArea);
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        NumberTick numberTick = (NumberTick) iterator.next();
        Point point2 = plot.translateValueThetaRadiusToJava2D(numberTick.getNumber().doubleValue(), maxRadius, dataArea);
        g2.setPaint(plot.getAngleGridlinePaint());
        ((Graphics) g2).drawLine((int) point1.x, (int) point1.y, (int) point2.x, (int) point2.y);
        if (plot.isAngleLabelsVisible())
        {
          int num1 = (int) point2.x;
          int num2 = (int) point2.y;
          g2.setPaint(plot.getAngleLabelPaint());
          TextUtilities.drawAlignedString(numberTick.getText(), g2, (float) num1, (float) num2, TextAnchor.__\u003C\u003ECENTER);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 108, (byte) 108, (byte) 140, (byte) 104, (byte) 171, (byte) 104, (byte) 107, (byte) 108, (byte) 158, (byte) 112, (byte) 107, (byte) 107, (byte) 102, (byte) 115, (byte) 108, (byte) 104, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRadialGridLines(Graphics2D g2, PolarPlot plot, ValueAxis radialAxis, List ticks, Rectangle2D dataArea)
    {
      ((Graphics) g2).setFont(radialAxis.getTickLabelFont());
      g2.setPaint(plot.getRadiusGridlinePaint());
      g2.setStroke(plot.getRadiusGridlineStroke());
      double lowerBound = radialAxis.getLowerBound();
      Point point = plot.translateValueThetaRadiusToJava2D(lowerBound, lowerBound, dataArea);
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        NumberTick numberTick = (NumberTick) iterator.next();
        int num1 = (int) (plot.translateValueThetaRadiusToJava2D(90.0, numberTick.getNumber().doubleValue(), dataArea).x - point.x);
        int num2 = point.x - num1;
        int num3 = point.y - num1;
        int num4 = 2 * num1;
        Ellipse2D.Double @double = new Ellipse2D.Double((double) num2, (double) num3, (double) num4, (double) num4);
        g2.setPaint(plot.getRadiusGridlinePaint());
        g2.draw((Shape) @double);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 98, (byte) 103, (byte) 102, (byte) 103, (byte) 99, (byte) 109, (byte) 99, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 147, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendItem getLegendItem(int series)
    {
      LegendItem legendItem = (LegendItem) null;
      PolarPlot plot = this.getPlot();
      if (plot != null)
      {
        XYDataset dataset = plot.getDataset();
        if (dataset != null)
        {
          string label = Object.instancehelper_toString((object) dataset.getSeriesKey(series));
          string description = label;
          Shape shape = this.lookupSeriesShape(series);
          Paint fillPaint = this.lookupSeriesPaint(series);
          Paint outlinePaint = this.lookupSeriesOutlinePaint(series);
          Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
          legendItem = new LegendItem(label, description, (string) null, (string) null, shape, fillPaint, outlineStroke, outlinePaint);
          legendItem.setDataset((Dataset) dataset);
        }
      }
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 200, (byte) 99, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == null || !(obj is DefaultPolarItemRenderer) || !this.seriesFilled.equals((object) ((DefaultPolarItemRenderer) obj).seriesFilled))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 221, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultPolarItemRenderer polarItemRenderer = (DefaultPolarItemRenderer) base.clone();
      polarItemRenderer.seriesFilled = (BooleanList) this.seriesFilled.clone();
      return (object) polarItemRenderer;
    }
  }
}
