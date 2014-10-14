// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.CategoryItemRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.ui;
using System;

namespace org.jfree.chart.renderer.category
{
  [Implements(new string[] {"org.jfree.chart.LegendItemSource"})]
  public interface CategoryItemRenderer : LegendItemSource
  {
    void setBaseToolTipGenerator(CategoryToolTipGenerator cttg);

    void setBaseItemURLGenerator(CategoryURLGenerator curlg);

    void setBaseItemLabelFont(Font f);

    void setBaseItemLabelPaint(Paint p);

    void setPlot(CategoryPlot cp);

    void addChangeListener(RendererChangeListener rcl);

    void removeChangeListener(RendererChangeListener rcl);

    LegendItem getLegendItem(int i1, int i2);

    void drawBackground(Graphics2D gd, CategoryPlot cp, Rectangle2D rd);

    void drawOutline(Graphics2D gd, CategoryPlot cp, Rectangle2D rd);

    CategoryItemRendererState initialise(Graphics2D gd, Rectangle2D rd, CategoryPlot cp, int i, PlotRenderingInfo pri);

    int getPassCount();

    void drawItem(Graphics2D gd, CategoryItemRendererState cirs, Rectangle2D rd, CategoryPlot cp, CategoryAxis ca, ValueAxis va, CategoryDataset cd, int i1, int i2, int i3);

    void drawDomainGridline(Graphics2D gd, CategoryPlot cp, Rectangle2D rd, double d);

    void drawRangeGridline(Graphics2D gd, CategoryPlot cp, ValueAxis va, Rectangle2D rd, double d);

    void drawDomainMarker(Graphics2D gd, CategoryPlot cp, CategoryAxis ca, CategoryMarker cm, Rectangle2D rd);

    void drawRangeMarker(Graphics2D gd, CategoryPlot cp, ValueAxis va, Marker m, Rectangle2D rd);

    double getItemMiddle(IComparable c1, IComparable c2, CategoryDataset cd, CategoryAxis ca, Rectangle2D rd, RectangleEdge re);

    Range findRangeBounds(CategoryDataset cd);

    CategoryPlot getPlot();

    bool getItemVisible(int i1, int i2);

    bool isSeriesVisible(int i);

    [Obsolete]
    Boolean getSeriesVisible();

    [Obsolete]
    void setSeriesVisible(Boolean b);

    [Obsolete]
    void setSeriesVisible(Boolean b1, bool b2);

    Boolean getSeriesVisible(int i);

    void setSeriesVisible(int i, Boolean b);

    void setSeriesVisible(int i, Boolean b1, bool b2);

    bool getBaseSeriesVisible();

    void setBaseSeriesVisible(bool b);

    void setBaseSeriesVisible(bool b1, bool b2);

    bool isSeriesVisibleInLegend(int i);

    [Obsolete]
    Boolean getSeriesVisibleInLegend();

    [Obsolete]
    void setSeriesVisibleInLegend(Boolean b);

    [Obsolete]
    void setSeriesVisibleInLegend(Boolean b1, bool b2);

    Boolean getSeriesVisibleInLegend(int i);

    void setSeriesVisibleInLegend(int i, Boolean b);

    void setSeriesVisibleInLegend(int i, Boolean b1, bool b2);

    bool getBaseSeriesVisibleInLegend();

    void setBaseSeriesVisibleInLegend(bool b);

    void setBaseSeriesVisibleInLegend(bool b1, bool b2);

    Paint getItemPaint(int i1, int i2);

    [Obsolete]
    void setPaint(Paint p);

    Paint getSeriesPaint(int i);

    void setSeriesPaint(int i, Paint p);

    Paint getBasePaint();

    void setBasePaint(Paint p);

    Paint getItemOutlinePaint(int i1, int i2);

    [Obsolete]
    void setOutlinePaint(Paint p);

    Paint getSeriesOutlinePaint(int i);

    void setSeriesOutlinePaint(int i, Paint p);

    Paint getBaseOutlinePaint();

    void setBaseOutlinePaint(Paint p);

    Stroke getItemStroke(int i1, int i2);

    [Obsolete]
    void setStroke(Stroke s);

    Stroke getSeriesStroke(int i);

    void setSeriesStroke(int i, Stroke s);

    Stroke getBaseStroke();

    void setBaseStroke(Stroke s);

    Stroke getItemOutlineStroke(int i1, int i2);

    [Obsolete]
    void setOutlineStroke(Stroke s);

    Stroke getSeriesOutlineStroke(int i);

    void setSeriesOutlineStroke(int i, Stroke s);

    Stroke getBaseOutlineStroke();

    void setBaseOutlineStroke(Stroke s);

    Shape getItemShape(int i1, int i2);

    [Obsolete]
    void setShape(Shape s);

    Shape getSeriesShape(int i);

