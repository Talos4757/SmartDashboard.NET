// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartMouseListener
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.util.EventListener"})]
  public interface ChartMouseListener : EventListener
  {
    void chartMouseClicked(ChartMouseEvent cme);

    void chartMouseMoved(ChartMouseEvent cme);
  }
}
