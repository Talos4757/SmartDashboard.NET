// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.PolarItemRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;
using java.awt.geom;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.data.xy;

namespace org.jfree.chart.renderer
{
  public interface PolarItemRenderer
  {
    void setPlot(PolarPlot pp);

    void addChangeListener(RendererChangeListener rcl);

    void removeChangeListener(RendererChangeListener rcl);

    void drawSeries(Graphics2D gd, Rectangle2D rd, PlotRenderingInfo pri, PolarPlot pp, XYDataset xyd, int i);

    void drawAngularGridLines(Graphics2D gd, PolarPlot pp, List l, Rectangle2D rd);

    void drawRadialGridLines(Graphics2D gd, PolarPlot pp, ValueAxis va, List l, Rectangle2D rd);

    LegendItem getLegendItem(int i);

    PolarPlot getPlot();
  }
}
