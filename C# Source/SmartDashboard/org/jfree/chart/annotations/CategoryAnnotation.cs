// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.CategoryAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;
using java.awt.geom;
using org.jfree.chart.axis;
using org.jfree.chart.plot;

namespace org.jfree.chart.annotations
{
  public interface CategoryAnnotation
  {
    void draw(Graphics2D gd, CategoryPlot cp, Rectangle2D rd, CategoryAxis ca, ValueAxis va);
  }
}
