// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYAnnotationBoundsInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using org.jfree.data;

namespace org.jfree.chart.annotations
{
  public interface XYAnnotationBoundsInfo
  {
    bool getIncludeInDataBounds();

    Range getXRange();

    Range getYRange();
  }
}
