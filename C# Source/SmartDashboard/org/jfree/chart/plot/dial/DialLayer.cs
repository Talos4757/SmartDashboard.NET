// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.DialLayer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;
using java.awt.geom;
using java.util;

namespace org.jfree.chart.plot.dial
{
  public interface DialLayer
  {
    bool isVisible();

    void addChangeListener(DialLayerChangeListener dlcl);

    void removeChangeListener(DialLayerChangeListener dlcl);

    bool hasListener(EventListener el);

    bool isClippedToWindow();

    void draw(Graphics2D gd, DialPlot dp, Rectangle2D rd1, Rectangle2D rd2);
  }
}
