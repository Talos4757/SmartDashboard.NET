// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.IntervalXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.general;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset"})]
  public interface IntervalXYDataset : XYDataset, SeriesDataset, Dataset
  {
    double getStartXValue(int i1, int i2);

    double getEndXValue(int i1, int i2);

    double getStartYValue(int i1, int i2);

    double getEndYValue(int i1, int i2);

    Number getStartY(int i1, int i2);

    Number getEndY(int i1, int i2);

    Number getStartX(int i1, int i2);

    Number getEndX(int i1, int i2);
  }
}
