// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.DrawingSupplier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.awt;

namespace org.jfree.chart.plot
{
  public interface DrawingSupplier
  {
    Paint getNextPaint();

    Paint getNextOutlinePaint();

    Paint getNextFillPaint();

    Stroke getNextStroke();

    Stroke getNextOutlineStroke();

    Shape getNextShape();
  }
}
