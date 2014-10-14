// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYBarPainter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;
using java.awt.geom;
using org.jfree.ui;

namespace org.jfree.chart.renderer.xy
{
  public interface XYBarPainter
  {
    void paintBarShadow(Graphics2D gd, XYBarRenderer xybr, int i1, int i2, RectangularShape rs, RectangleEdge re, bool b);

    void paintBar(Graphics2D gd, XYBarRenderer xybr, int i1, int i2, RectangularShape rs, RectangleEdge re);
  }
}
