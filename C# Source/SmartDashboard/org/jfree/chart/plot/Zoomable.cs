// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.Zoomable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt.geom;

namespace org.jfree.chart.plot
{
  public interface Zoomable
  {
    bool isDomainZoomable();

    bool isRangeZoomable();

    PlotOrientation getOrientation();

    void zoomDomainAxes(double d, PlotRenderingInfo pri, Point2D pd, bool b);

    void zoomRangeAxes(double d, PlotRenderingInfo pri, Point2D pd, bool b);

    void zoomDomainAxes(double d1, double d2, PlotRenderingInfo pri, Point2D pd);

    void zoomRangeAxes(double d1, double d2, PlotRenderingInfo pri, Point2D pd);

    void zoomDomainAxes(double d, PlotRenderingInfo pri, Point2D pd);

    void zoomRangeAxes(double d, PlotRenderingInfo pri, Point2D pd);
  }
}
