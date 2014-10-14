// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.OHLCDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.general;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset"})]
  public interface OHLCDataset : XYDataset, SeriesDataset, Dataset
  {
    Number getHigh(int i1, int i2);

    Number getLow(int i1, int i2);

    Number getOpen(int i1, int i2);

    Number getClose(int i1, int i2);

    double getVolumeValue(int i1, int i2);

    double getHighValue(int i1, int i2);

    double getLowValue(int i1, int i2);

    double getOpenValue(int i1, int i2);

    double getCloseValue(int i1, int i2);

    Number getVolume(int i1, int i2);
  }
}
