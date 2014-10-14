// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.TickUnitSource
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

namespace org.jfree.chart.axis
{
  public interface TickUnitSource
  {
    TickUnit getCeilingTickUnit(TickUnit tu);

    TickUnit getCeilingTickUnit(double d);

    TickUnit getLargerTickUnit(TickUnit tu);
  }
}
