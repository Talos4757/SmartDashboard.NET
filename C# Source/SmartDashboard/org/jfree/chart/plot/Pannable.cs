// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.Pannable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt.geom;

namespace org.jfree.chart.plot
{
  public interface Pannable
  {
    bool isDomainPannable();

    bool isRangePannable();

    PlotOrientation getOrientation();

    void panDomainAxes(double d, PlotRenderingInfo pri, Point2D pd);

    void panRangeAxes(double d, PlotRenderingInfo pri, Point2D pd);
  }
}
