// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.panel.Overlay
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;
using org.jfree.chart;
using org.jfree.chart.@event;

namespace org.jfree.chart.panel
{
  public interface Overlay
  {
    void addChangeListener(OverlayChangeListener ocl);

    void removeChangeListener(OverlayChangeListener ocl);

    void paintOverlay(Graphics2D gd, ChartPanel cp);
  }
}
