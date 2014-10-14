// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.general;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.general.SeriesDataset"})]
  public interface XYDataset : SeriesDataset, Dataset
  {
    double getXValue(int i1, int i2);

    double getYValue(int i1, int i2);

    Number getY(int i1, int i2);

    Number getX(int i1, int i2);

    int getItemCount(int i);

    DomainOrder getDomainOrder();
  }
}
