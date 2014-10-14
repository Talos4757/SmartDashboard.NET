// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYItemRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.annotations;
using org.jfree.chart.axis;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.xy;
using org.jfree.ui;
using System;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.LegendItemSource"})]
  public interface XYItemRenderer : LegendItemSource
  {
    void setBaseToolTipGenerator(XYToolTipGenerator xyttg);

    void setURLGenerator(XYURLGenerator xyurlg);

    void setBaseItemLabelFont(Font f);

    void setBaseItemLabelPaint(Paint p);

    void setPlot(XYPlot xyp);

    void addChangeListener(RendererChangeListener rcl);

    void removeChangeListener(RendererChangeListener rcl);

    void drawAnnotations(Graphics2D gd, Rectangle2D rd, ValueAxis va1, ValueAxis va2, Layer l, PlotRenderingInfo pri);

    void fillDomainGridBand(Graphics2D gd, XYPlot xyp, ValueAxis va, Rectangle2D rd, double d1, double d2);

    void fillRangeGridBand(Graphics2D gd, XYPlot xyp, ValueAxis va, Rectangle2D rd, double d1, double d2);

    XYItemRendererState initialise(Graphics2D gd, Rectangle2D rd, XYPlot xyp, XYDataset xyd, PlotRenderingInfo pri);

    int getPassCount();

    void drawItem(Graphics2D gd, XYItemRendererState xyirs, Rectangle2D rd, PlotRenderingInfo pri, XYPlot xyp, ValueAxis va1, ValueAxis va2, XYDataset xyd, int i1, int i2, CrosshairState cs, int i3);

    void drawRangeLine(Graphics2D gd, XYPlot xyp, ValueAxis va, Rectangle2D rd, double d, Paint p, Stroke s);

    void drawDomainMarker(Graphics2D gd, XYPlot xyp, ValueAxis va, Marker m, Rectangle2D rd);

    void drawRangeMarker(Graphics2D gd, XYPlot xyp, ValueAxis va, Marker m, Rectangle2D rd);

    Range findDomainBounds(XYDataset xyd);

    Range findRangeBounds(XYDataset xyd);

    bool isSeriesVisible(int i);

    bool isSeriesVisibleInLegend(int i);

    LegendItem getLegendItem(int i1, int i2);

    XYPlot getPlot();

    bool getItemVisible(int i1, int i2);

    Boolean getSeriesVisible(int i);

    void setSeriesVisible(int i, Boolean b);

    void setSeriesVisible(int i, Boolean b1, bool b2);

    bool getBaseSeriesVisible();

    void setBaseSeriesVisible(bool b);

    void setBaseSeriesVisible(bool b1, bool b2);

    Boolean getSeriesVisibleInLegend(int i);

    void setSeriesVisibleInLegend(int i, Boolean b);

    void setSeriesVisibleInLegend(int i, Boolean b1, bool b2);

    bool getBaseSeriesVisibleInLegend();

    void setBaseSeriesVisibleInLegend(bool b);

    void setBaseSeriesVisibleInLegend(bool b1, bool b2);

    Paint getItemPaint(int i1, int i2);

    Paint getSeriesPaint(int i);

    void setSeriesPaint(int i, Paint p);

    Paint getBasePaint();

    void setBasePaint(Paint p);

    Paint getItemOutlinePaint(int i1, int i2);

    Paint getSeriesOutlinePaint(int i);

    void setSeriesOutlinePaint(int i, Paint p);

    Paint getBaseOutlinePaint();

    void setBaseOutlinePaint(Paint p);

    Stroke getItemStroke(int i1, int i2);

    Stroke getSeriesStroke(int i);

    void setSeriesStroke(int i, Stroke s);

    Stroke getBaseStroke();

    void setBaseStroke(Stroke s);

    Stroke getItemOutlineStroke(int i1, int i2);

    Stroke getSeriesOutlineStroke(int i);

    void setSeriesOutlineStroke(int i, Stroke s);

    Stroke getBaseOutlineStroke();

    void setBaseOutlineStroke(Stroke s);

    Shape getItemShape(int i1, int i2);

    Shape getSeriesShape(int i);

    void setSeriesShape(int i, Shape s);

    Shape getBaseShape();

    void setBaseShape(Shape s);

    XYSeriesLabelGenerator getLegendItemLabelGenerator();

    void setLegendItemLabelGenerator(XYSeriesLabelGenerator xyslg);

    XYToolTipGenerator getToolTipGenerator(int i1, int i2);

    XYToolTipGenerator getSeriesToolTipGenerator(int i);

    void setSeriesToolTipGenerator(int i, XYToolTipGenerator xyttg);

    XYToolTipGenerator getBaseToolTipGenerator();

    XYURLGenerator getURLGenerator();

    bool isItemLabelVisible(int i1, int i2);

    bool isSeriesItemLabelsVisible(int i);

    void setSeriesItemLabelsVisible(int i, bool b);

    void setSeriesItemLabelsVisible(int i, Boolean b);

    void setSeriesItemLabelsVisible(int i, Boolean b1, bool b2);

    Boolean getBaseItemLabelsVisible();

    void setBaseItemLabelsVisible(bool b);

    void setBaseItemLabelsVisible(Boolean b);

    void setBaseItemLabelsVisible(Boolean b1, bool b2);

    XYItemLabelGenerator getItemLabelGenerator(int i1, int i2);

    XYItemLabelGenerator getSeriesItemLabelGenerator(int i);

    void setSeriesItemLabelGenerator(int i, XYItemLabelGenerator xyilg);

    XYItemLabelGenerator getBaseItemLabelGenerator();

    void setBaseItemLabelGenerator(XYItemLabelGenerator xyilg);

    Font getItemLabelFont(int i1, int i2);

    Font getSeriesItemLabelFont(int i);

    void setSeriesItemLabelFont(int i, Font f);

    Font getBaseItemLabelFont();

    Paint getItemLabelPaint(int i1, int i2);

    Paint getSeriesItemLabelPaint(int i);

    void setSeriesItemLabelPaint(int i, Paint p);

    Paint getBaseItemLabelPaint();

    ItemLabelPosition getPositiveItemLabelPosition(int i1, int i2);

    ItemLabelPosition getSeriesPositiveItemLabelPosition(int i);

    void setSeriesPositiveItemLabelPosition(int i, ItemLabelPosition ilp);

    void setSeriesPositiveItemLabelPosition(int i, ItemLabelPosition ilp, bool b);

    ItemLabelPosition getBasePositiveItemLabelPosition();

    void setBasePositiveItemLabelPosition(ItemLabelPosition ilp);

    void setBasePositiveItemLabelPosition(ItemLabelPosition ilp, bool b);

    ItemLabelPosition getNegativeItemLabelPosition(int i1, int i2);

    ItemLabelPosition getSeriesNegativeItemLabelPosition(int i);

    void setSeriesNegativeItemLabelPosition(int i, ItemLabelPosition ilp);

    void setSeriesNegativeItemLabelPosition(int i, ItemLabelPosition ilp, bool b);

    ItemLabelPosition getBaseNegativeItemLabelPosition();

    void setBaseNegativeItemLabelPosition(ItemLabelPosition ilp);

    void setBaseNegativeItemLabelPosition(ItemLabelPosition ilp, bool b);

    void addAnnotation(XYAnnotation xya);

    void addAnnotation(XYAnnotation xya, Layer l);

    bool removeAnnotation(XYAnnotation xya);

    void removeAnnotations();

    void drawDomainGridLine(Graphics2D gd, XYPlot xyp, ValueAxis va, Rectangle2D rd, double d);

    [Obsolete]
    Boolean getSeriesVisible();

    [Obsolete]
    void setSeriesVisible(Boolean b);

    [Obsolete]
    void setSeriesVisible(Boolean b1, bool b2);

    [Obsolete]
    Boolean getSeriesVisibleInLegend();

    [Obsolete]
    void setSeriesVisibleInLegend(Boolean b);

    [Obsolete]
    void setSeriesVisibleInLegend(Boolean b1, bool b2);

    [Obsolete]
    void setPaint(Paint p);

    [Obsolete]
    void setOutlinePaint(Paint p);

    [Obsolete]
    void setStroke(Stroke s);

    [Obsolete]
    void setOutlineStroke(Stroke s);

    [Obsolete]
    void setShape(Shape s);

    [Obsolete]
    void setItemLabelsVisible(bool b);

    [Obsolete]
    void setItemLabelsVisible(Boolean b);

    [Obsolete]
    void setItemLabelsVisible(Boolean b1, bool b2);

    [Obsolete]
    void setItemLabelGenerator(XYItemLabelGenerator xyilg);

    [Obsolete]
    void setToolTipGenerator(XYToolTipGenerator xyttg);

    [Obsolete]
    Font getItemLabelFont();

    [Obsolete]
    void setItemLabelFont(Font f);

    [Obsolete]
    Paint getItemLabelPaint();

    [Obsolete]
    void setItemLabelPaint(Paint p);

    [Obsolete]
    ItemLabelPosition getPositiveItemLabelPosition();

    [Obsolete]
    void setPositiveItemLabelPosition(ItemLabelPosition ilp);

    [Obsolete]
    void setPositiveItemLabelPosition(ItemLabelPosition ilp, bool b);

    [Obsolete]
    ItemLabelPosition getNegativeItemLabelPosition();

    [Obsolete]
    void setNegativeItemLabelPosition(ItemLabelPosition ilp);

    [Obsolete]
    void setNegativeItemLabelPosition(ItemLabelPosition ilp, bool b);
  }
}
