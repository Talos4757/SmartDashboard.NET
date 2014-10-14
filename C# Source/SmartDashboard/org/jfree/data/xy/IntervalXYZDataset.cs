// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.IntervalXYZDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.general;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.XYZDataset"})]
  public interface IntervalXYZDataset : XYZDataset, XYDataset, SeriesDataset, Dataset
  {
    Number getStartXValue(int i1, int i2);

    Number getEndXValue(int i1, int i2);

    Number getStartYValue(int i1, int i2);

    Number getEndYValue(int i1, int i2);

    Number getStartZValue(int i1, int i2);

    Number getEndZValue(int i1, int i2);
  }
}
