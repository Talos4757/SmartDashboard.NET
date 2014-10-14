// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.HeatMapDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.lang;

namespace org.jfree.data.general
{
  public interface HeatMapDataset
  {
    int getXSampleCount();

    int getYSampleCount();

    double getMinimumXValue();

    double getMaximumXValue();

    double getMinimumYValue();

    double getMaximumYValue();

    double getXValue(int i);

    double getYValue(int i);

    double getZValue(int i1, int i2);

    Number getZ(int i1, int i2);
  }
}