    void setSeriesShape(int i, Shape s);

    Shape getBaseShape();

    void setBaseShape(Shape s);

    bool isItemLabelVisible(int i1, int i2);

    [Obsolete]
    void setItemLabelsVisible(bool b);

    [Obsolete]
    void setItemLabelsVisible(Boolean b);

    [Obsolete]
    void setItemLabelsVisible(Boolean b1, bool b2);

    bool isSeriesItemLabelsVisible(int i);

    void setSeriesItemLabelsVisible(int i, bool b);

    void setSeriesItemLabelsVisible(int i, Boolean b);

    void setSeriesItemLabelsVisible(int i, Boolean b1, bool b2);

    Boolean getBaseItemLabelsVisible();

    void setBaseItemLabelsVisible(bool b);

    void setBaseItemLabelsVisible(Boolean b);

    void setBaseItemLabelsVisible(Boolean b1, bool b2);

    CategoryItemLabelGenerator getItemLabelGenerator(int i1, int i2);

    [Obsolete]
    void setItemLabelGenerator(CategoryItemLabelGenerator cilg);

    CategoryItemLabelGenerator getSeriesItemLabelGenerator(int i);

    void setSeriesItemLabelGenerator(int i, CategoryItemLabelGenerator cilg);

    CategoryItemLabelGenerator getBaseItemLabelGenerator();

    void setBaseItemLabelGenerator(CategoryItemLabelGenerator cilg);

    CategoryToolTipGenerator getToolTipGenerator(int i1, int i2);

    [Obsolete]
    CategoryToolTipGenerator getToolTipGenerator();

    [Obsolete]
    void setToolTipGenerator(CategoryToolTipGenerator cttg);

    CategoryToolTipGenerator getSeriesToolTipGenerator(int i);

    void setSeriesToolTipGenerator(int i, CategoryToolTipGenerator cttg);

    CategoryToolTipGenerator getBaseToolTipGenerator();

    Font getItemLabelFont(int i1, int i2);

    [Obsolete]
    Font getItemLabelFont();

    [Obsolete]
    void setItemLabelFont(Font f);

    Font getSeriesItemLabelFont(int i);

    void setSeriesItemLabelFont(int i, Font f);

    Font getBaseItemLabelFont();

    Paint getItemLabelPaint(int i1, int i2);

    [Obsolete]
    Paint getItemLabelPaint();

    [Obsolete]
    void setItemLabelPaint(Paint p);

    Paint getSeriesItemLabelPaint(int i);

    void setSeriesItemLabelPaint(int i, Paint p);

    Paint getBaseItemLabelPaint();

    ItemLabelPosition getPositiveItemLabelPosition(int i1, int i2);

    [Obsolete]
    ItemLabelPosition getPositiveItemLabelPosition();

    [Obsolete]
    void setPositiveItemLabelPosition(ItemLabelPosition ilp);

    [Obsolete]
    void setPositiveItemLabelPosition(ItemLabelPosition ilp, bool b);

    ItemLabelPosition getSeriesPositiveItemLabelPosition(int i);

    void setSeriesPositiveItemLabelPosition(int i, ItemLabelPosition ilp);

    void setSeriesPositiveItemLabelPosition(int i, ItemLabelPosition ilp, bool b);

    ItemLabelPosition getBasePositiveItemLabelPosition();

    void setBasePositiveItemLabelPosition(ItemLabelPosition ilp);

    void setBasePositiveItemLabelPosition(ItemLabelPosition ilp, bool b);

    ItemLabelPosition getNegativeItemLabelPosition(int i1, int i2);

    [Obsolete]
    ItemLabelPosition getNegativeItemLabelPosition();

    [Obsolete]
    void setNegativeItemLabelPosition(ItemLabelPosition ilp);

    [Obsolete]
    void setNegativeItemLabelPosition(ItemLabelPosition ilp, bool b);

    ItemLabelPosition getSeriesNegativeItemLabelPosition(int i);

    void setSeriesNegativeItemLabelPosition(int i, ItemLabelPosition ilp);

    void setSeriesNegativeItemLabelPosition(int i, ItemLabelPosition ilp, bool b);

    ItemLabelPosition getBaseNegativeItemLabelPosition();

    void setBaseNegativeItemLabelPosition(ItemLabelPosition ilp);

    void setBaseNegativeItemLabelPosition(ItemLabelPosition ilp, bool b);

    CategoryURLGenerator getItemURLGenerator(int i1, int i2);

    [Obsolete]
    void setItemURLGenerator(CategoryURLGenerator curlg);

    CategoryURLGenerator getSeriesItemURLGenerator(int i);

    void setSeriesItemURLGenerator(int i, CategoryURLGenerator curlg);

    CategoryURLGenerator getBaseItemURLGenerator();
  }
}
