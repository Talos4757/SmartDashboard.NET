// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.BoxAndWhiskerXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.data.xy;

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset"})]
  public interface BoxAndWhiskerXYDataset : XYDataset, SeriesDataset, Dataset
  {
    Number getMeanValue(int i1, int i2);

    Number getMedianValue(int i1, int i2);

    Number getMinRegularValue(int i1, int i2);

    Number getMaxRegularValue(int i1, int i2);

    Number getQ1Value(int i1, int i2);

    Number getQ3Value(int i1, int i2);

    List getOutliers(int i1, int i2);

    Number getMaxOutlier(int i1, int i2);

    Number getMinOutlier(int i1, int i2);

    double getOutlierCoefficient();

    double getFaroutCoefficient();
  }
}
